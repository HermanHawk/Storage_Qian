using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


public partial class AddCartSuccess : System.Web.UI.Page
{

    
    protected void Page_Load(object sender, EventArgs e)
    {

        #region old
        //string sql = "insert ShoppingCart(spProductID,spAmount,spUserTel,spProductName,spProductDescribe,spProductImages,spProductColor,spProductSize,spProductPrice,spProductTotal,spUserDiyPhoto) values (@spProductID,@spAmount,@spUserTel,@spProductName,@spProductDescribe,@spProductImages,@spProductColor,@spProductSize,@spProductPrice,@spProductTotal,@spUserDiyPhoto)";
        //DataTable dt;
        //dt = (DataTable)Session["Cart"];
        //SqlParameter[] pms = new SqlParameter[] { 
        //             new SqlParameter("@spProductID", SqlDbType.Int) { Value = dt.Rows[0]["productID"] },
        //             new SqlParameter("spAmount",SqlDbType.NVarChar){Value = Convert.ToDecimal(dt.Rows[0]["Amount"])},
        //             new SqlParameter("@spUserTel", SqlDbType.VarChar,50) { Value = dt.Rows[0]["userTel"] },
        //             new SqlParameter("@spProductName", SqlDbType.NVarChar) { Value = dt.Rows[0]["productName"] },
        //             new SqlParameter("@spProductDescribe", SqlDbType.NVarChar) { Value = dt.Rows[0]["productDescribe"] },
        //             new SqlParameter("@spProductImages", SqlDbType.NVarChar,50) { Value = dt.Rows[0]["productImages"] },
        //             new SqlParameter("@spProductColor", SqlDbType.NVarChar,50) { Value = dt.Rows[0]["productColor"] },
        //             new SqlParameter("@spProductSize", SqlDbType.NVarChar,50) { Value = dt.Rows[0]["productSize"] },
        //             new SqlParameter("@spProductPrice", SqlDbType.NVarChar) { Value = Convert.ToDecimal(dt.Rows[0]["productPrice"]) },
        //             new SqlParameter("@spProductTotal", SqlDbType.NVarChar) { Value = Convert.ToDecimal(dt.Rows[0]["Total"]) },
        //             new SqlParameter("@spUserDiyPhoto", SqlDbType.NVarChar,50) { Value = dt.Rows[0]["userDiyPhoto"] }
        //    };
        //int r = SqlHelper.ExecuteNonQuery(sql, CommandType.Text, pms);
        //Session["Cart"] = null;
        //if (r <= 0)
        //{
        //    Literal lit = new Literal();
        //    lit.Text = "<script language='javascript'>window.alert('加入购物车失败！')</script>";
        //    Page.Controls.Add(lit);

        //} 
        #endregion

        if (!IsPostBack)
        {

            string sql = "insert ShoppingCart(spProductID,spAmount,spUserTel,spProductName,spProductDescribe,spProductImages,spProductColor,spProductSize,spProductPrice,spProductTotal,spUserDiyPhoto) values (@spProductID,@spAmount,@spUserTel,@spProductName,@spProductDescribe,@spProductImages,@spProductColor,@spProductSize,@spProductPrice,@spProductTotal,@spUserDiyPhoto)";
            DataTable dt = new DataTable();
            dt = (DataTable)Session["Cart"];
            SqlParameter[] pms = new SqlParameter[] { 
                     new SqlParameter("@spProductID", SqlDbType.Int) { Value = dt.Rows[0]["productID"] },
                     new SqlParameter("@spAmount",SqlDbType.NVarChar){Value = Convert.ToDecimal(dt.Rows[0]["Amount"])},
					 new SqlParameter("@spUserTel", SqlDbType.VarChar,50) { Value = dt.Rows[0]["userTel"] },
					 new SqlParameter("@spProductName", SqlDbType.NVarChar) { Value = dt.Rows[0]["productName"] },
					 new SqlParameter("@spProductDescribe", SqlDbType.NVarChar) { Value = dt.Rows[0]["productDescribe"] },
					 new SqlParameter("@spProductImages", SqlDbType.NVarChar,50) { Value = dt.Rows[0]["productImages"] },
					 new SqlParameter("@spProductColor", SqlDbType.NVarChar,50) { Value = dt.Rows[0]["productColor"] },
					 new SqlParameter("@spProductSize", SqlDbType.NVarChar,50) { Value = dt.Rows[0]["productSize"] },
					 new SqlParameter("@spProductPrice", SqlDbType.NVarChar) { Value = Convert.ToDecimal(dt.Rows[0]["productPrice"]) },
					 new SqlParameter("@spProductTotal", SqlDbType.NVarChar) { Value = Convert.ToDecimal(dt.Rows[0]["Total"]) },
					 new SqlParameter("@spUserDiyPhoto", SqlDbType.NVarChar,50) { Value = dt.Rows[0]["userDiyPhoto"] }
            };
            int r = SqlHelper.ExecuteNonQuery(sql, CommandType.Text, pms);
            Session["Cart"] = null;
            if (r <= 0)
            {
                Literal lit = new Literal();
                lit.Text = "<script language='javascript'>window.alert('加入购物车失败！')</script>";
                Page.Controls.Add(lit);

            }
            // Session["Cart"] = null;
        }
    }
    
    protected void lbPay_Click(object sender, EventArgs e)
    {
        Response.Redirect("ShoppingCart.aspx");
    }
}