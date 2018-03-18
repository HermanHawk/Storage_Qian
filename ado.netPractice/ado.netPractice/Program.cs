using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ado.netPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 连接数据库
		            //    //Data Source
            //    //Initial catalog
            //    //Integrated security = true
            //string constr = "Data Source=Herman;Initial Catalog=book;Integtated security=true";
            //using(SqlConnection con = new SqlConnection(constr))
            //{
            //    con.Open();
            //    //con.Close();
            //    //con.Dispose(); 	
            //}
               #endregion

            #region （增）数据库的插入
             //1.连接字符串
             //2.创建连接对象
             //3.打开连接 (连接对象最晚打开，最早关闭！节省资源)
             //4.编写sql语句
             //5.创建执行sql语句的对象 (命令对象)sqlcommand
             //6.执行sql语句



            //string constr = "Data Source = DESKTOP-QP00RIV;Initial Catalog = db_travel;Integrated Security = True";
                                                        
            //using(SqlConnection con = new SqlConnection(constr))
            //{
              
            //    //深圳 兰州 1823 23
            //    string sql = "Insert into dbo.allservice values('深圳','兰州',1823,23)";
            //    using(SqlCommand cmd = new SqlCommand(sql,con))
            //    {
            //        con.Open();
            //        int r = cmd.ExecuteNonQuery();
            //        //cmd.ExecuteNonQuery();//insert，delete，update语句时
            //                                // 这个方法有int返回值，表示执行insert，delete，update语句后，所影响的行数（！！！只有执行insert，delete，update语句时候才会返回所影响的行数，执行任何其他sql语句永远返回-1.）  
            //        //cmd.ExecuteScalar(); //当执行返回单个结果的时候
            //        //cmd.ExecuteReader(); //当查询出多行多列结果的时候
            //        Console.WriteLine("成功插入了{0}条记录",r);

            //    }
            //}

            #endregion

            #region   (删)  数据库的删除
            
                 /*
                  * 1.连接字符串
                  * 2.创建连接对象
                  * 3.sql语句
                  * 4.sql语句执行的对象
                  * 5.打开连接
                  * 6.执行
                  */



            //string constr2 = "Data source = .;Initial Catalog = db_travel;Integrated Security = True";
            //using (SqlConnection con2 = new SqlConnection(constr2))
            //{
            //    string sql2 = "delete from dbo.allservice where ID = 23";
            //    using (SqlCommand cmd2 = new SqlCommand(sql2, con2))
            //    {
            //        con2.Open();
            //        int r2 = cmd2.ExecuteNonQuery();
            //        Console.WriteLine("成功删除了{0}条记录", r2);
            //    }
            //}
            #endregion

            #region   （改）修改操作
            //string constr3 = "Data source = .;Initial Catalog = db_travel;Integrated Security = True";
            //using (SqlConnection con3 = new SqlConnection(constr3))
            //{
            //    string sql3 = "update dbo.allservice set allSsta = '北京',allEsta = '深圳',allPrice = 1632 where ID = 23";
            //    using (SqlCommand cmd3 = new SqlCommand(sql3, con3))
            //    {
            //        con3.Open();
            //        int r3 = cmd3.ExecuteNonQuery();
            //        Console.WriteLine("成功更新了{0}条记录", r3);
            //    }
            //}
            #endregion

            #region   （查）简单的单行查询
            //string constr4 = "Data source = .;Initial Catalog = db_travel;Integrated Security = True";
            //using (SqlConnection con4 = new SqlConnection(constr4))
            //{
            //    string sql4 = "select COUNT (*) from AllService";
            //    using (SqlCommand cmd4 = new SqlCommand(sql4, con4))
            //    {
            //        con4.Open();
            //        //int count = (int)cmd4.ExecuteScalar();                  
            //        //object count = Convert.ToInt32(cmd4.ExecuteScalar());  字符串转int不会出错
            //        object count = cmd4.ExecuteScalar();
            //        Console.WriteLine("共有{0}条记录", count);
            //    }
            //}
            #endregion

            #region 查 reader查询

            string constr = " Data source = .;Initial Catalog = db_travel;Integrated Security = True";
            using (SqlConnection con = new SqlConnection(constr))
            {
                string sql = "select * from AllService";
                using (SqlCommand cmd = new SqlCommand (sql,con))
                {
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if(reader.HasRows)
                        {
                            while(reader.Read())
                            {
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    Console.Write(reader[i] + "\t");
                                    
                                }                         
                                Console.WriteLine();
                            }
                        }
                        else
                        {
                            Console.WriteLine("没有查询到数据");
                        }
                    }
                }
            }
            #endregion

        }
    }
}
