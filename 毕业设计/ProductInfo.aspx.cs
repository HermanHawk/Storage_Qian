using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ProductInfo : System.Web.UI.Page
{
    
    protected void Page_Load(object sender, EventArgs e)
    {
        //if (!IsPostBack)
        //{
        //    if (Request.QueryString["ProductKind"] == null)
        //    {
        //        Response.Redirect("home.aspx");
        //    }
        //    string productkind = Request.QueryString["ProductKind"].ToString();
        //    Session["ProductKind"] = productkind;
        //}
        //if (Session["ProductKind"] == null)
        //{
        //    string productkind = Request.QueryString["ProductKind"].ToString();
        //    Session["ProductKind"] = productkind;
        //}
        if (Request.QueryString["ProductKind"] == null)
        {
            Response.Redirect("home.aspx");
        }
        string productkind = Request.QueryString["ProductKind"].ToString();
        Session["ProductKind"] = productkind;


        string kind = Session["ProductKind"].ToString();
        if (kind == "Kind_TXu")
        {
            DataListT_shirt.Visible = true;
            DataListPhotoBook.Visible = false;
            DataListMuralPainting.Visible = false;
            DataListComputer.Visible = false;
            DataListPC_CPU.Visible = false;
            DataListMemory.Visible = false;
            DataListGraphics.Visible = false;
        }
        else if (kind == "Kind_PhotoBook")
        {
            DataListT_shirt.Visible = false;
            DataListPhotoBook.Visible = true;
            DataListMuralPainting.Visible = false;
            DataListComputer.Visible = false;
            DataListPC_CPU.Visible = false;
            DataListMemory.Visible = false;
            DataListGraphics.Visible = false;
        }
        else if (kind == "Kind_MuralPainting")
        {
            DataListT_shirt.Visible = false;
            DataListPhotoBook.Visible = false;
            DataListMuralPainting.Visible = true;
            DataListComputer.Visible = false;
            DataListPC_CPU.Visible = false;
            DataListMemory.Visible = false;
            DataListGraphics.Visible = false;
        }
        else
        {
            //ProductInfo.aspx?ProductKind=Kind_Computer
            DataListComputer.Visible = true;
            DataListT_shirt.Visible = false;
            DataListPhotoBook.Visible = false;
            DataListMuralPainting.Visible = false;
            DataListPC_CPU.Visible = true;
            DataListMemory.Visible = true;
            DataListGraphics.Visible = true;

        }
    }
  
}