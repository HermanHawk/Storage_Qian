using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            /*
             * 1.采集数据
             * 2.验证数据库登录
             */
            #region 防SQL注入
            string loginId = txtName.Text.Trim();
            string loginPwd = txtPwd.Text;

            string constr = "Data Source = .;Initial Catalog = db_travel;Integrated Security = True";
            using (SqlConnection con = new SqlConnection(constr))
            {
                //string sql = string.Format("select  count(*) from Users  where UserName='{0}' and Pwd = '{1}'", loginId, loginPwd);
                string sql = "select count(*) from Users where UserName = @LoginUserName and Pwd = @LoginPassword";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {

                    //SqlParameter paraUserName = new SqlParameter("@LoginUserName", SqlDbType.NVarChar, 50) { Value = loginId };
                    //SqlParameter paraPassword = new SqlParameter("@LoginPassword", SqlDbType.NVarChar, 50) { Value = loginPwd };
                    //cmd.Parameters.Add(paraUserName);
                    //cmd.Parameters.Add(paraPassword);

                    SqlParameter[] pms = new SqlParameter[] { 
                                        new SqlParameter("@LoginUserName", SqlDbType.NVarChar, 50) { Value = loginId },
                                        new SqlParameter("@LoginPassword", SqlDbType.NVarChar, 50) { Value = loginPwd }
                    };
                    cmd.Parameters.AddRange(pms);

                    //cmd.Parameters.AddWithValue("@LoginUserName", loginId);
                    //cmd.Parameters.AddWithValue("@LoginPassword", loginPwd);


                    con.Open();
                    int count = (int)cmd.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("登录成功", "提示");
                    }
                    else
                    {
                        MessageBox.Show("登录失败", "提示");
                    }
                }
            } 
            #endregion


            #region 普通验证登录
            //string loginId = txtName.Text.Trim();
            //string loginPwd = txtPwd.Text;

            //string constr = "Data Source = .;Initial Catalog = db_travel;Integrated Security = True";
            //using (SqlConnection con = new SqlConnection(constr))
            //{
            //    string sql = string.Format("select  count(*) from Users  where UserName='{0}' and Pwd = '{1}'", loginId, loginPwd);
            //    using (SqlCommand cmd = new SqlCommand(sql, con))
            //    {
            //        con.Open();
            //        int count = (int)cmd.ExecuteScalar();
            //        if (count > 0)
            //        {
            //            MessageBox.Show("登录成功", "提示");
            //        }
            //        else
            //        {
            //            MessageBox.Show("登录失败", "提示");
            //        }
            //    }
            //} 
            #endregion

        }

        private void button2_Click(object sender, EventArgs e)
        {


            string loginId = txtName.Text.Trim();
            string loginPwd = txtPwd.Text;

           // string constr = "Data Source = .;Initial Catalog = db_travel;Integrated Security = True";
            string constr = "Data Source = .;Initial Catalog = DIY_Shop;Integrated Security = True";
            using (SqlConnection con = new SqlConnection(constr))
            {
               
                //string sql = string.Format("select  count(*) from Users  where UserName='{0}' and Pwd = '{1}'", loginId, loginPwd);
                //string sql = string.Format("select * from Users where UserName = '{0}'",loginId);
                //string sql = "select * from UserInfo where Telephone = @loginId";
                string sql = string.Format("select * from UserInfo where Telephone = '{0}'", loginId);
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if(reader.HasRows)
                        {
                            if(reader.Read())
                            {
                                string Pwd = reader.GetString(2);
                                if(Pwd == loginPwd)
                                {
                                    this.Text = "登录成功";
                                    button3.Enabled = true;
                                    StorageId._UserId = reader.GetInt32(0);
                                }
                                else
                                {
                                    this.Text = "密码错误";
                                }
                            }
                        }
                        else
                        {
                            this.Text = "用户名不存在";
                        }
                    }
                    //int count = (int)cmd.ExecuteScalar();
                    //if (count > 0)
                    //{
                    //    MessageBox.Show("登录成功", "提示");
                    //}
                    //else
                    //{
                    //    MessageBox.Show("登录失败", "提示");
                    //}
                }
            }




        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Form1 f2 = new Form1();
            //f2.Show();
            ChangePwd f2 = new ChangePwd();
            f2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sql = "select count(*) from Users where UserName = @LoginUserName and Pwd = @LoginPassword";
            SqlParameter[] pms = new SqlParameter[] { 
                                        new SqlParameter("@LoginUserName", SqlDbType.NVarChar, 50) { Value = txtName.Text.Trim() },
                                        new SqlParameter("@LoginPassword", SqlDbType.NVarChar, 50) { Value = txtPwd.Text }
                    };
            int count = (int)SqlHelper.ExecuteScalar(sql,System.Data.CommandType.Text ,pms);
            if (count > 0)
            {
                MessageBox.Show("登录成功", "提示");
            }
            else
            {
                MessageBox.Show("登录失败", "提示");
            }
        }
    }
}
