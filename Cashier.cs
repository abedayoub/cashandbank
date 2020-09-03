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
    public partial class Cashier : Form
    {

        int sessionID;

        double sum = 0.0;
        double sumCash = 0.0;
        double sumCCM = 0.0;
        double sumABC = 0.0;

        string CCMID = "0";
        string CCM_ABCID = "0";

        double toUSD = 0.0;
        double toEUR = 0.0;
        double toQAR = 0.0;
        double toAED = 0.0;
        double toSAR = 0.0;
        SqlConnection con = new SqlConnection("Data Source = ABEDA\\SQLEXPRESS; Initial Catalog = CashAndBankdb; Integrated Security = True");


        //
        DateTime nowSession = DateTime.Now;
        public Cashier(int user)
        {
            con.Open();
            InitializeComponent();
            loggedIn_lbl.Text = user.ToString();
        }
        
        public Cashier()
        {
            con.Open();
            InitializeComponent();

            ////USD
            //Rate.Parameters.AddWithValue("@c", USDlbl.Text);
            //double RateUSD = (double)Rate.ExecuteScalar();
            //toUSD = Convert.ToDouble(USDtxt.Text) * RateUSD;
            //sum += toUSD;
            //sumCash += toUSD;
            //Rate.ExecuteScalar();
            //MessageBox.Show(RateUSD.ToString());

            ////EUR
            //Rate.Parameters.AddWithValue("@c", EURlbl.Text);
            //double RateEUR = (double)Rate.ExecuteScalar();
            //toEUR = Convert.ToDouble(EURtxt.Text) * RateEUR;
            //sum += toEUR;
            //sumCash += toEUR;
            //Rate.ExecuteScalar();

            ////QAR
            //Rate.Parameters.AddWithValue("@c", QARlbl.Text);
            //double RateQAR = (double)Rate.ExecuteScalar();
            //toAED = Convert.ToDouble(QARtxt.Text) * RateQAR;
            //sum += toQAR;
            //sumCash += toQAR;
            //Rate.ExecuteScalar();

            ////AED
            //Rate.Parameters.AddWithValue("@c", AEDlbl.Text);
            //double RateAED = (double)Rate.ExecuteScalar();
            //toAED = Convert.ToDouble(AEDtxt.Text) * RateAED;
            //sum += toAED;
            //sumCash += toAED;
            //Rate.ExecuteScalar();

            ////SAR
            //Rate.Parameters.AddWithValue("@c", SARlbl.Text);
            //double RateSAR = (double)Rate.ExecuteScalar();
            //toSAR = Convert.ToDouble(SARtxt.Text) * RateSAR;
            //sum += toSAR;
            //sumCash += toSAR;
            //Rate.ExecuteScalar();

            //LBP
            sum += Convert.ToDouble(LBLtxt.Text);
            sumCash += Convert.ToDouble(LBLtxt.Text);

            //myWallet
            sum += Convert.ToDouble(myWallettxt.Text);
            sumCash += Convert.ToDouble(myWallettxt.Text);
        }



        private void Cashier_Load(object sender, EventArgs e)
        {
            //Session Connection
            SqlCommand session_query = new SqlCommand("insert into Session(Date, UserID, ShortDate) values(@d, @u, @sd)",con);
            session_query.Parameters.AddWithValue("@d", nowSession);
            session_query.Parameters.AddWithValue("@sd", DateTime.Today.ToShortDateString());
            session_query.Parameters.AddWithValue("@u", Convert.ToInt16(loggedIn_lbl.Text));
            session_query.ExecuteNonQuery();

            SqlCommand session_get = new SqlCommand("select SessionID from Session where Date=@d and UserID = @u",con);
            session_get.Parameters.AddWithValue("@d", nowSession);
            session_get.Parameters.AddWithValue("@u", Convert.ToInt16(loggedIn_lbl.Text));
            sessionID = (int)session_get.ExecuteScalar();
            SessionID_lbl.Text = sessionID.ToString();

            datetoday_lbl.Text = DateTime.Today.ToShortDateString();
            ABCPanel.Hide();
            CCMpanel.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void GTotal_btn_Click(object sender, EventArgs e)
        {
            GTotal.Text = sum.ToString();
        }

        private void Cash_Check_Click(object sender, EventArgs e)
        {
            string Rate_Query = "select rate from currencies where currency=@c";
            SqlCommand Rate = new SqlCommand(Rate_Query, con);

            //USD
            Rate_Query = "select rate from currencies where currency=@USD";
            Rate = new SqlCommand(Rate_Query, con);
            Rate.Parameters.AddWithValue("@USD", USDlbl.Text);
            double RateUSD = (double)Rate.ExecuteScalar();
            toUSD = Convert.ToDouble(USDtxt.Text) * RateUSD;
            sum += toUSD;
            sumCash += toUSD;
            Rate.ExecuteScalar();

            //EUR
            Rate_Query = "select rate from currencies where currency=@EUR";
            Rate = new SqlCommand(Rate_Query, con);
            Rate.Parameters.AddWithValue("@EUR", EURlbl.Text);
            double RateEUR = (double)Rate.ExecuteScalar();
            toEUR = Convert.ToDouble(EURtxt.Text) * RateEUR;
            sum += toEUR;
            sumCash += toEUR;
            Rate.ExecuteScalar();

            //QAR
            Rate_Query = "select rate from currencies where currency=@QAR";
            Rate = new SqlCommand(Rate_Query, con);
            Rate.Parameters.AddWithValue("@QAR", QARlbl.Text);
            double RateQAR = (double)Rate.ExecuteScalar();
            toAED = Convert.ToDouble(QARtxt.Text) * RateQAR;
            sum += toQAR;
            sumCash += toQAR;
            Rate.ExecuteScalar();

            //AED
            Rate_Query = "select rate from currencies where currency=@AED";
            Rate = new SqlCommand(Rate_Query, con);
            Rate.Parameters.AddWithValue("@AED", AEDlbl.Text);
            double RateAED = (double)Rate.ExecuteScalar();
            toAED = Convert.ToDouble(AEDtxt.Text) * RateAED;
            sum += toAED;
            sumCash += toAED;
            Rate.ExecuteScalar();
            
            //SAR
            Rate_Query = "select rate from currencies where currency=@SAR";
            Rate = new SqlCommand(Rate_Query, con);
            Rate.Parameters.AddWithValue("@SAR", SARlbl.Text);
            double RateSAR = (double)Rate.ExecuteScalar();
            toSAR = Convert.ToDouble(SARtxt.Text) * RateSAR;
            sum += toSAR;
            sumCash += toSAR;
            Rate.ExecuteScalar();
            
            //LBP
            sum += Convert.ToDouble(LBLtxt.Text);
            sumCash += Convert.ToDouble(LBLtxt.Text);

            //myWallet
            sum += Convert.ToDouble(myWallettxt.Text);
            sumCash += Convert.ToDouble(myWallettxt.Text);

            Cash_totalcalc.Text = sumCash.ToString();
            sumCash = 0;
        }

        private void BankCCM_Check_Click(object sender, EventArgs e)
        {
            string Rate_Query = "select rate from currencies where currency=@c";
            SqlCommand Rate = new SqlCommand(Rate_Query, con);

            //MUSD
            Rate_Query = "select rate from currencies where currency=@MUSD";
            Rate = new SqlCommand(Rate_Query, con);
            Rate.Parameters.AddWithValue("@MUSD", USDlbl.Text);
            double RateMUSD = (double)Rate.ExecuteScalar();
            double toMUSD = Convert.ToDouble(MUSDtxt.Text) * RateMUSD;
            sum += toMUSD;
            sumCCM += toMUSD;
            Rate.ExecuteScalar();

            //VUSD
            Rate_Query = "select rate from currencies where currency=@VUSD";
            Rate = new SqlCommand(Rate_Query, con);
            Rate.Parameters.AddWithValue("@VUSD", USDlbl.Text);
            double RateVUSD = (double)Rate.ExecuteScalar();
            double toVUSD = Convert.ToDouble(VUSDtxt.Text) * RateVUSD;
            sum += toVUSD;
            sumCCM += toVUSD;
            Rate.ExecuteScalar();
            
            //AMEX
            Rate_Query = "select rate from currencies where currency=@AMEX";
            Rate = new SqlCommand(Rate_Query, con);
            Rate.Parameters.AddWithValue("@AMEX", USDlbl.Text);
            double RateUSD = (double)Rate.ExecuteScalar();
            double toAMEX = Convert.ToDouble(AMEXtxt.Text) * RateUSD;
            sum += toAMEX;
            sumCCM += toAMEX;
            Rate.ExecuteScalar();

            //VLBP
            sum += Convert.ToDouble(VLBPtxt.Text);
            sumCCM += Convert.ToDouble(VLBPtxt.Text);

            //MLBP
            sum += Convert.ToDouble(MLBPtxt.Text);
            sumCCM += Convert.ToDouble(MLBPtxt.Text);

            BankCCM_totalcalc.Text = sumCCM.ToString();
        }

        private void BankABC_Check_Click(object sender, EventArgs e)
        {
            string Rate_Query = "select rate from currencies where currency=@c";
            SqlCommand Rate = new SqlCommand(Rate_Query, con);

            
            //MUSD_A
            Rate_Query = "select rate from currencies where currency=@MUSD";
            Rate = new SqlCommand(Rate_Query, con);
            Rate.Parameters.AddWithValue("@MUSD", USDlbl.Text);
            double RateMUSD = (double)Rate.ExecuteScalar();
            double toMUSD_A = Convert.ToDouble(MUSD_Atxt.Text) * RateMUSD;
            sum += toMUSD_A;
            sumABC += toMUSD_A;
            Rate.ExecuteScalar();

            //VUSD_A
            Rate_Query = "select rate from currencies where currency=@VUSD";
            Rate = new SqlCommand(Rate_Query, con);
            Rate.Parameters.AddWithValue("@VUSD", USDlbl.Text);
            double RateVUSD = (double)Rate.ExecuteScalar();
            double toVUSD_A = Convert.ToDouble(VUSA_Atxt.Text) * RateVUSD;
            sum += toVUSD_A;
            sumABC += toVUSD_A;
            Rate.ExecuteScalar();

            //AMEX
            Rate_Query = "select rate from currencies where currency=@AMEX";
            Rate = new SqlCommand(Rate_Query, con);
            Rate.Parameters.AddWithValue("@AMEX", USDlbl.Text);
            double RateUSD = (double)Rate.ExecuteScalar();
            double toAMEX_A = Convert.ToDouble(AMEX_Atxt.Text) * RateUSD;
            sum += toAMEX_A;
            sumABC += toAMEX_A;
            Rate.ExecuteScalar();

            //VLBP
            sum += Convert.ToDouble(VLBP_Atxt.Text);
            sumABC += Convert.ToDouble(VLBP_Atxt.Text);

            //MLBP
            sum += Convert.ToDouble(MLBP_Atxt.Text);
            sumABC += Convert.ToDouble(MLBP_Atxt.Text);

            //GCAct
            sum += Convert.ToDouble(GCActtxt.Text);
            sumABC += Convert.ToDouble(GCActtxt.Text);

            //CVAct
            sum -= Convert.ToDouble(CVActtxt.Text);
            sumABC -= Convert.ToDouble(CVActtxt.Text);

            BankABC_totalcalc.Text = sumABC.ToString();
        }

        private void CCMSearchbtn_Click(object sender, EventArgs e)
        {
            string CCM = Machinetxt.Text;
            string CCM_Querystr = "select CCMID from CCM where CCMID=@ID";
            SqlCommand CCMQ_Query = new SqlCommand(CCM_Querystr, con);
            CCMQ_Query.Parameters.AddWithValue("@ID", CCM);
            SqlDataAdapter da = new SqlDataAdapter(CCMQ_Query);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                if (Machinetxt.Text.Count() < 9)
                {
                    CCMpanel.Show();
                    ABCPanel.Hide();
                    CCMID = Machinetxt.Text;
                }
                else
                {
                    ABCPanel.Show();
                    CCMpanel.Hide();
                    CCM_ABCID = Machinetxt.Text;
                }
            }
            else
            {
                MessageBox.Show("Incorrect Machine Number, Try Again");
            }
        }

        private void submit_btn_Click(object sender, EventArgs e)
        {
            SqlCommand session_get = new SqlCommand("select SessionID from Session where Date=@d and UserID = @u", con);
            session_get.Parameters.AddWithValue("@d", nowSession);
            session_get.Parameters.AddWithValue("@u", Convert.ToInt16(loggedIn_lbl.Text));
            sessionID = (int)session_get.ExecuteScalar();


            //insert cash
            string sub_cashStr = "insert into [CashEntry](sessionID,LBP,USD,EUR,SAR,QAR,AED,MyWallet) values(@sID,@L,@US,@EU,@SA,@QA,@AE,@MW)";
            SqlCommand sub_cash = new SqlCommand(sub_cashStr,con);
            sub_cash.Parameters.AddWithValue("@sID", sessionID);
            sub_cash.Parameters.AddWithValue("@L", Convert.ToDecimal(LBLtxt.Text));
            sub_cash.Parameters.AddWithValue("@US", Convert.ToDecimal(USDtxt.Text));
            sub_cash.Parameters.AddWithValue("@EU", Convert.ToDecimal(EURtxt.Text));
            sub_cash.Parameters.AddWithValue("@SA", Convert.ToDecimal(SARtxt.Text));
            sub_cash.Parameters.AddWithValue("@QA", Convert.ToDecimal(QARtxt.Text));
            sub_cash.Parameters.AddWithValue("@AE", Convert.ToDecimal(AEDtxt.Text));
            sub_cash.Parameters.AddWithValue("@MW", Convert.ToDecimal(myWallettxt.Text));
            sub_cash.ExecuteNonQuery();


            //insert  CCM
            string sub_CCMStr = "insert into [CCMEntry](sessionID,CCMID,MUSD,VUSA,MLBP,VLBP,AMEX) values(@sID,@CID,@MUS,@VUS,@MLB,@VLB,@AMEX)";
            SqlCommand sub_CCM = new SqlCommand(sub_CCMStr, con);
            sub_CCM.Parameters.AddWithValue("@sID", sessionID);
            sub_CCM.Parameters.AddWithValue("@CID", CCMID);
            sub_CCM.Parameters.AddWithValue("@MUS", Convert.ToDecimal(MUSDtxt.Text));
            sub_CCM.Parameters.AddWithValue("@VUS", Convert.ToDecimal(VUSDtxt.Text));
            sub_CCM.Parameters.AddWithValue("@MLB", Convert.ToDecimal(MLBPtxt.Text));
            sub_CCM.Parameters.AddWithValue("@VLB", Convert.ToDecimal(VLBPtxt.Text));
            sub_CCM.Parameters.AddWithValue("@AMEX", Convert.ToDecimal(AMEXtxt.Text));
            sub_CCM.ExecuteNonQuery();

            //insert CCM A
            string sub_CCM_AStr = "insert into [CCM_AEntry](sessionID,CCMID,GCRdmp,CVRdmp,GCAct,CVAct,MUSD,VUSD,MLBP,VLBP,AMEX) values(@sID,@CID,@GCR,@CVR,@GCA,@CVA,@MUS,@VUS,@MLB,@VLB,@AMEX)";
            SqlCommand sub_CCMA = new SqlCommand(sub_CCM_AStr, con);
            sub_CCMA.Parameters.AddWithValue("@sID", sessionID);
            sub_CCMA.Parameters.AddWithValue("@CID", CCM_ABCID);
            sub_CCMA.Parameters.AddWithValue("@MUS", Convert.ToDecimal(MUSD_Atxt.Text));
            sub_CCMA.Parameters.AddWithValue("@VUS", Convert.ToDecimal(VUSA_Atxt.Text));
            sub_CCMA.Parameters.AddWithValue("@MLB", Convert.ToDecimal(MLBP_Atxt.Text));
            sub_CCMA.Parameters.AddWithValue("@VLB", Convert.ToDecimal(VLBP_Atxt.Text));
            sub_CCMA.Parameters.AddWithValue("@AMEX", Convert.ToDecimal(AMEX_Atxt.Text));
            sub_CCMA.Parameters.AddWithValue("@GCR", Convert.ToDecimal(GCRmptxt.Text));
            sub_CCMA.Parameters.AddWithValue("@CVR", Convert.ToDecimal(CVRmptxt.Text));
            sub_CCMA.Parameters.AddWithValue("@GCA", Convert.ToDecimal(GCActtxt.Text));
            sub_CCMA.Parameters.AddWithValue("@CVA", Convert.ToDecimal(CVActtxt.Text));
            sub_CCMA.ExecuteNonQuery();

        }
    }
}
