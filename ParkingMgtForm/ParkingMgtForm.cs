using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingMgtForm
{
    public partial class ParkingMgtForm : Form
    {
        ArrayList carNumberList;
        List<Car> cars = new List<Car>();
        Car car;
        int seq = 0;
        public ParkingMgtForm()
        {
            InitializeComponent();
            // 이벤트 연결 코드
            btnCarIn.Click += BtnCarIn_Click; // 시험문제에 나온다. += 하고 tab
            btnCarOut.Click += BtnCarOut_Click;
            this.Text = "201730231 최두영";
            
            carNumberList = new ArrayList();
        }

        private void BtnCarOut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CAR OUT");
            foreach(var car in cars)
            {
                if(car.CarNumber.Contains(cboCarList.Text))
                {
                    car.SetOutTime();
                    StringBuilder sb = new StringBuilder();
                    sb.Append("차량번호 : ");
                    sb.Append(car.CarNumber);
                    sb.Append(" [출차시간] ");
                    sb.Append(car.GetOutTime());
                    listBoxState.Items.Add(sb.ToString());

                    DateTime parkingTime = GetParkingTime(car.GetInTime(), car.GetOutTime());
                    string fee = GetParkingFee(parkingTime);

                    sb.Clear();
                    sb.Append("입차시간 : " + car.GetInTime());
                    sb.AppendLine();
                    sb.Append("출차시간 : " + car.GetOutTime());
                    sb.AppendLine();
                    sb.Append("주차시간 : " + parkingTime.Hour+"시");
                    sb.Append(parkingTime.Minute + "분");
                    sb.Append(parkingTime.Second + "초");
                    sb.AppendLine();

                    sb.Append("주차요금 " + fee);
                    MessageBox.Show(sb.ToString());

                    cars.Remove(car); // 리스트에서 제거
                    break;
                }

            }
            carNumberList.Remove(cboCarList.Text);
            cboCarList.Items.Clear();
            cboCarList.Items.AddRange(carNumberList.ToArray());
            lbState.Text = cars.Count.ToString();
        }
        private string GetParkingFee(DateTime parkingTime)
        {
            int hour = parkingTime.Hour;
            int min = parkingTime.Minute;
            int sec = parkingTime.Second;
            int fee = hour * 3600 + min * 600 + sec + 10;
          
            return fee + "원";
        }
        private void BtnCarIn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboCarList.Text))
            {
                MessageBox.Show("차량 다시 입력 ");
                return;
            }

            MessageBox.Show("CAR IN");
            car = new Car();
            car.Seq = ++seq;
            car.CarNumber = cboCarList.Text;
            car.SetInTime();
            cars.Add(car);
            // 목적이 구분됨
            carNumberList.Add(cboCarList.Text);
            cboCarList.Items.Clear();
            cboCarList.Items.AddRange(carNumberList.ToArray());
            StringBuilder sb = new StringBuilder();
            sb.Append("차량번호 : ");
            sb.Append(cboCarList.Text);
            sb.Append(" [입고시간] ");
            sb.Append(car.GetInTime());
            listBoxState.Items.Add(sb.ToString());
            Console.WriteLine("현재 차량 대수 : " + cars.Count);
            lbState.Text = cars.Count.ToString();
            
            
        }
        public DateTime GetParkingTime(DateTime inTime, DateTime outTime)
        {
            DateTime parkingTime;
            double oAInTime = inTime.ToOADate();
            double oAOutTime = outTime.ToOADate();
            double oAParkingTime = oAOutTime - oAInTime;
            parkingTime = DateTime.FromOADate(oAParkingTime);
            return parkingTime;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBoxState_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCarIn_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnCarOut_Click_1(object sender, EventArgs e)
        {

        }

        private void cboCarList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cboCarList_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
