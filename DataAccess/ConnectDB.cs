namespace DataAccess
{
    using System.Data;
    using System.Data.SqlClient;

    public class ConnectDB
    {
        public SqlConnection GetConnect()
        {
            return new SqlConnection(@"Data Source=DESKTOP-HQBEJDL;Initial Catalog=CoffeeShop;Integrated Security=True");
        }

        //get table from SQL
        public DataTable GetTable(string sql)
        {
            SqlConnection con = this.GetConnect();
            SqlDataAdapter sda = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return (dt);
        }

        public void ExcuteNonQuery(string sql)
        {
            SqlConnection con = this.GetConnect();
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
    }
}
