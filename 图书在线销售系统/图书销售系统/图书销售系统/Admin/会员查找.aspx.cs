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

public partial class 会员查找 : System.Web.UI.Page
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

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        BindGrid();
    }
    private void BindGrid()
    {
        string s = txtSearch.Text;
        SqlConnection myConn = new SqlConnection(connStr);
        SqlDataAdapter myDa = new SqlDataAdapter("select * from 会员 where 编号 like '%" + s + "%'or 身份证 like '%" + s + "%'or 姓名 like '%" + s + "%'", myConn);
        myConn.Open();
        DataSet myDataSet = new DataSet();
        myDa.Fill(myDataSet);
        this.GridView1.DataSource = myDataSet.Tables[0];
        this.GridView1.DataBind();
        myConn.Close();

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
        strupdate = " 密码='" + ((TextBox)GridView1.Rows[e.RowIndex].Cells[1].Controls[0]).Text + "',";
        strupdate = strupdate + " 身份证='" + ((TextBox)GridView1.Rows[e.RowIndex].Cells[2].Controls[0]).Text + "',";
        strupdate = strupdate + " 姓名='" + ((TextBox)GridView1.Rows[e.RowIndex].Cells[3].Controls[0]).Text + "',";
        strupdate = strupdate + " 有效期='" + ((TextBox)GridView1.Rows[e.RowIndex].Cells[4].Controls[0]).Text + "',";
        strupdate = strupdate + " 会员等级='" + ((TextBox)GridView1.Rows[e.RowIndex].Cells[5].Controls[0]).Text + "',";
        strupdate = strupdate + " 积分='" + ((TextBox)GridView1.Rows[e.RowIndex].Cells[6].Controls[0]).Text + "',";
        strupdate = strupdate + " 余额='" + ((TextBox)GridView1.Rows[e.RowIndex].Cells[7].Controls[0]).Text + "',";
        strupdate = strupdate + " 是否挂失='" + ((TextBox)GridView1.Rows[e.RowIndex].Cells[8].Controls[0]).Text + "'";
        string updatecommand = "update 会员 set " + strupdate + " where 编号 = '" + GridView1.DataKeys[e.RowIndex].Value.ToString().Trim() + "'";
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
        string delcommand = "delete from 会员 where 编号 = '" + strdel + "'";
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
    protected void button1_Click(object sender, EventArgs e)
    {
        int level = Convert.ToInt32(Session["会员等级"]);
        if (level != 1)
        {
            Response.Write("<script>alert(\"" + "权限不足" + "\")</script>");
            return;
        }
        SqlConnection myConn3 = new SqlConnection(connStr);
        myConn3.Open();
        SqlCommand cmd = new SqlCommand("scoretomoney", myConn3);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlDataReader dr = cmd.ExecuteReader();
        BindGrid();
        myConn3.Close();
    }
}