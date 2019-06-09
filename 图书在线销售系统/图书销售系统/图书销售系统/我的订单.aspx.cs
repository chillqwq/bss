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
using System.Collections.Generic;
public partial class 我的订单 : System.Web.UI.Page
{
    string connStr = @"initial catalog=bss;data source=LAPTOP-BCEOI3RP\SQLEXPRESS;integrated security=sspi";
    protected void Page_Load(object sender, EventArgs e)
    {
        int 编号 = Convert.ToInt32(Session["编号"]);
        if (!IsPostBack)       //第一次请求时加载
        {
            SqlConnection myConn = new SqlConnection(connStr);
            SqlDataAdapter myDa = new SqlDataAdapter("select * from 销售列表 where 会员编号='" + 编号 + "'", myConn);
            myConn.Open();
            DataSet myDataSet = new DataSet();
            myDa.Fill(myDataSet);
            this.GridView1.DataSource = myDataSet.Tables[0];
            this.GridView1.DataBind();
            myConn.Close();
        }
    }

}
