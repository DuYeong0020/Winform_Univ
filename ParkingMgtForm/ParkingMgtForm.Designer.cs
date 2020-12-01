namespace ParkingMgtForm
{
    partial class ParkingMgtForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCarIn = new System.Windows.Forms.Button();
            this.btnCarOut = new System.Windows.Forms.Button();
            this.listBoxState = new System.Windows.Forms.ListBox();
            this.cboCarList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbState = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cboCarList);
            this.panel1.Controls.Add(this.btnCarOut);
            this.panel1.Controls.Add(this.btnCarIn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 54);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listBoxState);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 396);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbState);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 350);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 100);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // btnCarIn
            // 
            this.btnCarIn.Location = new System.Drawing.Point(621, 12);
            this.btnCarIn.Name = "btnCarIn";
            this.btnCarIn.Size = new System.Drawing.Size(76, 32);
            this.btnCarIn.TabIndex = 1;
            this.btnCarIn.Text = "입차";
            this.btnCarIn.UseVisualStyleBackColor = true;
            this.btnCarIn.Click += new System.EventHandler(this.btnCarIn_Click_1);
            // 
            // btnCarOut
            // 
            this.btnCarOut.Location = new System.Drawing.Point(712, 12);
            this.btnCarOut.Name = "btnCarOut";
            this.btnCarOut.Size = new System.Drawing.Size(76, 32);
            this.btnCarOut.TabIndex = 2;
            this.btnCarOut.Text = "출차";
            this.btnCarOut.UseVisualStyleBackColor = true;
            this.btnCarOut.Click += new System.EventHandler(this.btnCarOut_Click_1);
            // 
            // listBoxState
            // 
            this.listBoxState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxState.FormattingEnabled = true;
            this.listBoxState.ItemHeight = 18;
            this.listBoxState.Location = new System.Drawing.Point(0, 0);
            this.listBoxState.Name = "listBoxState";
            this.listBoxState.Size = new System.Drawing.Size(800, 396);
            this.listBoxState.TabIndex = 0;
            this.listBoxState.SelectedIndexChanged += new System.EventHandler(this.listBoxState_SelectedIndexChanged);
            // 
            // cboCarList
            // 
            this.cboCarList.FormattingEnabled = true;
            this.cboCarList.Location = new System.Drawing.Point(407, 16);
            this.cboCarList.Name = "cboCarList";
            this.cboCarList.Size = new System.Drawing.Size(175, 26);
            this.cboCarList.TabIndex = 3;
            this.cboCarList.SelectedIndexChanged += new System.EventHandler(this.cboCarList_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "현재 차량 대수 : ";
            // 
            // lbState
            // 
            this.lbState.AutoSize = true;
            this.lbState.Location = new System.Drawing.Point(164, 45);
            this.lbState.Name = "lbState";
            this.lbState.Size = new System.Drawing.Size(0, 18);
            this.lbState.TabIndex = 1;
            // 
            // ParkingMgtForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ParkingMgtForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCarIn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCarOut;
        private System.Windows.Forms.ListBox listBoxState;
        private System.Windows.Forms.ComboBox cboCarList;
        private System.Windows.Forms.Label lbState;
        private System.Windows.Forms.Label label1;
    }
}

