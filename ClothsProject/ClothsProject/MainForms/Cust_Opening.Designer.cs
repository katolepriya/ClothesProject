namespace ClothsProject
{
    partial class Cust_Opening
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cust_Opening));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker_Date = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_State = new System.Windows.Forms.Label();
            this.lbl_address = new System.Windows.Forms.Label();
            this.lbl_MobileNo = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_mobileNo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_Customer_name = new System.Windows.Forms.ComboBox();
            this.cmb_state = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_Amount = new System.Windows.Forms.Label();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.bttn_Close = new System.Windows.Forms.Button();
            this.bttn_Save = new System.Windows.Forms.Button();
            this.bttn_Reset = new System.Windows.Forms.Button();
            this.dgv_CustOpening = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mobile_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bttn_Search = new System.Windows.Forms.Button();
            this.Cmb_Name = new System.Windows.Forms.ComboBox();
            this.lblLedgerNameSearch = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CustOpening)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BackgroundImage = global::ClothsProject.Properties.Resources.Panal;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dateTimePicker_Date);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(483, 32);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Date";
            // 
            // dateTimePicker_Date
            // 
            this.dateTimePicker_Date.Location = new System.Drawing.Point(47, 6);
            this.dateTimePicker_Date.Name = "dateTimePicker_Date";
            this.dateTimePicker_Date.Size = new System.Drawing.Size(82, 20);
            this.dateTimePicker_Date.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 2;
            // 
            // lbl_State
            // 
            this.lbl_State.AutoSize = true;
            this.lbl_State.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_State.Location = new System.Drawing.Point(35, 97);
            this.lbl_State.Name = "lbl_State";
            this.lbl_State.Size = new System.Drawing.Size(40, 15);
            this.lbl_State.TabIndex = 4;
            this.lbl_State.Text = "State";
            this.lbl_State.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_address.Location = new System.Drawing.Point(34, 71);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(58, 15);
            this.lbl_address.TabIndex = 5;
            this.lbl_address.Text = "Address";
            // 
            // lbl_MobileNo
            // 
            this.lbl_MobileNo.AutoSize = true;
            this.lbl_MobileNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MobileNo.Location = new System.Drawing.Point(35, 45);
            this.lbl_MobileNo.Name = "lbl_MobileNo";
            this.lbl_MobileNo.Size = new System.Drawing.Size(73, 15);
            this.lbl_MobileNo.TabIndex = 6;
            this.lbl_MobileNo.Text = "Mobile No";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(34, 20);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(45, 15);
            this.lbl_Name.TabIndex = 7;
            this.lbl_Name.Text = "Name";
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(133, 71);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(238, 20);
            this.txt_address.TabIndex = 12;
            // 
            // txt_mobileNo
            // 
            this.txt_mobileNo.Location = new System.Drawing.Point(133, 44);
            this.txt_mobileNo.Name = "txt_mobileNo";
            this.txt_mobileNo.Size = new System.Drawing.Size(238, 20);
            this.txt_mobileNo.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_Customer_name);
            this.groupBox1.Controls.Add(this.cmb_state);
            this.groupBox1.Controls.Add(this.txt_address);
            this.groupBox1.Controls.Add(this.txt_mobileNo);
            this.groupBox1.Controls.Add(this.lbl_State);
            this.groupBox1.Controls.Add(this.lbl_address);
            this.groupBox1.Controls.Add(this.lbl_MobileNo);
            this.groupBox1.Controls.Add(this.lbl_Name);
            this.groupBox1.Location = new System.Drawing.Point(39, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(412, 131);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Details";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cmb_Customer_name
            // 
            this.cmb_Customer_name.FormattingEnabled = true;
            this.cmb_Customer_name.Location = new System.Drawing.Point(133, 16);
            this.cmb_Customer_name.Name = "cmb_Customer_name";
            this.cmb_Customer_name.Size = new System.Drawing.Size(238, 21);
            this.cmb_Customer_name.TabIndex = 15;
            // 
            // cmb_state
            // 
            this.cmb_state.FormattingEnabled = true;
            this.cmb_state.Location = new System.Drawing.Point(133, 98);
            this.cmb_state.Name = "cmb_state";
            this.cmb_state.Size = new System.Drawing.Size(238, 21);
            this.cmb_state.TabIndex = 14;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_Amount);
            this.groupBox2.Controls.Add(this.txt_amount);
            this.groupBox2.Location = new System.Drawing.Point(39, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(412, 49);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Payment Details";
            // 
            // lbl_Amount
            // 
            this.lbl_Amount.AutoSize = true;
            this.lbl_Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Amount.Location = new System.Drawing.Point(34, 21);
            this.lbl_Amount.Name = "lbl_Amount";
            this.lbl_Amount.Size = new System.Drawing.Size(55, 15);
            this.lbl_Amount.TabIndex = 13;
            this.lbl_Amount.Text = "Amount";
            // 
            // txt_amount
            // 
            this.txt_amount.Location = new System.Drawing.Point(133, 18);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(238, 20);
            this.txt_amount.TabIndex = 12;
            this.txt_amount.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // bttn_Close
            // 
            this.bttn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttn_Close.BackColor = System.Drawing.Color.Transparent;
            this.bttn_Close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_Close.BackgroundImage")));
            this.bttn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_Close.FlatAppearance.BorderSize = 0;
            this.bttn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_Close.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_Close.ForeColor = System.Drawing.Color.White;
            this.bttn_Close.Location = new System.Drawing.Point(374, 215);
            this.bttn_Close.Name = "bttn_Close";
            this.bttn_Close.Size = new System.Drawing.Size(71, 28);
            this.bttn_Close.TabIndex = 63;
            this.bttn_Close.Text = "CLOSE";
            this.bttn_Close.UseVisualStyleBackColor = false;
            // 
            // bttn_Save
            // 
            this.bttn_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttn_Save.BackColor = System.Drawing.Color.Transparent;
            this.bttn_Save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_Save.BackgroundImage")));
            this.bttn_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_Save.FlatAppearance.BorderSize = 0;
            this.bttn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_Save.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_Save.ForeColor = System.Drawing.Color.White;
            this.bttn_Save.Location = new System.Drawing.Point(170, 215);
            this.bttn_Save.Name = "bttn_Save";
            this.bttn_Save.Size = new System.Drawing.Size(71, 28);
            this.bttn_Save.TabIndex = 62;
            this.bttn_Save.Text = "SAVE";
            this.bttn_Save.UseVisualStyleBackColor = false;
            this.bttn_Save.Click += new System.EventHandler(this.bttn_Save_Click);
            // 
            // bttn_Reset
            // 
            this.bttn_Reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttn_Reset.BackColor = System.Drawing.Color.Transparent;
            this.bttn_Reset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_Reset.BackgroundImage")));
            this.bttn_Reset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_Reset.FlatAppearance.BorderSize = 0;
            this.bttn_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_Reset.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_Reset.ForeColor = System.Drawing.Color.White;
            this.bttn_Reset.Location = new System.Drawing.Point(272, 214);
            this.bttn_Reset.Name = "bttn_Reset";
            this.bttn_Reset.Size = new System.Drawing.Size(71, 28);
            this.bttn_Reset.TabIndex = 61;
            this.bttn_Reset.Text = "RESET";
            this.bttn_Reset.UseVisualStyleBackColor = false;
            // 
            // dgv_CustOpening
            // 
            this.dgv_CustOpening.AllowUserToAddRows = false;
            this.dgv_CustOpening.AllowUserToDeleteRows = false;
            this.dgv_CustOpening.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CustOpening.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Mobile_No,
            this.Address,
            this.State});
            this.dgv_CustOpening.Location = new System.Drawing.Point(19, 300);
            this.dgv_CustOpening.Name = "dgv_CustOpening";
            this.dgv_CustOpening.ReadOnly = true;
            this.dgv_CustOpening.Size = new System.Drawing.Size(442, 192);
            this.dgv_CustOpening.TabIndex = 65;
            this.dgv_CustOpening.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // Mobile_No
            // 
            this.Mobile_No.HeaderText = "Mobile_No";
            this.Mobile_No.Name = "Mobile_No";
            this.Mobile_No.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // State
            // 
            this.State.HeaderText = "State";
            this.State.Name = "State";
            this.State.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bttn_Search);
            this.groupBox3.Controls.Add(this.Cmb_Name);
            this.groupBox3.Controls.Add(this.lblLedgerNameSearch);
            this.groupBox3.Location = new System.Drawing.Point(7, 246);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(469, 48);
            this.groupBox3.TabIndex = 66;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // bttn_Search
            // 
            this.bttn_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttn_Search.BackColor = System.Drawing.Color.Transparent;
            this.bttn_Search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_Search.BackgroundImage")));
            this.bttn_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_Search.FlatAppearance.BorderSize = 0;
            this.bttn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_Search.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_Search.ForeColor = System.Drawing.Color.White;
            this.bttn_Search.Location = new System.Drawing.Point(353, 11);
            this.bttn_Search.Name = "bttn_Search";
            this.bttn_Search.Size = new System.Drawing.Size(96, 28);
            this.bttn_Search.TabIndex = 178;
            this.bttn_Search.Text = "SEARCH";
            this.bttn_Search.UseVisualStyleBackColor = false;
            this.bttn_Search.Click += new System.EventHandler(this.bttn_Search_Click);
            // 
            // Cmb_Name
            // 
            this.Cmb_Name.DisplayMember = "name";
            this.Cmb_Name.FormattingEnabled = true;
            this.Cmb_Name.Location = new System.Drawing.Point(83, 15);
            this.Cmb_Name.Name = "Cmb_Name";
            this.Cmb_Name.Size = new System.Drawing.Size(253, 21);
            this.Cmb_Name.TabIndex = 177;
            this.Cmb_Name.ValueMember = "FullName";
            // 
            // lblLedgerNameSearch
            // 
            this.lblLedgerNameSearch.AutoSize = true;
            this.lblLedgerNameSearch.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLedgerNameSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblLedgerNameSearch.Location = new System.Drawing.Point(24, 18);
            this.lblLedgerNameSearch.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblLedgerNameSearch.Name = "lblLedgerNameSearch";
            this.lblLedgerNameSearch.Size = new System.Drawing.Size(45, 16);
            this.lblLedgerNameSearch.TabIndex = 176;
            this.lblLedgerNameSearch.Text = "Name";
            // 
            // Cust_Opening
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(483, 504);
            this.Controls.Add(this.bttn_Save);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.bttn_Close);
            this.Controls.Add(this.bttn_Reset);
            this.Controls.Add(this.dgv_CustOpening);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
          //  this.Name = "Cust_Opening";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CustOpening)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_State;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.Label lbl_MobileNo;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.TextBox txt_mobileNo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_Amount;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Date;
        private System.Windows.Forms.ComboBox cmb_state;
        private System.Windows.Forms.Button bttn_Close;
        private System.Windows.Forms.Button bttn_Save;
        private System.Windows.Forms.Button bttn_Reset;
        private System.Windows.Forms.DataGridView dgv_CustOpening;
        private System.Windows.Forms.ComboBox cmb_Customer_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mobile_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bttn_Search;
        private System.Windows.Forms.ComboBox Cmb_Name;
        private System.Windows.Forms.Label lblLedgerNameSearch;
    }
}

