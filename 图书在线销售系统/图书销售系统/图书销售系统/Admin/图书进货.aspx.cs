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

public partial class Admin_图书进货 : System.Web.UI.Page
{
    string connStr = @"initial catalog=bss;data source=LAPTOP-BCEOI3RP\SQLEXPRESS;integrated security=sspi";
    protected void Button1_Click(object sender, EventArgs e)
    {
        int level = Convert.ToInt32(Session["会员等级"]);
        if (level != 1)
        {
            Response.Write("<script>alert(\"" + "权限不足" + "\")</script>");
            return;
        }
        SqlConnection myConnection = new SqlConnection();
        myConnection.ConnectionString = connStr;
        myConnection.Open();
        int ISBN = Convert.ToInt32(TextBox1.Text);
        string 书名 = TextBox2.Text;
        int 数量 = Convert.ToInt32(TextBox2.Text);
        string mysql = "update 图书 set 库存=库存+'" + 数量 + "'where ISBN='" + ISBN + "'";
        SqlCommand mycommand = new SqlCommand(mysql, myConnection);
        mycommand.ExecuteNonQuery();

        string mysql1 = "insert into 图书进货(ISBN,图书数量)values('" + ISBN + "','" + 数量 + "')";
        SqlCommand mycommand1 = new SqlCommand(mysql1, myConnection);
        mycommand1.ExecuteNonQuery();
        myConnection.Close();
        Response.Redirect("/Admin/管理员首页.aspx");
    }
}