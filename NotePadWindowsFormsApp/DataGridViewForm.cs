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

namespace NotePadWindowsFormsApp
{
    public partial class DataGridViewForm : Form
    {
        public DataGridViewForm()
        {
            InitializeComponent();
            this.Text = "20201234 홍길동";
            //            DataGridViewSetup();
            DataGridViewInit();
        }

        private void DataGridViewInit()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("A");
            dt.Columns.Add("B");
            dt.Columns.Add("C");
            dt.Columns.Add("D");
            dt.Rows.Add("A1", "B1", "C1", "D1");
            dt.Rows.Add("A2", "B2", "C2", "D2");
            dt.Rows.Add("A3", "B3", "C3", "D3");
            dt.Rows.Add("A4", "B4", "C4", "D4");
            dataGridView.DataSource = dt;
        }

        private void DataGridViewSetup()
        {
            dataGridView.ColumnCount = 5;
            dataGridView.Columns[0].Name = "이름";
            dataGridView.Columns[1].Name = "전화번호";
            dataGridView.Columns[2].Name = "소속";
            dataGridView.Columns[3].Name = "관계";
            dataGridView.Columns[4].Name = "비고";
        }

        private void DataGridViewSetup(string rowValue)
        {
            dataGridView.Columns.Clear();
            string[] columns = rowValue.Split(',');
            dataGridView.ColumnCount = columns.Length;
            for (int i = 0; i < columns.Length; i++)
            {
                dataGridView.Columns[i].Name = columns[i];
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //저장 로직
            saveFileDialog.Filter = "CSV (*.csv)|*.csv";
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(
                    saveFileDialog.FileName, false, Encoding.Default);
                string strHeader = "";
                for (int i = 0; i < dataGridView.Columns.Count; i++)
                {
                    strHeader += dataGridView.Columns[i].HeaderText + ",";
                }
                sw.WriteLine(strHeader);
                for (int i = 0; i < dataGridView.RowCount; i++)
                {
                    string strRowValue = "";
                    for (int j = 0; j < dataGridView.Columns.Count; j++)
                    {
                        strRowValue += dataGridView.Rows[i].Cells[j].Value + ",";
                    }
                    sw.WriteLine(strRowValue);
                }
                sw.Close();
            }

            //////저장 로직
            ////saveFileDialog.Filter = "텍스트파일 (*.txt)|*.txt";
            ////if(saveFileDialog.ShowDialog() == DialogResult.OK)
            ////{
            ////    StreamWriter sw = new StreamWriter
            ////        (saveFileDialog.FileName, false, Encoding.Default);
            ////    sw.Write(txtContent.Text);
            ////    sw.Close();
            ////}
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            //열기 로직
            openFileDialog.Filter = "CSV(*.csv)|*.csv";
            if(openFileDialog.ShowDialog()==DialogResult.OK)
            {

                StreamReader sr = new StreamReader(
                    openFileDialog.FileName, Encoding.Default);
                string rowValue = sr.ReadLine();
                DataGridViewSetup(rowValue);

                string[] cellValue;
                dataGridView.Rows.Clear();
                while(sr.Peek()!=-1)
                {
                    rowValue = sr.ReadLine();
                    cellValue = rowValue.Split(',');
                    dataGridView.Rows.Add(cellValue);
                }
                sr.Close();
            }

            //////열기 로직
            ////openFileDialog.Filter = "텍스트 파일 (*.txt)|*.txt";
            ////if(openFileDialog.ShowDialog() == DialogResult.OK)
            ////{
            ////    StreamReader sr = new StreamReader(
            ////        openFileDialog.FileName, Encoding.Default);
            ////    txtContent.Text = sr.ReadToEnd();
            ////    sr.Close();
            ////}
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            dataGridView.Rows.Add();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            dataGridView.Rows.RemoveAt(0);
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
