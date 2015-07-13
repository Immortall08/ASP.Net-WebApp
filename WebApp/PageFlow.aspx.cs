using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class PageFlow : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connectionString = "DATA SOURCE=192.168.36.135:1521/DEV; PASSWORD=pw;PERSIST SECURITY INFO=True;USER ID=MDM";
            OracleConnection _connection = new OracleConnection();
            _connection.ConnectionString = connectionString;
            DataTable dataTable = new DataTable();
            _connection.Open();
            string sql = "select * from test_sa";
            OracleCommand command = new OracleCommand(sql, _connection);
            GridView1.DataSource = command.ExecuteReader();
            GridView1.DataBind();
            _connection.Close();
        }

    }
}