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

public partial class Admin_图书查询 : System.Web.UI.Page
{
    string connStr = @"initial catalog=bss;data source=LAPTOP-BCEOI3RP\SQLEXPRESS;integrated security=sspi";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)       //第一次请求时加载
        {
            SqlConnection myConn = new SqlConnection(connStr);
            SqlDataAdapter myDa = new SqlDataAdapter("select * from 图书 where 书名 like '%" + this.Request["KeyWord"] + "%'or 作者 like '%" + this.Request["KeyWord"] + "%'or 出版社 like '%" + this.Request["KeyWord"] + "%'or ISBN like '%" + this.Request["KeyWord"] + "%'", myConn);
            myConn.Open();
            DataSet myDataSet = new DataSet();
            myDa.Fill(myDataSet);
            this.DataList1.DataSource = myDataSet.Tables[0];
            this.DataList1.DataBind();
            myConn.Close();
        }
    }
}

