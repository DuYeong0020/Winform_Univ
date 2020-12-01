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
    public partial class NotePadForm : Form
    {
        public NotePadForm()
        {
            InitializeComponent();
            this.Text = "20201234 홍길동";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //저장 로직
            saveFileDialog.Filter = "텍스트파일 (*.txt)|*.txt";
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter
                    (saveFileDialog.FileName, false, Encoding.Default);
                sw.Write(txtContent.Text);
                sw.Close();
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            //열기 로직
            openFileDialog.Filter = "텍스트 파일 (*.txt)|*.txt";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(
                    openFileDialog.FileName, Encoding.Default);
                txtContent.Text = sr.ReadToEnd();
                sr.Close();
            }
        }

        private void txtContent_TextChanged(object sender, EventArgs e)
        {
              
        }
    }
}
