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

public partial class Admin_订单管理 : System.Web.UI.Page
{
    protected SqlConnection myConnection = new SqlConnection();
    string connStr = @"initial catalog=bss;data source=LAPTOP-BCEOI3RP\SQLEXPRESS;integrated security=sspi";
    protected void Page_Load(object sender, EventArgs e)
    {
        int level = Convert.ToInt32(Session["会员等级"]);
        if (level != 1)
        {
            Response.Write("<script>alert(\"" + "权限不足" + "\")</script>");
            return;
        }
        if (!IsPostBack)
        {
            BindGrid();
        }

    }
    private void BindGrid()
    {
        myConnection.ConnectionString = connStr;
        string strCommand = "select * from 图书销售单";
        SqlDataAdapter da = new SqlDataAdapter(strCommand, myConnection);
        DataSet ds = new DataSet();
        da.Fill(ds, "图书销售单");
        GridView1.DataSource = ds.Tables["图书销售单"].DefaultView;
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
        int level = Convert.ToInt32(Session["会员等级"]);
        if (level != 1)
        {
            Response.Write("<script>alert(\"" + "权限不足" + "\")</script>");
            return;
        }
        string strupdate = "";
        strupdate = " 图书='" + ((TextBox)GridView1.Rows[e.RowIndex].Cells[1].Controls[0]).Text + "',";
        strupdate = strupdate + " 会员编号='" + ((TextBox)GridView1.Rows[e.RowIndex].Cells[3].Controls[0]).Text + "',";
        strupdate = strupdate + " 数量='" + ((TextBox)GridView1.Rows[e.RowIndex].Cells[5].Controls[0]).Text + "',";
        strupdate = strupdate + " 金额='" + ((TextBox)GridView1.Rows[e.RowIndex].Cells[6].Controls[0]).Text + "',";
        strupdate = strupdate + " 积分='" + ((TextBox)GridView1.Rows[e.RowIndex].Cells[7].Controls[0]).Text + "',";
        strupdate = strupdate + " 时间='" + ((TextBox)GridView1.Rows[e.RowIndex].Cells[8].Controls[0]).Text + "'";
        string updatecommand = "update 销售列表 set " + strupdate + " where 流水号='" + GridView1.DataKeys[e.RowIndex].Value.ToString().Trim() + "'";
        myConnection.ConnectionString = connStr;
        SqlCommand mycommand = new SqlCommand(updatecommand, myConnection);
        mycommand.Connection.Open();
        mycommand.ExecuteNonQuery();
        mycommand.Connection.Close();
        GridView1.EditIndex = -1;　//－１表示没有行是可编辑的
        BindGrid();

    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int level = Convert.ToInt32(Session["会员等级"]);
        if (level != 1)
        {
            Response.Write("<script>alert(\"" + "权限不足" + "\")</script>");
            return;
        }
        string strdel = GridView1.DataKeys[e.RowIndex].Value.ToString();
        string delcommand = "delete from 销售列表  where 流水号 like '" + strdel + "'";
        myConnection.ConnectionString = connStr;
        SqlCommand mycommand = new SqlCommand(delcommand, myConnection);
        mycommand.Connection.Open();
        mycommand.ExecuteNonQuery();
        mycommand.Connection.Close();
        GridView1.EditIndex = -1;
        BindGrid();
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}