using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class ProductJoinCar : System.Web.UI.Page
{

    string userDiyPhoto = "0";

    protected void Page_Load(object sender, EventArgs e)
    {
        //string CurrentUrl = HttpContext.Current.Request.Url.PathAndQuery;
        //if (Session["telephone"] == null)
        //{

        //    Response.Redirect("Login.aspx?url=" + CurrentUrl);

        //}
    }

    /// <summary>
    /// 通过dataset 和SQLdataAdapter 查询数据库填充到虚拟表
    /// </summary>
    /// <param name="sql"></param>
    /// <param name="pms"></param>
    /// <returns></returns>
    #region 已封装ExecuteDataSet方法
    //private DataRow getProductInfoByID(string sql, params SqlParameter[] pms)
    //{
    //    SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["DIY_ShopConnectionString"].ConnectionString);
    //    SqlCommand cmd = new SqlCommand(sql, cn);
    //    if (pms != null)
    //    {
    //        cmd.Parameters.AddRange(pms);
    //    }
    //    DataSet ds = new DataSet();

    //    SqlDataAdapter da = new SqlDataAdapter(cmd);

    //    cn.Open();

    //    da.Fill(ds);

    //    cn.Close();

    //    if (ds.Tables[0].Rows.Count > 0)

    //        return ds.Tables[0].Rows[0];

    //    else
    //        return null;
    //} 
    #endregion

    private void GetDatatableAndValue(string productName, string productImages, string productDescribe, string productColor, double productPrice, string productSize, string productID, int Amount, string userDiyPhoto)
    {
        DataTable dt;
        if (Session["Cart"] != null)
        {
            dt = (DataTable)Session["Cart"];
        }
        else
        {
            #region 定义datatable的列
            dt = new DataTable();
            DataColumn dc;

            dc = new DataColumn("productID", typeof(string));
            dt.Columns.Add(dc);

            dc = new DataColumn("userTel", typeof(string));
            dt.Columns.Add(dc);

            dc = new DataColumn("productName", typeof(string));
            dt.Columns.Add(dc);

            dc = new DataColumn("productImages", typeof(string));
            dt.Columns.Add(dc);

            dc = new DataColumn("userDiyPhoto", typeof(string));
            dt.Columns.Add(dc);

            dc = new DataColumn("productDescribe", typeof(string));
            dt.Columns.Add(dc);

            dc = new DataColumn("productColor", typeof(string));
            dt.Columns.Add(dc);

            //dc = new DataColumn("foodKind", typeof(string));
            //dt.Columns.Add(dc);

            dc = new DataColumn("productPrice", typeof(double));
            dt.Columns.Add(dc);

            dc = new DataColumn("Amount", typeof(double));
            dt.Columns.Add(dc);

            dc = new DataColumn("productSize", typeof(string));
            dt.Columns.Add(dc);

            dc = new DataColumn("Total", typeof(double));
            dt.Columns.Add(dc);
            #endregion
        }
        bool IsExist = false;

        for (int I = 0; I < dt.Rows.Count; I++)
        {
            if (dt.Rows[I]["productID"].ToString() == productID && dt.Rows[I]["userDiyPhoto"].ToString() == userDiyPhoto)
            {
                IsExist = true;
                dt.Rows[I]["Amount"] = Convert.ToInt32(dt.Rows[I]["Amount"].ToString()) + Amount;
                dt.Rows[I]["Total"] = Convert.ToInt32(dt.Rows[I]["Amount"].ToString()) * Convert.ToInt32(dt.Rows[I]["productPrice"].ToString());
                break;
            }
        }

        if (!IsExist)
        {
            #region 把字符串变量的值赋给datatable
            DataRow drNew = dt.NewRow();
            drNew["productID"] = productID;
            drNew["productName"] = productName;
            drNew["productImages"] = productImages;
            drNew["productDescribe"] = productDescribe;
            drNew["productColor"] = productColor;
            drNew["productPrice"] = productPrice;
            drNew["productSize"] = productSize;
            drNew["userDiyPhoto"] = userDiyPhoto;
            drNew["userTel"] = Session["telephone"].ToString();
            //drNew["T_shirtSize"] = ((RadioButtonList)DataList1.FindControl("RBLSize")).Text.ToString();
            drNew["Amount"] = Amount;
            drNew["Total"] = productPrice * Amount;

            dt.Rows.Add(drNew);
            #endregion
        }
        Session["Cart"] = dt;

        Response.Redirect("addCartSuccess.aspx");
    }

    protected void DataListT_shirtJoinCar_ItemCommand(object source, DataListCommandEventArgs e)
    {
        if (e.CommandName == "Buy")
        {
            string CurrentUrl = HttpContext.Current.Request.Url.PathAndQuery;
            if (Session["telephone"] == null)
            {
                Response.Redirect("Login.aspx?url=" + CurrentUrl);

            }
            userDiyPhoto = @"~\images\logo.png";
            GetValueFromT_shirt(e);

        }
        if (e.CommandName == "DIY")
        {

            ((LinkButton)(e.Item.FindControl("lbtnJoinCar_TShirt"))).Visible = false;
            ((LinkButton)(e.Item.FindControl("lbtnDIY_TShirt"))).Visible = false;
            PanelDiy.Visible = true;
            Session["e"] = e;
            Session["list"] = "T_shirt";
        }
    }

    private void GetValueFromT_shirt(DataListCommandEventArgs e)
    {
        #region 给字符串变量赋值

        string sql = "SELECT  T_shirtInfo.*, Product_TShirt.* FROM Product_TShirt INNER JOIN T_shirtInfo ON Product_TShirt.Product_TShirtFromID = T_shirtInfo.T_shirtID where T_shirtInfo.T_shirtID =@T_shirtID ";
        SqlParameter[] pms = new SqlParameter[] { 
                             new SqlParameter("@T_shirtID", SqlDbType.Int) { Value = Request.QueryString["T_shirtID"] }};
        //DataSet ds = new DataSet();
        DataRow dr = SqlHelper.ExecuteDataSet(sql, CommandType.Text, pms);
        string productName = dr["T_shirtName"].ToString();
        string productImages = dr["T_shirtImages"].ToString();
        string productDescribe = dr["T_shirtDescribe"].ToString();
        string productColor = dr["T_shirtColor"].ToString();
        double productPrice = Convert.ToDouble(dr["T_shirtPrice"].ToString());
        string productSize = "";
        productSize = (((RadioButtonList)(e.Item.FindControl("rblT_shirtSize"))).Text).ToString();
        //if (productSize == "")
        //{
        //    Literal lit = new Literal();
        //    lit.Text = "<script language='javascript'>window.alert('请选择大小！')</script>";
        //    Page.Controls.Add(lit);
        //}
        try
        {
            string sql1 = "SELECT  T_shirtInfo.*, Product_TShirt.* FROM Product_TShirt INNER JOIN T_shirtInfo ON Product_TShirt.Product_TShirtFromID = T_shirtInfo.T_shirtID where Product_TShirtSize =@Product_TShirtSize ";
            SqlParameter[] pms1 = new SqlParameter[] { 
                                 new SqlParameter("@Product_TShirtSize", SqlDbType.NVarChar, 50) { Value = productSize }};
            DataRow dr1 = SqlHelper.ExecuteDataSet(sql1, CommandType.Text, pms1);
            string productID = dr1["Product_TShirtID"].ToString();
            int Amount = Convert.ToInt32(((TextBox)(e.Item.FindControl("txtAmount_TShirt"))).Text);


        #endregion
            Session["e"] = null;
            GetDatatableAndValue(productName, productImages, productDescribe, productColor, productPrice, productSize, productID, Amount, userDiyPhoto);
        }
        catch
        {
            Literal lit = new Literal();
            lit.Text = "<script language='javascript'>window.alert('请选择大小！')</script>";
            Page.Controls.Add(lit);

        }
    }

   
    protected void DataListPhotoBookJoinCar_ItemCommand(object source, DataListCommandEventArgs e)
    {

        if (e.CommandName == "Buy")
        {
            string CurrentUrl = HttpContext.Current.Request.Url.PathAndQuery;
            if (Session["telephone"] == null)
            {
                Response.Redirect("Login.aspx?url=" + CurrentUrl);
            }
            userDiyPhoto = @"~\images\logo.png";
            GetValueFromPhotoBook(e);

        }
        if (e.CommandName == "DIY")
        {
            ((LinkButton)(e.Item.FindControl("lbtnJoinCar_PhotoBook"))).Visible = false;
            ((LinkButton)(e.Item.FindControl("lbtnDIY_PhotoBook"))).Visible = false;
            PanelDiy.Visible = true;
            Session["e"] = e;
            Session["list"] = "PhotoBook";
        }


    }

    private void GetValueFromPhotoBook(DataListCommandEventArgs e)
    {
        string sql = "SELECT  PhotoBooks.*, Product_PhotoBooks.* FROM Product_PhotoBooks INNER JOIN PhotoBooks ON Product_PhotoBooks.Product_PhotoBookFromID = PhotoBooks.PhotoBookID where PhotoBooks.PhotoBookID =@PhotoBookID";
        SqlParameter[] pms = new SqlParameter[] { 
                             new SqlParameter("@PhotoBookID", SqlDbType.Int) { Value = Request.QueryString["PhotoBookID"] }};
        DataRow dr = SqlHelper.ExecuteDataSet(sql, CommandType.Text, pms);
        string productName = dr["PhotoBookName"].ToString();
        string productImages = dr["PhotoBookImages"].ToString();
        string productDescribe = dr["PhotoBookDescribe"].ToString();
        string productColor = dr["PhotoBookColor"].ToString();
        //string productSize = "";
        //string productSize = (((RadioButtonList)(DataListPhotoBookJoinCar.Items[0].FindControl("rbl_PhotoBook"))).Text).ToString();
        string productSize = (((RadioButtonList)(e.Item.FindControl("rbl_PhotoBook"))).Text).ToString();
        try
        {
            string sql1 = "SELECT  PhotoBooks.*, Product_PhotoBooks.* FROM Product_PhotoBooks INNER JOIN PhotoBooks ON Product_PhotoBooks.Product_PhotoBookFromID = PhotoBooks.PhotoBookID where Product_PhotoBookSize =@Product_PhotoBookSize";
            SqlParameter[] pms1 = new SqlParameter[] { 
                                 new SqlParameter("@Product_PhotoBookSize", SqlDbType.NVarChar, 50) { Value = productSize }};
            DataRow dr1 = SqlHelper.ExecuteDataSet(sql1, CommandType.Text, pms1);

            string productID = dr1["Product_PhotoBookID"].ToString();
            double productPrice = Convert.ToDouble(dr1["Product_PhotoBookPrice"].ToString());
            //((Label)(e.Item.FindControl("lblPhotoBook"))).Text = productPrice.ToString();
            int Amount = Convert.ToInt32(((TextBox)(e.Item.FindControl("txtAmount_PhotoBook"))).Text);
            GetDatatableAndValue(productName, productImages, productDescribe, productColor, productPrice, productSize, productID, Amount, userDiyPhoto);
        }
        catch
        {
            Literal lit = new Literal();
            lit.Text = "<script language='javascript'>window.alert('请选择大小！')</script>";
            Page.Controls.Add(lit);

        }
    }
    protected void DataListMuralPaintingJoinCar_ItemCommand(object source, DataListCommandEventArgs e)
    {
        if (e.CommandName == "Buy")
        {
            string CurrentUrl = HttpContext.Current.Request.Url.PathAndQuery;
            if (Session["telephone"] == null)
            {
                Response.Redirect("Login.aspx?url=" + CurrentUrl);
            }

            userDiyPhoto = @"~\images\logo.png";
            GetValueFromMuralPainting(e);
        }
        if (e.CommandName == "DIY")
        {
            ((LinkButton)(e.Item.FindControl("lbtnJoinCar_MuralPainting"))).Visible = false;
            ((LinkButton)(e.Item.FindControl("lbtn_DIY_MuralPainting"))).Visible = false;
            PanelDiy.Visible = true;
            Session["e"] = e;
            Session["list"] = "MuralPainting";
        }
    }

    private void GetValueFromMuralPainting(DataListCommandEventArgs e)
    {

        string sql = "SELECT  * FROM MuralPaintings where MuralPaintingID =@MuralPaintingID";
        SqlParameter[] pms = new SqlParameter[] { 
                             new SqlParameter("@MuralPaintingID", SqlDbType.Int) { Value = Request.QueryString["MuralPaintingID"] }};
        DataRow dr = SqlHelper.ExecuteDataSet(sql, CommandType.Text, pms);
        string productName = dr["MuralPaintingName"].ToString();
        string productImages = dr["MuralPaintingImages"].ToString();
        string productDescribe = dr["MuralPaintingDescribe"].ToString();
        string productColor = dr["MuralPaintingColor"].ToString();
        string productID = dr["MuralPaintingID"].ToString();
        double productPrice = Convert.ToDouble(dr["MuralPaintingPrice"].ToString());
        string productSize = dr["MuralPaintingSize"].ToString();
        int Amount = Convert.ToInt32(((TextBox)(e.Item.FindControl("txtAmount_MuralPainting"))).Text);
        GetDatatableAndValue(productName, productImages, productDescribe, productColor, productPrice, productSize, productID, Amount, userDiyPhoto);


    }
    protected void DataListPC_Host_ItemCommand(object source, DataListCommandEventArgs e)
    {

        if (e.CommandName == "Buy")
        {
            string CurrentUrl = HttpContext.Current.Request.Url.PathAndQuery;
            if (Session["telephone"] == null)
            {
                Response.Redirect("Login.aspx?url=" + CurrentUrl);
            }
            userDiyPhoto = @"~\images\logo.png";
            GetValueFromPC_Host(e);
        }



    }

    private void GetValueFromPC_Host(DataListCommandEventArgs e)
    {

        string sql = "SELECT  * FROM PC_Host where HostID =@HostID";
        SqlParameter[] pms = new SqlParameter[] { 
                             new SqlParameter("@HostID", SqlDbType.Int) { Value = Request.QueryString["HostID"] }};
        DataRow dr = SqlHelper.ExecuteDataSet(sql, CommandType.Text, pms);
        //string HostID = dr["HostID"].ToString();
        //string Name = dr["Name"].ToString();
        //string Cpu = dr["Cpu"].ToString();
        //string MainBoard = dr["MainBoard"].ToString();
        //string Cooler = dr["Cooler"].ToString();
        //string HardDisk = (dr["HardDisk"].ToString());
        //string Memory = dr["Memory"].ToString();
        //string Graphics = dr["Graphics"].ToString();
        //string Power = dr["Power"].ToString();
        //string ComputerCase = dr["ComputerCase"].ToString();
        //double Price = Convert.ToDouble(dr["Price"].ToString());
        //string Images = dr["Images"].ToString();
        //int Amount = Convert.ToInt32(((TextBox)(e.Item.FindControl("txtAmountPC_Host"))).Text);
        //GetDatatableAndValue(HostID, Name, Cpu, MainBoard, Cooler, HardDisk, Memory, Graphics, Power, ComputerCase, Price, Images, Amount);
        string productName = dr["Name"].ToString();
        string productImages = dr["Images"].ToString();
        string productDescribe = dr["Cpu"].ToString() + dr["MainBoard"].ToString() + dr["Memory"].ToString();//dr["PhotoBookDescribe"].ToString();
        string productColor = dr["ComputerCase"].ToString() + "黑色为主（以图片为准）";
        string productID = dr["HostID"].ToString();
        double productPrice = Convert.ToDouble(dr["Price"].ToString());
        string productSize = "无参数";//dr["MuralPaintingSize"].ToString();
        int Amount = Convert.ToInt32(((TextBox)(e.Item.FindControl("txtAmountPC_Host"))).Text);
        GetDatatableAndValue(productName, productImages, productDescribe, productColor, productPrice, productSize, productID, Amount, userDiyPhoto);



    }
    protected void DataListPC_CPU_ItemCommand(object source, DataListCommandEventArgs e)
    {

        if (e.CommandName == "Buy")
        {
            string CurrentUrl = HttpContext.Current.Request.Url.PathAndQuery;
            if (Session["telephone"] == null)
            {
                Response.Redirect("Login.aspx?url=" + CurrentUrl);
            }
            userDiyPhoto = @"~\images\logo.png";
            GetValueFromPC_CPU(e);
        }



    }

    private void GetValueFromPC_CPU(DataListCommandEventArgs e)
    {
        string sql = "SELECT  * FROM PC_Cpu where CpuID =@CpuID";
        SqlParameter[] pms = new SqlParameter[] { 
                             new SqlParameter("@CpuID", SqlDbType.Int) { Value = Request.QueryString["CpuID"] }};
        DataRow dr = SqlHelper.ExecuteDataSet(sql, CommandType.Text, pms);
        string productName = dr["Name"].ToString();
        string productImages = dr["Images"].ToString();
        string productDescribe = dr["Brand"].ToString() + dr["Model"].ToString() + dr["Series"].ToString();//dr["PhotoBookDescribe"].ToString();
        string productColor = "无参数";//dr["ComputerCase"].ToString() + "黑色为主（以图片为准）";
        string productID = dr["CpuID"].ToString();
        double productPrice = Convert.ToDouble(dr["Price"].ToString());
        string productSize = "无参数";//dr["MuralPaintingSize"].ToString();
        int Amount = Convert.ToInt32(((TextBox)(e.Item.FindControl("txtAmountPC_Cpu"))).Text);
        GetDatatableAndValue(productName, productImages, productDescribe, productColor, productPrice, productSize, productID, Amount, userDiyPhoto);

    }
    protected void DataListMemory_ItemCommand(object source, DataListCommandEventArgs e)
    {
        if (e.CommandName == "Buy")
        {
            string CurrentUrl = HttpContext.Current.Request.Url.PathAndQuery;
            if (Session["telephone"] == null)
            {
                Response.Redirect("Login.aspx?url=" + CurrentUrl);
            }
            userDiyPhoto = @"~\images\logo.png";
            GetValueFromMemory(e);
        }
    }

    private void GetValueFromMemory(DataListCommandEventArgs e)
    {
        string sql = "SELECT  * FROM PC_Memory where MemoryID =@MemoryID";
        SqlParameter[] pms = new SqlParameter[] { 
                             new SqlParameter("@MemoryID", SqlDbType.Int) { Value = Request.QueryString["MemoryID"] }};
        DataRow dr = SqlHelper.ExecuteDataSet(sql, CommandType.Text, pms);
        string productName = dr["Name"].ToString();
        string productImages = dr["Images"].ToString();
        string productDescribe = dr["Brand"].ToString() + dr["Series"].ToString() + dr["Speed"].ToString();//dr["PhotoBookDescribe"].ToString();
        string productColor = "无参数";//dr["ComputerCase"].ToString() + "黑色为主（以图片为准）";
        string productID = dr["MemoryID"].ToString();
        double productPrice = Convert.ToDouble(dr["Price"].ToString());
        string productSize = dr["Capacity"].ToString();//"无参数";//dr["Capacity"].ToString();
        int Amount = Convert.ToInt32(((TextBox)(e.Item.FindControl("txtAmountMemory"))).Text);
        GetDatatableAndValue(productName, productImages, productDescribe, productColor, productPrice, productSize, productID, Amount, userDiyPhoto);

    }
    protected void DataListGraphics_ItemCommand(object source, DataListCommandEventArgs e)
    {
        if (e.CommandName == "Buy")
        {
            string CurrentUrl = HttpContext.Current.Request.Url.PathAndQuery;
            if (Session["telephone"] == null)
            {
                Response.Redirect("Login.aspx?url=" + CurrentUrl);
            }
            //GetValueFromT_shirt(e);
            //GetValueFromMuralPainting(e);
            userDiyPhoto = @"~\images\logo.png";
            GetValueFromGraphics(e);
        }
    }

    private void GetValueFromGraphics(DataListCommandEventArgs e)
    {
        string sql = "SELECT  * FROM PC_Graphics where GraphicsID =@GraphicsID";
        SqlParameter[] pms = new SqlParameter[] { 
                             new SqlParameter("@GraphicsID", SqlDbType.Int) { Value = Request.QueryString["GraphicsID"] }};
        DataRow dr = SqlHelper.ExecuteDataSet(sql, CommandType.Text, pms);
        string productName = dr["Name"].ToString();
        string productImages = dr["Images"].ToString();
        string productDescribe = dr["Brand"].ToString() + dr["Model"].ToString() + dr["Frequency"].ToString();//dr["PhotoBookDescribe"].ToString();
        string productColor = "无参数";//dr["ComputerCase"].ToString() + "黑色为主（以图片为准）";
        string productID = dr["GraphicsID"].ToString();
        double productPrice = Convert.ToDouble(dr["Price"].ToString());
        string productSize = "无参数"; //dr["Capacity"].ToString();//"无参数";//dr["Capacity"].ToString();
        int Amount = Convert.ToInt32(((TextBox)(e.Item.FindControl("txtAmountGraphics"))).Text);
        GetDatatableAndValue(productName, productImages, productDescribe, productColor, productPrice, productSize, productID, Amount, userDiyPhoto);

    }



    /// <summary>
    /// 当用户div时加入购物车
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lbtnDiyJoinCar_Click(object sender, EventArgs e)
    {
        string list = Session["list"].ToString();
        DataListCommandEventArgs eModel = (DataListCommandEventArgs)Session["e"];

        if (fupJoinCar.HasFile)
        {
            string pUrl = @"~\images\userdiy\" + fupJoinCar.FileName;  //上传图片保存路径
            fupJoinCar.SaveAs(Server.MapPath(pUrl));                      //保存文件
            userDiyPhoto = pUrl;
        }
        else
        {
            userDiyPhoto = "-1";
        }
        if (userDiyPhoto == "-1")
        {
            Literal lit = new Literal();
            lit.Text = "<script language='javascript'>window.alert('请上传DIY蓝图！')</script>";
            Page.Controls.Add(lit);
        }

        else
        {
            if (list == "T_shirt")
            {
                GetValueFromT_shirt(eModel);
            }
            else if (list == "PhotoBook")
            {
                GetValueFromPhotoBook(eModel);
            }
            else if (list == "MuralPainting")
            {
                GetValueFromMuralPainting(eModel);
            }
        }
    }



    /// <summary>
    /// 当用户不想div时，取消
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lbtCancel_Click(object sender, EventArgs e)
    {
        string list = Session["list"].ToString();
        if (list == "T_shirt")
        {
            ((LinkButton)(DataListT_shirtJoinCar.Items[0].FindControl("lbtnJoinCar_TShirt"))).Visible = true;
            ((LinkButton)(DataListT_shirtJoinCar.Items[0].FindControl("lbtnDIY_TShirt"))).Visible = true;
            PanelDiy.Visible = false;
        }
        else if (list == "PhotoBook")
        {
            ((LinkButton)(DataListPhotoBookJoinCar.Items[0].FindControl("lbtnJoinCar_PhotoBook"))).Visible = true;
            ((LinkButton)(DataListPhotoBookJoinCar.Items[0].FindControl("lbtnDIY_PhotoBook"))).Visible = true;
            PanelDiy.Visible = false;
        }
        else if (list == "MuralPainting")
        {
            //DataListMuralPaintingJoinCar
            ((LinkButton)(DataListMuralPaintingJoinCar.Items[0].FindControl("lbtnJoinCar_MuralPainting"))).Visible = true;
            ((LinkButton)(DataListMuralPaintingJoinCar.Items[0].FindControl("lbtn_DIY_MuralPainting"))).Visible = true;
            PanelDiy.Visible = false;
        }
    }
    protected void rbl_PhotoBook_SelectedIndexChanged(object sender, EventArgs e)
    {
        string productSize = (((RadioButtonList)(DataListPhotoBookJoinCar.Items[0].FindControl("rbl_PhotoBook"))).Text).ToString();
        string sql1 = "SELECT  PhotoBooks.*, Product_PhotoBooks.* FROM Product_PhotoBooks INNER JOIN PhotoBooks ON Product_PhotoBooks.Product_PhotoBookFromID = PhotoBooks.PhotoBookID where Product_PhotoBookSize =@Product_PhotoBookSize";
        SqlParameter[] pms1 = new SqlParameter[] { 
                                 new SqlParameter("@Product_PhotoBookSize", SqlDbType.NVarChar, 50) { Value = productSize }};
        DataRow dr1 = SqlHelper.ExecuteDataSet(sql1, CommandType.Text, pms1);

        double productPrice = Convert.ToDouble(dr1["Product_PhotoBookPrice"].ToString());
        ((Label)(DataListPhotoBookJoinCar.Items[0].FindControl("lblPhotoBook"))).Text = productPrice.ToString();

    }
}