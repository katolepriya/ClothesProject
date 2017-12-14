namespace ClothsProject
{
    partial class AddItemName
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddItemName));
            this.Item_Name_hindi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.item_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bttn_Reset = new System.Windows.Forms.Button();
            this.bttn_Delete = new System.Windows.Forms.Button();
            this.bttn_Update = new System.Windows.Forms.Button();
            this.bttn_Save = new System.Windows.Forms.Button();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.txt_ItemHindiName = new System.Windows.Forms.TextBox();
            this.txt_ItemName = new System.Windows.Forms.TextBox();
            this.lbl_ItemName = new System.Windows.Forms.Label();
            this.lbl_ItemHindiName = new System.Windows.Forms.Label();
            this.errLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnl_Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // Item_Name_hindi
            // 
            this.Item_Name_hindi.HeaderText = "Items Name Hindi";
            this.Item_Name_hindi.Name = "Item_Name_hindi";
            this.Item_Name_hindi.ReadOnly = true;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.item_name,
            this.Item_Name_hindi});
            this.dataGridView1.Location = new System.Drawing.Point(13, 194);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(338, 256);
            this.dataGridView1.TabIndex = 99;
            // 
            // item_name
            // 
            this.item_name.HeaderText = "Item Name";
            this.item_name.Name = "item_name";
            this.item_name.ReadOnly = true;
            // 
            // bttn_Reset
            // 
            this.bttn_Reset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_Reset.BackgroundImage")));
            this.bttn_Reset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_Reset.FlatAppearance.BorderSize = 0;
            this.bttn_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_Reset.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_Reset.ForeColor = System.Drawing.Color.White;
            this.bttn_Reset.Location = new System.Drawing.Point(185, 146);
            this.bttn_Reset.Name = "bttn_Reset";
            this.bttn_Reset.Size = new System.Drawing.Size(71, 28);
            this.bttn_Reset.TabIndex = 98;
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
            this.bttn_Delete.Location = new System.Drawing.Point(273, 146);
            this.bttn_Delete.Name = "bttn_Delete";
            this.bttn_Delete.Size = new System.Drawing.Size(71, 28);
            this.bttn_Delete.TabIndex = 97;
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
            this.bttn_Update.Location = new System.Drawing.Point(101, 146);
            this.bttn_Update.Name = "bttn_Update";
            this.bttn_Update.Size = new System.Drawing.Size(71, 28);
            this.bttn_Update.TabIndex = 96;
            this.bttn_Update.Text = "UPDATE";
            this.bttn_Update.UseVisualStyleBackColor = true;
            // 
            // bttn_Save
            // 
            this.bttn_Save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_Save.BackgroundImage")));
            this.bttn_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_Save.FlatAppearance.BorderSize = 0;
            this.bttn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_Save.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_Save.ForeColor = System.Drawing.Color.White;
            this.bttn_Save.Location = new System.Drawing.Point(20, 146);
            this.bttn_Save.Name = "bttn_Save";
            this.bttn_Save.Size = new System.Drawing.Size(71, 28);
            this.bttn_Save.TabIndex = 95;
            this.bttn_Save.Text = "SAVE";
            this.bttn_Save.UseVisualStyleBackColor = true;
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(135, 44);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(209, 22);
            this.txt_id.TabIndex = 94;
            this.txt_id.Visible = false;
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(132)))), ((int)(((byte)(153)))));
            this.pnl_Header.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_Header.Controls.Add(this.dtp_Date);
            this.pnl_Header.Controls.Add(this.lbl_Date);
            this.pnl_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Header.Location = new System.Drawing.Point(0, 0);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(362, 35);
            this.pnl_Header.TabIndex = 87;
            // 
            // dtp_Date
            // 
            this.dtp_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Date.Location = new System.Drawing.Point(240, 5);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(98, 20);
            this.dtp_Date.TabIndex = 3;
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Date.Location = new System.Drawing.Point(194, 6);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(41, 16);
            this.lbl_Date.TabIndex = 1;
            this.lbl_Date.Text = "Date";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.ForeColor = System.Drawing.Color.Black;
            this.lbl_id.Location = new System.Drawing.Point(18, 47);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(20, 16);
            this.lbl_id.TabIndex = 93;
            this.lbl_id.Text = "Id";
            this.lbl_id.Visible = false;
            // 
            // txt_ItemHindiName
            // 
            this.txt_ItemHindiName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ItemHindiName.Location = new System.Drawing.Point(135, 108);
            this.txt_ItemHindiName.Name = "txt_ItemHindiName";
            this.txt_ItemHindiName.Size = new System.Drawing.Size(209, 22);
            this.txt_ItemHindiName.TabIndex = 91;
            // 
            // txt_ItemName
            // 
            this.txt_ItemName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ItemName.Location = new System.Drawing.Point(135, 76);
            this.txt_ItemName.Name = "txt_ItemName";
            this.txt_ItemName.Size = new System.Drawing.Size(209, 22);
            this.txt_ItemName.TabIndex = 92;
            // 
            // lbl_ItemName
            // 
            this.lbl_ItemName.AutoSize = true;
            this.lbl_ItemName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ItemName.ForeColor = System.Drawing.Color.Black;
            this.lbl_ItemName.Location = new System.Drawing.Point(18, 75);
            this.lbl_ItemName.Name = "lbl_ItemName";
            this.lbl_ItemName.Size = new System.Drawing.Size(81, 16);
            this.lbl_ItemName.TabIndex = 88;
            this.lbl_ItemName.Text = "Item Name ";
            // 
            // lbl_ItemHindiName
            // 
            this.lbl_ItemHindiName.AutoSize = true;
            this.lbl_ItemHindiName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ItemHindiName.ForeColor = System.Drawing.Color.Black;
            this.lbl_ItemHindiName.Location = new System.Drawing.Point(18, 98);
            this.lbl_ItemHindiName.Name = "lbl_ItemHindiName";
            this.lbl_ItemHindiName.Size = new System.Drawing.Size(86, 32);
            this.lbl_ItemHindiName.TabIndex = 90;
            this.lbl_ItemHindiName.Text = "Item\r\nHindi Name ";
            // 
            // errLbl
            // 
            this.errLbl.AutoSize = true;
            this.errLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errLbl.ForeColor = System.Drawing.Color.Red;
            this.errLbl.Location = new System.Drawing.Point(294, 113);
            this.errLbl.Name = "errLbl";
            this.errLbl.Size = new System.Drawing.Size(15, 20);
            this.errLbl.TabIndex = 89;
            this.errLbl.Text = "*";
            this.errLbl.Visible = false;
            // 
            // AddItemName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 453);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bttn_Reset);
            this.Controls.Add(this.bttn_Delete);
            this.Controls.Add(this.bttn_Update);
            this.Controls.Add(this.bttn_Save);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.pnl_Header);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.txt_ItemHindiName);
            this.Controls.Add(this.txt_ItemName);
            this.Controls.Add(this.lbl_ItemName);
            this.Controls.Add(this.lbl_ItemHindiName);
            this.Controls.Add(this.errLbl);
            this.Name = "AddItemName";
            this.Text = "AddItemName";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn Item_Name_hindi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_name;
        private System.Windows.Forms.Button bttn_Reset;
        private System.Windows.Forms.Button bttn_Delete;
        private System.Windows.Forms.Button bttn_Update;
        private System.Windows.Forms.Button bttn_Save;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.TextBox txt_ItemHindiName;
        private System.Windows.Forms.TextBox txt_ItemName;
        private System.Windows.Forms.Label lbl_ItemName;
        private System.Windows.Forms.Label lbl_ItemHindiName;
        private System.Windows.Forms.Label errLbl;
    }
}