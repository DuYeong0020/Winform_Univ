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
using PlayerDataClassLibrary;

namespace PlayerManager
{
    public partial class PlayerMGTForm : Form
    {
        public PlayerMGTForm()
        {
            InitializeComponent();
            btnSearch.Click += BtnSearch_Click;
            InitData();
            
        }

        private void InitData()
        {
            checkedListBoxPlayer.Items.Clear();
            checkedListBoxPlayer.Items.Add(PlayerDataSon.name);
            checkedListBoxPlayer.Items.Add(PlayerDataPark.name);
 
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string strPlayers = ""; // 연산을 위한 변수
            for (int i = 0; i < checkedListBoxPlayer.CheckedItems.Count; i++)
            {
                strPlayers += checkedListBoxPlayer.CheckedItems[i].ToString();
                strPlayers += ", ";
            }
            if (strPlayers.Length >= 2)
                strPlayers = strPlayers.Remove(strPlayers.Length - 2, 2);
            lbPlayer.Text = strPlayers;

            DataDraw();
            ChartDraw();
          
        }

        private void ChartDraw()
        {
            myChart.Series.Clear();
            for (int i = 0; i < checkedListBoxPlayer.CheckedItems.Count; i++)
            {
                Series[] serieses = new Series[checkedListBoxPlayer.CheckedItems.Count];
                if(checkedListBoxPlayer.CheckedItems[i].Equals(PlayerDataClassLibrary.PlayerDataSon.name))
                {
                    serieses[i] = new Series(PlayerDataSon.name);
                    serieses[i].Points.AddXY("공격", PlayerDataSon.offense);
                    serieses[i].Points.AddXY("수비", PlayerDataSon.defense);
                    serieses[i].Points.AddXY("스피드", PlayerDataSon.speed);
                    serieses[i].Points.AddXY("패스", PlayerDataSon.pass);
                    serieses[i].Points.AddXY("슛", PlayerDataSon.shoot);
                    myChart.Series.Add(serieses[i]);
                }
                if (checkedListBoxPlayer.CheckedItems[i].Equals(PlayerDataPark.name))
                {
                    serieses[i] = new Series(PlayerDataPark.name);
                    serieses[i].Points.AddXY("공격", PlayerDataPark.offense);
                    serieses[i].Points.AddXY("수비", PlayerDataPark.defense);
                    serieses[i].Points.AddXY("스피드", PlayerDataPark.speed);
                    serieses[i].Points.AddXY("패스", PlayerDataPark.pass);
                    serieses[i].Points.AddXY("슛", PlayerDataPark.shoot);
                    myChart.Series.Add(serieses[i]);
                }
            }
        }

        private void DataDraw()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("이름");
            dt.Columns.Add("공격");
            dt.Columns.Add("수비");
            dt.Columns.Add("스피드");
            dt.Columns.Add("패스");
            dt.Columns.Add("슛");
            dt.Columns.Add("평균치");
         

            // 연산
            myDataGridView.DataSource = dt;
            for (int i = 0; i < checkedListBoxPlayer.CheckedItems.Count; i++)
            {
                
                if(checkedListBoxPlayer.CheckedItems[i].Equals(PlayerDataSon.name))
                {
                    double avg = PlayerDataClassLibrary.DataUtil.GetAvg(new int[] {
                       PlayerDataSon.offense,
                        PlayerDataSon.defense,
                        PlayerDataSon.speed,
                        PlayerDataSon.pass,
                        PlayerDataSon.shoot});
                    dt.Rows.Add(PlayerDataSon.name
                        , PlayerDataSon.offense,
                        PlayerDataSon.defense,
                        PlayerDataSon.speed,
                        PlayerDataSon.pass,
                        PlayerDataSon.shoot,
                        avg);
                }
                if (checkedListBoxPlayer.CheckedItems[i].Equals(PlayerDataPark.name))
                {
                    double avg = DataUtil.GetAvg(new int[] {
                       PlayerDataPark.offense,
                        PlayerDataPark.defense,
                        PlayerDataPark.speed,
                        PlayerDataPark.pass,
                        PlayerDataPark.shoot});
                    dt.Rows.Add(PlayerDataPark.name
                        , PlayerDataPark.offense,
                        PlayerDataPark.defense,
                        PlayerDataPark.speed,
                        PlayerDataPark.pass,
                        PlayerDataPark.shoot
                        ,avg);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void myChart_Click(object sender, EventArgs e)
        {

        }
    }
}
