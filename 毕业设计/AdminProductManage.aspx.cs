using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminProductManage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Session["telephone"] != null)
        {
            //this.hplUserinfo.Text = "欢迎用户" + Session["UserName"];
            //前台<%= Session["UserName"]%>
            this.lblUserTel.Text = Session["telephone"].ToString();
            //this.userLoginShow.Visible = false;
            //this.userRegister.Visible = false;
            string sql = "select * from AdminInfo where AdminTelephone = @AdminTelephone";
            SqlParameter[] pms = new SqlParameter[] { 
                                     new SqlParameter("@AdminTelephone", SqlDbType.VarChar, 50) { Value = Session["telephone"].ToString() }};
            using (SqlDataReader reader = SqlHelper.ExecuteReader(sql, CommandType.Text, pms))
            {
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        this.lblUserName.Text = reader.GetString(2);
                        this.lbluserEmail.Text = reader.GetString(3);
                    }
                }
            }



        }
    }

    /// <summary>
    /// 添加T恤，照片书，墙画
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnJoinProducts_Click(object sender, EventArgs e)
    {
        string sql1 = "insert into T_shirtInfo(T_shirtPrice,T_shirtDescribe,T_shirtColor,T_shirtName,T_shirtImages) values(@T_shirtPrice,@T_shirtDescribe,@T_shirtColor,@T_shirtName,@T_shirtImages)";
        string sql6 = "select count(*) from T_shirtInfo";
        string sql2 = "insert into Product_TShirt(Product_TShirtFromID,Product_TShirtSize) values(@Product_TShirtFromID,@Product_TShirtSize)";
        string sql3 = "INSERT into MuralPaintings(MuralPaintingName,MuralPaintingDescribe,MuralPaintingColor,MuralPaintingSize,MuralPaintingPrice,MuralPaintingImages) VALUES(@MuralPaintingName,@MuralPaintingDescribe,@MuralPaintingColor,@MuralPaintingSize,@MuralPaintingPrice,@MuralPaintingImages)";
        string sql4 = "insert into PhotoBooks(PhotoBookName,PhotoBookDescribe,PhotoBookColor,PhotoBookImages) values(@PhotoBookName,@PhotoBookDescribe,@PhotoBookColor,@PhotoBookImages)";
        string sql7 = "select count(*) from PhotoBooks";
        string sql5 = "insert into Product_PhotoBooks(Product_PhotoBookFromID,Product_PhotoBookPrice,Product_PhotoBookSize) values(@Product_PhotoBookFromID,@Product_PhotoBookPrice,@Product_PhotoBookSize)";

        Literal lit = new Literal();

        if (dplProducts.SelectedValue == "0")
        {
            #region T_shirt
            SqlParameter T_shirtPrice = new SqlParameter("@T_shirtPrice", SqlDbType.NVarChar) { Value = Convert.ToDecimal(txtProductPrice.Text.Trim()) };
            SqlParameter T_shirtDescribe = new SqlParameter("@T_shirtDescribe", SqlDbType.NVarChar) { Value = txtProductDescribe.Text.Trim() };
            SqlParameter T_shirtColor = new SqlParameter("@T_shirtColor", SqlDbType.NVarChar, 50) { Value = txtProductColor.Text.Trim() };
            SqlParameter T_shirtName = new SqlParameter("@T_shirtName", SqlDbType.NVarChar, 50) { Value = txtProductName.Text.Trim() };
            //new SqlParameter("@T_shirtImages",SqlDbType.NVarChar,50){Value = };
            SqlParameter T_shirtImages = null;              //SqlParameter userPhoto = null;
            if (fupProducts.HasFile)
            {
                //\images\userImages   \images\txu
                string pUrl = @"~\images\txu\" + fupProducts.FileName;  //上传图片保存路径
                fupProducts.SaveAs(Server.MapPath(pUrl));                      //保存文件
                T_shirtImages = new SqlParameter("@T_shirtImages", SqlDbType.NVarChar, 50) { Value = pUrl };
            }
            else
            {
                T_shirtImages = new SqlParameter("@T_shirtImages", SqlDbType.NVarChar, 50) { Value = "" };
            }
            SqlParameter[] pmsT_shirtInfo = new SqlParameter[] { T_shirtPrice, T_shirtDescribe, T_shirtColor, T_shirtName, T_shirtImages };

            int countT_shirtInfo = SqlHelper.ExecuteNonQuery(sql1, CommandType.Text, pmsT_shirtInfo);

            if (countT_shirtInfo > 0)
            {
                int sumCoumtT_shirt = (int)SqlHelper.ExecuteScalar(sql6, CommandType.Text);
                // txtProductSize.Enabled = false;
                SqlParameter Product_TShirtSize = new SqlParameter("@Product_TShirtSize", SqlDbType.NVarChar, 50) { Value = "" };
                for (int i = 0; i < 6; i++)
                {

                    if (i == 0)
                    {
                        Product_TShirtSize = new SqlParameter("@Product_TShirtSize", SqlDbType.NVarChar, 50) { Value = "S" };
                    }
                    else if (i == 1)
                    {
                        Product_TShirtSize = new SqlParameter("@Product_TShirtSize", SqlDbType.NVarChar, 50) { Value = "M" };
                    }
                    else if (i == 2)
                    {
                        Product_TShirtSize = new SqlParameter("@Product_TShirtSize", SqlDbType.NVarChar, 50) { Value = "L" };
                    }
                    else if (i == 3)
                    {
                        Product_TShirtSize = new SqlParameter("@Product_TShirtSize", SqlDbType.NVarChar, 50) { Value = "XL" };
                    }
                    else if (i == 4)
                    {
                        Product_TShirtSize = new SqlParameter("@Product_TShirtSize", SqlDbType.NVarChar, 50) { Value = "XXL" };
                    }
                    else if (i == 5)
                    {
                        Product_TShirtSize = new SqlParameter("@Product_TShirtSize", SqlDbType.NVarChar, 50) { Value = "XXXL" };
                    }
                    SqlParameter Product_TShirtFromID = new SqlParameter("@Product_TShirtFromID", SqlDbType.Int) { Value = sumCoumtT_shirt };
                    SqlParameter[] PmsProduct_TShirt = new SqlParameter[] { Product_TShirtFromID, Product_TShirtSize };

                    int countProduct_TShirt = SqlHelper.ExecuteNonQuery(sql2, CommandType.Text, PmsProduct_TShirt);

                    if (countProduct_TShirt > 0)
                    {

                        //lit.Text = "<script>alert('加入成功!')</script>";

                        //this.GridView2.DataBind();
                    }
                    else
                    {
                        lit.Text = "<script>alert('加入失败!')</script>";
                    }
                }
                lit.Text = "<script>alert('加入成功!')</script>";

                this.gvT_shirt.DataBind();
                txtProductName.Text = "";
                txtProductPrice.Text = "";
                txtProductDescribe.Text = "";
                txtProductColor.Text = "";
                
                //this.GridView2.DataBind();
            }
            else
            {
                lit.Text = "<script>alert('加入失败!')</script>";
            }


            #endregion
        }


        else if (dplProducts.SelectedValue == "2")
        {
            #region MuralPainting
            //txtProductSize.Enabled = true;
            SqlParameter MuralPaintingName = new SqlParameter("@MuralPaintingName", SqlDbType.NVarChar, 50) { Value = txtProductName.Text.Trim() };
            SqlParameter MuralPaintingDescribe = new SqlParameter("@MuralPaintingDescribe", SqlDbType.NVarChar) { Value = txtProductDescribe.Text.Trim() };
            SqlParameter MuralPaintingColor = new SqlParameter("@MuralPaintingColor", SqlDbType.NVarChar, 50) { Value = txtProductColor.Text.Trim() };
            SqlParameter MuralPaintingSize = new SqlParameter("@MuralPaintingSize", SqlDbType.NVarChar, 50) { Value = dplProductSize.Text };
            SqlParameter MuralPaintingPrice = new SqlParameter("@MuralPaintingPrice", SqlDbType.NVarChar) { Value = Convert.ToDecimal(txtProductPrice.Text.Trim()) };
            //SqlParameter MuralPaintingImages = new SqlParameter("@MuralPaintingImages",SqlDbType.NVarChar,50){Value = };
            SqlParameter MuralPaintingImages = null;      //SqlParameter userPhoto = null;                                      
            if (fupProducts.HasFile)
            {
                //\images\userImages   \images\txu   \images\muban
                string pUrl = @"~\images\muban\" + fupProducts.FileName;  //上传图片保存路径
                fupProducts.SaveAs(Server.MapPath(pUrl));                      //保存文件
                MuralPaintingImages = new SqlParameter("@MuralPaintingImages", SqlDbType.NVarChar, 50) { Value = pUrl };
            }
            else
            {
                MuralPaintingImages = new SqlParameter("@MuralPaintingImages", SqlDbType.NVarChar, 50) { Value = "" };
            }
            SqlParameter[] PmsMuralPaintings = new SqlParameter[] { MuralPaintingName, MuralPaintingDescribe, MuralPaintingColor, MuralPaintingSize, MuralPaintingPrice, MuralPaintingImages };
            int countMuralPaintings = SqlHelper.ExecuteNonQuery(sql3, CommandType.Text, PmsMuralPaintings);

            if (countMuralPaintings > 0)
            {

                lit.Text = "<script>alert('加入成功!')</script>";

                //this.GridView2.DataBind();
                
                this.gvMuralPainting.DataBind();
                txtProductName.Text = "";
                txtProductPrice.Text = "";
                txtProductDescribe.Text = "";
                txtProductColor.Text = "";
            }
            else
            {
                lit.Text = "<script>alert('加入失败!')</script>";
            }
            #endregion
        }

        else if (dplProducts.SelectedValue == "1")
        {
            #region PhotoBooks
            SqlParameter PhotoBookName = new SqlParameter("@PhotoBookName", SqlDbType.NVarChar, 50) { Value = txtProductName.Text.Trim() };
            SqlParameter PhotoBookDescribe = new SqlParameter("@PhotoBookDescribe", SqlDbType.NVarChar) { Value = txtProductDescribe.Text.Trim() };
            SqlParameter PhotoBookColor = new SqlParameter("@PhotoBookColor", SqlDbType.NVarChar, 50) { Value = txtProductColor.Text.Trim() };
            //SqlParameter PhotoBookImages = new SqlParameter("@PhotoBookImages",SqlDbType.NVarChar,50){Value = };
            SqlParameter PhotoBookImages = null;      //SqlParameter userPhoto = null;                                      
            if (fupProducts.HasFile)
            {
                //\images\userImages   \images\txu   \images\muban    \images\books
                string pUrl = @"~\images\books\" + fupProducts.FileName;  //上传图片保存路径
                fupProducts.SaveAs(Server.MapPath(pUrl));                      //保存文件
                PhotoBookImages = new SqlParameter("@PhotoBookImages", SqlDbType.NVarChar, 50) { Value = pUrl };
            }
            else
            {
                PhotoBookImages = new SqlParameter("@PhotoBookImages", SqlDbType.NVarChar, 50) { Value = "" };
            }
            SqlParameter[] PmsPhotoBooks = new SqlParameter[] { PhotoBookName, PhotoBookDescribe, PhotoBookColor, PhotoBookImages };
            int countPhotoBooks = SqlHelper.ExecuteNonQuery(sql4, CommandType.Text, PmsPhotoBooks);

            if (countPhotoBooks > 0)
            {
                SqlParameter Product_PhotoBookSize = new SqlParameter("@Product_PhotoBookSize", SqlDbType.NVarChar, 50) { Value = "" };
                int sumCoumtPhotoBook = (int)SqlHelper.ExecuteScalar(sql7, CommandType.Text);
                for (int i = 0; i < 2; i++)
                {
                    if (i == 0)
                    {
                        Product_PhotoBookSize = new SqlParameter("@Product_PhotoBookSize", SqlDbType.NVarChar, 50) { Value = "8寸" };
                    }
                    else if (i == 1)
                    {
                        Product_PhotoBookSize = new SqlParameter("@Product_PhotoBookSize", SqlDbType.NVarChar, 50) { Value = "12寸" };
                    }

                    SqlParameter Product_PhotoBookFromID = new SqlParameter("@Product_PhotoBookFromID", SqlDbType.Int) { Value = sumCoumtPhotoBook };
                    SqlParameter Product_PhotoBookPrice = new SqlParameter("@Product_PhotoBookPrice", SqlDbType.NVarChar) { Value = Convert.ToDecimal(txtProductPrice.Text.Trim()) };


                    SqlParameter[] PmsProduct_PhotoBooks = new SqlParameter[] { Product_PhotoBookFromID, Product_PhotoBookPrice, Product_PhotoBookSize };
                    int countProduct_PhotoBooks = SqlHelper.ExecuteNonQuery(sql5, CommandType.Text, PmsProduct_PhotoBooks);

                    if (countProduct_PhotoBooks > 0)
                    {

                        //lit.Text = "<script>alert('加入成功!')</script>";

                        //this.GridView2.DataBind();
                    }
                    else
                    {
                        lit.Text = "<script>alert('加入失败!')</script>";
                    }
                }


                lit.Text = "<script>alert('加入成功!')</script>";
                this.gvPhotoBook.DataBind();
                //this.GridView2.DataBind();
                txtProductName.Text = "";
                txtProductPrice.Text = "";
                txtProductDescribe.Text = "";
                txtProductColor.Text = "";
            }
            else
            {
                lit.Text = "<script>alert('加入失败!')</script>";
            }


            #endregion
        }

        else
        {
            lit.Text = "<script>alert('请选择商品类别!')</script>";
        }
        Page.Controls.Add(lit);




    }
    protected void dplProducts_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (dplProducts.SelectedValue == "2")
        {
            dplProductSize.Enabled = true;
        }
        else
        {
            dplProductSize.Enabled = false;
        }
    }



    /// <summary>
    /// 添加内存条
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnJoinMemory_Click(object sender, EventArgs e)
    {
        string sql = "INSERT into PC_Memory(Brand,Series,Speed,Capacity,Name,Price,Images) VALUES(@Brand,@Model,@Speed,@Capacity,@Name,@Price,@Images)";
        Literal lit = new Literal();
        SqlParameter Brand = new SqlParameter("Brand", SqlDbType.NVarChar, 50) { Value = txtMemoryBrand.Text.Trim() };
        SqlParameter Series = new SqlParameter("Series", SqlDbType.NVarChar, 50) { Value = txtMemorySeries.Text.Trim() };
        SqlParameter Speed = new SqlParameter("Speed", SqlDbType.NVarChar, 50) { Value = txtMemorySpeed.Text.Trim() };
        SqlParameter Capacity = new SqlParameter("Capacity", SqlDbType.NVarChar, 50) { Value = txtMemoryCapacity.Text.Trim() };
        SqlParameter Name = new SqlParameter("Name", SqlDbType.NVarChar, 50) { Value = txtMemoryName.Text.Trim() };
        SqlParameter Price = new SqlParameter("Price", SqlDbType.NVarChar, 50) { Value = Convert.ToDecimal(txtMemoryPrice.Text.Trim()) };
        SqlParameter Images = null;
        if (fupMemoryImages.HasFile)
        {
            //\images\userImages   \images\txu     \images\pc
            string pUrl = @"~\images\pc\" + fupMemoryImages.FileName;  //上传图片保存路径
            fupMemoryImages.SaveAs(Server.MapPath(pUrl));                      //保存文件
            Images = new SqlParameter("@Images", SqlDbType.NVarChar, 50) { Value = pUrl };
        }
        else
        {
            Images = new SqlParameter("@Images", SqlDbType.NVarChar, 50) { Value = "" };
        }
        SqlParameter[] pmsPC_Memory = new SqlParameter[] { Brand, Series, Speed, Capacity, Name, Price, Images };
        int countPC_Memory = SqlHelper.ExecuteNonQuery(sql, CommandType.Text, pmsPC_Memory);
        if (countPC_Memory > 0)
        {
            lit.Text = "<script>alert('加入成功!')</script>";

            //this.GridView2.DataBind();
            this.gvMemory.DataBind();
            txtMemoryBrand.Text = "";
            txtMemorySeries.Text = "";
            txtMemorySpeed.Text = "";
            txtMemoryCapacity.Text = "";
            txtMemoryName.Text = "";
            txtMemoryPrice.Text = "";
        }
        else
        {
            lit.Text = "<script>alert('加入失败!')</script>";
        }
        Page.Controls.Add(lit);



    }


    /// <summary>
    /// 添加主机
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnJoinHost_Click(object sender, EventArgs e)
    {
        string sql = "INSERT into PC_Host(Name,Cpu,MainBoard,Cooler,HardDisk,Memory,Graphics,Power,ComputerCase,Price,Images) VALUES(@Name,@Cpu,@MainBoard,@Cooler,@HardDisk,@Memory,@Graphics,@Power,@ComputerCase,@Price,@Images)";
        Literal lit = new Literal();
        SqlParameter Name = new SqlParameter("Name", SqlDbType.NVarChar, 50) { Value = txtHostName.Text.Trim() };
        SqlParameter Cpu = new SqlParameter("Cpu", SqlDbType.NVarChar, 50) { Value = txtHostCPU.Text.Trim() };
        SqlParameter MainBoard = new SqlParameter("MainBoard", SqlDbType.NVarChar, 50) { Value = txtHostMainBoard.Text.Trim() };
        SqlParameter Cooler = new SqlParameter("Cooler", SqlDbType.NVarChar, 50) { Value = txtHostCooler.Text.Trim() };
        SqlParameter HardDisk = new SqlParameter("HardDisk", SqlDbType.NVarChar, 50) { Value = txtHostHardDisk.Text.Trim() };
        SqlParameter Price = new SqlParameter("Price", SqlDbType.NVarChar, 50) { Value = Convert.ToDecimal(txtHostPrice.Text.Trim()) };
        SqlParameter Memory = new SqlParameter("Memory", SqlDbType.NVarChar, 50) { Value = txtHostMemory.Text.Trim() };
        SqlParameter Graphics = new SqlParameter("Graphics", SqlDbType.NVarChar, 50) { Value = txtHostGraphics.Text.Trim() };
        SqlParameter Power = new SqlParameter("Power", SqlDbType.NVarChar, 50) { Value = txtHostPower.Text.Trim() };
        SqlParameter ComputerCase = new SqlParameter("ComputerCase", SqlDbType.NVarChar, 50) { Value = txtHostComputerCase.Text.Trim() };
        SqlParameter Images = null;
        if (fupHostImage.HasFile)
        {
            //\images\userImages   \images\txu     \images\pc
            string pUrl = @"~\images\pc\" + fupHostImage.FileName;  //上传图片保存路径
            fupHostImage.SaveAs(Server.MapPath(pUrl));                      //保存文件
            Images = new SqlParameter("@Images", SqlDbType.NVarChar, 50) { Value = pUrl };
        }
        else
        {
            Images = new SqlParameter("@Images", SqlDbType.NVarChar, 50) { Value = "" };
        }
        SqlParameter[] pmsPC_Host = new SqlParameter[] { Name, Cpu, MainBoard, Cooler, HardDisk, Price, Memory, Graphics, Power, ComputerCase, Images };
        int countPC_Host = SqlHelper.ExecuteNonQuery(sql, CommandType.Text, pmsPC_Host);
        if (countPC_Host > 0)
        {
            lit.Text = "<script>alert('加入成功!')</script>";

            //this.GridView2.DataBind();
            this.gvPC_Host.DataBind();
            txtHostName.Text = "";
            txtHostCPU.Text = "";
            txtHostMainBoard.Text = "";
            txtHostCooler.Text = "";
            txtHostHardDisk.Text = "";
            txtHostMemory.Text = "";
            txtHostGraphics.Text = "";
            txtHostPower.Text = "";
            txtHostComputerCase.Text = "";
            txtHostPrice.Text = "";
        }
        else
        {
            lit.Text = "<script>alert('加入失败!')</script>";
        }
        Page.Controls.Add(lit);
    }


    /// <summary>
    /// 添加显卡
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnJoinGraphics_Click(object sender, EventArgs e)
    {
        string sql = "INSERT into PC_Graphics(Name,Brand,Model,Frequency,Character,Price,Images) VALUES(@Name,@Brand,@Model,@Frequency,@Character,@Price,@Images)";
        Literal lit = new Literal();
        SqlParameter Name = new SqlParameter("Name", SqlDbType.NVarChar, 50) { Value = txtGraphicsName.Text.Trim() };
        SqlParameter Brand = new SqlParameter("Brand", SqlDbType.NVarChar, 50) { Value = txtGraphicsBrand.Text.Trim() };
        SqlParameter Model = new SqlParameter("Model", SqlDbType.NVarChar, 50) { Value = txtGraphicsModel.Text.Trim() };
        SqlParameter Frequency = new SqlParameter("Frequency", SqlDbType.NVarChar, 50) { Value = txtGraphicsFrequency.Text.Trim() };
        SqlParameter Character = new SqlParameter("Character", SqlDbType.NVarChar, 50) { Value = txtGraphicsCharacter.Text.Trim() };
        SqlParameter Price = new SqlParameter("Price", SqlDbType.NVarChar, 50) { Value = Convert.ToDecimal(txtGraphicsPrice.Text.Trim()) };
        SqlParameter Images = null;
        if (fupGraphicsImages.HasFile)
        {
            //\images\userImages   \images\txu     \images\pc
            string pUrl = @"~\images\pc\" + fupGraphicsImages.FileName;  //上传图片保存路径
            fupGraphicsImages.SaveAs(Server.MapPath(pUrl));                      //保存文件
            Images = new SqlParameter("@Images", SqlDbType.NVarChar, 50) { Value = pUrl };
        }
        else
        {
            Images = new SqlParameter("@Images", SqlDbType.NVarChar, 50) { Value = "" };
        }
        SqlParameter[] pmsPC_Graphics = new SqlParameter[] { Name, Brand, Model, Frequency, Character, Price, Images };
        int countPC_Graphics = SqlHelper.ExecuteNonQuery(sql, CommandType.Text, pmsPC_Graphics);
        if (countPC_Graphics > 0)
        {
            lit.Text = "<script>alert('加入成功!')</script>";

            //this.GridView2.DataBind();
            this.gvGraphics.DataBind();
            txtGraphicsName.Text = "";
            txtGraphicsBrand.Text = "";
            txtGraphicsModel.Text = "";
            txtGraphicsFrequency.Text = "";
            txtGraphicsCharacter.Text = "";
            txtGraphicsPrice.Text = "";
        }
        else
        {
            lit.Text = "<script>alert('加入失败!')</script>";
        }
        Page.Controls.Add(lit);
    }



    /// <summary>
    /// 添加CPU
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnJoinCpu_Click(object sender, EventArgs e)
    {
        string sql = "INSERT into PC_Cpu(Brand,Model,Series,Name,Price,Images) VALUES(@Brand,@Model,Series,@Name,@Price,@Images)";
        Literal lit = new Literal();
        SqlParameter Brand = new SqlParameter("Brand", SqlDbType.NVarChar, 50) { Value = txtCpuBrand.Text.Trim() };
        SqlParameter Model = new SqlParameter("Model", SqlDbType.NVarChar, 50) { Value = txtCpuModel.Text.Trim() };
        SqlParameter Series = new SqlParameter("Series", SqlDbType.NVarChar, 50) { Value = txtCpuSeries.Text.Trim() };
        SqlParameter Name = new SqlParameter("Name", SqlDbType.NVarChar, 50) { Value = txtCpuName.Text.Trim() };
        SqlParameter Price = new SqlParameter("Price", SqlDbType.NVarChar, 50) { Value = Convert.ToDecimal(txtCpuPrice.Text.Trim()) };
        SqlParameter Images = null;
        if (fupCpuImages.HasFile)
        {
            //\images\userImages   \images\txu     \images\pc
            string pUrl = @"~\images\pc\" + fupCpuImages.FileName;  //上传图片保存路径
            fupCpuImages.SaveAs(Server.MapPath(pUrl));                      //保存文件
            Images = new SqlParameter("@Images", SqlDbType.NVarChar, 50) { Value = pUrl };
        }
        else
        {
            Images = new SqlParameter("@Images", SqlDbType.NVarChar, 50) { Value = "" };
        }
        SqlParameter[] pmsPC_Cpu = new SqlParameter[] { Brand, Model, Series, Name, Price, Images };
        int countPC_Cpu = SqlHelper.ExecuteNonQuery(sql, CommandType.Text, pmsPC_Cpu);
        if (countPC_Cpu > 0)
        {
            lit.Text = "<script>alert('加入成功!')</script>";

            //this.GridView2.DataBind();
            this.gvPC_CPU.DataBind();
            txtCpuBrand.Text = "";
            txtCpuModel.Text = "";
            txtCpuSeries.Text = "";
            txtCpuName.Text = "";
            txtCpuPrice.Text = "";
        }
        else
        {
            lit.Text = "<script>alert('加入失败!')</script>";
        }
        Page.Controls.Add(lit);
    }
   



   
    /// <summary>
    /// PhotoBook编辑的时候修改图片
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void gvPhotoBook_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {


        FileUpload f = (FileUpload)gvPhotoBook.Rows[e.RowIndex].FindControl("fupUpdatePhotoBook");
        Image img = (Image)gvPhotoBook.Rows[e.RowIndex].FindControl("imgUpdatePhotoBook");
        if (f != null)
        {
            if (f.HasFile)
            {
                //上传图片
                f.PostedFile.SaveAs(Server.MapPath(@"~\images\books\" + f.FileName));
                //修改update语句的参数值
                dsPhotoBook.UpdateParameters["PhotoBookImages"].DefaultValue = @"~\images\books\" + f.FileName;
            }
            else
            {
                dsPhotoBook.UpdateParameters["PhotoBookImages"].DefaultValue = img.ImageUrl;
            }
        }

    }




    /// <summary>
    /// Muralpainting编辑的时候修改图片
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void gvMuralPainting_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {



        FileUpload f = (FileUpload)gvMuralPainting.Rows[e.RowIndex].FindControl("fupUpdateMuralPainting");
        Image img = (Image)gvMuralPainting.Rows[e.RowIndex].FindControl("imgUpdateMuralPainting");
        if (f != null)
        {
            if (f.HasFile)
            {
                //上传图片
                f.PostedFile.SaveAs(Server.MapPath(@"~\images\muban\" + f.FileName));
                //修改update语句的参数值
                dsMuralPainting.UpdateParameters["MuralPaintingImages"].DefaultValue = @"~\images\muban\" + f.FileName;
            }
            else
            {
                dsMuralPainting.UpdateParameters["MuralPaintingImages"].DefaultValue = img.ImageUrl;
            }
        }



    }




    /// <summary>
    /// 主机编辑时的修改图片
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void gvPC_Host_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {

        FileUpload f = (FileUpload)gvPC_Host.Rows[e.RowIndex].FindControl("fupUpdatePC_Host");
        Image img = (Image)gvPC_Host.Rows[e.RowIndex].FindControl("imgUpdatePC_Host");
        if (f != null)
        {
            if (f.HasFile)
            {
                //上传图片
                f.PostedFile.SaveAs(Server.MapPath(@"~\images\pc\" + f.FileName));
                //修改update语句的参数值
                dsPC_Host.UpdateParameters["Images"].DefaultValue = @"~\images\pc\" + f.FileName;
            }
            else
            {
                dsPC_Host.UpdateParameters["Images"].DefaultValue = img.ImageUrl;
            }
        }


    }




    /// <summary>
    /// cpu编辑时修改图片
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void gvPC_CPU_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {


        FileUpload f = (FileUpload)gvPC_CPU.Rows[e.RowIndex].FindControl("fupUpdatePC_CPU");
        Image img = (Image)gvPC_CPU.Rows[e.RowIndex].FindControl("imgUpdatePC_CPU");
        if (f != null)
        {
            if (f.HasFile)
            {
                //上传图片
                f.PostedFile.SaveAs(Server.MapPath(@"~\images\pc\" + f.FileName));
                //修改update语句的参数值
                dsPC_CPU.UpdateParameters["Images"].DefaultValue = @"~\images\pc\" + f.FileName;
            }
            else
            {
                dsPC_CPU.UpdateParameters["Images"].DefaultValue = img.ImageUrl;
            }
        }


    }




    /// <summary>
    /// 显卡编辑时修改图片
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void gvGraphics_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {


        FileUpload f = (FileUpload)gvGraphics.Rows[e.RowIndex].FindControl("fupUpdatePC_Graphics");
        Image img = (Image)gvGraphics.Rows[e.RowIndex].FindControl("imgUpdatePC_Graphics");
        if (f != null)
        {
            if (f.HasFile)
            {
                //上传图片
                f.PostedFile.SaveAs(Server.MapPath(@"~\images\pc\" + f.FileName));
                //修改update语句的参数值
                dsGraphics.UpdateParameters["Images"].DefaultValue = @"~\images\pc\" + f.FileName;
            }
            else
            {
                dsGraphics.UpdateParameters["Images"].DefaultValue = img.ImageUrl;
            }
        }


    }


    /// <summary>
    ///编辑内存条时修改图片
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>

    protected void gvMemory_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {

        FileUpload f = (FileUpload)gvMemory.Rows[e.RowIndex].FindControl("fupUpdatePC_Memory");
        Image img = (Image)gvMemory.Rows[e.RowIndex].FindControl("imgPC_Memory");
        if (f != null)
        {
            if (f.HasFile)
            {
                //上传图片
                f.PostedFile.SaveAs(Server.MapPath(@"~\images\pc\" + f.FileName));
                //修改update语句的参数值
                dsMemory.UpdateParameters["Images"].DefaultValue = @"~\images\pc\" + f.FileName;
            }
            else
            {
                dsMemory.UpdateParameters["Images"].DefaultValue = img.ImageUrl;
            }
        }


    }
    protected void gvT_shirt_RowUpdating1(object sender, GridViewUpdateEventArgs e)
    {
        FileUpload f = (FileUpload)gvT_shirt.Rows[e.RowIndex].FindControl("fupUpdateT_shirt");
        Image img = (Image)gvT_shirt.Rows[e.RowIndex].FindControl("ImgUPdateT_shirt");
        if (f != null)
        {
            if (f.HasFile)
            {
                //上传图片
                f.PostedFile.SaveAs(Server.MapPath(@"~\images\txu\" + f.FileName));
                //修改update语句的参数值
                dsT_shirt.UpdateParameters["T_shirtImages"].DefaultValue = @"~\images\txu\" + f.FileName;
            }
            else
            {
                dsT_shirt.UpdateParameters["T_shirtImages"].DefaultValue = img.ImageUrl;
            }
        }
    }
}