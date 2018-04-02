using LoginPractice;
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

namespace sqlDataAdapter的练习使用
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constr = "Data Source  = .;Initial Catalog = db_travel;Integrated Security = True";
            string sql = "select * from allservice";
            DataTable dt = new DataTable();
            using (SqlDataAdapter adapter = new SqlDataAdapter(sql, constr))
            {
                adapter.Fill(dt);
            }
            this.dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "select * from allservice";
            this.dataGridView1.DataSource = SqlHelper.ExecuteDataTable(sql);
        }
    }
}
