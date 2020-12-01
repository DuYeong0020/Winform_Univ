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

namespace DB2FormsApp
{
    public partial class DBForm : Form
    {
        public DBForm()
        {
            InitializeComponent();
            this.Text = "201730231 최두영";
            btnInit.Click += BtnInit_Click;
        }
        private static string mySqlConnStr
            = "Server=61.84.24.210;Database=myprog;Uid=winprog;Pwd=winprog2020!";
        DataSet ds;
        private void BtnInit_Click(object sender, EventArgs e)
        {
            try
            {
                ds = new DataSet();
                MySqlConnection conn = new MySqlConnection(mySqlConnStr);
                StringBuilder sb = new StringBuilder();
               
                sb.Append(" select id as ID ");
                if (cbName.Checked)
                    sb.Append(" , name as 이름 ");
                if (cbDept.Checked)
                    sb.Append(" , dept as 부서 ");
                if (cbJob.Checked)
                    sb.Append(" , job as 직군 ");
                if (cbLevel.Checked)
                    sb.Append(" , level as 직위 ");
                if (cbSalary.Checked)
                    sb.Append(" , salary as 봉급 ");
                if (cbEmail.Checked)
                    sb.Append(" , email as 이메일 ");

                sb.Append(" from mycompany2 ");
                sb.Append(" where 1=1 ");
                if (!string.IsNullOrEmpty(txtCont.Text))
                {
                    sb.Append(" and ");
                    sb.Append(txtCont.Text);
                    MessageBox.Show(txtCont.Text);
                }
                MySqlDataAdapter adapter = new MySqlDataAdapter(sb.ToString(), conn);
                adapter.Fill(ds, "mycompany2");
                myComDataGridView.DataSource =  ds.Tables[0];

                
                
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnInit_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtCont_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
