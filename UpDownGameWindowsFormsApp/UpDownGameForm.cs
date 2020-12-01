using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UpDownGameWindowsFormsApp
{
    public partial class UpDownGameForm : Form
    {
        public UpDownGameForm()
        {
            InitializeComponent();
        }

        int tryCount = 0;
        int resultNum = 0;
        private void btnInit_Click(object sender, EventArgs e)
        {
            //초기화 버튼 클릭
            Console.WriteLine("초기화 버튼 클릭");
            lbStartTime.Text = DateTime.Now.ToString();
            lbState.Text = "게임 시작! 0~60값을 입력!";
            tryCount = 0;
            lbTryCount.Text = tryCount.ToString();
            Random rdNum = new Random();
            resultNum = rdNum.Next(60);
            txtInput.Text = "";
            btnInput.Enabled = true;
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            //입력 버튼 클릭
            Console.WriteLine("입력 버튼 클릭");
            //로직 완성
            tryCount++;
            //tryCount 값을 활용하여, ProgressBar 게이지 채우기
            IncreaseTryProgressBar(tryCount);

            lbTryCount.Text = tryCount.ToString();
            string input = txtInput.Text;
            int inputValue = int.Parse(input);
            if (resultNum == inputValue)
            {
//                lbState.Text = "정답!" + inputValue + "를 맞추셨습니다.";
                //정답이 수행되었을 경우
                MessageBox.Show("정답! " + inputValue + "를 맞추셨습니다.");
                InitGame();                
            }
            else if (resultNum > inputValue)
            {
                lbState.Text = "Up!" + inputValue + " 보다 큰 값을 입력하세요.";
            }
            else
            {
                lbState.Text = "Down!" + inputValue + " 보다 작은 값을 입력하세요.";
            }
            if( tryCount == 10)
            {
                //시도를 못하게 막기
                CloseGame();
            }
        }

        private void CloseGame()
        {
            lbState.Text = "시도한 횟수를 초과 하였음";
            btnInput.Enabled = false;
        }

        private void IncreaseTryProgressBar(int tryCount)
        {
            tryProgressBar.Value = tryCount * 10;
        }

        private void InitGame()
        {
            lbTryCount.Text = "-";
            lbStartTime.Text = "-";
            lbState.Text = "-";
            txtInput.Text = "";
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tryProgressBar_Click(object sender, EventArgs e)
        {

        }

        private void UpDownGameForm_Load(object sender, EventArgs e)
        {

        }
    }
}
