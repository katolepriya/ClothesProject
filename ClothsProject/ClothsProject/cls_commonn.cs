using System;
using System.Data;

namespace ClothsProject
{
    internal class cls_commonn
    {
        SQLHelper _objsqlh = new SQLHelper();
        internal void getcustomer(string name, string mobileNo, string Address, string State, string amount)
        {
            string str = "INSERT INTO custOpening (name, mobile_no, address, state, amount) VALUES ('" + name + "','" + mobileNo + "','" + Address + "','" + State + "','"+ amount + "')";
            _objsqlh.ExecuteScalar(str);
            
        } 
        internal DataTable getcustomerdetails()
        {
            string str = "select * from custOpening";
            DataTable dt = _objsqlh.GetDataTable(str);
            return dt;
        }

       

        internal DataTable getCustnamedetails(string Name)
        {

            string str = "SELECT * FROM custOpening where name= '" + Name + "'";
            DataTable dt = _objsqlh.GetDataTable(str);
            return dt;
        }

        internal DataTable getcustdetail()
        {
            string str = "SELECT * FROM custOpening ";
            DataTable dt = _objsqlh.GetDataTable(str);
            return dt;
        }
    }
}