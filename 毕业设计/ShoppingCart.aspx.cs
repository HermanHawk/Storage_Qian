using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class ShoppingCart : System.Web.UI.Page
{

    DataTable dt = new DataTable();

    /// <summary>
    /// 计算金额
    /// </summary>
    public void CalcSum()
    {
        dt = (DataTable)Session["ShoppingCart"];
        double sum = 0;
        int sum1 = 0;
        for (int i = 0; i < GridView1.Rows.Count; i++)
        {
            GridView1.Rows[i].Cells[4].Text = string.Format("{0:N0}", dt.Rows[i]["spAmount"]);
            GridView1.Rows[i].Cells[6].Text = string.Format("{0:N2}", dt.Rows[i]["spProductTotal"]);
            if (dt.Rows[i]["spProductTotal"] is DBNull)
            {
                dt.Rows[i]["spProductTotal"] = 0;
            }
            sum += Convert.ToDouble(dt.Rows[i]["spProductTotal"]);
            sum1 += Convert.ToInt32(dt.Rows[i]["spAmount"]);
        }
        lblSum.Text = "合计数量:" + string.Format("{0:N0}", sum1) + "合计金额:" + string.Format("{0:c}", sum);

        Session["showCart"] = lblSum.Text.ToString();

    }


    protected void Page_Load(object sender, EventArgs e)
    {
        //if (Session["telephone"] == null)
        //{
        //    Response.Redirect("Login.aspx");
        //}


        if (!IsPostBack)
        {
            if (Session["telephone"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            dt.Clear();
            Session["ShoppingCart"] = null;
            /*
              * 1.先找出总行数
              * 然后通过reader.reader找到数据循环赋值
              */
            string sql1 = "select count(*) from ShoppingCart where spUserTel = @spUserTel";

            SqlParameter[] pms1 = new SqlParameter[] { 
                             new SqlParameter("@spUserTel", SqlDbType.VarChar,50) { Value = Session["telephone"].ToString() }};
            int count = (int)SqlHelper.ExecuteScalar(sql1, CommandType.Text, pms1);
            string sql2 = "select * from ShoppingCart where spUserTel = @spUserTel";

            SqlParameter[] pms2 = new SqlParameter[] { 
                             new SqlParameter("@spUserTel", SqlDbType.VarChar,50) { Value = Session["telephone"] }};
            using (SqlDataReader reader = SqlHelper.ExecuteReader(sql2, CommandType.Text, pms2))
            {
                if (reader.HasRows)
                {
                    for (int i = 0; i < count; i++)
                    {
                        if (reader.Read())
                        {
                            #region 定义变量
                            string spID = (reader.GetInt32(0)).ToString();
                            string spProductID = (reader.GetInt32(1)).ToString();
                            double spAmount = Convert.ToDouble(reader.GetDecimal(2));//dr["spAmount"].ToString();
                            string spDate = (reader.GetDateTime(3)).ToString();//dr["spDate"].ToString();
                            string spUserTel = reader.GetString(4);//dr["spUserTel"].ToString();
                            string spProductName = reader.GetString(5);//dr["spProductName"].ToString();
                            string spProductDescribe = reader.GetString(6); //dr["spProductDescribe"].ToString();
                            string spProductImages = reader.GetString(7); //dr["spProductImages"].ToString();
                            string spProductColor = reader.GetString(8); //dr["spProductColor"].ToString();
                            string spProductSize = reader.GetString(9); //dr["spProductSize"].ToString();
                            double spProductPrice = Convert.ToDouble(reader.GetDecimal(10));
                            double spProductTotal = Convert.ToDouble(reader.GetDecimal(11));
                            string spUserDiyPhoto = reader.GetString(12); //dr["spUserDiyPhoto"].ToString(); 
                            #endregion

                            #region 定义列
                            if (Session["ShoppingCart"] != null)
                            {

                                dt = (DataTable)Session["ShoppingCart"];
                            }
                            else
                            {
                                //dt = new DataTable();
                                DataColumn dc;

                                dc = new DataColumn("spID", typeof(string));
                                dt.Columns.Add(dc);

                                dc = new DataColumn("spProductID", typeof(string));
                                dt.Columns.Add(dc);

                                dc = new DataColumn("spUserTel", typeof(string));
                                dt.Columns.Add(dc);

                                dc = new DataColumn("spProductName", typeof(string));
                                dt.Columns.Add(dc);

                                dc = new DataColumn("spProductImages", typeof(string));
                                dt.Columns.Add(dc);

                                dc = new DataColumn("spUserDiyPhoto", typeof(string));
                                dt.Columns.Add(dc);

                                dc = new DataColumn("spProductDescribe", typeof(string));
                                dt.Columns.Add(dc);

                                dc = new DataColumn("spProductColor", typeof(string));
                                dt.Columns.Add(dc);

                                dc = new DataColumn("spProductPrice", typeof(double));
                                dt.Columns.Add(dc);

                                dc = new DataColumn("spAmount", typeof(double));
                                dt.Columns.Add(dc);

                                dc = new DataColumn("spProductSize", typeof(string));
                                dt.Columns.Add(dc);

                                dc = new DataColumn("spProductTotal", typeof(double));
                                dt.Columns.Add(dc);

                                dc = new DataColumn("spDate", typeof(string));
                                dt.Columns.Add(dc);
                            }
                            #endregion

                            #region 给列赋值
                            DataRow drNew = dt.NewRow();
                            drNew["spID"] = spID;
                            drNew["spProductID"] = spProductID;
                            drNew["spUserTel"] = spUserTel;
                            drNew["spProductName"] = spProductName;
                            drNew["spProductImages"] = spProductImages;
                            drNew["spUserDiyPhoto"] = spUserDiyPhoto;
                            drNew["spProductDescribe"] = spProductDescribe;
                            drNew["spProductColor"] = spProductColor;
                            drNew["spProductPrice"] = spProductPrice;
                            drNew["spAmount"] = spAmount;
                            drNew["spProductSize"] = spProductSize;
                            drNew["spProductTotal"] = spProductTotal;
                            drNew["spDate"] = spDate;

                            dt.Rows.Add(drNew);
                            #endregion
                        }
                        GridView1.DataSource = null;
                        GridView1.DataSource = dt;

                        GridView1.DataBind();



                        Session["ShoppingCart"] = dt;
                        CalcSum();
                    }
                }
            }



        }

    }



    /// <summary>
    /// 单击gridview中的删除按钮时删除datatable中相应的数据行
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "del")
        {
            dt = (DataTable)Session["ShoppingCart"];
            int rowIndex = Int32.Parse((String)e.CommandArgument);
            //int rowIndex = Convert.ToInt32((e.CommandArgument).ToString());
            string spId = dt.Rows[rowIndex]["spID"].ToString();
            dt.Rows.RemoveAt(rowIndex);
            //dt.Rows.RemoveAt(rowIndex);
            GridView1.DataSource = dt;
            Session["ShoppingCart"] = dt;
            GridView1.DataBind();

            CalcSum();

            string sql = "delete from ShoppingCart where spId = @spId";
            SqlParameter[] pms = new SqlParameter[] { 
                             new SqlParameter("@spId", SqlDbType.Int) { Value = spId }};
            SqlHelper.ExecuteNonQuery(sql, CommandType.Text, pms);
        }
    }


    /// <summary>
    /// 在对行进行了数据绑定后激发
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            ((LinkButton)e.Row.Cells[8].Controls[0]).Attributes.Add("onclick", "javascript:return confirm('确认删除此订单吗？')");
        }

    }


    /// <summary>
    ///  清除购物车dt，重新计算和绑定gradview1
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnClear_Click(object sender, EventArgs e)
    {
        dt.Clear();
        Session["ShoppingCart"] = null;
        GridView1.DataSource = dt;

        GridView1.DataBind();

        CalcSum();
        //Session["ShoppingCart"] = dt;
        string sql = "delete from ShoppingCart where spUserTel = @spUserTel";
        SqlParameter[] pms = new SqlParameter[] { 
                             new SqlParameter("@spUserTel", SqlDbType.VarChar,50) { Value = Session["telephone"].ToString() }};
        SqlHelper.ExecuteNonQuery(sql, CommandType.Text, pms);
        //btnClear.Enabled = false;
        //btnSubmit.Enabled = true;
    }


    /// <summary>
    ///  提交订单
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        Response.Redirect("UserOrderInfo.aspx");
    }
}