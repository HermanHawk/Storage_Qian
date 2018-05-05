using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace 用xml当做数据库实现登录以及增删改查
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadUser();
        }

        private void LoadUser()
        {
            #region 窗体加载的时候把数据加载到listview中
            listView1.Items.Clear();
            //读取xml文件
            XmlDocument document = new XmlDocument();
            document.Load("UserData.xml");
            XmlNodeList nodeLiset = document.SelectNodes("/Users/user");

            //遍历选择到的节点加载到listview中        
            foreach (XmlNode userNode in nodeLiset)
            {
                //创建一个listview的一个项
                ListViewItem lvItem = new ListViewItem(userNode.Attributes["id"].Value);
                //获取节点 
                lvItem.SubItems.Add(userNode.SelectSingleNode("name").InnerText);
                lvItem.SubItems.Add(userNode.SelectSingleNode("password").InnerText);
                listView1.Items.Add(lvItem);
            }
            #endregion
        }
        //增加一个用户
        private void button1_Click(object sender, EventArgs e)
        {
            string id = txtUId.Text.Trim();
            string name = txtLoginUId.Text.Trim();
            string password = txtPassword.Text;

            XmlDocument document = new XmlDocument();
            document.Load("UserData.xml");

            XmlElement root = document.DocumentElement;
            XmlElement userElement = document.CreateElement("user");

            if (document.SelectNodes("/Users/user[@id='" + id + "']").Count > 0)
            {
                MessageBox.Show("ID重复");
            }
            else
            {
                userElement.SetAttribute("id", id);
                XmlElement nameElement = document.CreateElement("name");
                nameElement.InnerText = name;

                XmlElement passwordElement = document.CreateElement("password");
                passwordElement.InnerText = password;

                userElement.AppendChild(nameElement);
                userElement.AppendChild(passwordElement);

                root.AppendChild(userElement);
                document.Save("UserData.xml");
                LoadUser();
                MessageBox.Show("ok");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            XmlDocument document = new XmlDocument();
            document.Load("UserData.xml");

            if(listView1.SelectedItems.Count >0)
            {
                //获取选中行的ID
                string id = listView1.SelectedItems[0].SubItems[0].Text;
                //从xml中找到ID等于用户选择项的ID的user标签
                XmlNode node = document.SelectSingleNode("/Users/user[@id='" + id + "']"); 
                if(node != null)
                { 
                //从文档的根节点开始删除当前选中的节点
                    document.DocumentElement.RemoveChild(node);
                    document.Save("UserData.xml");
                    LoadUser();
                }
            }

        }
         //listview的选中项改变事件
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count>0)
            {
                ListViewItem lv = listView1.SelectedItems[0];
                txtEditUid.Text = lv.SubItems[0].Text;
                txtEditLoginUid.Text = lv.SubItems[1].Text;
                txtEditPassword.Text = lv.SubItems[2].Text;
            }

        }

        /// <summary>
        /// 修改某个节点  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            XmlDocument document = new XmlDocument();
            document.Load("UserData.xml");

            //根据用户选中的ID，先在userdata.xml中找到对应的user节点  
            XmlNode userNode = document.SelectSingleNode("/Users/user[@id='" + txtEditUid.Text.Trim() + "']");
            userNode.SelectSingleNode("name").InnerText = txtEditLoginUid.Text.Trim();
            userNode.SelectSingleNode("password").InnerText = txtEditPassword.Text.Trim();
            document.Save("UserData.xml");
            LoadUser(); 
        }
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            string uid = txtloginUserName.Text.Trim();
            string pwd = txtLoginPassword.Text;

            XmlDocument document = new XmlDocument();
            document.Load("UserData.xml");

            XmlNode node = document.SelectSingleNode("/Users/user/name[.='" + uid + "']");
            if(node!=null)
            {
                if(node.NextSibling.InnerText==pwd)
                {
                    MessageBox.Show("登录成功");
                }  
                else
                {
                    MessageBox.Show("密码错误");
                }
            }
            else
            {
                MessageBox.Show("用户名不存在");
            }
        }


      
    }
}
