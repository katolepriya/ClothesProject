namespace ClothsProject
{
    partial class frm_CustomerSale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_CustomerSale));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmb_Company = new System.Windows.Forms.ComboBox();
            this.lbl_Company = new System.Windows.Forms.Label();
            this.txt_BillNo = new System.Windows.Forms.TextBox();
            this.lbl_BillNo = new System.Windows.Forms.Label();
            this.grp_CustomerInfo = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.cmb_CustName = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_GstNo = new System.Windows.Forms.TextBox();
            this.Chk_GstNo = new System.Windows.Forms.CheckBox();
            this.bttn_SalesPersonPopup = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_State = new System.Windows.Forms.ComboBox();
            this.lblState = new System.Windows.Forms.Label();
            this.lbl_amtpaidbycash = new System.Windows.Forms.Label();
            this.lbl_AmountPaidByCash = new System.Windows.Forms.Label();
            this.cmb_SalesPerson = new System.Windows.Forms.ComboBox();
            this.lbl_SalesPerson = new System.Windows.Forms.Label();
            this.txt_PancardNo = new System.Windows.Forms.TextBox();
            this.lbl_PancardNo = new System.Windows.Forms.Label();
            this.lbl_Amount = new System.Windows.Forms.Label();
            this.txt_AccNo = new System.Windows.Forms.TextBox();
            this.lbl_AccNo = new System.Windows.Forms.Label();
            this.lbl_BalanceAmount = new System.Windows.Forms.Label();
            this.bttn_Show = new System.Windows.Forms.Button();
            this.bttn_CUpdate = new System.Windows.Forms.Button();
            this.txt_ContNo = new System.Windows.Forms.TextBox();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.lbl_ContNo = new System.Windows.Forms.Label();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.lbl_CustName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bttn_Reset = new System.Windows.Forms.Button();
            this.bttn_Delete = new System.Windows.Forms.Button();
            this.bttn_Update = new System.Windows.Forms.Button();
            this.bttn_Add = new System.Windows.Forms.Button();
            this.lbl_Disc = new System.Windows.Forms.Label();
            this.lbl_NetPrice = new System.Windows.Forms.Label();
            this.lbl_Quantity = new System.Windows.Forms.Label();
            this.lbl_CurrentPrice = new System.Windows.Forms.Label();
            this.cmb_Makingdisc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Hs_Code = new System.Windows.Forms.Label();
            this.cmb_HsName = new System.Windows.Forms.ComboBox();
            this.cmb_carat1 = new System.Windows.Forms.ComboBox();
            this.txt_NetPrice = new System.Windows.Forms.TextBox();
            this.txt_Quantity = new System.Windows.Forms.TextBox();
            this.Cmb_SubMetalType = new System.Windows.Forms.ComboBox();
            this.txt_ItemNo = new System.Windows.Forms.TextBox();
            this.lbl_itemno = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_paycustomer = new System.Windows.Forms.Label();
            this.lbl_BalAmount = new System.Windows.Forms.Label();
            this.txt_AmountPaidByCash = new System.Windows.Forms.TextBox();
            this.txt_discAmount = new System.Windows.Forms.TextBox();
            this.lbl_Discount = new System.Windows.Forms.Label();
            this.txt_BalAmount = new System.Windows.Forms.TextBox();
            this.txt_AmountPaid = new System.Windows.Forms.TextBox();
            this.lbl_PaidAmount = new System.Windows.Forms.Label();
            this.chk_IGST = new System.Windows.Forms.CheckBox();
            this.chk_SGST = new System.Windows.Forms.CheckBox();
            this.chk_CGST = new System.Windows.Forms.CheckBox();
            this.txt_IGSTAmt = new System.Windows.Forms.TextBox();
            this.txt_IGSTPer = new System.Windows.Forms.TextBox();
            this.lbl_IGST = new System.Windows.Forms.Label();
            this.txt_CGSTAmt = new System.Windows.Forms.TextBox();
            this.txt_CGSTPer = new System.Windows.Forms.TextBox();
            this.lbl_CGST = new System.Windows.Forms.Label();
            this.txt_SGSTPer = new System.Windows.Forms.TextBox();
            this.txt_SGSTAmt = new System.Windows.Forms.TextBox();
            this.lbl_Vat = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.grp_CustomerInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::ClothsProject.Properties.Resources.Panal;
            this.panel1.Controls.Add(this.cmb_Company);
            this.panel1.Controls.Add(this.lbl_Company);
            this.panel1.Controls.Add(this.txt_BillNo);
            this.panel1.Controls.Add(this.lbl_BillNo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1094, 34);
            this.panel1.TabIndex = 0;
            // 
            // cmb_Company
            // 
            this.cmb_Company.DisplayMember = "CompanyName";
            this.cmb_Company.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Company.FormattingEnabled = true;
            this.cmb_Company.Location = new System.Drawing.Point(374, 6);
            this.cmb_Company.Name = "cmb_Company";
            this.cmb_Company.Size = new System.Drawing.Size(273, 24);
            this.cmb_Company.TabIndex = 237;
            this.cmb_Company.ValueMember = "companyid";
            // 
            // lbl_Company
            // 
            this.lbl_Company.AutoSize = true;
            this.lbl_Company.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Company.ForeColor = System.Drawing.Color.White;
            this.lbl_Company.Location = new System.Drawing.Point(300, 7);
            this.lbl_Company.Name = "lbl_Company";
            this.lbl_Company.Size = new System.Drawing.Size(68, 16);
            this.lbl_Company.TabIndex = 236;
            this.lbl_Company.Text = "Company";
            // 
            // txt_BillNo
            // 
            this.txt_BillNo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BillNo.ForeColor = System.Drawing.Color.Red;
            this.txt_BillNo.Location = new System.Drawing.Point(70, 5);
            this.txt_BillNo.Name = "txt_BillNo";
            this.txt_BillNo.ReadOnly = true;
            this.txt_BillNo.Size = new System.Drawing.Size(120, 22);
            this.txt_BillNo.TabIndex = 235;
            this.txt_BillNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_BillNo
            // 
            this.lbl_BillNo.AutoSize = true;
            this.lbl_BillNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BillNo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_BillNo.Location = new System.Drawing.Point(9, 10);
            this.lbl_BillNo.Name = "lbl_BillNo";
            this.lbl_BillNo.Size = new System.Drawing.Size(54, 16);
            this.lbl_BillNo.TabIndex = 234;
            this.lbl_BillNo.Text = "Bill No";
            // 
            // grp_CustomerInfo
            // 
            this.grp_CustomerInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(234)))), ((int)(((byte)(232)))));
            this.grp_CustomerInfo.Controls.Add(this.comboBox2);
            this.grp_CustomerInfo.Controls.Add(this.cmb_CustName);
            this.grp_CustomerInfo.Controls.Add(this.label7);
            this.grp_CustomerInfo.Controls.Add(this.label6);
            this.grp_CustomerInfo.Controls.Add(this.txt_GstNo);
            this.grp_CustomerInfo.Controls.Add(this.Chk_GstNo);
            this.grp_CustomerInfo.Controls.Add(this.bttn_SalesPersonPopup);
            this.grp_CustomerInfo.Controls.Add(this.label5);
            this.grp_CustomerInfo.Controls.Add(this.cmb_State);
            this.grp_CustomerInfo.Controls.Add(this.lblState);
            this.grp_CustomerInfo.Controls.Add(this.lbl_amtpaidbycash);
            this.grp_CustomerInfo.Controls.Add(this.lbl_AmountPaidByCash);
            this.grp_CustomerInfo.Controls.Add(this.cmb_SalesPerson);
            this.grp_CustomerInfo.Controls.Add(this.lbl_SalesPerson);
            this.grp_CustomerInfo.Controls.Add(this.txt_PancardNo);
            this.grp_CustomerInfo.Controls.Add(this.lbl_PancardNo);
            this.grp_CustomerInfo.Controls.Add(this.lbl_Amount);
            this.grp_CustomerInfo.Controls.Add(this.txt_AccNo);
            this.grp_CustomerInfo.Controls.Add(this.lbl_AccNo);
            this.grp_CustomerInfo.Controls.Add(this.lbl_BalanceAmount);
            this.grp_CustomerInfo.Controls.Add(this.bttn_Show);
            this.grp_CustomerInfo.Controls.Add(this.bttn_CUpdate);
            this.grp_CustomerInfo.Controls.Add(this.txt_ContNo);
            this.grp_CustomerInfo.Controls.Add(this.txt_Address);
            this.grp_CustomerInfo.Controls.Add(this.lbl_ContNo);
            this.grp_CustomerInfo.Controls.Add(this.lbl_Address);
            this.grp_CustomerInfo.Controls.Add(this.lbl_CustName);
            this.grp_CustomerInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grp_CustomerInfo.ForeColor = System.Drawing.Color.DodgerBlue;
            this.grp_CustomerInfo.Location = new System.Drawing.Point(2, 36);
            this.grp_CustomerInfo.Name = "grp_CustomerInfo";
            this.grp_CustomerInfo.Size = new System.Drawing.Size(1090, 115);
            this.grp_CustomerInfo.TabIndex = 1;
            this.grp_CustomerInfo.TabStop = false;
            this.grp_CustomerInfo.Text = "Customer Info";
            // 
            // comboBox2
            // 
            this.comboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox2.DisplayMember = "GeneratedStateName";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(120, 14);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(186, 21);
            this.comboBox2.TabIndex = 154;
            this.comboBox2.ValueMember = "SrNo";
            // 
            // cmb_CustName
            // 
            this.cmb_CustName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_CustName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_CustName.DisplayMember = "name";
            this.cmb_CustName.FormattingEnabled = true;
            this.cmb_CustName.Location = new System.Drawing.Point(120, 48);
            this.cmb_CustName.Name = "cmb_CustName";
            this.cmb_CustName.Size = new System.Drawing.Size(186, 21);
            this.cmb_CustName.TabIndex = 153;
            this.cmb_CustName.ValueMember = "SrNo";
          //  this.cmb_CustName.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(1057, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 19);
            this.label7.TabIndex = 152;
            this.label7.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(895, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 151;
            this.label6.Text = "Amount Paid By Cash";
            // 
            // txt_GstNo
            // 
            this.txt_GstNo.Location = new System.Drawing.Point(402, 85);
            this.txt_GstNo.Name = "txt_GstNo";
            this.txt_GstNo.Size = new System.Drawing.Size(186, 20);
            this.txt_GstNo.TabIndex = 150;
            // 
            // Chk_GstNo
            // 
            this.Chk_GstNo.AutoSize = true;
            this.Chk_GstNo.Location = new System.Drawing.Point(315, 87);
            this.Chk_GstNo.Name = "Chk_GstNo";
            this.Chk_GstNo.Size = new System.Drawing.Size(65, 17);
            this.Chk_GstNo.TabIndex = 149;
            this.Chk_GstNo.Text = "GST No";
            this.Chk_GstNo.UseVisualStyleBackColor = true;
            // 
            // bttn_SalesPersonPopup
            // 
            this.bttn_SalesPersonPopup.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_SalesPersonPopup.BackgroundImage")));
            this.bttn_SalesPersonPopup.Location = new System.Drawing.Point(864, 17);
            this.bttn_SalesPersonPopup.Name = "bttn_SalesPersonPopup";
            this.bttn_SalesPersonPopup.Size = new System.Drawing.Size(18, 23);
            this.bttn_SalesPersonPopup.TabIndex = 148;
            this.bttn_SalesPersonPopup.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(8, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 147;
            this.label5.Text = "Select Bill";
            // 
            // cmb_State
            // 
            this.cmb_State.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_State.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_State.DisplayMember = "GeneratedStateName";
            this.cmb_State.FormattingEnabled = true;
            this.cmb_State.Location = new System.Drawing.Point(691, 49);
            this.cmb_State.Name = "cmb_State";
            this.cmb_State.Size = new System.Drawing.Size(186, 21);
            this.cmb_State.TabIndex = 144;
            this.cmb_State.ValueMember = "SrNo";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblState.Location = new System.Drawing.Point(598, 53);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(41, 16);
            this.lblState.TabIndex = 143;
            this.lblState.Text = "State";
            // 
            // lbl_amtpaidbycash
            // 
            this.lbl_amtpaidbycash.AutoSize = true;
            this.lbl_amtpaidbycash.Location = new System.Drawing.Point(895, 40);
            this.lbl_amtpaidbycash.Name = "lbl_amtpaidbycash";
            this.lbl_amtpaidbycash.Size = new System.Drawing.Size(109, 13);
            this.lbl_amtpaidbycash.TabIndex = 141;
            this.lbl_amtpaidbycash.Text = "Amount Paid By Cash";
            // 
            // lbl_AmountPaidByCash
            // 
            this.lbl_AmountPaidByCash.AutoSize = true;
            this.lbl_AmountPaidByCash.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_AmountPaidByCash.ForeColor = System.Drawing.Color.Black;
            this.lbl_AmountPaidByCash.Location = new System.Drawing.Point(1059, 38);
            this.lbl_AmountPaidByCash.Name = "lbl_AmountPaidByCash";
            this.lbl_AmountPaidByCash.Size = new System.Drawing.Size(17, 19);
            this.lbl_AmountPaidByCash.TabIndex = 140;
            this.lbl_AmountPaidByCash.Text = "0";
            // 
            // cmb_SalesPerson
            // 
            this.cmb_SalesPerson.DisplayMember = "SalesPerson";
            this.cmb_SalesPerson.FormattingEnabled = true;
            this.cmb_SalesPerson.Location = new System.Drawing.Point(691, 16);
            this.cmb_SalesPerson.Name = "cmb_SalesPerson";
            this.cmb_SalesPerson.Size = new System.Drawing.Size(171, 21);
            this.cmb_SalesPerson.TabIndex = 135;
            this.cmb_SalesPerson.ValueMember = "id";
            // 
            // lbl_SalesPerson
            // 
            this.lbl_SalesPerson.AutoSize = true;
            this.lbl_SalesPerson.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SalesPerson.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_SalesPerson.Location = new System.Drawing.Point(598, 20);
            this.lbl_SalesPerson.Name = "lbl_SalesPerson";
            this.lbl_SalesPerson.Size = new System.Drawing.Size(91, 16);
            this.lbl_SalesPerson.TabIndex = 134;
            this.lbl_SalesPerson.Text = "Sales Person";
            // 
            // txt_PancardNo
            // 
            this.txt_PancardNo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PancardNo.Location = new System.Drawing.Point(402, 50);
            this.txt_PancardNo.Name = "txt_PancardNo";
            this.txt_PancardNo.Size = new System.Drawing.Size(186, 22);
            this.txt_PancardNo.TabIndex = 131;
            // 
            // lbl_PancardNo
            // 
            this.lbl_PancardNo.AutoSize = true;
            this.lbl_PancardNo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PancardNo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_PancardNo.Location = new System.Drawing.Point(312, 53);
            this.lbl_PancardNo.Name = "lbl_PancardNo";
            this.lbl_PancardNo.Size = new System.Drawing.Size(82, 16);
            this.lbl_PancardNo.TabIndex = 132;
            this.lbl_PancardNo.Text = "Pancard No";
            // 
            // lbl_Amount
            // 
            this.lbl_Amount.AutoSize = true;
            this.lbl_Amount.Location = new System.Drawing.Point(895, 15);
            this.lbl_Amount.Name = "lbl_Amount";
            this.lbl_Amount.Size = new System.Drawing.Size(82, 13);
            this.lbl_Amount.TabIndex = 130;
            this.lbl_Amount.Text = "BalanceAmount";
            // 
            // txt_AccNo
            // 
            this.txt_AccNo.BackColor = System.Drawing.Color.White;
            this.txt_AccNo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AccNo.Location = new System.Drawing.Point(1138, 49);
            this.txt_AccNo.Name = "txt_AccNo";
            this.txt_AccNo.Size = new System.Drawing.Size(39, 22);
            this.txt_AccNo.TabIndex = 0;
            this.txt_AccNo.Visible = false;
            // 
            // lbl_AccNo
            // 
            this.lbl_AccNo.AutoSize = true;
            this.lbl_AccNo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AccNo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_AccNo.Location = new System.Drawing.Point(1135, 20);
            this.lbl_AccNo.Name = "lbl_AccNo";
            this.lbl_AccNo.Size = new System.Drawing.Size(51, 16);
            this.lbl_AccNo.TabIndex = 1;
            this.lbl_AccNo.Text = "A/C No";
            this.lbl_AccNo.Visible = false;
            // 
            // lbl_BalanceAmount
            // 
            this.lbl_BalanceAmount.AutoSize = true;
            this.lbl_BalanceAmount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_BalanceAmount.ForeColor = System.Drawing.Color.Black;
            this.lbl_BalanceAmount.Location = new System.Drawing.Point(1058, 13);
            this.lbl_BalanceAmount.Name = "lbl_BalanceAmount";
            this.lbl_BalanceAmount.Size = new System.Drawing.Size(17, 19);
            this.lbl_BalanceAmount.TabIndex = 129;
            this.lbl_BalanceAmount.Text = "0";
            // 
            // bttn_Show
            // 
            this.bttn_Show.BackColor = System.Drawing.Color.Transparent;
            this.bttn_Show.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_Show.BackgroundImage")));
            this.bttn_Show.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_Show.FlatAppearance.BorderSize = 0;
            this.bttn_Show.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_Show.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_Show.ForeColor = System.Drawing.Color.White;
            this.bttn_Show.Location = new System.Drawing.Point(794, 76);
            this.bttn_Show.Name = "bttn_Show";
            this.bttn_Show.Size = new System.Drawing.Size(71, 28);
            this.bttn_Show.TabIndex = 9;
            this.bttn_Show.Text = "SHOW";
            this.bttn_Show.UseVisualStyleBackColor = false;
            // 
            // bttn_CUpdate
            // 
            this.bttn_CUpdate.BackColor = System.Drawing.Color.Transparent;
            this.bttn_CUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_CUpdate.BackgroundImage")));
            this.bttn_CUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_CUpdate.FlatAppearance.BorderSize = 0;
            this.bttn_CUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_CUpdate.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_CUpdate.ForeColor = System.Drawing.Color.White;
            this.bttn_CUpdate.Location = new System.Drawing.Point(703, 76);
            this.bttn_CUpdate.Name = "bttn_CUpdate";
            this.bttn_CUpdate.Size = new System.Drawing.Size(71, 28);
            this.bttn_CUpdate.TabIndex = 8;
            this.bttn_CUpdate.Text = "UPDATE";
            this.bttn_CUpdate.UseVisualStyleBackColor = false;
            // 
            // txt_ContNo
            // 
            this.txt_ContNo.AllowDrop = true;
            this.txt_ContNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_ContNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_ContNo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ContNo.Location = new System.Drawing.Point(402, 17);
            this.txt_ContNo.Name = "txt_ContNo";
            this.txt_ContNo.Size = new System.Drawing.Size(186, 22);
            this.txt_ContNo.TabIndex = 3;
            // 
            // txt_Address
            // 
            this.txt_Address.AllowDrop = true;
            this.txt_Address.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_Address.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_Address.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Address.Location = new System.Drawing.Point(119, 83);
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(187, 22);
            this.txt_Address.TabIndex = 2;
            // 
            // lbl_ContNo
            // 
            this.lbl_ContNo.AutoSize = true;
            this.lbl_ContNo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ContNo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_ContNo.Location = new System.Drawing.Point(312, 20);
            this.lbl_ContNo.Name = "lbl_ContNo";
            this.lbl_ContNo.Size = new System.Drawing.Size(77, 16);
            this.lbl_ContNo.TabIndex = 5;
            this.lbl_ContNo.Text = "Contact No";
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Address.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_Address.Location = new System.Drawing.Point(8, 88);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(58, 16);
            this.lbl_Address.TabIndex = 4;
            this.lbl_Address.Text = "Address";
            // 
            // lbl_CustName
            // 
            this.lbl_CustName.AutoSize = true;
            this.lbl_CustName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CustName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_CustName.Location = new System.Drawing.Point(8, 53);
            this.lbl_CustName.Name = "lbl_CustName";
            this.lbl_CustName.Size = new System.Drawing.Size(109, 16);
            this.lbl_CustName.TabIndex = 2;
            this.lbl_CustName.Text = "Customer Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bttn_Reset);
            this.groupBox1.Controls.Add(this.bttn_Delete);
            this.groupBox1.Controls.Add(this.bttn_Update);
            this.groupBox1.Controls.Add(this.bttn_Add);
            this.groupBox1.Controls.Add(this.lbl_Disc);
            this.groupBox1.Controls.Add(this.lbl_NetPrice);
            this.groupBox1.Controls.Add(this.lbl_Quantity);
            this.groupBox1.Controls.Add(this.lbl_CurrentPrice);
            this.groupBox1.Controls.Add(this.cmb_Makingdisc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbl_Hs_Code);
            this.groupBox1.Controls.Add(this.cmb_HsName);
            this.groupBox1.Controls.Add(this.cmb_carat1);
            this.groupBox1.Controls.Add(this.txt_NetPrice);
            this.groupBox1.Controls.Add(this.txt_Quantity);
            this.groupBox1.Controls.Add(this.Cmb_SubMetalType);
            this.groupBox1.Controls.Add(this.txt_ItemNo);
            this.groupBox1.Controls.Add(this.lbl_itemno);
            this.groupBox1.Location = new System.Drawing.Point(2, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(788, 117);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // bttn_Reset
            // 
            this.bttn_Reset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_Reset.BackgroundImage")));
            this.bttn_Reset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_Reset.FlatAppearance.BorderSize = 0;
            this.bttn_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_Reset.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_Reset.ForeColor = System.Drawing.Color.White;
            this.bttn_Reset.Location = new System.Drawing.Point(367, 80);
            this.bttn_Reset.Name = "bttn_Reset";
            this.bttn_Reset.Size = new System.Drawing.Size(71, 28);
            this.bttn_Reset.TabIndex = 255;
            this.bttn_Reset.Text = "RESET";
            this.bttn_Reset.UseVisualStyleBackColor = true;
            // 
            // bttn_Delete
            // 
            this.bttn_Delete.BackColor = System.Drawing.Color.Transparent;
            this.bttn_Delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_Delete.BackgroundImage")));
            this.bttn_Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_Delete.FlatAppearance.BorderSize = 0;
            this.bttn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_Delete.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_Delete.ForeColor = System.Drawing.Color.White;
            this.bttn_Delete.Location = new System.Drawing.Point(444, 80);
            this.bttn_Delete.Name = "bttn_Delete";
            this.bttn_Delete.Size = new System.Drawing.Size(71, 28);
            this.bttn_Delete.TabIndex = 254;
            this.bttn_Delete.Text = "DELETE";
            this.bttn_Delete.UseVisualStyleBackColor = false;
            // 
            // bttn_Update
            // 
            this.bttn_Update.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_Update.BackgroundImage")));
            this.bttn_Update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_Update.FlatAppearance.BorderSize = 0;
            this.bttn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_Update.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_Update.ForeColor = System.Drawing.Color.White;
            this.bttn_Update.Location = new System.Drawing.Point(291, 80);
            this.bttn_Update.Name = "bttn_Update";
            this.bttn_Update.Size = new System.Drawing.Size(71, 28);
            this.bttn_Update.TabIndex = 253;
            this.bttn_Update.Text = "UPDATE";
            this.bttn_Update.UseVisualStyleBackColor = true;
            // 
            // bttn_Add
            // 
            this.bttn_Add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_Add.BackgroundImage")));
            this.bttn_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_Add.FlatAppearance.BorderSize = 0;
            this.bttn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_Add.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_Add.ForeColor = System.Drawing.Color.White;
            this.bttn_Add.Location = new System.Drawing.Point(214, 80);
            this.bttn_Add.Name = "bttn_Add";
            this.bttn_Add.Size = new System.Drawing.Size(71, 28);
            this.bttn_Add.TabIndex = 252;
            this.bttn_Add.Text = "ADD";
            this.bttn_Add.UseVisualStyleBackColor = true;
            // 
            // lbl_Disc
            // 
            this.lbl_Disc.AutoSize = true;
            this.lbl_Disc.ForeColor = System.Drawing.Color.Black;
            this.lbl_Disc.Location = new System.Drawing.Point(341, 54);
            this.lbl_Disc.Name = "lbl_Disc";
            this.lbl_Disc.Size = new System.Drawing.Size(39, 13);
            this.lbl_Disc.TabIndex = 251;
            this.lbl_Disc.Text = "Disc %";
            // 
            // lbl_NetPrice
            // 
            this.lbl_NetPrice.AutoSize = true;
            this.lbl_NetPrice.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NetPrice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_NetPrice.Location = new System.Drawing.Point(497, 54);
            this.lbl_NetPrice.Name = "lbl_NetPrice";
            this.lbl_NetPrice.Size = new System.Drawing.Size(62, 16);
            this.lbl_NetPrice.TabIndex = 250;
            this.lbl_NetPrice.Text = "NetPrice";
            // 
            // lbl_Quantity
            // 
            this.lbl_Quantity.AutoSize = true;
            this.lbl_Quantity.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Quantity.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_Quantity.Location = new System.Drawing.Point(5, 56);
            this.lbl_Quantity.Name = "lbl_Quantity";
            this.lbl_Quantity.Size = new System.Drawing.Size(29, 16);
            this.lbl_Quantity.TabIndex = 249;
            this.lbl_Quantity.Text = "Qty";
            // 
            // lbl_CurrentPrice
            // 
            this.lbl_CurrentPrice.AutoSize = true;
            this.lbl_CurrentPrice.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CurrentPrice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_CurrentPrice.Location = new System.Drawing.Point(174, 53);
            this.lbl_CurrentPrice.Name = "lbl_CurrentPrice";
            this.lbl_CurrentPrice.Size = new System.Drawing.Size(41, 16);
            this.lbl_CurrentPrice.TabIndex = 248;
            this.lbl_CurrentPrice.Text = "Price";
            // 
            // cmb_Makingdisc
            // 
            this.cmb_Makingdisc.DisplayMember = "MakingDiscountInPer";
            this.cmb_Makingdisc.FormattingEnabled = true;
            this.cmb_Makingdisc.Location = new System.Drawing.Point(386, 52);
            this.cmb_Makingdisc.Name = "cmb_Makingdisc";
            this.cmb_Makingdisc.Size = new System.Drawing.Size(90, 21);
            this.cmb_Makingdisc.TabIndex = 247;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(481, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 246;
            this.label1.Text = "Item";
            // 
            // lbl_Hs_Code
            // 
            this.lbl_Hs_Code.AutoSize = true;
            this.lbl_Hs_Code.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Hs_Code.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_Hs_Code.Location = new System.Drawing.Point(245, 21);
            this.lbl_Hs_Code.Name = "lbl_Hs_Code";
            this.lbl_Hs_Code.Size = new System.Drawing.Size(35, 16);
            this.lbl_Hs_Code.TabIndex = 245;
            this.lbl_Hs_Code.Text = "HSN";
            // 
            // cmb_HsName
            // 
            this.cmb_HsName.AllowDrop = true;
            this.cmb_HsName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_HsName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_HsName.DisplayMember = "MetalName";
            this.cmb_HsName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_HsName.FormattingEnabled = true;
            this.cmb_HsName.Location = new System.Drawing.Point(289, 18);
            this.cmb_HsName.Name = "cmb_HsName";
            this.cmb_HsName.Size = new System.Drawing.Size(168, 24);
            this.cmb_HsName.TabIndex = 244;
            this.cmb_HsName.ValueMember = "SrNo";
            // 
            // cmb_carat1
            // 
            this.cmb_carat1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_carat1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_carat1.DisplayMember = "Carat";
            this.cmb_carat1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_carat1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_carat1.FormattingEnabled = true;
            this.cmb_carat1.Location = new System.Drawing.Point(221, 51);
            this.cmb_carat1.Name = "cmb_carat1";
            this.cmb_carat1.Size = new System.Drawing.Size(94, 21);
            this.cmb_carat1.TabIndex = 243;
            this.cmb_carat1.ValueMember = "Rate";
            // 
            // txt_NetPrice
            // 
            this.txt_NetPrice.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_NetPrice.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NetPrice.Location = new System.Drawing.Point(565, 50);
            this.txt_NetPrice.Name = "txt_NetPrice";
            this.txt_NetPrice.ReadOnly = true;
            this.txt_NetPrice.Size = new System.Drawing.Size(108, 22);
            this.txt_NetPrice.TabIndex = 242;
            this.txt_NetPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_Quantity
            // 
            this.txt_Quantity.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Quantity.Location = new System.Drawing.Point(40, 51);
            this.txt_Quantity.Name = "txt_Quantity";
            this.txt_Quantity.Size = new System.Drawing.Size(112, 22);
            this.txt_Quantity.TabIndex = 241;
            this.txt_Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Cmb_SubMetalType
            // 
            this.Cmb_SubMetalType.AllowDrop = true;
            this.Cmb_SubMetalType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Cmb_SubMetalType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Cmb_SubMetalType.DisplayMember = "SubMetalName";
            this.Cmb_SubMetalType.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_SubMetalType.FormattingEnabled = true;
            this.Cmb_SubMetalType.Location = new System.Drawing.Point(522, 18);
            this.Cmb_SubMetalType.Name = "Cmb_SubMetalType";
            this.Cmb_SubMetalType.Size = new System.Drawing.Size(177, 24);
            this.Cmb_SubMetalType.TabIndex = 239;
            this.Cmb_SubMetalType.ValueMember = "HSNMapID";
            // 
            // txt_ItemNo
            // 
            this.txt_ItemNo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ItemNo.Location = new System.Drawing.Point(72, 18);
            this.txt_ItemNo.Name = "txt_ItemNo";
            this.txt_ItemNo.Size = new System.Drawing.Size(157, 22);
            this.txt_ItemNo.TabIndex = 240;
            // 
            // lbl_itemno
            // 
            this.lbl_itemno.AutoSize = true;
            this.lbl_itemno.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemno.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_itemno.Location = new System.Drawing.Point(5, 23);
            this.lbl_itemno.Name = "lbl_itemno";
            this.lbl_itemno.Size = new System.Drawing.Size(61, 16);
            this.lbl_itemno.TabIndex = 238;
            this.lbl_itemno.Text = "Barcode";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_paycustomer);
            this.groupBox2.Controls.Add(this.lbl_BalAmount);
            this.groupBox2.Controls.Add(this.txt_AmountPaidByCash);
            this.groupBox2.Controls.Add(this.txt_discAmount);
            this.groupBox2.Controls.Add(this.lbl_Discount);
            this.groupBox2.Controls.Add(this.txt_BalAmount);
            this.groupBox2.Controls.Add(this.txt_AmountPaid);
            this.groupBox2.Controls.Add(this.lbl_PaidAmount);
            this.groupBox2.Controls.Add(this.chk_IGST);
            this.groupBox2.Controls.Add(this.chk_SGST);
            this.groupBox2.Controls.Add(this.chk_CGST);
            this.groupBox2.Controls.Add(this.txt_IGSTAmt);
            this.groupBox2.Controls.Add(this.txt_IGSTPer);
            this.groupBox2.Controls.Add(this.lbl_IGST);
            this.groupBox2.Controls.Add(this.txt_CGSTAmt);
            this.groupBox2.Controls.Add(this.txt_CGSTPer);
            this.groupBox2.Controls.Add(this.lbl_CGST);
            this.groupBox2.Controls.Add(this.txt_SGSTPer);
            this.groupBox2.Controls.Add(this.txt_SGSTAmt);
            this.groupBox2.Controls.Add(this.lbl_Vat);
            this.groupBox2.Location = new System.Drawing.Point(796, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(296, 248);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // lbl_paycustomer
            // 
            this.lbl_paycustomer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_paycustomer.AutoSize = true;
            this.lbl_paycustomer.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_paycustomer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_paycustomer.Location = new System.Drawing.Point(22, 203);
            this.lbl_paycustomer.Name = "lbl_paycustomer";
            this.lbl_paycustomer.Size = new System.Drawing.Size(96, 16);
            this.lbl_paycustomer.TabIndex = 428;
            this.lbl_paycustomer.Text = "Pay Customer";
            // 
            // lbl_BalAmount
            // 
            this.lbl_BalAmount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_BalAmount.AutoSize = true;
            this.lbl_BalAmount.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BalAmount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_BalAmount.Location = new System.Drawing.Point(22, 176);
            this.lbl_BalAmount.Name = "lbl_BalAmount";
            this.lbl_BalAmount.Size = new System.Drawing.Size(113, 16);
            this.lbl_BalAmount.TabIndex = 427;
            this.lbl_BalAmount.Text = "Balance Amount";
            // 
            // txt_AmountPaidByCash
            // 
            this.txt_AmountPaidByCash.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_AmountPaidByCash.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AmountPaidByCash.Location = new System.Drawing.Point(170, 200);
            this.txt_AmountPaidByCash.Name = "txt_AmountPaidByCash";
            this.txt_AmountPaidByCash.Size = new System.Drawing.Size(113, 22);
            this.txt_AmountPaidByCash.TabIndex = 426;
            this.txt_AmountPaidByCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_discAmount
            // 
            this.txt_discAmount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_discAmount.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_discAmount.Location = new System.Drawing.Point(170, 120);
            this.txt_discAmount.Name = "txt_discAmount";
            this.txt_discAmount.Size = new System.Drawing.Size(113, 22);
            this.txt_discAmount.TabIndex = 424;
            this.txt_discAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_Discount
            // 
            this.lbl_Discount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Discount.AutoSize = true;
            this.lbl_Discount.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Discount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_Discount.Location = new System.Drawing.Point(22, 123);
            this.lbl_Discount.Name = "lbl_Discount";
            this.lbl_Discount.Size = new System.Drawing.Size(136, 16);
            this.lbl_Discount.TabIndex = 423;
            this.lbl_Discount.Text = "Discount / Round Up";
            // 
            // txt_BalAmount
            // 
            this.txt_BalAmount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_BalAmount.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BalAmount.Location = new System.Drawing.Point(170, 173);
            this.txt_BalAmount.Name = "txt_BalAmount";
            this.txt_BalAmount.Size = new System.Drawing.Size(113, 22);
            this.txt_BalAmount.TabIndex = 422;
            this.txt_BalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_AmountPaid
            // 
            this.txt_AmountPaid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_AmountPaid.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AmountPaid.Location = new System.Drawing.Point(170, 147);
            this.txt_AmountPaid.Name = "txt_AmountPaid";
            this.txt_AmountPaid.Size = new System.Drawing.Size(113, 22);
            this.txt_AmountPaid.TabIndex = 420;
            this.txt_AmountPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_PaidAmount
            // 
            this.lbl_PaidAmount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_PaidAmount.AutoSize = true;
            this.lbl_PaidAmount.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PaidAmount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_PaidAmount.Location = new System.Drawing.Point(22, 153);
            this.lbl_PaidAmount.Name = "lbl_PaidAmount";
            this.lbl_PaidAmount.Size = new System.Drawing.Size(120, 16);
            this.lbl_PaidAmount.TabIndex = 419;
            this.lbl_PaidAmount.Text = "Received Amount";
            // 
            // chk_IGST
            // 
            this.chk_IGST.AutoSize = true;
            this.chk_IGST.Location = new System.Drawing.Point(194, 18);
            this.chk_IGST.Name = "chk_IGST";
            this.chk_IGST.Size = new System.Drawing.Size(51, 17);
            this.chk_IGST.TabIndex = 418;
            this.chk_IGST.Text = "IGST";
            this.chk_IGST.UseVisualStyleBackColor = true;
            // 
            // chk_SGST
            // 
            this.chk_SGST.AutoSize = true;
            this.chk_SGST.Location = new System.Drawing.Point(120, 19);
            this.chk_SGST.Name = "chk_SGST";
            this.chk_SGST.Size = new System.Drawing.Size(55, 17);
            this.chk_SGST.TabIndex = 417;
            this.chk_SGST.Text = "SGST";
            this.chk_SGST.UseVisualStyleBackColor = true;
            // 
            // chk_CGST
            // 
            this.chk_CGST.AutoSize = true;
            this.chk_CGST.Location = new System.Drawing.Point(40, 19);
            this.chk_CGST.Name = "chk_CGST";
            this.chk_CGST.Size = new System.Drawing.Size(55, 17);
            this.chk_CGST.TabIndex = 416;
            this.chk_CGST.Text = "CGST";
            this.chk_CGST.UseVisualStyleBackColor = true;
            // 
            // txt_IGSTAmt
            // 
            this.txt_IGSTAmt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_IGSTAmt.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IGSTAmt.Location = new System.Drawing.Point(170, 92);
            this.txt_IGSTAmt.Name = "txt_IGSTAmt";
            this.txt_IGSTAmt.ReadOnly = true;
            this.txt_IGSTAmt.Size = new System.Drawing.Size(113, 22);
            this.txt_IGSTAmt.TabIndex = 415;
            this.txt_IGSTAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_IGSTPer
            // 
            this.txt_IGSTPer.Location = new System.Drawing.Point(75, 96);
            this.txt_IGSTPer.Name = "txt_IGSTPer";
            this.txt_IGSTPer.ReadOnly = true;
            this.txt_IGSTPer.Size = new System.Drawing.Size(46, 20);
            this.txt_IGSTPer.TabIndex = 414;
            // 
            // lbl_IGST
            // 
            this.lbl_IGST.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_IGST.AutoSize = true;
            this.lbl_IGST.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IGST.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_IGST.Location = new System.Drawing.Point(22, 95);
            this.lbl_IGST.Name = "lbl_IGST";
            this.lbl_IGST.Size = new System.Drawing.Size(43, 16);
            this.lbl_IGST.TabIndex = 413;
            this.lbl_IGST.Text = "IGST ";
            // 
            // txt_CGSTAmt
            // 
            this.txt_CGSTAmt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_CGSTAmt.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CGSTAmt.Location = new System.Drawing.Point(169, 66);
            this.txt_CGSTAmt.Name = "txt_CGSTAmt";
            this.txt_CGSTAmt.ReadOnly = true;
            this.txt_CGSTAmt.Size = new System.Drawing.Size(113, 22);
            this.txt_CGSTAmt.TabIndex = 412;
            this.txt_CGSTAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_CGSTPer
            // 
            this.txt_CGSTPer.Location = new System.Drawing.Point(76, 68);
            this.txt_CGSTPer.Name = "txt_CGSTPer";
            this.txt_CGSTPer.ReadOnly = true;
            this.txt_CGSTPer.Size = new System.Drawing.Size(46, 20);
            this.txt_CGSTPer.TabIndex = 411;
            // 
            // lbl_CGST
            // 
            this.lbl_CGST.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_CGST.AutoSize = true;
            this.lbl_CGST.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CGST.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_CGST.Location = new System.Drawing.Point(22, 68);
            this.lbl_CGST.Name = "lbl_CGST";
            this.lbl_CGST.Size = new System.Drawing.Size(48, 16);
            this.lbl_CGST.TabIndex = 410;
            this.lbl_CGST.Text = "CGST ";
            // 
            // txt_SGSTPer
            // 
            this.txt_SGSTPer.Location = new System.Drawing.Point(76, 37);
            this.txt_SGSTPer.Name = "txt_SGSTPer";
            this.txt_SGSTPer.ReadOnly = true;
            this.txt_SGSTPer.Size = new System.Drawing.Size(46, 20);
            this.txt_SGSTPer.TabIndex = 409;
            // 
            // txt_SGSTAmt
            // 
            this.txt_SGSTAmt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_SGSTAmt.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SGSTAmt.Location = new System.Drawing.Point(168, 40);
            this.txt_SGSTAmt.Name = "txt_SGSTAmt";
            this.txt_SGSTAmt.ReadOnly = true;
            this.txt_SGSTAmt.Size = new System.Drawing.Size(113, 22);
            this.txt_SGSTAmt.TabIndex = 408;
            this.txt_SGSTAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_Vat
            // 
            this.lbl_Vat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Vat.AutoSize = true;
            this.lbl_Vat.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Vat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_Vat.Location = new System.Drawing.Point(22, 37);
            this.lbl_Vat.Name = "lbl_Vat";
            this.lbl_Vat.Size = new System.Drawing.Size(48, 16);
            this.lbl_Vat.TabIndex = 407;
            this.lbl_Vat.Text = "SGST ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 268);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(788, 221);
            this.dataGridView1.TabIndex = 4;
            // 
            // frm_CustomerSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 494);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grp_CustomerInfo);
            this.Controls.Add(this.panel1);
            this.Name = "frm_CustomerSale";
            this.Text = "frm_CustomerSale";
            this.Load += new System.EventHandler(this.frm_CustomerSale_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grp_CustomerInfo.ResumeLayout(false);
            this.grp_CustomerInfo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmb_Company;
        private System.Windows.Forms.Label lbl_Company;
        private System.Windows.Forms.TextBox txt_BillNo;
        private System.Windows.Forms.Label lbl_BillNo;
        private System.Windows.Forms.GroupBox grp_CustomerInfo;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox cmb_CustName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_GstNo;
        private System.Windows.Forms.CheckBox Chk_GstNo;
        private System.Windows.Forms.Button bttn_SalesPersonPopup;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_State;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lbl_amtpaidbycash;
        private System.Windows.Forms.Label lbl_AmountPaidByCash;
        private System.Windows.Forms.ComboBox cmb_SalesPerson;
        private System.Windows.Forms.Label lbl_SalesPerson;
        private System.Windows.Forms.TextBox txt_PancardNo;
        private System.Windows.Forms.Label lbl_PancardNo;
        private System.Windows.Forms.Label lbl_Amount;
        public System.Windows.Forms.TextBox txt_AccNo;
        private System.Windows.Forms.Label lbl_AccNo;
        private System.Windows.Forms.Label lbl_BalanceAmount;
        private System.Windows.Forms.Button bttn_Show;
        private System.Windows.Forms.Button bttn_CUpdate;
        private System.Windows.Forms.TextBox txt_ContNo;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.Label lbl_ContNo;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.Label lbl_CustName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bttn_Reset;
        private System.Windows.Forms.Button bttn_Delete;
        private System.Windows.Forms.Button bttn_Update;
        private System.Windows.Forms.Button bttn_Add;
        private System.Windows.Forms.Label lbl_Disc;
        private System.Windows.Forms.Label lbl_NetPrice;
        private System.Windows.Forms.Label lbl_Quantity;
        private System.Windows.Forms.Label lbl_CurrentPrice;
        private System.Windows.Forms.ComboBox cmb_Makingdisc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Hs_Code;
        private System.Windows.Forms.ComboBox cmb_HsName;
        private System.Windows.Forms.ComboBox cmb_carat1;
        private System.Windows.Forms.TextBox txt_NetPrice;
        private System.Windows.Forms.TextBox txt_Quantity;
        private System.Windows.Forms.ComboBox Cmb_SubMetalType;
        private System.Windows.Forms.TextBox txt_ItemNo;
        private System.Windows.Forms.Label lbl_itemno;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_paycustomer;
        private System.Windows.Forms.Label lbl_BalAmount;
        private System.Windows.Forms.TextBox txt_AmountPaidByCash;
        private System.Windows.Forms.TextBox txt_discAmount;
        private System.Windows.Forms.Label lbl_Discount;
        private System.Windows.Forms.TextBox txt_BalAmount;
        private System.Windows.Forms.TextBox txt_AmountPaid;
        private System.Windows.Forms.Label lbl_PaidAmount;
        private System.Windows.Forms.CheckBox chk_IGST;
        private System.Windows.Forms.CheckBox chk_SGST;
        private System.Windows.Forms.CheckBox chk_CGST;
        private System.Windows.Forms.TextBox txt_IGSTAmt;
        private System.Windows.Forms.TextBox txt_IGSTPer;
        private System.Windows.Forms.Label lbl_IGST;
        private System.Windows.Forms.TextBox txt_CGSTAmt;
        private System.Windows.Forms.TextBox txt_CGSTPer;
        private System.Windows.Forms.Label lbl_CGST;
        private System.Windows.Forms.TextBox txt_SGSTPer;
        private System.Windows.Forms.TextBox txt_SGSTAmt;
        private System.Windows.Forms.Label lbl_Vat;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}