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
public partial class Admin_出账管理 : System.Web.UI.Page
{
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
    }
    protected void GridView2_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView2.PageIndex = e.NewPageIndex;
    }
    string connStr = @"initial catalog=bss;data source=LAPTOP-BCEOI3RP\SQLEXPRESS;integrated security=sspi";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            int level = Convert.ToInt32(Session["会员等级"]);
            if (level != 1)
            {
                Response.Write("<script>alert(\"" + "权限不足" + "\")</script>");
                return;
            }

            SqlConnection myConn = new SqlConnection(connStr);
            SqlDataAdapter myDa = new SqlDataAdapter("select * from 图书进货单", myConn);
            myConn.Open();
            DataSet myDataSet = new DataSet();
            myDa.Fill(myDataSet);
            this.GridView1.DataSource = myDataSet.Tables[0];
            this.GridView1.DataBind();

            SqlDataAdapter myDa2 = new SqlDataAdapter("select * from 图书退货单", myConn);
            DataSet ds2 = new DataSet();
            DataSet myDataSet2 = new DataSet();
            myDa2.Fill(myDataSet2);
            this.GridView2.DataSource = myDataSet2.Tables[0];
            this.GridView2.DataBind();
            myConn.Close();
        }

    }
    protected void button1_Click(object sender, EventArgs e)
    {
        int level = Convert.ToInt32(Session["会员等级"]);
        if (level != 1)
        {
            Response.Write("<script>alert(\"" + "权限不足" + "\")</script>");
            return;
        }
        int ss = 0;
        SqlConnection myConn1 = new SqlConnection(connStr);
        SqlDataAdapter myDa = new SqlDataAdapter("select sum(金额) from 销售列表", myConn1);
        DataSet myDataSet = new DataSet();
        myDa.Fill(myDataSet);
        if (myDataSet.Tables[0].Rows.Count > 0)
        {
             ss = Convert.ToInt32(myDataSet.Tables[0].Rows[0][0].ToString());
            Label1.Text = ss.ToString() + "¥";
        }

        SqlDataAdapter myDa2 = new SqlDataAdapter("select 进价,图书数量 from 图书进货单", myConn1);
        DataSet myDataSet2 = new DataSet();
        myDa2.Fill(myDataSet2);
        int i = 0;
        int s1, s2, s3, ss0 = 0;
        i = myDataSet2.Tables[0].Rows.Count;
        while (i >0)
        {
            i--;
            s1 = Convert.ToInt32(myDataSet2.Tables[0].Rows[i]["进价"].ToString());
            s2 = Convert.ToInt32(myDataSet2.Tables[0].Rows[i]["图书数量"].ToString());
            ss0 = ss0 + s2 * s1;
        }
        Label2.Text = ss0.ToString() + "¥"; //取得进货总花费

        SqlDataAdapter myDa3 = new SqlDataAdapter("select 退货价,进价,图书数量 from 图书退货单", myConn1);
        DataSet myDataSet3 = new DataSet();
        myDa3.Fill(myDataSet3);
        i = 0; s1 = 0; s2 = 0; s3 = 0;
        int ss1 = 0, ss2 = 0;//ss1退货收入,ss2退货亏损
        i = myDataSet3.Tables[0].Rows.Count;
        while (i>0)
        {
            i--;
            s1 = Convert.ToInt32(myDataSet3.Tables[0].Rows[i]["进价"].ToString());
            s2 = Convert.ToInt32(myDataSet3.Tables[0].Rows[i]["图书数量"].ToString());
            s3 = Convert.ToInt32(myDataSet3.Tables[0].Rows[i]["退货价"].ToString());
            ss1 = ss1 + s2 * s1;
            ss2 = ss2 + s2 * (s1 - s3);
        }
        Label3.Text = ss1.ToString()+"¥";
        Label4.Text = ss2.ToString()+"¥";

        SqlDataAdapter myDa4 = new SqlDataAdapter("select 进价,数量 from 图书销售单", myConn1);
        DataSet myDataSet4 = new DataSet();
        myDa4.Fill(myDataSet4);
        i = 0; s1 = 0; s2 = 0;
        int ss3 = 0;
        i = myDataSet4.Tables[0].Rows.Count;
        while (i >0)
        {
            i--;
            s1 = Convert.ToInt32(myDataSet4.Tables[0].Rows[i]["进价"].ToString());
            s2 = Convert.ToInt32(myDataSet4.Tables[0].Rows[i]["数量"].ToString());
            ss3 = ss3 + s2 * s1;
        }
        ss3 = ss - ss3;
        Label5.Text = ss3.ToString() + "¥";
    }
}
