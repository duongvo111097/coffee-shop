using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using System.Data;

namespace BusinessLogic
{
    public class ControlStock
    {
        ConnectDB conn = new ConnectDB();

        public DataTable ShowStock()
        {
            string sql = "SELECT * FROM Stock";
            DataTable dt = new DataTable();
            dt = conn.GetTable(sql);
            return dt;
        }

        public void Insert(string id, string address)
        {
            string sql = "INSERT Stock VALUES ('"+id+"','"+address+"')";
            conn.ExcuteNonQuery(sql);
        }

        public void Update(string oldID, string id,string address)
        {
            string sql = "UPDATE Stock SET stock_id = '"+id+ "', stock_address = N'" + address+"' WHERE stock_id = '"+oldID+"'";
            conn.ExcuteNonQuery(sql);
        }

        public void Delete(string id)
        {
            string sql = "DELETE FROM Stock WHERE stock_id = '"+id+"'";
            conn.ExcuteNonQuery(sql);
        }
    }
}
