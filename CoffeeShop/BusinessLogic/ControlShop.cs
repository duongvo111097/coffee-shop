using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using System.Data;

namespace BusinessLogic
{
    public class ControlShop
    {
        ConnectDB conn = new ConnectDB();
        public DataTable ShowShop()
        {
            string sql = "SELECT * FROM Shops";
            DataTable dt = new DataTable();
            dt = conn.GetTable(sql);
            return dt;
        }

        public void Insert(string id, string name, string address, string stock_id)
        {
            string sql = "INSERT Shops VALUES('"+id+"','"+name+"','"+address+"','"+stock_id+"')";
            conn.ExcuteNonQuery(sql);
        }

        public void Update(string oldID, string id, string name, string address, string stock_id)
        {
            string sql = "UPDATE Shops SET shop_id = '"+id+"', shop_address = '"+address+"', shop_name = '"+name+"', stock_id = '"+stock_id+"' WHERE shop_id = '"+oldID+"'";
            conn.ExcuteNonQuery(sql);
        }

        public void Delete(string id)
        {
            string sql = "DELETE Shops WHERE shop_id = '"+id+"'";
            conn.ExcuteNonQuery(sql);
        }
    }
}
