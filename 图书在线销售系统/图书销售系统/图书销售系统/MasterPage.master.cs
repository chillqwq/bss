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


public partial class MasterPage : System.Web.UI.MasterPage
{

    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Text = "用户：" + Session["姓名"];
    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        this.Response.Redirect("图书查询.aspx?KeyWord=" + this.txtSearch.Text);
    }

    protected void Menu1_MenuItemClick(object sender, MenuEventArgs e)
    {

    }
}
