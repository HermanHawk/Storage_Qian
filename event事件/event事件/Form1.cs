using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace event事件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ucLogin1.UserLoginValidating += ucLogin1_UserLoginValidating; 
        }

        void ucLogin1_UserLoginValidating(object arg1, UserLoginEventargs arg2)
        {
            //throw new NotImplementedException();
            if(arg2.LoginId == "admin" && arg2.LoginPassword  == "888888")
            {
                arg2.IsOk = true;
            }
        }

        /// <summary>
        /// 事件的校验方法
        /// </summary>
        //private void ucLogin1_UserLoginValidating()
        //{
        //    //throw new NotImplementedException();
        //    //要获取用户输入的内容，然后校验
        //}
    }
  
}
