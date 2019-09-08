using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gried_view_table
{
    class ConnectionForLogin
    {
        SqlConnection cn = new SqlConnection("Data Source=USER-PC; " + "Initial Catalog = loginforusr; Integrated Security=true");
        SqlCommand command = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable dt = new DataTable();

        public void manipulate(string qry)
        {

            cn.Open();
            command.Connection = cn; //connceion from cn

            command.CommandText = qry;//conncetion from query(which need to be passed from parameter) 

            command.ExecuteNonQuery();//insert ,update, delete (except select)
            cn.Close();
        }

        public DataTable retrieve(string qry)
        {

            DataSet ds = new DataSet();
            adapter = new SqlDataAdapter(qry, cn);
            adapter.Fill(ds);
            return ds.Tables[0];
        }
    }
}
