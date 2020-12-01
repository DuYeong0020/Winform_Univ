using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotePadWindowsFormsApp
{
    public partial class DataSpreadForm : Form
    {
        public DataSpreadForm()
        {
            InitializeComponent();
            analysisDataGrid.CellClick += analysisDataGrid_CellClick; // 시험

            dt = new DataTable();
        }
         
        private void analysisDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            MessageBox.Show("셀을 클릭하였습니다.");
            int rowIndex = e.RowIndex;
            int columnIndex = e.ColumnIndex;
            string selectedData = dt.Rows[rowIndex][columnIndex].ToString();
            lbSelectedData.Text = selectedData;
            // analysisDataGrid.Rows[rowIndex].Cells[columnIndex].ToString();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dt.Rows.Count > 0)
            {
                dt.Rows.RemoveAt(0);
            }
        }
        private void selectedDataGroupBox_Enter(object sender, EventArgs e)
        {

        }
        DataTable dt;
        private void btnInit_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            dt.Columns.Add("SEQ");
            dt.Columns.Add("ID");
            dt.Columns.Add("P_1");
            dt.Columns.Add("P_2");
            dt.Columns.Add("P_3");
            dt.Columns.Add("P_4");
            Random rd = new Random();
            for(int i=1; i<=10;i++)
            {
                dt.Rows.Add(i,"s"+i,rd.NextDouble(),rd.NextDouble(), rd.NextDouble(), rd.NextDouble());
            }
            analysisDataGrid.DataSource = dt;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            int nNum = dt.Rows.Count + 1;
            dt.Rows.Add(nNum, "s"+nNum,rd.NextDouble(), rd.NextDouble(), rd.NextDouble(), rd.NextDouble());
        }

        private void pnlTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void analysisDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lbSelectedData_Click(object sender, EventArgs e)
        {

        }
    }
}
