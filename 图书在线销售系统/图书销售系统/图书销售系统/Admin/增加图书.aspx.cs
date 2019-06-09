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

public partial class Admin_增加图书 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }
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
        int ISBN = Convert.ToInt32(TextBox1.Text);
        string 书名 = TextBox2.Text;
        string 作者 = TextBox3.Text;
        string 出版社 = TextBox4.Text;
        int 进价 =Convert.ToInt32( TextBox5.Text);
        int 售价 = Convert.ToInt32(TextBox6.Text);
        int 库存 = Convert.ToInt32(TextBox7.Text);
        this.FileUpload1.SaveAs(this.Server.MapPath(@"~/image/")+ FileUpload1.FileName);
        string 图片 = @"~/image/" +FileUpload1.FileName;
        string mysql= "insert into 图书(ISBN,书名,作者,出版社,进价,售价,库存,图片)values('"+ISBN+"','" + 书名+"','" + 作者+"','" + 出版社 + "','" + 进价+"','" +售价+ "','" +库存 + "','" + 图片 +"')";
        SqlCommand mycommand = new SqlCommand(mysql, myConnection);
        mycommand.Connection.Open();
        mycommand.ExecuteNonQuery();
        Response.Redirect("/Admin/管理员首页.aspx");
    }
}