using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace OrderBasicMVC.Views.Home
{
    public partial class insert : System.Web.UI.Page
    {
        //NOT REQUIRED - EXTRA 
        //practiced for inserting records to DB through ajax
        SqlConnection con = new SqlConnection(@"");
        string OrderType, OrderId, CustName, AccountNum;
        protected void Page_Load(object sender, EventArgs e)
        {
            OrderType = Request.QueryString["ot"].ToString();
            OrderId = Request.QueryString["oId"].ToString();
            CustName = Request.QueryString["cName"].ToString();
            AccountNum = Request.QueryString["accNum"].ToString();

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText="insert into orderTable values('"+OrderId.ToString()+"','"+OrderType.ToString()+"','"+CustName.ToString()+"'.'"+AccountNum.ToString()+"')";
                cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}