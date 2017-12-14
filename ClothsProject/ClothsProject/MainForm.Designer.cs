namespace ClothsProject
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openingFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ghToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerOpeningToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemOpeningToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vyapariOpeningToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerSaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openingFormToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.transactionToolStripMenuItem,
            this.settingToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(501, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openingFormToolStripMenuItem
            // 
            this.openingFormToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ghToolStripMenuItem,
            this.customerSaleToolStripMenuItem,
            this.purchaseToolStripMenuItem});
            this.openingFormToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openingFormToolStripMenuItem.Name = "openingFormToolStripMenuItem";
            this.openingFormToolStripMenuItem.Size = new System.Drawing.Size(131, 21);
            this.openingFormToolStripMenuItem.Text = "Sale and Purchase";
            // 
            // ghToolStripMenuItem
            // 
            this.ghToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerOpeningToolStripMenuItem,
            this.itemOpeningToolStripMenuItem,
            this.vyapariOpeningToolStripMenuItem});
            this.ghToolStripMenuItem.Name = "ghToolStripMenuItem";
            this.ghToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.ghToolStripMenuItem.Text = " Opening Form";
            // 
            // customerOpeningToolStripMenuItem
            // 
            this.customerOpeningToolStripMenuItem.Name = "customerOpeningToolStripMenuItem";
            this.customerOpeningToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.customerOpeningToolStripMenuItem.Text = "Customer Opening";
            this.customerOpeningToolStripMenuItem.Click += new System.EventHandler(this.customerOpeningToolStripMenuItem_Click_1);
            // 
            // itemOpeningToolStripMenuItem
            // 
            this.itemOpeningToolStripMenuItem.Name = "itemOpeningToolStripMenuItem";
            this.itemOpeningToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.itemOpeningToolStripMenuItem.Text = "Item Opening";
            // 
            // vyapariOpeningToolStripMenuItem
            // 
            this.vyapariOpeningToolStripMenuItem.Name = "vyapariOpeningToolStripMenuItem";
            this.vyapariOpeningToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.vyapariOpeningToolStripMenuItem.Text = "Vyapari Opening";
            // 
            // customerSaleToolStripMenuItem
            // 
            this.customerSaleToolStripMenuItem.Name = "customerSaleToolStripMenuItem";
            this.customerSaleToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.customerSaleToolStripMenuItem.Text = "Customer Sale";
            this.customerSaleToolStripMenuItem.Click += new System.EventHandler(this.customerSaleToolStripMenuItem_Click);
            // 
            // purchaseToolStripMenuItem
            // 
            this.purchaseToolStripMenuItem.Name = "purchaseToolStripMenuItem";
            this.purchaseToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.purchaseToolStripMenuItem.Text = "Purchase";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(67, 21);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // transactionToolStripMenuItem
            // 
            this.transactionToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            this.transactionToolStripMenuItem.Size = new System.Drawing.Size(91, 21);
            this.transactionToolStripMenuItem.Text = "Transaction";
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(64, 21);
            this.settingToolStripMenuItem.Text = "Setting";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(43, 21);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 355);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openingFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ghToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerOpeningToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemOpeningToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vyapariOpeningToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerSaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseToolStripMenuItem;
    }
}