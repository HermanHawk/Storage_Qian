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
    public partial class ChangePwd : Form
    {
        public ChangePwd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
             * 1.采集用户输入
             * 2.验证两次输入的新密码
             * 3.验证旧密码
             * 4.更新密码
             */

            string oldPwd = textBox1.Text;
            string newPwd1 = textBox2.Text;
            string newPwd2 = textBox3.Text;

            if(newPwd1 == newPwd2 )
            {
                if( CheckOldPwd(oldPwd,StorageId._UserId) )
                {
                   //修改密码
                    if(UpdatePassword(StorageId._UserId,newPwd1))
                    {
                        MessageBox.Show("密码修改成功");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("修改失败","提示");
                    }
                }
                else
                {
                    MessageBox.Show("密码输入错误", "提示");
                }
            }
            else
            {
                MessageBox.Show("两次输入的密码不一致", "提示");
            }

        }

        private bool UpdatePassword(int userId, string newPwd1)
        {
            string constr = "Data Source = .;Initial Catalog = db_travel;Integrated Security = True";
            using (SqlConnection con = new SqlConnection(constr))
            {

                //string sql = string.Format("select  count(*) from Users  where UserName='{0}' and Pwd = '{1}'", loginId, loginPwd);
                string sql = string.Format("update Users set Pwd = '{1}' where UserId = {0} ", userId, newPwd1);
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    con.Open();
                    int r = cmd.ExecuteNonQuery();
                    return r > 0;
                }
            }
        }

        private bool CheckOldPwd(string oldPwd, int userId)
        {
            string constr = "Data Source = .;Initial Catalog = db_travel;Integrated Security = True";
            using (SqlConnection con = new SqlConnection(constr))
            {

                //string sql = string.Format("select  count(*) from Users  where UserName='{0}' and Pwd = '{1}'", loginId, loginPwd);
                string sql = string.Format("select count(*) from Users where UserId = {0} and Pwd = '{1}'",userId,oldPwd);
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    con.Open();
                    int r =(int) cmd.ExecuteScalar();
                    return r > 0;
                } 
            }
        }
    }
}
