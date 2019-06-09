using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;
public partial class register : System.Web.UI.Page
{

    protected void Button2_Click(object sender, EventArgs e)
    {
        string username = Request.Form["username"];
        string password = Request.Form["password"];
        string repassword = Request.Form["repassword"];
        string user_name = Request.Form["user_name"];
        string useridcard = Request.Form["useridcard"];
        if (password.CompareTo(repassword) != 0)
        {
            Response.Write("<script>alert(\"" + "密码不一致" + "\")</script>");
            return;
        }
        string connStr = @"initial catalog=bss;data source=LAPTOP-BCEOI3RP\SQLEXPRESS;integrated security=sspi";
        SqlConnection myConn = new SqlConnection(connStr);
        string mySql = "insert into 会员(编号,密码,姓名,身份证) values('" + username + "', '" + password + "','" + user_name + "','" + useridcard + "')";
        SqlCommand myCommand = new SqlCommand(mySql, myConn);
        myConn.Open();
        myCommand.ExecuteNonQuery();
        Response.Redirect("login.aspx");

    }
}