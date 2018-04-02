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

namespace 省市联动
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProvince();
        }

        private void LoadProvince()
        {
            string sql = "select AreaId,AreaName from Area where AreaPId = @PId";
            SqlParameter p1 = new SqlParameter("@PId", SqlDbType.NVarChar, 50) { Value = 0 };
            
            using (SqlDataReader reader = SqlHelper.ExecuteReader(sql,p1))
            {
                if(reader.HasRows)
                {
                    while (reader.Read())
                    {
                        TbArea model = new TbArea();
                        model.AreaId = reader.GetInt32(0);
                        model.AreaName = reader.GetString(1);
                        comboBox1.Items.Add(model);
                    }
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
             * 获取当前用户选择的省份Id
             * 根据ID从数据库中查找对应的值
             */
            if(comboBox1.SelectedItem != null)
            {
                TbArea model = comboBox1.SelectedItem as TbArea;
                int areaId = model.AreaId;
                List<TbArea> cities = GetSubCity(areaId);

                comboBox2.DisplayMember = "AreaName";
                comboBox2.ValueMember = "AreaId";
                comboBox2.DataSource = cities;

            }
        }

        private List<TbArea> GetSubCity(int areaId)
        {
            List<TbArea> list = new List<TbArea>();
            string sql = "select AreaId,AreaName from Area where AreaPId = @Id";
            SqlParameter p1 = new SqlParameter("@Id", SqlDbType.NVarChar, 50) { Value = areaId };
            using(SqlDataReader reader = SqlHelper.ExecuteReader(sql,p1))
            {
                if(reader.HasRows)
                {
                    while(reader.Read())
                    {
                        TbArea model = new TbArea();
                        model.AreaId = reader.GetInt32(0);
                        model.AreaName = reader.GetString(1);
                        list.Add(model);
                    }
                }
            }
            return list;
        }
    }
}
