using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Cash_and_Bank
{
    public partial class Manager : Form
    {
        int WorkPlaceID_const;
        int MgrID;
        DateTime nowSession = DateTime.Now;
        double sum = 0;
        double sumImp = 0;
        //getData
        string CCMIDNum=" ";
        string CCMIDANum=" ";
        
        //get data Cash
        double getLBP = 0.0;
        double getUSD = 0.0;
        double getEUR = 0.0;
        double getSAR = 0.0;
        double getQAR = 0.0;
        double getAED = 0.0;
        double getMyWallet = 0.0;
        //get data CCM
        double getMUSD = 0.0;
        double getVUSD = 0.0;
        double getMLBP = 0.0;
        double getVLBP = 0.0;
        double getAMEX = 0.0;
        //get data CCMA
        double getMUSDA = 0.0;
        double getVUSDA = 0.0;
        double getMLBPA = 0.0;
        double getVLBPA = 0.0;
        double getAMEXA = 0.0;
        double getCVAct = 0.0;
        double getCVRdmp = 0.0;
        double getGCRdmp = 0.0;
        double getGCAct = 0.0;


        SqlConnection con = new SqlConnection("Data Source = ABEDA\\SQLEXPRESS; Initial Catalog = CashAndBankdb; Integrated Security = True");

        public Manager()
        {
            InitializeComponent();
            
        }
        public Manager(int WS,int ID)
        {
            InitializeComponent();
            WorkPlaceID_const = WS;
            MgrID = ID;
            label1.Text = WorkPlaceID_const.ToString();
            label2.Text = ID.ToString();
        }

        private void sessionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sessionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cashAndBankdbDataSet);

        }

        private void Manager_Load(object sender, EventArgs e)
        {
            con.Open();


            SqlCommand gridLoad = new SqlCommand("select Session.SessionID, Session.Date, Session.UserID from Session, Users,WorkPlace where Session.UserID=Users.userID and Users.Workplace = Workplace.PlaceID and Workplace.mgr_ID = @mgrID and Session.Date= @d", con);
            gridLoad.Parameters.AddWithValue("@mgrID", MgrID);
            gridLoad.Parameters.AddWithValue("@d",Convert.ToDateTime(dateDateTimePicker.Value.ToShortDateString()));
            SqlDataReader dr = gridLoad.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            sessionDataGridView.DataSource = dt;
            dateDateTimePicker.MinDate = DateTime.Today.AddDays(-7);
            dateDateTimePicker.MaxDate = DateTime.Today.AddDays(2);

            // CashAndBankdbDataSet.Session.FillBy(MgrID, Convert.ToDateTime(dateDateTimePicker.Value.ToShortDateString().ToString()));

            //// TODO: This line of code loads data into the 'cashAndBankdbDataSet.Session' table. You can move, or remove it, as needed.
            //sessionTableAdapter.Fill(this.CashAndBankdbDataSet.Session.FillBy(MgrID, Convert.ToDateTime(dateDateTimePicker.Value.ToShortDateString().ToString())));


        }

        private void sessionDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int sID = Convert.ToInt16(sessionDataGridView.Rows[sessionDataGridView.CurrentRow.Index].Cells[0].Value.ToString());
            MessageBox.Show(dateDateTimePicker.Value.ToLongDateString().ToString());
            
            
            //getLBP
            SqlCommand getdata_Cash_LBP = new SqlCommand("select LBP from CashEntry where SessionID=@id ", con);
            getdata_Cash_LBP.Parameters.AddWithValue("@id", sID);
            getLBP = Convert.ToDouble(getdata_Cash_LBP.ExecuteScalar());
            LBPImp.Text = getLBP.ToString();
            sumImp += getLBP;

            //getUSD
            SqlCommand getdata_Cash_USD = new SqlCommand("select USD from CashEntry where SessionID=@id ", con);
            getdata_Cash_USD.Parameters.AddWithValue("@id", sID);
            getUSD = Convert.ToDouble(getdata_Cash_USD.ExecuteScalar());
            USDImp.Text = getUSD.ToString();
            sumImp += getUSD;

            //getEUR
            SqlCommand getdata_Cash_EUR = new SqlCommand("select EUR from CashEntry where SessionID=@id ", con);
            getdata_Cash_EUR.Parameters.AddWithValue("@id", sID);
            getEUR = Convert.ToDouble(getdata_Cash_EUR.ExecuteScalar());
            EURImp.Text = getEUR.ToString();
            sumImp += getEUR;

            //getSAR
            SqlCommand getdata_Cash_SAR = new SqlCommand("select SAR from CashEntry where SessionID=@id ", con);
            getdata_Cash_SAR.Parameters.AddWithValue("@id", sID);
            getSAR = Convert.ToDouble(getdata_Cash_SAR.ExecuteScalar());
            SARImp.Text = getSAR.ToString();
            sumImp += getSAR;

            //getQAR
            SqlCommand getdata_Cash_QAR = new SqlCommand("select QAR from CashEntry where SessionID=@id ", con);
            getdata_Cash_QAR.Parameters.AddWithValue("@id", sID);
            getQAR = Convert.ToDouble(getdata_Cash_QAR.ExecuteScalar());
            QARImp.Text = getQAR.ToString();
            sumImp += getQAR;

            //getAED
            SqlCommand getdata_Cash_AED = new SqlCommand("select AED from CashEntry where SessionID=@id ", con);
            getdata_Cash_AED.Parameters.AddWithValue("@id", sID);
            getAED = Convert.ToDouble(getdata_Cash_AED.ExecuteScalar());
            AEDImp.Text = getAED.ToString();
            sumImp += getAED;

            //getMyWallet
            SqlCommand getdata_Cash_MyWallet = new SqlCommand("select MyWallet from CashEntry where SessionID=@id ", con);
            getdata_Cash_MyWallet.Parameters.AddWithValue("@id", sID);
            getMyWallet = Convert.ToDouble(getdata_Cash_MyWallet.ExecuteScalar());
            MyWalletImp.Text = getMyWallet.ToString();
            sumImp += getMyWallet;


            //CCMID
            SqlCommand getdata_CCM = new SqlCommand("select CCMID from CCMEntry where SessionID=@id ", con);
            getdata_CCM.Parameters.AddWithValue("@id", sID);
                CCMIDNum = getdata_CCM.ExecuteScalar().ToString();
                CCMID.Text = CCMIDNum.ToString();
            

            //getMUSD
            SqlCommand getdata_CCM_MUSD = new SqlCommand("select MUSD from CCMEntry where SessionID=@id ", con);
            getdata_CCM_MUSD.Parameters.AddWithValue("@id", sID);
            getMUSD = Convert.ToDouble(getdata_CCM_MUSD.ExecuteScalar());
            MUSDImp.Text = getMUSD.ToString();
            sumImp += getMUSD;


            //getVUSD
            SqlCommand getdata_CCM_VUSD = new SqlCommand("select VUSA from CCMEntry where SessionID=@id ", con);
            getdata_CCM_VUSD.Parameters.AddWithValue("@id", sID);
            getVUSD = Convert.ToDouble(getdata_CCM_VUSD.ExecuteScalar());
            VUSDImp.Text = getVUSD.ToString();
            sumImp += getVUSD;

            //getMLBP
            SqlCommand getdata_CCM_MLBP = new SqlCommand("select MLBP from CCMEntry where SessionID=@id ", con);
            getdata_CCM_MLBP.Parameters.AddWithValue("@id", sID);
            getMLBP = Convert.ToDouble(getdata_CCM_MLBP.ExecuteScalar());
            MLBPImp.Text = getMLBP.ToString();
            sumImp += getMLBP;

            //getVLBP
            SqlCommand getdata_CCM_VLBP = new SqlCommand("select VLBP from CCMEntry where SessionID=@id ", con);
            getdata_CCM_VLBP.Parameters.AddWithValue("@id", sID);
            getVLBP = Convert.ToDouble(getdata_CCM_VLBP.ExecuteScalar());
            VLBPImp.Text = getVLBP.ToString();
            sumImp += getVLBP;

            //getAMEX
            SqlCommand getdata_CCM_AMEX = new SqlCommand("select AMEX from CCMEntry where SessionID=@id ", con);
            getdata_CCM_AMEX.Parameters.AddWithValue("@id", sID);
            getAMEX = Convert.ToDouble(getdata_CCM_AMEX.ExecuteScalar());
            AmexImp.Text = getAMEX.ToString();
            sumImp += getAMEX;

            //CCMIDA
            SqlCommand getdata_CCMA = new SqlCommand("select CCMID from CCM_AEntry where SessionID=@id ", con);
            getdata_CCMA.Parameters.AddWithValue("@id", sID);
            CCMIDANum = getdata_CCMA.ExecuteScalar().ToString();
            CCM_AID.Text = CCMIDANum.ToString();

            //getMUSD
            SqlCommand getdata_CCM_MUSDA = new SqlCommand("select MUSD from CCM_AEntry where SessionID=@id ", con);
            getdata_CCM_MUSDA.Parameters.AddWithValue("@id", sID);
            getMUSDA = Convert.ToDouble(getdata_CCM_MUSDA.ExecuteScalar());
            MUSDImpA.Text = getMUSDA.ToString();
            sumImp += getMUSDA;

            //getVUSD
            SqlCommand getdata_CCM_VUSDA = new SqlCommand("select VUSD from CCM_AEntry where SessionID=@id ", con);
            getdata_CCM_VUSDA.Parameters.AddWithValue("@id", sID);
            getVUSDA = Convert.ToDouble(getdata_CCM_VUSDA.ExecuteScalar());
            VUSDImpA.Text = getVUSDA.ToString();
            sumImp += getVUSDA;

            //getMLBP
            SqlCommand getdata_CCM_MLBPA = new SqlCommand("select MLBP from CCM_AEntry where SessionID=@id ", con);
            getdata_CCM_MLBPA.Parameters.AddWithValue("@id", sID);
            getMLBPA = Convert.ToDouble(getdata_CCM_MLBPA.ExecuteScalar());
            MLBPImpA.Text = getMLBPA.ToString();
            sumImp += getMLBPA;

            //getVLBP
            SqlCommand getdata_CCM_VLBPA = new SqlCommand("select VLBP from CCM_AEntry where SessionID=@id ", con);
            getdata_CCM_VLBPA.Parameters.AddWithValue("@id", sID);
            getVLBPA = Convert.ToDouble(getdata_CCM_VLBPA.ExecuteScalar());
            VLBPImpA.Text = getVLBPA.ToString();
            sumImp += getVLBPA;

            //getAMEX
            SqlCommand getdata_CCM_AMEXA = new SqlCommand("select AMEX from CCM_AEntry where SessionID=@id ", con);
            getdata_CCM_AMEXA.Parameters.AddWithValue("@id", sID);
            getAMEXA = Convert.ToDouble(getdata_CCM_AMEXA.ExecuteScalar());
            AMEXImpA.Text = getAMEXA.ToString();
            sumImp += getAMEXA;

            //getCVAct
            SqlCommand getdata_CCM_CVAct = new SqlCommand("select CVAct from CCM_AEntry where SessionID=@id ", con);
            getdata_CCM_CVAct.Parameters.AddWithValue("@id", sID);
            getCVAct = Convert.ToDouble(getdata_CCM_CVAct.ExecuteScalar());
            CVActlbl.Text = getCVAct.ToString();
            sumImp -= getCVAct;

            //getGCAct
            SqlCommand getdata_CCM_GCAct = new SqlCommand("select GCAct from CCM_AEntry where SessionID=@id ", con);
            getdata_CCM_GCAct.Parameters.AddWithValue("@id", sID);
            getGCAct = Convert.ToDouble(getdata_CCM_GCAct.ExecuteScalar());
            GCActlbl.Text = getCVAct.ToString();

            //getCVRdmp
            SqlCommand getdata_CCM_CVRdmp = new SqlCommand("select CVRdmp from CCM_AEntry where SessionID=@id ", con);
            getdata_CCM_CVRdmp.Parameters.AddWithValue("@id", sID);
            getCVRdmp = Convert.ToDouble(getdata_CCM_CVRdmp.ExecuteScalar());
            CVRdmplbl.Text = getCVRdmp.ToString();
            sumImp += getCVRdmp;

            //getGCRdmp
            SqlCommand getdata_CCM_GCRdmp = new SqlCommand("select GCRdmp from CCM_AEntry where SessionID=@id ", con);
            getdata_CCM_GCRdmp.Parameters.AddWithValue("@id", sID);
            getGCRdmp = Convert.ToDouble(getdata_CCM_GCRdmp.ExecuteScalar());
            GCRdmplbl.Text = getGCRdmp.ToString();
            sumImp += getGCRdmp;



        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            SqlCommand gridLoad = new SqlCommand("select Session.SessionID, Session.Date, Session.UserID from Session, Users,WorkPlace where Session.UserID=Users.userID and Users.Workplace = Workplace.PlaceID and Workplace.mgr_ID = @mgrID and Session.ShortDate= @d", con);
            gridLoad.Parameters.AddWithValue("@mgrID", MgrID);
            gridLoad.Parameters.AddWithValue("@d", Convert.ToDateTime(dateDateTimePicker.Value.ToShortDateString()));
            SqlDataReader dr = gridLoad.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            sessionDataGridView.DataSource = dt;  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            login l = new login();
            l.Show();
        }

        private void Check_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {


            int sID = Convert.ToInt16(sessionDataGridView.Rows[sessionDataGridView.CurrentRow.Index].Cells[0].Value.ToString());

            SqlCommand session_query = new SqlCommand("insert into ManagerSession(SessionIDEmp, Date, mgr_ID) values(@sIDEmp, @d, @mID)", con);
            session_query.Parameters.AddWithValue("@sIDEmp", sID);
            session_query.Parameters.AddWithValue("@d", DateTime.Today.ToString());
            session_query.Parameters.AddWithValue("@mID", Convert.ToInt16(label2.Text));
            session_query.ExecuteNonQuery();
            //insert cash
            string sub_cashStr = "update CashEntry set LBPM=@L ,USDM=@US ,EURM=@EU ,SARM=@SA, QARM=@QA, AEDM=@AE, MyWalletM=@MW where SessionID=@sID";
            SqlCommand sub_cash = new SqlCommand(sub_cashStr, con);
            sub_cash.Parameters.AddWithValue("@sID", sID);

            double getLBP = Convert.ToDouble(LBPtxt.Text);
            sum += getLBP;
            sub_cash.Parameters.AddWithValue("@L", Convert.ToDecimal(LBPtxt.Text));
            
            double getUSD = Convert.ToDouble(USDtxt.Text);
            sum += getUSD;
            sub_cash.Parameters.AddWithValue("@US", Convert.ToDecimal(USDtxt.Text));

            double getEUR = Convert.ToDouble(EURtxt.Text);
            sum += getEUR;
            sub_cash.Parameters.AddWithValue("@EU", Convert.ToDecimal(EURtxt.Text));

            double getSAR = Convert.ToDouble(SARtxt.Text);
            sum += getSAR;
            sub_cash.Parameters.AddWithValue("@SA", Convert.ToDecimal(SARtxt.Text));

            double getQAR = Convert.ToDouble(QARtxt.Text);
            sum += getQAR;
            sub_cash.Parameters.AddWithValue("@QA", Convert.ToDecimal(QARtxt.Text));

            double getAED = Convert.ToDouble(AEDtxt.Text);
            sum += getAED;
            sub_cash.Parameters.AddWithValue("@AE", Convert.ToDecimal(AEDtxt.Text));

            double getMW = Convert.ToDouble(MyWallettxt.Text);
            sum += getMW;
            sub_cash.Parameters.AddWithValue("@MW", Convert.ToDecimal(MyWallettxt.Text));
            sub_cash.ExecuteNonQuery();

            //insert  CCM
            string sub_CCMStr = "update CCMEntry set MUSDM=@MUS, VUSDM=@VUS, MLBPM=@MLB, VLBPM=@VLB, AMEXM=@AMEX where SessionID=@sID and CCMID = @cID";
            SqlCommand sub_CCM = new SqlCommand(sub_CCMStr, con);
            sub_CCM.Parameters.AddWithValue("@sID", sID);
            sub_CCM.Parameters.AddWithValue("@cID", CCMID.Text.ToString());

            double getMUSD = Convert.ToDouble(MUSDtxt.Text);
            sum += getMUSD;
            sub_CCM.Parameters.AddWithValue("@MUS", Convert.ToDecimal(MUSDtxt.Text));

            double getVUSD = Convert.ToDouble(VUSDtxt.Text);
            sum += getVUSD;
            sub_CCM.Parameters.AddWithValue("@VUS", Convert.ToDecimal(VUSDtxt.Text));

            double getMLBP = Convert.ToDouble(MLBPtxt.Text);
            sum += getMLBP;
            sub_CCM.Parameters.AddWithValue("@MLB", Convert.ToDecimal(MLBPtxt.Text));

            double getVLBP = Convert.ToDouble(VLBPtxt.Text);
            sum += getVLBP;
            sub_CCM.Parameters.AddWithValue("@VLB", Convert.ToDecimal(VLBPtxt.Text));

            double getAMEX = Convert.ToDouble(AMEXtxt.Text);
            sum += getAMEX;
            sub_CCM.Parameters.AddWithValue("@AMEX", Convert.ToDecimal(AMEXtxt.Text));

            sub_CCM.ExecuteNonQuery();



            //insert CCM A
            string sub_CCM_AStr = "update CCM_AEntry set GCRdmp=@GCR, CVRdmp=@CVR, GCAct=@GCA, CVAct=@CVA, MUSD=@MUS, VUSD=@VUS, MLBP=@MLB,VLBP=@VLB,AMEX=@AMEX where SessionID=@sID and CCMID=@cID";
            SqlCommand sub_CCMA = new SqlCommand(sub_CCM_AStr, con);
            sub_CCMA.Parameters.AddWithValue("@sID", sID);
            sub_CCMA.Parameters.AddWithValue("@cID", CCM_AID.Text);

            double getMUS = Convert.ToDouble(MUSD_Atxt.Text);
            sum += getMUS;
            sub_CCMA.Parameters.AddWithValue("@MUS", Convert.ToDecimal(MUSD_Atxt.Text));

            double getVUS = Convert.ToDouble(VUSD_Atxt.Text);
            sum += getVUS;
            sub_CCMA.Parameters.AddWithValue("@VUS", Convert.ToDecimal(VUSD_Atxt.Text));

            double getMLB = Convert.ToDouble(MLBP_Atxt.Text);
            sum += getMLBP;
            sub_CCMA.Parameters.AddWithValue("@MLB", Convert.ToDecimal(MLBP_Atxt.Text));

            double getVLB = Convert.ToDouble(VLBP_Atxt.Text);
            sum += getVLB;
            sub_CCMA.Parameters.AddWithValue("@VLB", Convert.ToDecimal(VLBP_Atxt.Text));

            double getAMEX_A = Convert.ToDouble(AMEX_Atxt.Text);
            sum += getAMEX_A;
            sub_CCMA.Parameters.AddWithValue("@AMEX", Convert.ToDecimal(AMEX_Atxt.Text));

            double getGCR = Convert.ToDouble(GCRdmptxt.Text);
            sum += getGCR;
            sub_CCMA.Parameters.AddWithValue("@GCR", Convert.ToDecimal(GCRdmptxt.Text));

            double getCVR = Convert.ToDouble(CVRdmptxt.Text);
            sum += getCVR;
            sub_CCMA.Parameters.AddWithValue("@CVR", Convert.ToDecimal(CVRdmptxt.Text));

            sub_CCMA.Parameters.AddWithValue("@GCA", Convert.ToDecimal(GCActtxt.Text));

            double getCVAct = Convert.ToDouble(CVActtxt.Text);
            sum -= getCVAct;
            sub_CCMA.Parameters.AddWithValue("@CVA", Convert.ToDecimal(CVActtxt.Text));
            sub_CCMA.ExecuteNonQuery();

            totalLbl.Text = sum.ToString();
            double diff = sum - sumImp;
            if (diff > 1000)
            {
                panel1.BackColor = Color.Red;
            }
            else
            {
                panel1.BackColor = Color.Green;
            }
            sumdifflbl.Text = diff.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //private void fillByToolStripButton_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        this.sessionTableAdapter.FillBy(this.cashAndBankdbDataSet.Session, ((int)(System.Convert.ChangeType(mgrIDToolStripTextBox.Text, typeof(int)))), ((System.DateTime)(System.Convert.ChangeType(dToolStripTextBox.Text, typeof(System.DateTime)))));
        //    }
        //    catch (System.Exception ex)
        //    {
        //        System.Windows.Forms.MessageBox.Show(ex.Message);
        //    }

        //}
    }
}
