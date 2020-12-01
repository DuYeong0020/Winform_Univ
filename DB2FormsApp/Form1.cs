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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitEvent();
            InitData();
        }

        private void InitData()
        {
            try
            {
                Search();
            }catch(Exception)
            {
                throw;
            }
        }

        private void InitEvent()
        {
            btnInsert.Click += BtnInsert_Click;
            btnSearch.Click += BtnSearch_Click;
            btnUpdate.Click += BtnUpdate_Click;
            btnDelete.Click += BtnDelete_Click;
            dataGridView1.CellClick += DataGridView1_CellClick;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            // 접속하기
            MySqlConnection conn = new MySqlConnection(mySqlConnStr);
            // 오픈
            conn.Open();
            // 데이터 삽입하기 쿼리
            StringBuilder sb = new StringBuilder();
            sb.Append(" delete from myCompany2 ");
            sb.Append(" where ");
            sb.Append(" id = '"); sb.Append(txtId.Text); sb.Append("'");
            string sql = sb.ToString();
            // sql 실행
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            Search();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            // 접속하기
            MySqlConnection conn = new MySqlConnection(mySqlConnStr);
            // 오픈
            conn.Open();
            // 데이터 삽입하기 쿼리
            StringBuilder sb = new StringBuilder();
            sb.Append(" update myCompany2 ");
            sb.Append(" set ");
            sb.Append(" name = '"); sb.Append(txtName.Text); sb.Append("', ");           
            sb.Append(" email = '"); sb.Append(txtEmail.Text); sb.Append("', ");
            sb.Append(" dept = '"); sb.Append(txtDept.Text); sb.Append("', ");
            sb.Append(" job = '"); sb.Append(txtJob.Text); sb.Append("', ");
            sb.Append(" level = '"); sb.Append(txtLevel.Text); sb.Append("', ");
            sb.Append(" fla_type = '"); sb.Append(txtFlaType.Text); sb.Append("', ");
            sb.Append(" fla_value = '"); sb.Append(txtFlaValue.Text); sb.Append("', ");
            sb.Append(" flb_type = '"); sb.Append(txtFlbType.Text); sb.Append("', ");
            sb.Append(" flb_value = '"); sb.Append(txtFlbValue.Text); sb.Append("', ");
            sb.Append(" score = '"); sb.Append(txtScore.Text); sb.Append("', ");
            sb.Append(" salary = '"); sb.Append(txtSalary.Text); sb.Append("' ");
            sb.Append(" where ");
            sb.Append(" id = '"); sb.Append(txtId.Text); sb.Append("'");
            string sql = sb.ToString();
            // sql 실행
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();

            Search();
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
           
            txtId.Text = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
            txtName.Text = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
            txtEmail.Text = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
            txtDept.Text = dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();
            txtJob.Text = dataGridView1.Rows[rowIndex].Cells[4].Value.ToString();
            txtLevel.Text = dataGridView1.Rows[rowIndex].Cells[5].Value.ToString();
            txtFlaType.Text = dataGridView1.Rows[rowIndex].Cells[6].Value.ToString();
            txtFlaValue.Text = dataGridView1.Rows[rowIndex].Cells[7].Value.ToString();
            txtFlbType.Text = dataGridView1.Rows[rowIndex].Cells[8].Value.ToString();
            txtFlbValue.Text = dataGridView1.Rows[rowIndex].Cells[9].Value.ToString();
            txtScore.Text = dataGridView1.Rows[rowIndex].Cells[10].Value.ToString();
            txtSalary.Text = dataGridView1.Rows[rowIndex].Cells[11].Value.ToString();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                Search();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void Search()
        {
            // 데이터 공간 생성
            ds = new DataSet();
            // 접속하기 
            MySqlConnection conn = new MySqlConnection(mySqlConnStr);
            // 오픈
            conn.Open();
            // 데이터 가져오기 쿼리
            string sql = "select * from myCompany2";
            // 비연결 모드 DB연결
            // 비연결 모드 : 데이터베이스에서 가져온 값을 클라이언트 메모리로 저장한 후, 연결을 끊는 방식
            // 즉, 데이털르 가져와서 본 프로그램의 연결 공간에 데이터 저장
            MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);
            // DataSet내에 myCompany2라는 Table공간을 만들어서 저장
            // 즉, DataSource는 여러개의 DataTable을 가질 수 있음
            adpt.Fill(ds, "myCompany2");
            dataGridView1.DataSource = ds.Tables[0];
        }

        private static string mySqlConnStr
            = "Server=61.84.24.210;Database=myprog;Uid=winprog;Pwd=winprog2020!";
        DataSet ds;
        private void BtnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                // 데이터 공간 생성
                ds = new DataSet();
                // 접속하기
                MySqlConnection conn = new MySqlConnection(mySqlConnStr);
                // 오픈
                conn.Open();
                // 데이터 가져오기 쿼리
                StringBuilder sb = new StringBuilder();
                sb.Append(" insert into myCompany2 ");
                sb.Append(" values ( ");
                sb.Append(" '"); sb.Append(txtId.Text); sb.Append("', ");
                sb.Append(" '"); sb.Append(txtName.Text); sb.Append("', ");
                sb.Append(" '"); sb.Append(txtEmail.Text); sb.Append("', ");
                sb.Append(" '"); sb.Append(txtDept.Text); sb.Append("', ");
                sb.Append(" '"); sb.Append(txtJob.Text); sb.Append("', ");
                sb.Append(" '"); sb.Append(txtLevel.Text); sb.Append("', ");
                sb.Append(" '"); sb.Append(txtFlaType.Text); sb.Append("', ");
                sb.Append(" '"); sb.Append(txtFlaValue.Text); sb.Append("', ");
                sb.Append(" '"); sb.Append(txtFlbType.Text); sb.Append("', ");
                sb.Append(" '"); sb.Append(txtFlbValue.Text); sb.Append("', ");
                sb.Append(" '"); sb.Append(txtScore.Text); sb.Append("', ");
                sb.Append(" '"); sb.Append(txtSalary.Text); sb.Append("'");
                sb.Append(" ) ");
                string sql = sb.ToString();
                // sql 실행
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                // search호출
                // 리팩토링 코드 추출
                // Search();
                Search();
            } catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {

        }
    }
}
