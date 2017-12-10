using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using System.Data;

namespace BusinessLogic
{
    public class ControlMenu
    {
        ConnectDB conn = new ConnectDB();
        public DataTable showMenu()
        {
            DataTable dt = new DataTable();
            string sql = "SELECT * FROM Menu";
            dt = conn.GetTable(sql);
            return dt;
        }

        public void Insert(string id, string name, int price)
        {
            string sql = "INSERT Menu VALUES('"+id+"', '"+price+"', '"+name+"')";
            conn.ExcuteNonQuery(sql);
        }

        public void Delete(string id)
        {
            string sql = "DELETE FROM Menu WHERE drinks_id='"+id+"'";
            conn.ExcuteNonQuery(sql);
        }

        public void Update(string id, string name, int price, string oldID)
        {
            string sql = "UPDATE Menu SET drinks_id = '"+id+"', drinks_price ='"+price+"', drinks_name = '"+name+"' WHERE drinks_id = '"+oldID+"'";
            conn.ExcuteNonQuery(sql);
        }
    }
}
