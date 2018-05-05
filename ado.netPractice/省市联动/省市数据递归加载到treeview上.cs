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
    public partial class 省市数据递归加载到treeview上 : Form
    {
        public 省市数据递归加载到treeview上()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadAreasToTreeview(0, this.treeView1.Nodes);
        }

        /// <summary>
        /// 将指定的ID下的节点加载到nodes集合中
        /// </summary>
        /// <param name="pid"></param>
        /// <param name="treeNodeCollection"></param>
        private void LoadAreasToTreeview(int pid, TreeNodeCollection treeNodeCollection)
        {
            //1.根据pID查询下面的所有的子城市
            List<TbArea> list = GetAreaParentId(pid);
            //2.把这些城市加载到TreeView中
            //遍历list集合把数据加载到treeNodeCollection中
            foreach (TbArea item in list)
            {
                TreeNode node = treeNodeCollection.Add(item.AreaName);
                node.Tag = item.AreaId;

                //下面这句话实现里递归
                LoadAreasToTreeview(item.AreaId, node.Nodes);
            }
        }

        private List<TbArea> GetAreaParentId(int pid)
        {

            List<TbArea> list = new List<TbArea>();
            string sql = "select AreaId,AreaName from Area where AreaPId = @Id";
            SqlParameter p1 = new SqlParameter("@Id", SqlDbType.NVarChar, 50) { Value = pid };
            using (SqlDataReader reader = SqlHelper.ExecuteReader(sql, p1))
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
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
