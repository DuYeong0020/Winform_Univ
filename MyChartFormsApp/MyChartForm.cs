using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MyChartFormsApp
{
    public partial class MyChartForm : Form
    {
        DataSet ds;
        private static string mySqlConnStr
            = "Server=61.84.24.210;Database=myprog;Uid=winprog;Pwd=winprog2020!";
        public MyChartForm()
        {
            InitializeComponent();
            cbTypeInit();
            InitControl();
            btnDraw.Click += BtnDraw_Click;
            
            
            
        }

        private void InitControl()
        {
            this.Text = "201730231 최두영";
            ds = new DataSet();
            MySqlConnection conn = new MySqlConnection(mySqlConnStr);
            try
            {
                conn.Open();
                StringBuilder sb = new StringBuilder();
                sb.Append(" select id as 학번");
                sb.Append(" from quiz2 ");
                sb.Append(" order by id ");
                string sql = sb.ToString();
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
                adapter.Fill(ds, "quiz2");
                cbIDInit();
                
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        private void cbIDInit()
        {
            cbID.Items.Clear();
            for (int i = 0; i < ds.Tables["quiz2"].Rows.Count; i++)
            {
                cbID.Items.Add(ds.Tables["quiz2"].Rows[i][0].ToString());
                
            }
        }

        private void cbTypeInit()
        {
            cbType.Items.Clear();
            cbType.Items.Add("Column");
            cbType.Items.Add("Bar");
            cbType.Items.Add("Pie");
            cbType.Items.Add("Bubble");
            cbType.Items.Add("Doughnut");
            cbType.Items.Add("Point");
        }

        private void BtnDraw_Click(object sender, EventArgs e)
        {
            ds = new DataSet();
            MySqlConnection conn = new MySqlConnection(mySqlConnStr);
            try
            {
                conn.Open();
                StringBuilder sb = new StringBuilder();
                sb.Append(" select id as 학번");
                sb.Append(" , name as 이름");
                sb.Append(" , eng as 영어");
                sb.Append(" , math as 수학");
                sb.Append(" from quiz2");
                sb.Append(" where 1=1");
                if(!string.IsNullOrEmpty(cbID.Text))
                {
                    sb.Append(" and ");
                    sb.Append(" id = ");
                    sb.Append("'");
                    sb.Append(cbID.Text);
                    sb.Append("'");
                }
                sb.Append("");
                string sql = sb.ToString();
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
                adapter.Fill(ds, "quiz2");

                Series s1 = new Series(ds.Tables[0].Rows[0]["이름"].ToString());
                string[] xValues = { "영어", "수학" };
                int[] yValues =
                {
                    int.Parse(ds.Tables[0].Rows[0]["영어"].ToString()),
                    int.Parse(ds.Tables[0].Rows[0]["수학"].ToString())
                };
                
                myChart.Series.Clear();
                
                
                
                
                int[] yValue = { 10000, 3000, 2000 };
                if (cbType.SelectedItem.ToString().Equals("Column"))
                {
                    s1.ChartType = SeriesChartType.Column;
                }
                else if (cbType.SelectedItem.ToString().Equals("Bar"))
                {
                    s1.ChartType = SeriesChartType.Bar;
                }
                else if (cbType.SelectedItem.ToString().Equals("Pie"))
                {
                    s1.ChartType = SeriesChartType.Pie;
                }
                else if (cbType.SelectedItem.ToString().Equals("Bubble"))
                {
                    s1.ChartType = SeriesChartType.Bubble;
                }
                else if (cbType.SelectedItem.ToString().Equals("Doughnut"))
                {
                    s1.ChartType = SeriesChartType.Doughnut;
                }
                else if (cbType.SelectedItem.ToString().Equals("Point"))
                {
                    s1.ChartType = SeriesChartType.Point;
                }
                s1.Points.DataBindXY(xValues, yValues);
                myChart.Series.Add(s1);
            }
            catch(Exception)
            {
                throw;
            }

            

        }

        private void myChart_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
