using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;
using System.Data.SqlClient;
public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string connStr = @"initial catalog=bss;data source=LAPTOP-BCEOI3RP\SQLEXPRESS;integrated security=sspi";
        SqlConnection myConn = new SqlConnection(connStr);
        string userid = Request.Form["username"];
        string password = Request.Form["password"];
        string mySql = "select * from 会员 where 编号='" + userid + "' and " + "密码='" + password + "'";
        SqlCommand myCommand = new SqlCommand(mySql, myConn);
        myConn.Open();
        SqlDataReader myDr = myCommand.ExecuteReader();
        if (myDr.Read())
        {
            myDr.Close();
            SqlDataAdapter myDa = new SqlDataAdapter("select * from 会员 where 编号='" + userid + "' and " + "密码='" + password + "'", myConn);
            DataSet myDataSet = new DataSet();
            myDa.Fill(myDataSet);
            if (myDataSet.Tables[0].Rows.Count > 0)
            {
                this.Session["编号"] = userid;
                this.Session["姓名"] = myDataSet.Tables[0].Rows[0]["姓名"].ToString();
                this.Session["余额"]= myDataSet.Tables[0].Rows[0]["余额"].ToString();
                this.Session["是否挂失"] = myDataSet.Tables[0].Rows[0]["是否挂失"].ToString();
                this.Session["会员等级"] = myDataSet.Tables[0].Rows[0]["会员等级"].ToString();
            }
            if ((string)Session["是否挂失"] == "1")
            {
                Response.Write("<script>alert(\"" + "账号已经冻结" + "\")</script>");
                return;
            }  
            Response.Redirect("/首页.aspx");
        }
        else
            Response.Write("<script>alert(\"" + "密码错误" + "\")</script>");
        myConn.Close();
    }
}