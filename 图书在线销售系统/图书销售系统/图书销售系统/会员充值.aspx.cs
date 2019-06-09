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

public partial class 会员充值 : System.Web.UI.Page
{
    protected SqlConnection myConnection = new SqlConnection();
    string connStr = @"initial catalog=bss;data source=LAPTOP-BCEOI3RP\SQLEXPRESS;integrated security=sspi";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindGrid();
        }

    }
    private void BindGrid()
    {
        int 编号 = Convert.ToInt32(Session["编号"]);
        myConnection.ConnectionString = connStr;
        string strCommand = "select * from 会员 where 编号='" + 编号 + "'";
        SqlDataAdapter da = new SqlDataAdapter(strCommand, myConnection);
        DataSet ds = new DataSet();
        da.Fill(ds, "会员");
        GridView1.DataSource = ds.Tables["会员"].DefaultView;
        GridView1.DataBind();

    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        BindGrid();
    }
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridView1.EditIndex = (int)e.NewEditIndex; //当前行作为待编辑行
        BindGrid();

    }
    protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        GridView1.EditIndex = -1; //－１表示没有行是可编辑的
        BindGrid();

    }
    protected void GridView1_RowUpdated(object sender, GridViewUpdatedEventArgs e)
    {
        GridView1.EditIndex = -1;
        //BindGrid();

    }
    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        int 编号 = Convert.ToInt32(Session["编号"]);
        string strupdate = "";
        strupdate = " 余额=余额+'" + ((TextBox)GridView1.Rows[e.RowIndex].Cells[5].Controls[0]).Text + "'";
        this.Session["余额"] = ((TextBox)GridView1.Rows[e.RowIndex].Cells[5].Controls[0]).Text;
        string updatecommand = "update 会员 set " + strupdate + " where 编号 = '" + 编号 + "'";
        myConnection.ConnectionString = connStr;
        SqlCommand mycommand = new SqlCommand(updatecommand, myConnection);
        mycommand.Connection.Open();
        mycommand.ExecuteNonQuery();
        mycommand.Connection.Close();
        GridView1.EditIndex = -1;　//－１表示没有行是可编辑的
        BindGrid();

    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}