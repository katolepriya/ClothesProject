using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyRegistrationForm2.class_file
{
    public class softwareForm
    {
        SQLHelper _objs = new SQLHelper();
        internal string getlicrate;

        internal DataTable getSaoftwareRate()

        {
            string ss = "select * from software";
            DataTable dt = _objs.GetDataTable(ss);
            return dt;
        }

        internal string getrate(string soff)
        {
            string str = "select soft_rate from software where software = '" + soff + "'";
            return _objs.ExecuteScalar(str);
        }

        internal DataTable getcdetail(string name)
        {
            string s = "SELECT customerData.bill_no, customerData.customer_id, customerData.customer_name, customerData.customer_add, customerData.contact_no, software.bill_no AS Expr1, software.software, software.soft_rate, software.licence, software.lic_rate, software.total FROM customerData INNER JOIN software ON customerData.bill_no = software.bill_no where customer_name = '" + name + "'";
            DataTable dt = _objs.GetDataTable(s);
            return dt;

        }

       // internal DataTable GetDataTable()
       // {
            
        //}

        // internal DataTable getcustdetaail(string custn)
        //  {
        //   string s = "SELECT customerData.bill_no, customerData.customer_id, customerData.customer_name, customerData.customer_add, customerData.contact_no, software.bill_no AS Expr1, software.software, software.soft_rate, software.licence, software.lic_rate, software.total FROM customerData INNER JOIN software ON customerData.bill_no = software.bill_no where customer_name = '" + custn + "'";

        //}

        /* internal DataTable getdetails(string custname)
         {
             string s = "SELECT customerData.bill_no, customerData.customer_id, customerData.customer_name, customerData.customer_add, customerData.contact_no, software.bill_no AS Expr1, software.software, software.soft_rate, software.licence, software.lic_rate, software.total FROM customerData INNER JOIN software ON customerData.bill_no = software.bill_no where customer_name = '"+custname+"'";
             DataTable dt = _objs.GetDataTable(s);
             return dt;
         }*/

        internal DataTable getdetails()
        {
            throw new NotImplementedException();
        }

        internal string getLicencerate(string sofff)
        {
            string str = "select lic_rate from software where licence = '" + sofff + "'";
            return _objs.ExecuteScalar(str);
        }

       /* internal DataTable GetDataTable(string s)
        {
            throw new NotImplementedException();
        }
        */
        /* internal void insertCustomerInfo(string id, string name, string add, string cont)
         {
             string s = "insert into customerData(customer_id,customer_name,customer_add,contact_no)values('" + id + "','" + name + "','" + add + "','" + cont + "')";
             _objs.ExecuteScalar(s);
         }*/

        /* internal void insertCustomerInfo(string soft, string softRate, string licence, string licRate, string total)
         {
             string ssss = "insert into software(software,soft_rate,licence,lic_rate,total)values ('" + soft + "','" + softRate + "','" + licence + "','" + licRate + "','" + total + "')";
             _objs.ExecuteScalar(ssss);
         }*/

        internal void insertCcustomerInfo(string billNo, string totalAmt, string netAmt, string paidAmt, string balanceAmt)
        {

            string ss = "insert into paymentDetails(bill_no,total_amt,net_amt,paid_amt,balance_amt)values('" + billNo + "','" + totalAmt + "','" + netAmt + "','" + paidAmt + "','" + balanceAmt + "')";
            _objs.ExecuteScalar(ss);
        }

        internal void insertCustomerInfo(string biino, string soft, string softrate, string licence, string lic_rate, string total)
        {
            string sss = "insert into software(bill_no,software,soft_rate,licence,lic_rate,total)values ('" + biino + "','" + soft + "','" + softrate + "','" + licence + "','" + lic_rate + "','" + total + "')";
            _objs.ExecuteScalar(sss);
        }

        internal void insertCustomerInfo(string billno, string custId, string custName, string custAdd, string contactNo)
        {
            string s = "insert into customerData(bill_no,customer_id,customer_name,customer_add,contact_no)values('" + billno + "','" + custId + "','" + custName + "','" + custAdd + "','" + contactNo + "')";
            _objs.ExecuteScalar(s);
        }
    }
}
