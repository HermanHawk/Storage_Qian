using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class UserOrderInfo : System.Web.UI.Page
{


    DataTable dt;

    /// <summary>
    /// 遍历datatable的每一行，累计金额列的值
    /// </summary>
    public void CalcSum()
    {
        double sum = 0;

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            sum += Convert.ToDouble(dt.Rows[i]["spProductTotal"]);
        }
        lblSum.Text = string.Format("{0:C}", sum);

    }


    protected void Page_Load(object sender, EventArgs e)
    {
        #region old
        ///*
        // * 如果购物车不存在，则跳转到商城首页
        // * 如果用户未登陆，则跳转到登陆页面并记录当前的URL
        // * 如果购物车存在则将其类型转换为datatable并绑定到GridView1。
        // */

        //if (Session["Cart"] == null)
        //    Response.Redirect("home.aspx");
        //else
        //{
        //    dt = (DataTable)Session["Cart"];

        //    if (dt.Rows.Count == 0)
        //    {
        //        lbOk.Enabled = false;
        //    }
        //}
        //string CurrentUrl = HttpContext.Current.Request.Url.PathAndQuery;

        //if (Session["telephone"] == null)
        //{
        //    Response.Redirect("Login.aspx?url=" + CurrentUrl);
        //}

        //paymentCode.Visible = false;
        //if (!IsPostBack)
        //{
        //    /*
        //     * 如果用户已登陆，则获取该用户最近一笔订单的联系电话、送货地址、收货人作为默认值，以便用户无须再次输入，或在此基础上进行修改。
        //     */
        //    if (Session["telephone"] != null)
        //    {

        //        string sql = "select * from UserInfo where Telephone=@Telephone";
        //        SqlParameter[] pms = new SqlParameter[] { 
        //                             new SqlParameter("@Telephone", SqlDbType.VarChar,50) { Value = Session["telephone"] }};
        //        DataSet ds = new DataSet();
        //        SqlHelper.ExecuteDataSet(sql, CommandType.Text, pms);
        //        if (ds.Tables[0].Rows.Count > 0)
        //        {
        //            txtAddress.Text = ds.Tables[0].Rows[0]["address"].ToString();

        //            txtConsignee.Text = ds.Tables[0].Rows[0]["Name"].ToString();

        //            txtTelephone.Text = ds.Tables[0].Rows[0]["Telephone"].ToString();
        //        }
        //    }

        //    if (Session["Cart"] != null)
        //    {
        //        dt = (DataTable)Session["Cart"];

        //        GridView1.DataSource = dt;

        //        GridView1.DataBind();

        //        CalcSum();
        //    }
        //    else
        //    {
        //        lblSum.Text = "购物车中没有商品";
        //    }
        //} 
        #endregion

        /*
         * 如果购物车不存在，则跳转到商城首页
         * 如果用户未登陆，则跳转到登陆页面并记录当前的URL
         * 如果购物车存在则将其类型转换为datatable并绑定到GridView1。
         */

        //if (Session["ShoppingCart"] == null)
        //{
        //    //Response.Redirect("home.aspx");
        //    //lbPay.Enabled = false;
        //}
        //else
        //{
        //    dt = (DataTable)Session["ShoppingCart"];

        //    if (dt.Rows.Count == 0)
        //    {
        //        lbOk.Enabled = false;
        //    }
        //}
        string CurrentUrl = HttpContext.Current.Request.Url.PathAndQuery;

        if (Session["telephone"] == null)
        {
            Response.Redirect("Login.aspx?url=" + CurrentUrl);
        }

        paymentCode.Visible = false;
        if (!IsPostBack)
        {
            /*
             * 如果用户已登陆，则获取该用户最近一笔订单的联系电话、送货地址、收货人作为默认值，以便用户无须再次输入，或在此基础上进行修改。
             */
            if (Session["telephone"] != null)
            {

                string sql = "select * from UserInfo where Telephone=@Telephone";
                SqlParameter[] pms = new SqlParameter[] { 
                                     new SqlParameter("@Telephone", SqlDbType.VarChar,50) { Value = Session["telephone"] }};
                DataSet ds = new DataSet();

                DataRow dr = SqlHelper.ExecuteDataSet(sql, CommandType.Text, pms);

                if (dr != null)
                {
                    txtAddress.Text = dr["address"].ToString();

                    txtConsignee.Text = dr["Name"].ToString();

                    txtTelephone.Text = dr["Telephone"].ToString();
                }
            }

            if (Session["ShoppingCart"] != null)
            {
                dt = (DataTable)Session["ShoppingCart"];

                //if (dt.Rows.Count == 0)
                //{
                //    lbOk.Enabled = false;
                //}

                lbPay.Visible = true;

                GridView1.DataSource = dt;

                GridView1.DataBind();

                CalcSum();
            }
            else
            {
                lblSum.Text = "购物车中没有商品";
                lbPay.Visible = false;
            }
        }
    }
    protected void lbOk_Click(object sender, EventArgs e)
    {


        #region old
        //string sql = "select * from UserInfo where Telephone=@Telephone";
        //SqlParameter[] pms = new SqlParameter[] { 
        //                             new SqlParameter("@Telephone", SqlDbType.VarChar,50) { Value = Session["telephone"] }};

        //DataSet ds = new DataSet();

        //SqlHelper.ExecuteDataSet(sql, CommandType.Text, pms);

        //if (ds.Tables[0].Rows.Count > 0)
        //{
        //    if (txtPwd1.Text.ToString() + txtPwd2.Text.ToString() + txtPwd3.Text.ToString() + txtPwd4.Text.ToString() + txtPwd5.Text.ToString() + txtPwd6.Text.ToString() == ds.Tables[0].Rows[0]["paymentCode"].ToString())
        //    {


        //        string orderID = Guid.NewGuid().ToString();

        //        //SqlConnection cn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["DIY_ShopConnectionString"].ConnectionString);
        //        //记得修改SQL语句
        //        //SqlCommand cmd1 = new SqlCommand("INSERT orders (orderID,userName,userTel,userAddress) VALUES(@orderID,@userName,@userTel,@userAddress)", cn1);
        //        string sql1 = "INSERT orders (orderID,userName,userTel,userAddress) VALUES(@orderID,@userName,@userTel,@userAddress)";
        //        SqlParameter[] pms1 = new SqlParameter[] { 
        //             new SqlParameter("@orderID", SqlDbType.NVarChar,50) { Value = orderID },
        //             new SqlParameter("@userName",SqlDbType.NVarChar,50){Value = txtConsignee.Text.Trim()},
        //             new SqlParameter("@userTel", SqlDbType.NVarChar,50) { Value = txtTelephone.Text.Trim() },
        //             new SqlParameter("@userAddress", SqlDbType.NVarChar,50) { Value = txtAddress.Text.Trim() }

        //    };

        //        SqlHelper.ExecuteDataSet(sql, CommandType.Text, pms1);
        //        string sql2 = "INSERT orderItems (OrderID,amount,orderPrice,orderSumPrice,ProductID,ProductName,ProductImage,ProductDiv,ProductSize) VALUES(@OrderID,@amount,@orderPrice,@orderSumPrice,@ProductID,@ProductName,@ProductImage,@ProductDiv,@ProductSize)";
        //        //cmd1 = new SqlCommand("INSERT orderItems (OrderID,amount,orderPrice,orderSumPrice,ProductID) VALUES(@OrderID,@amount,@orderPrice,@orderSumPrice,@ProductID)", cn1);
        //        string sql3 = "delete from ShoppingCart where spProductID = @spProductID";
        //        dt = (DataTable)Session["Cart"];

        //        for (int I = 0; I < dt.Rows.Count; I++)
        //        {

        //            SqlParameter[] pms2 = new SqlParameter[] { 
        //             new SqlParameter("@OrderID", SqlDbType.NVarChar,50) { Value = orderID },
        //             new SqlParameter("@ProductID",SqlDbType.Int){Value = dt.Rows[I]["ProductID"]},
        //             new SqlParameter("@amount", SqlDbType.NVarChar) { Value = Convert.ToDecimal(dt.Rows[I]["Amount"]) },
        //             new SqlParameter("@orderPrice", SqlDbType.NVarChar) { Value = Convert.ToDecimal(dt.Rows[I]["T_shirtPrice"]) },
        //             new SqlParameter("@orderSumPrice", SqlDbType.NVarChar) { Value = Convert.ToDecimal(dt.Rows[I]["Total"]) },
        //             new SqlParameter("@ProductName",SqlDbType.NVarChar,50){Value = dt.Rows[I]["spProductName"]},
        //             new SqlParameter("@ProductImage", SqlDbType.NVarChar,50) { Value = dt.Rows[I]["spProductImages"] },
        //             new SqlParameter("@ProductDiv", SqlDbType.NVarChar,50) { Value = dt.Rows[I]["spUserDiyPhoto"] },
        //             new SqlParameter("@ProductSize", SqlDbType.NVarChar,50) { Value = dt.Rows[I]["spProductSize"] }

        //            };

        //            SqlHelper.ExecuteNonQuery(sql2, CommandType.Text, pms2);

        //            SqlParameter[] pms3 = new SqlParameter[] { 
        //             new SqlParameter("@spProductID", SqlDbType.NVarChar,50) { Value = dt.Rows[I]["spProductID"] }};
        //            SqlHelper.ExecuteNonQuery(sql3, CommandType.Text, pms3);
        //        }





        //        //Session["Cart"] = null;

        //        //Session.Remove("Cart");

        //        //Response.Redirect("userOrder.aspx");

        //        Session["Total"] = lblSum.Text.ToString();

        //        Response.Redirect("UserOrderSuccess.aspx?orderID=" + orderID);

        //    }
        //    else
        //    {
        //        Response.Write("<script>alert('密码错误！')</script>");
        //        txtPwd1.Text = "";
        //        txtPwd2.Text = "";
        //        txtPwd3.Text = "";
        //        txtPwd4.Text = "";
        //        txtPwd5.Text = "";
        //        txtPwd6.Text = "";
        //    }
        //} 
        #endregion

        string sql = "select * from UserInfo where Telephone=@Telephone";
        SqlParameter[] pms = new SqlParameter[] { 
                                     new SqlParameter("@Telephone", SqlDbType.VarChar,50) { Value = Session["telephone"] }};

        DataSet ds = new DataSet();

        DataRow dr = SqlHelper.ExecuteDataSet(sql, CommandType.Text, pms);

        if (dr != null)
        {
            if (txtPwd1.Text.ToString() + txtPwd2.Text.ToString() + txtPwd3.Text.ToString() + txtPwd4.Text.ToString() + txtPwd5.Text.ToString() + txtPwd6.Text.ToString() == dr["paymentCode"].ToString())
            {


                string orderID = Guid.NewGuid().ToString();

                //SqlConnection cn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["DIY_ShopConnectionString"].ConnectionString);
                //记得修改SQL语句
                //SqlCommand cmd1 = new SqlCommand("INSERT orders (orderID,userName,userTel,userAddress) VALUES(@orderID,@userName,@userTel,@userAddress)", cn1);
                string sql1 = "INSERT Orders (OrderID,UserName,UserTel,UserAddress) VALUES(@OrderID,@UserName,@UserTel,@UserAddress)";
                SqlParameter[] pms1 = new SqlParameter[] { 
                     new SqlParameter("@OrderID", SqlDbType.NVarChar,50) { Value = orderID },
                     new SqlParameter("@UserName",SqlDbType.NVarChar,50){Value = txtConsignee.Text.Trim()},
					 new SqlParameter("@UserTel", SqlDbType.NVarChar,50) { Value = txtTelephone.Text.Trim() },
					 new SqlParameter("@UserAddress", SqlDbType.NVarChar,50) { Value = txtAddress.Text.Trim() }
					
            };
                //DataSet ds1 = new DataSet();
                //SqlHelper.ExecuteDataSet(sql1, CommandType.Text,ds1, pms1);
                SqlHelper.ExecuteNonQuery(sql1, CommandType.Text, pms1);
                string sql2 = "INSERT OrderItems (OrderID,amount,orderPrice,orderSumPrice,ProductID,ProductName,ProductImages,ProductDiv,ProductSize) VALUES(@OrderID,@amount,@orderPrice,@orderSumPrice,@ProductID,@ProductName,@ProductImages,@ProductDiv,@ProductSize)";
                //cmd1 = new SqlCommand("INSERT orderItems (OrderID,amount,orderPrice,orderSumPrice,ProductID) VALUES(@OrderID,@amount,@orderPrice,@orderSumPrice,@ProductID)", cn1);
                string sql3 = "delete from ShoppingCart where spProductID = @spProductID and spProductName=@spProductName and spUserDiyPhoto=@spUserDiyPhoto";
                dt = (DataTable)Session["ShoppingCart"];

                for (int I = 0; I < dt.Rows.Count; I++)
                {

                    SqlParameter[] pms2 = new SqlParameter[] { 
                     new SqlParameter("@OrderID", SqlDbType.NVarChar,50) { Value = orderID },
                     new SqlParameter("@ProductID",SqlDbType.Int){Value = dt.Rows[I]["spProductID"]},
					 new SqlParameter("@amount", SqlDbType.NVarChar) { Value = Convert.ToDecimal(dt.Rows[I]["spAmount"]) },
					 new SqlParameter("@orderPrice", SqlDbType.NVarChar) { Value = Convert.ToDecimal(dt.Rows[I]["spProductPrice"]) },
                     new SqlParameter("@orderSumPrice", SqlDbType.NVarChar) { Value = Convert.ToDecimal(dt.Rows[I]["spProductTotal"]) },
                     new SqlParameter("@ProductName",SqlDbType.NVarChar,50){Value = dt.Rows[I]["spProductName"]},
					 new SqlParameter("@ProductImages", SqlDbType.NVarChar,50) { Value = dt.Rows[I]["spProductImages"] },
					 new SqlParameter("@ProductDiv", SqlDbType.NVarChar,50) { Value = dt.Rows[I]["spUserDiyPhoto"] },
                     new SqlParameter("@ProductSize", SqlDbType.NVarChar,50) { Value = dt.Rows[I]["spProductSize"] }
                    
					
                    };

                    SqlHelper.ExecuteNonQuery(sql2, CommandType.Text, pms2);

                    SqlParameter[] pms3 = new SqlParameter[] { 
                     new SqlParameter("@spProductID", SqlDbType.NVarChar,50) { Value = dt.Rows[I]["spProductID"] },
                     new SqlParameter("@spProductName", SqlDbType.NVarChar,50) { Value = dt.Rows[I]["spProductName"] },
                     new SqlParameter("@spUserDiyPhoto", SqlDbType.NVarChar,50) { Value = dt.Rows[I]["spUserDiyPhoto"] }
                    };
                    SqlHelper.ExecuteNonQuery(sql3, CommandType.Text, pms3);
                }

                //Session["Cart"] = null;

                //Session.Remove("Cart");

                //Response.Redirect("userOrder.aspx");

                Session["Total"] = lblSum.Text.ToString();

                Response.Redirect("UserOrderSuccess.aspx?OrderID=" + orderID);

            }
            else
            {
                Response.Write("<script>alert('密码错误！')</script>");
                txtPwd1.Text = "";
                txtPwd2.Text = "";
                txtPwd3.Text = "";
                txtPwd4.Text = "";
                txtPwd5.Text = "";
                txtPwd6.Text = "";
                lbPay.Visible = true;
            }
        }
    }
    protected void lbPay_Click(object sender, EventArgs e)
    {
        paymentCode.Visible = true;
        lbPay.Visible = false;
    }
}