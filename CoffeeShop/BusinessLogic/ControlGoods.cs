using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using System.Data;

namespace BusinessLogic
{
    public class ControlGoods
    {
        ConnectDB conn = new ConnectDB();

        public DataTable ShowGoods(string id)
        {
            string sql = "SELECT goods_id, goods_name, quantity, goods_price FROM Goods WHERE stock_id ='"+id+"'";
            DataTable dt = new DataTable();
            dt = conn.GetTable(sql);
            return dt;
        }

        public void Insert(string id, string name, string quantity, int price, string stock_id)
        {
            string sql = "INSERT Goods VALUES('"+id+"', '"+name+"', '"+quantity+"', '"+price+"', '"+stock_id+"')";
            conn.ExcuteNonQuery(sql);
        }

        public void Update(string id, string name, string quantity, int price, string stock_id, string oldID)
        {
            string sql = "UPDATE Goods SET goods_id = '"+id+"', goods_name = '"+name+"', quantity = '"+quantity+"', goods_price = '"+price+"', stock_id = '"+stock_id+"' WHERE goods_id = '"+oldID+"'";
            conn.ExcuteNonQuery(sql);
        }

        public void Delete(string id)
        {
            string sql = "DELETE FROM Goods WHERE goods_id = '"+id+"'";
            conn.ExcuteNonQuery(sql);
        }
    }
}
