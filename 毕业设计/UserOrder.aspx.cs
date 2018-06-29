using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


public partial class UserOrder : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["telephone"] == null)
        {
            Response.Redirect("Login.aspx");
        }
        lblUserOrder.Text = Session["telephone"] + "的订单列表";
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string sql = "SELECT Orders.UserAddress, Orders.orderDate, OrderItems.orderPrice, OrderItems.orderSumPrice, OrderItems.amount, OrderItems.ProductName, OrderItems.ProductImages, OrderItems.ProductDiv, OrderItems.ProductSize, OrderItems.OrderID FROM OrderItems INNER JOIN Orders ON OrderItems.OrderID = Orders.OrderID where orders.userTel = @telephone ORDER BY orders.orderDate DESC";
       
        SqlParameter[] pms = new SqlParameter[] { 
                                     new SqlParameter("@telephone", SqlDbType.VarChar,50) { Value = Session["telephone"] }};
        DataTable dt = new DataTable();

        dt = SqlHelper.ExecuteDataTable(sql, CommandType.Text, pms);
        DataList1.DataSourceID = null;

        DataList1.DataSource = dt;
        
        DataList1.DataBind();
    }
}