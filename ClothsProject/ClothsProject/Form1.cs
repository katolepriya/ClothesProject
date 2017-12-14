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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SQLHelper _objsql = new SQLHelper();
        cls_commonn _objcls = new cls_commonn();

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void bttn_Save_Click(object sender, EventArgs e)
        {
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fillgrid();
        }

        private void fillgrid()
        {
            _objcls.getcustomer(txt_Custname.Text, txt_mobileNo.Text, txt_address.Text, cmb_state.Text, txt_amount.Text);
        }
    }
}
