using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            musicPlayer.Ctlcontrols.play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            musicPlayer.Ctlcontrols.pause();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            musicPlayer.Ctlcontrols.stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            musicPlayer.settings.autoStart = false;
            //musicPlayer.URL = @" G:\迅雷下载\[歌手]0128期：迪玛希大秀海豚音挑战超高音域_bd.mp4";
        }
        List<string> listPath = new List<string>();

        private void btnPlayerOrPause_Click(object sender, EventArgs e)
        {
             if(btnPlayerOrPause.Text == "播放")
             {
                 musicPlayer.Ctlcontrols.play();
                 btnPlayerOrPause.Text = "暂停";
             }
             else if(btnPlayerOrPause.Text == "暂停")
             {
                 musicPlayer.Ctlcontrols.pause();
                 btnPlayerOrPause.Text = "播放";
             }
        }
           /// <summary>
           /// 打开文件选择器
           /// </summary>
           /// <param name="sender"></param>
           /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"C:\Users\Herman\Desktop\c#_practice\MusicPlayer\music";
            ofd.Title = "请选择音乐文件";
            ofd.Filter = "视频文件|*.wav|音乐文件|*.mp3|所有文件|*.*";
            ofd.Multiselect = true;
            ofd.ShowDialog();

            string[] path = ofd.FileNames;
            for (int i = 0; i < path.Length; i++)
            {
                listPath.Add(path[i]);
                listBox1.Items.Add(Path.GetFileName(path[i]));
                
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if(listBox1.Items.Count == 0)
            {
                MessageBox.Show("请先选择音乐文件");
                return;
            }
            try
            {
                musicPlayer.URL = listPath[listBox1.SelectedIndex];
                musicPlayer.Ctlcontrols.play();
                btnPlayerOrPause.Text = "暂停";
            }                                
            catch { }
        }

    }
}
