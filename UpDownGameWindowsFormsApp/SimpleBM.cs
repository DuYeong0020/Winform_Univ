using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UpDownGameWindowsFormsApp
{
    public partial class SimpleBM : Form
    {
        public SimpleBM()
        {
            InitializeComponent();
            //초기UI설정
            InitControl();
        }

        private void InitControl()
        {
            cbCoin.Items.Clear();
            cbCoin.Items.Add("100");
            cbCoin.Items.Add("500");
            cbCoin.Items.Add("1000");
        }

        int money = 0;

        private void btnCoin_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(cbCoin.Text))
            {
                MessageBox.Show("금액을 투입하세요.");
                return;
            }
            money += int.Parse(cbCoin.SelectedItem.ToString());
            lbChangesValue.Text = money.ToString();
        }

        private void btnCoke500_Click(object sender, EventArgs e)
        {
            if(money>=500)
            {
                money -= 500; // money = money - 500;
                MessageBox.Show("콜라가 나왔습니다.");
                lbChangesValue.Text = money.ToString();
            }
            else
            {
                MessageBox.Show("잔액이 부족합니다.");
            }
        }

        private void btnCider300_Click(object sender, EventArgs e)
        {
            if(money < 300)
            {
                MessageBox.Show("잔액이 부족합니다.");
                return;
            }
            
            MessageBox.Show("사이다가 나왔습니다.");
            money -= 300;
            lbChangesValue.Text = money.ToString();
        }

        private void btnCoffee700_Click(object sender, EventArgs e)
        {
            if (money < 700)
            {
                MessageBox.Show("잔액이 부족합니다.");
                return;
            }

            MessageBox.Show("커피가 나왔습니다.");
            money -= 700;
            lbChangesValue.Text = money.ToString();
        }

        private void btnChanges_Click(object sender, EventArgs e)
        {
            //환전 이벤트 구현
            if(money > 0)
            {
                MessageBox.Show(money+"원이 환전 되었습니다.");
                money = 0;
                lbChangesValue.Text = "-";
                cbCoin.Text = "";
            }
            else
            {
                MessageBox.Show("환전될 금액이 없습니다.");
            }
        }

        private void cbCoin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SimpleBM_Load(object sender, EventArgs e)
        {

        }
    }
}
