using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using System.Data;

namespace BusinessLogic
{
    public class ControlSell
    {
        ConnectDB conn = new ConnectDB();        
        public DataTable ShowMenu()
        {
            DataTable dt = new DataTable();
            string sql = "SELECT drinks_id, drinks_name, drinks_price FROM Menu";
            dt = conn.GetTable(sql);
            return dt;
        }

        public DataTable SelectShop(string id)
        {
            DataTable dt = new DataTable();
            string sql = "SELECT shop_id FROM Shops Where shop_id = '"+id+"'";
            dt = conn.GetTable(sql);
            return dt;
        }

        public void Sell(int id, int total, int quality, string staff_id, string shop_id, string drinks_id)
        {
            string sql = "INSERT Invoice VALUES('"+id+"', '"+staff_id+"','"+shop_id+"','"+total+"','"+quality+"','"+drinks_id+"')";
            conn.ExcuteNonQuery(sql);
        }

        public DataTable AutoId()
        {
            DataTable dt = new DataTable();
            string sql = "select max(invoice_id) from Invoice";
            dt = conn.GetTable(sql);
            return dt;
        }
    }
}