using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClothsProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //private void customerOpeningToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    Cust_Opening _objfrm = new Cust_Opening();
        //    _objfrm.Show();
        //}

        private void itemOpeningToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddItemName _objfrm = new AddItemName();
            _objfrm.Show();

        }

        private void openingFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void ghToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void vyapariOpeningToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WholesalerOpening _objfrm = new WholesalerOpening();
            _objfrm.Show();
        }

        private void customerSaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_CustomerSale _objfrm = new frm_CustomerSale();
            _objfrm.Show();
        }

        private void customerOpeningToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Cust_Opening _objfrm = new Cust_Opening();
            _objfrm.Show();
        }
    }
}
