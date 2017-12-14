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
    public partial class frm_CustomerSale : Form
    {
        public frm_CustomerSale()
        {
            InitializeComponent();
        }
        cls_commonn _objcls = new cls_commonn();

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void frm_CustomerSale_Load(object sender, EventArgs e)
        {
            // cmb_CustName.DataSource = _objcls.getcustdetails();
           
            cmb_CustName.DataSource = _objcls.getcustomerdetails();
        }
    }
}
