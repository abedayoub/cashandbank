using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
namespace Cash_and_Bank
{
    public partial class login : Form
    {
        SqlConnection login_cnx = new SqlConnection("Data Source = ABEDA\\SQLEXPRESS; Initial Catalog = CashAndBankdb; Integrated Security = True");
        public login(int user)
        {
            int id = Convert.ToInt16(txtUser.Text);
        }

        public login()
        {
            InitializeComponent();
            login_cnx.Open();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                
                SqlCommand login_verify = new SqlCommand("select * from Users where userID = @uID and userPass = @uPass", login_cnx);
                int UID = Convert.ToInt16(txtUser.Text);
                login_verify.Parameters.AddWithValue("@uID", UID);
                login_verify.Parameters.AddWithValue("@uPass", txtPass.Text);
                SqlDataAdapter da_login = new SqlDataAdapter(login_verify);
                DataTable dt_login = new DataTable();
                da_login.Fill(dt_login);

                SqlCommand control_check = new SqlCommand("select Controls.ControlID from Controls,Users where Controls.ControlID=Users.Control and Users.userID=@uId", login_cnx);
                control_check.Parameters.AddWithValue("@uId", UID);
                SqlDataAdapter da_control = new SqlDataAdapter(control_check);
                DataTable dt_control = new DataTable();
                SqlDataReader dr_control = control_check.ExecuteReader();
                dt_control.Load(dr_control);

                if (dt_login.Rows.Count > 0)
                {
                    //if (control_check.ExecuteScalar().ToString()=="10")  //returns the first result of the first row of a query
                    if (dt_control.Rows[0]["ControlId"].ToString() == "10")
                    {
                        this.Hide();
                        int user = Convert.ToInt16(txtUser.Text);
                        Cashier c = new Cashier(user);
                        c.Show();
                    }
                    else if (dt_control.Rows[0]["ControlId"].ToString() == "20")
                    {
                        SqlCommand wscmd = new SqlCommand("select WorkPlace from Users where userID = @id", login_cnx);
                        wscmd.Parameters.AddWithValue("@id", Convert.ToInt16(txtUser.Text));
                        int WSID = Convert.ToInt16(wscmd.ExecuteScalar().ToString());
                        this.Hide();
                        Manager m = new Manager(WSID, Convert.ToInt16(txtUser.Text));
                        m.Show();

                    }
                    else if (dt_control.Rows[0]["ControlId"].ToString() == "30")
                    {
                        this.Hide();
                        Audit a = new Audit();
                        a.Show();
                    }
                    else if (dt_control.Rows[0]["ControlId"].ToString() == "50")
                    {
                        this.Hide();
                        Finance f = new Finance();
                        f.Show();
                    }
                }
                else
                {
                    incorrect_lbl.Visible = true;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
