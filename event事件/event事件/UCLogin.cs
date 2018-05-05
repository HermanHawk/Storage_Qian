using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace event事件
{
    public partial class UCLogin : UserControl
    {
        public UCLogin()
        {
            InitializeComponent();
        }

        private void UCLogin_Load(object sender, EventArgs e)
        {

        }

        //定义了一个用户校验事件
        public event Action<object, UserLoginEventargs> UserLoginValidating;
        private void button1_Click(object sender, EventArgs e)
        {
            //在这里执行用户的校验
            if(UserLoginValidating != null)
            {
                UserLoginEventargs evtObj = new UserLoginEventargs();
                evtObj.IsOk = false;
                evtObj.LoginId = txtUid.Text.Trim();
                evtObj.LoginPassword = txtPwd.Text.Trim();
                UserLoginValidating(this, evtObj);
                if(evtObj.IsOk)
                {
                    this.BackColor = Color.Green;
                }                                       
                else
                {
                    this.BackColor = Color.Red;
                }
            }
        }
    }
    public class UserLoginEventargs : EventArgs
    {

        public string LoginId
        {
            get;
            set;
        }
        public string LoginPassword
        {
            get;
            set;
        }
        public bool IsOk
        {
            get;
            set;
        }
    }
}
