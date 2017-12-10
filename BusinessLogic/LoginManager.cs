using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using System.Data;
using System.Data.SqlClient;

namespace BusinessLogic
{
    public class LoginManager
    {
        ConnectDB conn = new ConnectDB();
        public DataTable CheckLogin(string id, string pass)
        {
            string sql = "SELECT staff_id, staff_pass, position, staff_name FROM Staff WHERE staff_id ='"+id+"' AND staff_pass = '"+pass+"'";
            DataTable dt = new DataTable();
            dt = conn.GetTable(sql);
            return (dt);
        }

        public DataTable ShopId()
        {
            string sql = "SELECT shop_id FROM Shops";
            DataTable dt = new DataTable();
            dt = conn.GetTable(sql);
            return dt;
        }
    }
}
