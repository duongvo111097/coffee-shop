using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace BusinessLogic
{
    public class ControlStaff
    {
        ConnectDB conn = new ConnectDB();
        public DataTable ShowStaff()
        {
            string sql = "select * from Staff";
            DataTable dt = new DataTable();
            dt = conn.GetTable(sql);
            return dt;
        }

        public void InsertStaff(string id, string name, string gender, string phone, string pass, string position, string email, string identity, string shop_id)
        {
            string sql = "INSERT Staff values('"+id+"','"+pass+"','"+email+"','"+phone+"','"+position+"','"+identity+"',N'"+name+"','"+shop_id+"','"+gender+"')";
            conn.ExcuteNonQuery(sql);
        }

        public void UpdateStaff(string oldID, string id, string name, string gender, string phone, string pass, string position, string email, string identity, string shop_id)
        {
            string sql = "UPDATE Staff SET staff_id = '"+id+"', staff_pass = N'"+pass+"', email = '"+email+"', phone = '"+phone+"', position = '"+position+"', identity_number ='"+identity +"', staff_name = '"+name+"', shop_id ='"+shop_id+"', gender = '"+gender+"' Where staff_id = '"+oldID+"'";
            conn.ExcuteNonQuery(sql);
        }

        public void DeleteStaff(string id)
        {
            string sql = "DELETE FROM Staff WHERE staff_id = '"+id+"'";
            conn.ExcuteNonQuery(sql);
        }
    }
}
