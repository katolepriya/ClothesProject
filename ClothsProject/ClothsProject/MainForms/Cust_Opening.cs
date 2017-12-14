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
    public partial class Cust_Opening : Form
    {
        public Cust_Opening()
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
            //dgv_CustOpening.Rows.Add(cmb_Customer_name.Text, txt_amount.Text, txt_address.Text, cmb_state.Text);





            _objcls.getcustomer(cmb_Customer_name.Text, txt_mobileNo.Text, txt_address.Text, cmb_state.Text, txt_amount.Text);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Cmb_Name.DataSource = _objcls.getcustdetail();

            DataTable dt = _objcls.getcustdetail();
            for (int i = 0; i < dt.Rows.Count; i++)
                dgv_CustOpening.Rows.Add(dt.Rows[i]["name"].ToString(), dt.Rows[i]["mobile_no"].ToString(), dt.Rows[i]["address"].ToString(), dt.Rows[i]["state"].ToString());

        }



        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bttn_Search_Click(object sender, EventArgs e)
        {
            DataTable dt = _objcls.getCustnamedetails(Cmb_Name.Text);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dgv_CustOpening.Rows.Add();
                dgv_CustOpening.Rows[i].Cells["Name"].Value = dt.Rows[i]["name"].ToString();
                dgv_CustOpening.Rows[i].Cells["Mobile_No"].Value = dt.Rows[i]["mobile_no"].ToString();
                dgv_CustOpening.Rows[i].Cells["Address"].Value = dt.Rows[i]["address"].ToString();
                dgv_CustOpening.Rows[i].Cells["State"].Value = dt.Rows[i]["state"].ToString();
                //dgv_CustOpening.Rows[i].Cells["contact_no"].Value = dt.Rows[i]["contact_no"].ToString();
                //dgv_CustOpening.Rows[i].Cells["software"].Value = dt.Rows[i]["software"].ToString();
                //dgv_CustOpening.Rows[i].Cells["soft_rate"].Value = dt.Rows[i]["soft_rate"].ToString();
                //dgv_CustOpening.Rows[i].Cells["licence"].Value = dt.Rows[i]["licence"].ToString();
            }
        }
    }
}
    

