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
public partial class 图书详情 : System.Web.UI.Page
{
    string connStr = @"initial catalog=bss;data source=LAPTOP-BCEOI3RP\SQLEXPRESS;integrated security=sspi";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {

            string bookId = Request["ISBN"];
            string sql = "select * from 图书 where ISBN="+ bookId;
            SqlConnection myConn = new SqlConnection(connStr);
            myConn.Open();
            SqlCommand command = new SqlCommand(sql, myConn);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(ds);
            this.DetailsView1.DataSource = ds.Tables[0];
            this.DetailsView1.DataBind();
            myConn.Close();
        }
    }
    protected void btnShop_Click(object sender, EventArgs e)
    {
        SqlConnection myConn = new SqlConnection(connStr);
        myConn.Open();
        int 余额 = Convert.ToInt32(Session["余额"]);
        int @会员编号 = Convert.ToInt32(Session["编号"]);
        int @图书 = Convert.ToInt32(Request["ISBN"]);
        int @数量=Convert.ToInt32(this.txtQuantity.Text);
        int @金额 = (Convert.ToInt32( (DetailsView1.Rows[5].Cells[1].Text)))* @数量;
        int 库存 = Convert.ToInt32((DetailsView1.Rows[6].Cells[1].Text));
        string zhifu = DropDownList1.SelectedItem.ToString();
        if (@数量>库存)
        {
            Response.Write("<script>alert(\"" + "库存不足" + "\")</script>");
            return;
        }
        if (zhifu == "会员卡")
        {
            if (余额 > @金额)
            {
                string sql2 = "update 会员 set 余额=余额-'" + @金额 + "' where 编号= '" + @会员编号 + "'";
                SqlCommand command2 = new SqlCommand(sql2, myConn);
                command2.ExecuteNonQuery();
            }
            else
            {
                Response.Write("<script>alert(\"" + "余额不足" + "\")</script>");
                return;
            }            
        }
        string sql = "insert into 销售列表(会员编号,图书,数量,金额,积分) values('" + @会员编号 + "','" + @图书 + "','" + @数量 + "','" + @金额 + "','" + @金额 + "')";
        SqlCommand command = new SqlCommand(sql, myConn);
        command.ExecuteNonQuery();
        string sql1 = "update 图书 set 库存=库存-'" + @数量 + "' where ISBN= '" +@图书+ "'";
        SqlCommand command1 = new SqlCommand(sql1, myConn);
        command1.ExecuteNonQuery();
        string sql3 = "update 会员 set 积分=积分+'" + @金额 + "' where 编号= '" +@会员编号+ "'";
        SqlCommand command3 = new SqlCommand(sql3, myConn);
        command3.ExecuteNonQuery();
        myConn.Close();
        Response.Write("<script>alert(\"" + "购买成功" + "\")</script>");
    }
}