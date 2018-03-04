using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 石头剪刀布
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = "石头";
            JudgeText(str);
            
        }

        private void JudgeText(string str)
        {
            lblPlayer.Text = str;

            Player player = new Player();
            int playerNumber = player.PlayerNumber(str);

            Conputer cpu = new Conputer();
            int computerNumber = cpu.CompurerNumber();
            lblComputer.Text = cpu.fist;

            lblJudge.Text = Judge.GetType(playerNumber, computerNumber).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str = "剪刀";
            JudgeText(str);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string str = "布";
            JudgeText(str);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //lblPlayer.Text = " ";
            //lblComputer.Text = " ";
            //lblJudge.Text = " ";
            string str = "石头";
            JudgeText(str);
        }
    }
}
