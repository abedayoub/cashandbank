namespace Cash_and_Bank
{
    partial class Cashier
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CashBox = new System.Windows.Forms.GroupBox();
            this.Cash_Check = new System.Windows.Forms.Button();
            this.Cash_totalcalc = new System.Windows.Forms.Label();
            this.Cash_total = new System.Windows.Forms.Label();
            this.myWallettxt = new System.Windows.Forms.TextBox();
            this.MyWalletlbl = new System.Windows.Forms.Label();
            this.AEDtxt = new System.Windows.Forms.TextBox();
            this.AEDlbl = new System.Windows.Forms.Label();
            this.QARtxt = new System.Windows.Forms.TextBox();
            this.QARlbl = new System.Windows.Forms.Label();
            this.SARtxt = new System.Windows.Forms.TextBox();
            this.SARlbl = new System.Windows.Forms.Label();
            this.EURtxt = new System.Windows.Forms.TextBox();
            this.EURlbl = new System.Windows.Forms.Label();
            this.USDtxt = new System.Windows.Forms.TextBox();
            this.USDlbl = new System.Windows.Forms.Label();
            this.LBLtxt = new System.Windows.Forms.TextBox();
            this.LBPlbl = new System.Windows.Forms.Label();
            this.BankBox = new System.Windows.Forms.GroupBox();
            this.ABCPanel = new System.Windows.Forms.Panel();
            this.BankABC_Check = new System.Windows.Forms.Button();
            this.BankABC_totalcalc = new System.Windows.Forms.Label();
            this.BankABC_total = new System.Windows.Forms.Label();
            this.AMEX_Albl = new System.Windows.Forms.Label();
            this.AMEX_Atxt = new System.Windows.Forms.TextBox();
            this.VLBP_Albl = new System.Windows.Forms.Label();
            this.VLBP_Atxt = new System.Windows.Forms.TextBox();
            this.MLBP_Albl = new System.Windows.Forms.Label();
            this.MLBP_Atxt = new System.Windows.Forms.TextBox();
            this.VUSA_Albl = new System.Windows.Forms.Label();
            this.VUSA_Atxt = new System.Windows.Forms.TextBox();
            this.MUSD_Albl = new System.Windows.Forms.Label();
            this.MUSD_Atxt = new System.Windows.Forms.TextBox();
            this.CVActlbl = new System.Windows.Forms.Label();
            this.CVActtxt = new System.Windows.Forms.TextBox();
            this.GCActlbl = new System.Windows.Forms.Label();
            this.GCActtxt = new System.Windows.Forms.TextBox();
            this.CVRmplbl = new System.Windows.Forms.Label();
            this.CVRmptxt = new System.Windows.Forms.TextBox();
            this.GCRmplbl = new System.Windows.Forms.Label();
            this.GCRmptxt = new System.Windows.Forms.TextBox();
            this.CCMSearchbtn = new System.Windows.Forms.Button();
            this.CCMpanel = new System.Windows.Forms.Panel();
            this.BankCCM_Check = new System.Windows.Forms.Button();
            this.BankCCM_totalcalc = new System.Windows.Forms.Label();
            this.BankCCM_total = new System.Windows.Forms.Label();
            this.AMEXlbl = new System.Windows.Forms.Label();
            this.AMEXtxt = new System.Windows.Forms.TextBox();
            this.VLBPlbl = new System.Windows.Forms.Label();
            this.VLBPtxt = new System.Windows.Forms.TextBox();
            this.MLBPlbl = new System.Windows.Forms.Label();
            this.MLBPtxt = new System.Windows.Forms.TextBox();
            this.VUSDlbl = new System.Windows.Forms.Label();
            this.VUSDtxt = new System.Windows.Forms.TextBox();
            this.MUSDlbl = new System.Windows.Forms.Label();
            this.MUSDtxt = new System.Windows.Forms.TextBox();
            this.Machinetxt = new System.Windows.Forms.TextBox();
            this.Machinelbl = new System.Windows.Forms.Label();
            this.loggedIn_lbl = new System.Windows.Forms.Label();
            this.GTotal_btn = new System.Windows.Forms.Button();
            this.GTotal = new System.Windows.Forms.Label();
            this.datetoday_lbl = new System.Windows.Forms.Label();
            this.submit_btn = new System.Windows.Forms.Button();
            this.SessionID_lbl = new System.Windows.Forms.Label();
            this.CashBox.SuspendLayout();
            this.BankBox.SuspendLayout();
            this.ABCPanel.SuspendLayout();
            this.CCMpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CashBox
            // 
            this.CashBox.Controls.Add(this.Cash_Check);
            this.CashBox.Controls.Add(this.Cash_totalcalc);
            this.CashBox.Controls.Add(this.Cash_total);
            this.CashBox.Controls.Add(this.myWallettxt);
            this.CashBox.Controls.Add(this.MyWalletlbl);
            this.CashBox.Controls.Add(this.AEDtxt);
            this.CashBox.Controls.Add(this.AEDlbl);
            this.CashBox.Controls.Add(this.QARtxt);
            this.CashBox.Controls.Add(this.QARlbl);
            this.CashBox.Controls.Add(this.SARtxt);
            this.CashBox.Controls.Add(this.SARlbl);
            this.CashBox.Controls.Add(this.EURtxt);
            this.CashBox.Controls.Add(this.EURlbl);
            this.CashBox.Controls.Add(this.USDtxt);
            this.CashBox.Controls.Add(this.USDlbl);
            this.CashBox.Controls.Add(this.LBLtxt);
            this.CashBox.Controls.Add(this.LBPlbl);
            this.CashBox.Location = new System.Drawing.Point(14, 39);
            this.CashBox.Name = "CashBox";
            this.CashBox.Size = new System.Drawing.Size(309, 459);
            this.CashBox.TabIndex = 0;
            this.CashBox.TabStop = false;
            this.CashBox.Text = "Cash";
            this.CashBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Cash_Check
            // 
            this.Cash_Check.Location = new System.Drawing.Point(201, 381);
            this.Cash_Check.Name = "Cash_Check";
            this.Cash_Check.Size = new System.Drawing.Size(83, 33);
            this.Cash_Check.TabIndex = 16;
            this.Cash_Check.Text = "Calculate";
            this.Cash_Check.UseVisualStyleBackColor = true;
            this.Cash_Check.Click += new System.EventHandler(this.Cash_Check_Click);
            // 
            // Cash_totalcalc
            // 
            this.Cash_totalcalc.AutoSize = true;
            this.Cash_totalcalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cash_totalcalc.Location = new System.Drawing.Point(197, 426);
            this.Cash_totalcalc.Name = "Cash_totalcalc";
            this.Cash_totalcalc.Size = new System.Drawing.Size(18, 20);
            this.Cash_totalcalc.TabIndex = 15;
            this.Cash_totalcalc.Text = "0";
            // 
            // Cash_total
            // 
            this.Cash_total.AutoSize = true;
            this.Cash_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cash_total.Location = new System.Drawing.Point(10, 426);
            this.Cash_total.Name = "Cash_total";
            this.Cash_total.Size = new System.Drawing.Size(51, 20);
            this.Cash_total.TabIndex = 14;
            this.Cash_total.Text = "Total:";
            // 
            // myWallettxt
            // 
            this.myWallettxt.Location = new System.Drawing.Point(109, 344);
            this.myWallettxt.Name = "myWallettxt";
            this.myWallettxt.Size = new System.Drawing.Size(175, 22);
            this.myWallettxt.TabIndex = 13;
            this.myWallettxt.Text = "0.00";
            // 
            // MyWalletlbl
            // 
            this.MyWalletlbl.AutoSize = true;
            this.MyWalletlbl.Location = new System.Drawing.Point(19, 347);
            this.MyWalletlbl.Name = "MyWalletlbl";
            this.MyWalletlbl.Size = new System.Drawing.Size(69, 17);
            this.MyWalletlbl.TabIndex = 12;
            this.MyWalletlbl.Text = "My Wallet";
            // 
            // AEDtxt
            // 
            this.AEDtxt.Location = new System.Drawing.Point(109, 291);
            this.AEDtxt.Name = "AEDtxt";
            this.AEDtxt.Size = new System.Drawing.Size(175, 22);
            this.AEDtxt.TabIndex = 11;
            this.AEDtxt.Text = "0.00";
            // 
            // AEDlbl
            // 
            this.AEDlbl.AutoSize = true;
            this.AEDlbl.Location = new System.Drawing.Point(19, 294);
            this.AEDlbl.Name = "AEDlbl";
            this.AEDlbl.Size = new System.Drawing.Size(36, 17);
            this.AEDlbl.TabIndex = 10;
            this.AEDlbl.Text = "AED";
            // 
            // QARtxt
            // 
            this.QARtxt.Location = new System.Drawing.Point(109, 239);
            this.QARtxt.Name = "QARtxt";
            this.QARtxt.Size = new System.Drawing.Size(175, 22);
            this.QARtxt.TabIndex = 9;
            this.QARtxt.Text = "0.00";
            this.QARtxt.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // QARlbl
            // 
            this.QARlbl.AutoSize = true;
            this.QARlbl.Location = new System.Drawing.Point(19, 242);
            this.QARlbl.Name = "QARlbl";
            this.QARlbl.Size = new System.Drawing.Size(38, 17);
            this.QARlbl.TabIndex = 8;
            this.QARlbl.Text = "QAR";
            // 
            // SARtxt
            // 
            this.SARtxt.Location = new System.Drawing.Point(109, 188);
            this.SARtxt.Name = "SARtxt";
            this.SARtxt.Size = new System.Drawing.Size(175, 22);
            this.SARtxt.TabIndex = 7;
            this.SARtxt.Text = "0.00";
            this.SARtxt.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // SARlbl
            // 
            this.SARlbl.AutoSize = true;
            this.SARlbl.Location = new System.Drawing.Point(19, 191);
            this.SARlbl.Name = "SARlbl";
            this.SARlbl.Size = new System.Drawing.Size(36, 17);
            this.SARlbl.TabIndex = 6;
            this.SARlbl.Text = "SAR";
            // 
            // EURtxt
            // 
            this.EURtxt.Location = new System.Drawing.Point(109, 134);
            this.EURtxt.Name = "EURtxt";
            this.EURtxt.Size = new System.Drawing.Size(175, 22);
            this.EURtxt.TabIndex = 5;
            this.EURtxt.Text = "0.00";
            this.EURtxt.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // EURlbl
            // 
            this.EURlbl.AutoSize = true;
            this.EURlbl.Location = new System.Drawing.Point(19, 137);
            this.EURlbl.Name = "EURlbl";
            this.EURlbl.Size = new System.Drawing.Size(37, 17);
            this.EURlbl.TabIndex = 4;
            this.EURlbl.Text = "EUR";
            // 
            // USDtxt
            // 
            this.USDtxt.Location = new System.Drawing.Point(109, 86);
            this.USDtxt.Name = "USDtxt";
            this.USDtxt.Size = new System.Drawing.Size(175, 22);
            this.USDtxt.TabIndex = 3;
            this.USDtxt.Text = "0.00";
            this.USDtxt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // USDlbl
            // 
            this.USDlbl.AutoSize = true;
            this.USDlbl.Location = new System.Drawing.Point(19, 89);
            this.USDlbl.Name = "USDlbl";
            this.USDlbl.Size = new System.Drawing.Size(37, 17);
            this.USDlbl.TabIndex = 2;
            this.USDlbl.Text = "USD";
            // 
            // LBLtxt
            // 
            this.LBLtxt.Location = new System.Drawing.Point(109, 38);
            this.LBLtxt.Name = "LBLtxt";
            this.LBLtxt.Size = new System.Drawing.Size(175, 22);
            this.LBLtxt.TabIndex = 1;
            this.LBLtxt.Text = "0.00";
            this.LBLtxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LBPlbl
            // 
            this.LBPlbl.AutoSize = true;
            this.LBPlbl.Location = new System.Drawing.Point(19, 41);
            this.LBPlbl.Name = "LBPlbl";
            this.LBPlbl.Size = new System.Drawing.Size(34, 17);
            this.LBPlbl.TabIndex = 0;
            this.LBPlbl.Text = "LBP";
            // 
            // BankBox
            // 
            this.BankBox.Controls.Add(this.ABCPanel);
            this.BankBox.Controls.Add(this.CCMSearchbtn);
            this.BankBox.Controls.Add(this.CCMpanel);
            this.BankBox.Controls.Add(this.Machinetxt);
            this.BankBox.Controls.Add(this.Machinelbl);
            this.BankBox.Location = new System.Drawing.Point(353, 40);
            this.BankBox.Name = "BankBox";
            this.BankBox.Size = new System.Drawing.Size(774, 458);
            this.BankBox.TabIndex = 1;
            this.BankBox.TabStop = false;
            this.BankBox.Text = "Bank";
            // 
            // ABCPanel
            // 
            this.ABCPanel.Controls.Add(this.BankABC_Check);
            this.ABCPanel.Controls.Add(this.BankABC_totalcalc);
            this.ABCPanel.Controls.Add(this.BankABC_total);
            this.ABCPanel.Controls.Add(this.AMEX_Albl);
            this.ABCPanel.Controls.Add(this.AMEX_Atxt);
            this.ABCPanel.Controls.Add(this.VLBP_Albl);
            this.ABCPanel.Controls.Add(this.VLBP_Atxt);
            this.ABCPanel.Controls.Add(this.MLBP_Albl);
            this.ABCPanel.Controls.Add(this.MLBP_Atxt);
            this.ABCPanel.Controls.Add(this.VUSA_Albl);
            this.ABCPanel.Controls.Add(this.VUSA_Atxt);
            this.ABCPanel.Controls.Add(this.MUSD_Albl);
            this.ABCPanel.Controls.Add(this.MUSD_Atxt);
            this.ABCPanel.Controls.Add(this.CVActlbl);
            this.ABCPanel.Controls.Add(this.CVActtxt);
            this.ABCPanel.Controls.Add(this.GCActlbl);
            this.ABCPanel.Controls.Add(this.GCActtxt);
            this.ABCPanel.Controls.Add(this.CVRmplbl);
            this.ABCPanel.Controls.Add(this.CVRmptxt);
            this.ABCPanel.Controls.Add(this.GCRmplbl);
            this.ABCPanel.Controls.Add(this.GCRmptxt);
            this.ABCPanel.Location = new System.Drawing.Point(377, 37);
            this.ABCPanel.Name = "ABCPanel";
            this.ABCPanel.Size = new System.Drawing.Size(396, 421);
            this.ABCPanel.TabIndex = 4;
            // 
            // BankABC_Check
            // 
            this.BankABC_Check.Location = new System.Drawing.Point(298, 343);
            this.BankABC_Check.Name = "BankABC_Check";
            this.BankABC_Check.Size = new System.Drawing.Size(83, 33);
            this.BankABC_Check.TabIndex = 22;
            this.BankABC_Check.Text = "Calculate";
            this.BankABC_Check.UseVisualStyleBackColor = true;
            this.BankABC_Check.Click += new System.EventHandler(this.BankABC_Check_Click);
            // 
            // BankABC_totalcalc
            // 
            this.BankABC_totalcalc.AutoSize = true;
            this.BankABC_totalcalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BankABC_totalcalc.Location = new System.Drawing.Point(294, 388);
            this.BankABC_totalcalc.Name = "BankABC_totalcalc";
            this.BankABC_totalcalc.Size = new System.Drawing.Size(18, 20);
            this.BankABC_totalcalc.TabIndex = 21;
            this.BankABC_totalcalc.Text = "0";
            // 
            // BankABC_total
            // 
            this.BankABC_total.AutoSize = true;
            this.BankABC_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BankABC_total.Location = new System.Drawing.Point(3, 388);
            this.BankABC_total.Name = "BankABC_total";
            this.BankABC_total.Size = new System.Drawing.Size(51, 20);
            this.BankABC_total.TabIndex = 20;
            this.BankABC_total.Text = "Total:";
            // 
            // AMEX_Albl
            // 
            this.AMEX_Albl.AutoSize = true;
            this.AMEX_Albl.Location = new System.Drawing.Point(20, 294);
            this.AMEX_Albl.Name = "AMEX_Albl";
            this.AMEX_Albl.Size = new System.Drawing.Size(46, 17);
            this.AMEX_Albl.TabIndex = 19;
            this.AMEX_Albl.Text = "AMEX";
            // 
            // AMEX_Atxt
            // 
            this.AMEX_Atxt.Location = new System.Drawing.Point(209, 291);
            this.AMEX_Atxt.Name = "AMEX_Atxt";
            this.AMEX_Atxt.Size = new System.Drawing.Size(172, 22);
            this.AMEX_Atxt.TabIndex = 18;
            this.AMEX_Atxt.Text = "0.00";
            // 
            // VLBP_Albl
            // 
            this.VLBP_Albl.AutoSize = true;
            this.VLBP_Albl.Location = new System.Drawing.Point(20, 258);
            this.VLBP_Albl.Name = "VLBP_Albl";
            this.VLBP_Albl.Size = new System.Drawing.Size(65, 17);
            this.VLBP_Albl.TabIndex = 17;
            this.VLBP_Albl.Text = "Visa LBP";
            // 
            // VLBP_Atxt
            // 
            this.VLBP_Atxt.Location = new System.Drawing.Point(209, 255);
            this.VLBP_Atxt.Name = "VLBP_Atxt";
            this.VLBP_Atxt.Size = new System.Drawing.Size(172, 22);
            this.VLBP_Atxt.TabIndex = 16;
            this.VLBP_Atxt.Text = "0.00";
            // 
            // MLBP_Albl
            // 
            this.MLBP_Albl.AutoSize = true;
            this.MLBP_Albl.Location = new System.Drawing.Point(20, 223);
            this.MLBP_Albl.Name = "MLBP_Albl";
            this.MLBP_Albl.Size = new System.Drawing.Size(81, 17);
            this.MLBP_Albl.TabIndex = 15;
            this.MLBP_Albl.Text = "Master LBP";
            // 
            // MLBP_Atxt
            // 
            this.MLBP_Atxt.Location = new System.Drawing.Point(209, 220);
            this.MLBP_Atxt.Name = "MLBP_Atxt";
            this.MLBP_Atxt.Size = new System.Drawing.Size(172, 22);
            this.MLBP_Atxt.TabIndex = 14;
            this.MLBP_Atxt.Text = "0.00";
            // 
            // VUSA_Albl
            // 
            this.VUSA_Albl.AutoSize = true;
            this.VUSA_Albl.Location = new System.Drawing.Point(20, 188);
            this.VUSA_Albl.Name = "VUSA_Albl";
            this.VUSA_Albl.Size = new System.Drawing.Size(68, 17);
            this.VUSA_Albl.TabIndex = 13;
            this.VUSA_Albl.Text = "Visa USD";
            // 
            // VUSA_Atxt
            // 
            this.VUSA_Atxt.Location = new System.Drawing.Point(209, 185);
            this.VUSA_Atxt.Name = "VUSA_Atxt";
            this.VUSA_Atxt.Size = new System.Drawing.Size(172, 22);
            this.VUSA_Atxt.TabIndex = 12;
            this.VUSA_Atxt.Text = "0.00";
            // 
            // MUSD_Albl
            // 
            this.MUSD_Albl.AutoSize = true;
            this.MUSD_Albl.Location = new System.Drawing.Point(20, 152);
            this.MUSD_Albl.Name = "MUSD_Albl";
            this.MUSD_Albl.Size = new System.Drawing.Size(84, 17);
            this.MUSD_Albl.TabIndex = 11;
            this.MUSD_Albl.Text = "Master USD";
            // 
            // MUSD_Atxt
            // 
            this.MUSD_Atxt.Location = new System.Drawing.Point(209, 149);
            this.MUSD_Atxt.Name = "MUSD_Atxt";
            this.MUSD_Atxt.Size = new System.Drawing.Size(172, 22);
            this.MUSD_Atxt.TabIndex = 10;
            this.MUSD_Atxt.Text = "0.00";
            // 
            // CVActlbl
            // 
            this.CVActlbl.AutoSize = true;
            this.CVActlbl.ForeColor = System.Drawing.Color.Red;
            this.CVActlbl.Location = new System.Drawing.Point(20, 118);
            this.CVActlbl.Name = "CVActlbl";
            this.CVActlbl.Size = new System.Drawing.Size(167, 17);
            this.CVActlbl.TabIndex = 7;
            this.CVActlbl.Text = "Credit Voucher Activation";
            // 
            // CVActtxt
            // 
            this.CVActtxt.Location = new System.Drawing.Point(209, 115);
            this.CVActtxt.Name = "CVActtxt";
            this.CVActtxt.Size = new System.Drawing.Size(172, 22);
            this.CVActtxt.TabIndex = 6;
            this.CVActtxt.Text = "0.00";
            // 
            // GCActlbl
            // 
            this.GCActlbl.AutoSize = true;
            this.GCActlbl.Location = new System.Drawing.Point(20, 87);
            this.GCActlbl.Name = "GCActlbl";
            this.GCActlbl.Size = new System.Drawing.Size(129, 17);
            this.GCActlbl.TabIndex = 5;
            this.GCActlbl.Text = "Gift Card Activation";
            // 
            // GCActtxt
            // 
            this.GCActtxt.Location = new System.Drawing.Point(209, 84);
            this.GCActtxt.Name = "GCActtxt";
            this.GCActtxt.Size = new System.Drawing.Size(172, 22);
            this.GCActtxt.TabIndex = 4;
            this.GCActtxt.Text = "0.00";
            // 
            // CVRmplbl
            // 
            this.CVRmplbl.AutoSize = true;
            this.CVRmplbl.Location = new System.Drawing.Point(20, 55);
            this.CVRmplbl.Name = "CVRmplbl";
            this.CVRmplbl.Size = new System.Drawing.Size(182, 17);
            this.CVRmplbl.TabIndex = 3;
            this.CVRmplbl.Text = "Credit Voucher Redemption";
            // 
            // CVRmptxt
            // 
            this.CVRmptxt.Location = new System.Drawing.Point(209, 52);
            this.CVRmptxt.Name = "CVRmptxt";
            this.CVRmptxt.Size = new System.Drawing.Size(172, 22);
            this.CVRmptxt.TabIndex = 2;
            this.CVRmptxt.Text = "0.00";
            // 
            // GCRmplbl
            // 
            this.GCRmplbl.AutoSize = true;
            this.GCRmplbl.Location = new System.Drawing.Point(20, 20);
            this.GCRmplbl.Name = "GCRmplbl";
            this.GCRmplbl.Size = new System.Drawing.Size(144, 17);
            this.GCRmplbl.TabIndex = 1;
            this.GCRmplbl.Text = "Gift Card Redemption";
            // 
            // GCRmptxt
            // 
            this.GCRmptxt.Location = new System.Drawing.Point(209, 17);
            this.GCRmptxt.Name = "GCRmptxt";
            this.GCRmptxt.Size = new System.Drawing.Size(172, 22);
            this.GCRmptxt.TabIndex = 0;
            this.GCRmptxt.Text = "0.00";
            // 
            // CCMSearchbtn
            // 
            this.CCMSearchbtn.Location = new System.Drawing.Point(241, 73);
            this.CCMSearchbtn.Name = "CCMSearchbtn";
            this.CCMSearchbtn.Size = new System.Drawing.Size(103, 32);
            this.CCMSearchbtn.TabIndex = 3;
            this.CCMSearchbtn.Text = "Search CCM";
            this.CCMSearchbtn.UseVisualStyleBackColor = true;
            this.CCMSearchbtn.Click += new System.EventHandler(this.CCMSearchbtn_Click);
            // 
            // CCMpanel
            // 
            this.CCMpanel.Controls.Add(this.BankCCM_Check);
            this.CCMpanel.Controls.Add(this.BankCCM_totalcalc);
            this.CCMpanel.Controls.Add(this.BankCCM_total);
            this.CCMpanel.Controls.Add(this.AMEXlbl);
            this.CCMpanel.Controls.Add(this.AMEXtxt);
            this.CCMpanel.Controls.Add(this.VLBPlbl);
            this.CCMpanel.Controls.Add(this.VLBPtxt);
            this.CCMpanel.Controls.Add(this.MLBPlbl);
            this.CCMpanel.Controls.Add(this.MLBPtxt);
            this.CCMpanel.Controls.Add(this.VUSDlbl);
            this.CCMpanel.Controls.Add(this.VUSDtxt);
            this.CCMpanel.Controls.Add(this.MUSDlbl);
            this.CCMpanel.Controls.Add(this.MUSDtxt);
            this.CCMpanel.Location = new System.Drawing.Point(19, 130);
            this.CCMpanel.Name = "CCMpanel";
            this.CCMpanel.Size = new System.Drawing.Size(325, 328);
            this.CCMpanel.TabIndex = 2;
            // 
            // BankCCM_Check
            // 
            this.BankCCM_Check.Location = new System.Drawing.Point(219, 250);
            this.BankCCM_Check.Name = "BankCCM_Check";
            this.BankCCM_Check.Size = new System.Drawing.Size(83, 33);
            this.BankCCM_Check.TabIndex = 18;
            this.BankCCM_Check.Text = "Calculate";
            this.BankCCM_Check.UseVisualStyleBackColor = true;
            this.BankCCM_Check.Click += new System.EventHandler(this.BankCCM_Check_Click);
            // 
            // BankCCM_totalcalc
            // 
            this.BankCCM_totalcalc.AutoSize = true;
            this.BankCCM_totalcalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BankCCM_totalcalc.Location = new System.Drawing.Point(218, 295);
            this.BankCCM_totalcalc.Name = "BankCCM_totalcalc";
            this.BankCCM_totalcalc.Size = new System.Drawing.Size(18, 20);
            this.BankCCM_totalcalc.TabIndex = 17;
            this.BankCCM_totalcalc.Text = "0";
            // 
            // BankCCM_total
            // 
            this.BankCCM_total.AutoSize = true;
            this.BankCCM_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BankCCM_total.Location = new System.Drawing.Point(10, 295);
            this.BankCCM_total.Name = "BankCCM_total";
            this.BankCCM_total.Size = new System.Drawing.Size(51, 20);
            this.BankCCM_total.TabIndex = 16;
            this.BankCCM_total.Text = "Total:";
            // 
            // AMEXlbl
            // 
            this.AMEXlbl.AutoSize = true;
            this.AMEXlbl.Location = new System.Drawing.Point(15, 227);
            this.AMEXlbl.Name = "AMEXlbl";
            this.AMEXlbl.Size = new System.Drawing.Size(46, 17);
            this.AMEXlbl.TabIndex = 9;
            this.AMEXlbl.Text = "AMEX";
            // 
            // AMEXtxt
            // 
            this.AMEXtxt.Location = new System.Drawing.Point(133, 224);
            this.AMEXtxt.Name = "AMEXtxt";
            this.AMEXtxt.Size = new System.Drawing.Size(169, 22);
            this.AMEXtxt.TabIndex = 8;
            this.AMEXtxt.Text = "0.00";
            // 
            // VLBPlbl
            // 
            this.VLBPlbl.AutoSize = true;
            this.VLBPlbl.Location = new System.Drawing.Point(15, 177);
            this.VLBPlbl.Name = "VLBPlbl";
            this.VLBPlbl.Size = new System.Drawing.Size(65, 17);
            this.VLBPlbl.TabIndex = 7;
            this.VLBPlbl.Text = "Visa LBP";
            // 
            // VLBPtxt
            // 
            this.VLBPtxt.Location = new System.Drawing.Point(133, 174);
            this.VLBPtxt.Name = "VLBPtxt";
            this.VLBPtxt.Size = new System.Drawing.Size(169, 22);
            this.VLBPtxt.TabIndex = 6;
            this.VLBPtxt.Text = "0.00";
            // 
            // MLBPlbl
            // 
            this.MLBPlbl.AutoSize = true;
            this.MLBPlbl.Location = new System.Drawing.Point(15, 120);
            this.MLBPlbl.Name = "MLBPlbl";
            this.MLBPlbl.Size = new System.Drawing.Size(81, 17);
            this.MLBPlbl.TabIndex = 5;
            this.MLBPlbl.Text = "Master LBP";
            // 
            // MLBPtxt
            // 
            this.MLBPtxt.Location = new System.Drawing.Point(133, 117);
            this.MLBPtxt.Name = "MLBPtxt";
            this.MLBPtxt.Size = new System.Drawing.Size(169, 22);
            this.MLBPtxt.TabIndex = 4;
            this.MLBPtxt.Text = "0.00";
            // 
            // VUSDlbl
            // 
            this.VUSDlbl.AutoSize = true;
            this.VUSDlbl.Location = new System.Drawing.Point(15, 68);
            this.VUSDlbl.Name = "VUSDlbl";
            this.VUSDlbl.Size = new System.Drawing.Size(68, 17);
            this.VUSDlbl.TabIndex = 3;
            this.VUSDlbl.Text = "Visa USD";
            this.VUSDlbl.Click += new System.EventHandler(this.label2_Click);
            // 
            // VUSDtxt
            // 
            this.VUSDtxt.Location = new System.Drawing.Point(133, 65);
            this.VUSDtxt.Name = "VUSDtxt";
            this.VUSDtxt.Size = new System.Drawing.Size(169, 22);
            this.VUSDtxt.TabIndex = 2;
            this.VUSDtxt.Text = "0.00";
            this.VUSDtxt.TextChanged += new System.EventHandler(this.textBox3_TextChanged_1);
            // 
            // MUSDlbl
            // 
            this.MUSDlbl.AutoSize = true;
            this.MUSDlbl.Location = new System.Drawing.Point(15, 7);
            this.MUSDlbl.Name = "MUSDlbl";
            this.MUSDlbl.Size = new System.Drawing.Size(84, 17);
            this.MUSDlbl.TabIndex = 1;
            this.MUSDlbl.Text = "Master USD";
            // 
            // MUSDtxt
            // 
            this.MUSDtxt.Location = new System.Drawing.Point(133, 6);
            this.MUSDtxt.Name = "MUSDtxt";
            this.MUSDtxt.Size = new System.Drawing.Size(169, 22);
            this.MUSDtxt.TabIndex = 0;
            this.MUSDtxt.Text = "0.00";
            // 
            // Machinetxt
            // 
            this.Machinetxt.Location = new System.Drawing.Point(152, 37);
            this.Machinetxt.Name = "Machinetxt";
            this.Machinetxt.Size = new System.Drawing.Size(192, 22);
            this.Machinetxt.TabIndex = 1;
            // 
            // Machinelbl
            // 
            this.Machinelbl.AutoSize = true;
            this.Machinelbl.Location = new System.Drawing.Point(16, 40);
            this.Machinelbl.Name = "Machinelbl";
            this.Machinelbl.Size = new System.Drawing.Size(119, 17);
            this.Machinelbl.TabIndex = 0;
            this.Machinelbl.Text = "Machine Number:";
            this.Machinelbl.Click += new System.EventHandler(this.label8_Click);
            // 
            // loggedIn_lbl
            // 
            this.loggedIn_lbl.AutoSize = true;
            this.loggedIn_lbl.Location = new System.Drawing.Point(626, 15);
            this.loggedIn_lbl.Name = "loggedIn_lbl";
            this.loggedIn_lbl.Size = new System.Drawing.Size(140, 17);
            this.loggedIn_lbl.TabIndex = 2;
            this.loggedIn_lbl.Text = "Logged in Username";
            // 
            // GTotal_btn
            // 
            this.GTotal_btn.Location = new System.Drawing.Point(14, 521);
            this.GTotal_btn.Name = "GTotal_btn";
            this.GTotal_btn.Size = new System.Drawing.Size(102, 30);
            this.GTotal_btn.TabIndex = 3;
            this.GTotal_btn.Text = "Check Total";
            this.GTotal_btn.UseVisualStyleBackColor = true;
            this.GTotal_btn.Click += new System.EventHandler(this.GTotal_btn_Click);
            // 
            // GTotal
            // 
            this.GTotal.AutoSize = true;
            this.GTotal.Location = new System.Drawing.Point(161, 528);
            this.GTotal.Name = "GTotal";
            this.GTotal.Size = new System.Drawing.Size(16, 17);
            this.GTotal.TabIndex = 4;
            this.GTotal.Text = "0";
            // 
            // datetoday_lbl
            // 
            this.datetoday_lbl.AutoSize = true;
            this.datetoday_lbl.Location = new System.Drawing.Point(13, 14);
            this.datetoday_lbl.Name = "datetoday_lbl";
            this.datetoday_lbl.Size = new System.Drawing.Size(46, 17);
            this.datetoday_lbl.TabIndex = 5;
            this.datetoday_lbl.Text = "label1";
            // 
            // submit_btn
            // 
            this.submit_btn.Location = new System.Drawing.Point(1028, 527);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(98, 34);
            this.submit_btn.TabIndex = 6;
            this.submit_btn.Text = "Submit";
            this.submit_btn.UseVisualStyleBackColor = true;
            this.submit_btn.Click += new System.EventHandler(this.submit_btn_Click);
            // 
            // SessionID_lbl
            // 
            this.SessionID_lbl.AutoSize = true;
            this.SessionID_lbl.Location = new System.Drawing.Point(1211, 14);
            this.SessionID_lbl.Name = "SessionID_lbl";
            this.SessionID_lbl.Size = new System.Drawing.Size(71, 17);
            this.SessionID_lbl.TabIndex = 7;
            this.SessionID_lbl.Text = "SessionID";
            // 
            // Cashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 589);
            this.Controls.Add(this.SessionID_lbl);
            this.Controls.Add(this.submit_btn);
            this.Controls.Add(this.datetoday_lbl);
            this.Controls.Add(this.GTotal);
            this.Controls.Add(this.GTotal_btn);
            this.Controls.Add(this.loggedIn_lbl);
            this.Controls.Add(this.BankBox);
            this.Controls.Add(this.CashBox);
            this.Name = "Cashier";
            this.Text = "Cashier";
            this.Load += new System.EventHandler(this.Cashier_Load);
            this.CashBox.ResumeLayout(false);
            this.CashBox.PerformLayout();
            this.BankBox.ResumeLayout(false);
            this.BankBox.PerformLayout();
            this.ABCPanel.ResumeLayout(false);
            this.ABCPanel.PerformLayout();
            this.CCMpanel.ResumeLayout(false);
            this.CCMpanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox CashBox;
        private System.Windows.Forms.TextBox AEDtxt;
        private System.Windows.Forms.Label AEDlbl;
        private System.Windows.Forms.TextBox QARtxt;
        private System.Windows.Forms.Label QARlbl;
        private System.Windows.Forms.TextBox SARtxt;
        private System.Windows.Forms.Label SARlbl;
        private System.Windows.Forms.TextBox EURtxt;
        private System.Windows.Forms.Label EURlbl;
        private System.Windows.Forms.TextBox USDtxt;
        private System.Windows.Forms.Label USDlbl;
        private System.Windows.Forms.TextBox LBLtxt;
        private System.Windows.Forms.Label LBPlbl;
        private System.Windows.Forms.TextBox myWallettxt;
        private System.Windows.Forms.Label MyWalletlbl;
        private System.Windows.Forms.GroupBox BankBox;
        private System.Windows.Forms.Label Machinelbl;
        private System.Windows.Forms.TextBox Machinetxt;
        private System.Windows.Forms.Panel CCMpanel;
        private System.Windows.Forms.Label VUSDlbl;
        private System.Windows.Forms.TextBox VUSDtxt;
        private System.Windows.Forms.Label MUSDlbl;
        private System.Windows.Forms.TextBox MUSDtxt;
        private System.Windows.Forms.Button CCMSearchbtn;
        private System.Windows.Forms.Label AMEXlbl;
        private System.Windows.Forms.TextBox AMEXtxt;
        private System.Windows.Forms.Label VLBPlbl;
        private System.Windows.Forms.TextBox VLBPtxt;
        private System.Windows.Forms.Label MLBPlbl;
        private System.Windows.Forms.TextBox MLBPtxt;
        private System.Windows.Forms.Panel ABCPanel;
        private System.Windows.Forms.Label CVActlbl;
        private System.Windows.Forms.TextBox CVActtxt;
        private System.Windows.Forms.Label GCActlbl;
        private System.Windows.Forms.TextBox GCActtxt;
        private System.Windows.Forms.Label CVRmplbl;
        private System.Windows.Forms.TextBox CVRmptxt;
        private System.Windows.Forms.Label GCRmplbl;
        private System.Windows.Forms.TextBox GCRmptxt;
        private System.Windows.Forms.Label AMEX_Albl;
        private System.Windows.Forms.TextBox AMEX_Atxt;
        private System.Windows.Forms.Label VLBP_Albl;
        private System.Windows.Forms.TextBox VLBP_Atxt;
        private System.Windows.Forms.Label MLBP_Albl;
        private System.Windows.Forms.TextBox MLBP_Atxt;
        private System.Windows.Forms.Label VUSA_Albl;
        private System.Windows.Forms.TextBox VUSA_Atxt;
        private System.Windows.Forms.Label MUSD_Albl;
        private System.Windows.Forms.TextBox MUSD_Atxt;
        private System.Windows.Forms.Label loggedIn_lbl;
        private System.Windows.Forms.Button Cash_Check;
        private System.Windows.Forms.Label Cash_totalcalc;
        private System.Windows.Forms.Label Cash_total;
        private System.Windows.Forms.Button BankABC_Check;
        private System.Windows.Forms.Label BankABC_totalcalc;
        private System.Windows.Forms.Label BankABC_total;
        private System.Windows.Forms.Button BankCCM_Check;
        private System.Windows.Forms.Label BankCCM_totalcalc;
        private System.Windows.Forms.Label BankCCM_total;
        private System.Windows.Forms.Button GTotal_btn;
        private System.Windows.Forms.Label GTotal;
        private System.Windows.Forms.Label datetoday_lbl;
        private System.Windows.Forms.Button submit_btn;
        private System.Windows.Forms.Label SessionID_lbl;
    }
}