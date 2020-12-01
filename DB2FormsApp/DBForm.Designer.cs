namespace DB2FormsApp
{
    partial class DBForm
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCont = new System.Windows.Forms.TextBox();
            this.cbDept = new System.Windows.Forms.CheckBox();
            this.cbSalary = new System.Windows.Forms.CheckBox();
            this.cbLevel = new System.Windows.Forms.CheckBox();
            this.cbJob = new System.Windows.Forms.CheckBox();
            this.cbEmail = new System.Windows.Forms.CheckBox();
            this.cbName = new System.Windows.Forms.CheckBox();
            this.btnInit = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.myComDataGridView = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myComDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtCont);
            this.panel1.Controls.Add(this.cbDept);
            this.panel1.Controls.Add(this.cbSalary);
            this.panel1.Controls.Add(this.cbLevel);
            this.panel1.Controls.Add(this.cbJob);
            this.panel1.Controls.Add(this.cbEmail);
            this.panel1.Controls.Add(this.cbName);
            this.panel1.Controls.Add(this.btnInit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1076, 63);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtCont
            // 
            this.txtCont.Location = new System.Drawing.Point(600, 22);
            this.txtCont.Name = "txtCont";
            this.txtCont.Size = new System.Drawing.Size(100, 28);
            this.txtCont.TabIndex = 7;
            this.txtCont.Text = "dd";
            this.txtCont.TextChanged += new System.EventHandler(this.txtCont_TextChanged);
            // 
            // cbDept
            // 
            this.cbDept.AutoSize = true;
            this.cbDept.Location = new System.Drawing.Point(209, 24);
            this.cbDept.Name = "cbDept";
            this.cbDept.Size = new System.Drawing.Size(69, 22);
            this.cbDept.TabIndex = 6;
            this.cbDept.Text = "dept";
            this.cbDept.UseVisualStyleBackColor = true;
            // 
            // cbSalary
            // 
            this.cbSalary.AutoSize = true;
            this.cbSalary.Location = new System.Drawing.Point(485, 24);
            this.cbSalary.Name = "cbSalary";
            this.cbSalary.Size = new System.Drawing.Size(83, 22);
            this.cbSalary.TabIndex = 5;
            this.cbSalary.Text = "salary";
            this.cbSalary.UseVisualStyleBackColor = true;
            // 
            // cbLevel
            // 
            this.cbLevel.AutoSize = true;
            this.cbLevel.Location = new System.Drawing.Point(387, 24);
            this.cbLevel.Name = "cbLevel";
            this.cbLevel.Size = new System.Drawing.Size(70, 22);
            this.cbLevel.TabIndex = 4;
            this.cbLevel.Text = "level";
            this.cbLevel.UseVisualStyleBackColor = true;
            this.cbLevel.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // cbJob
            // 
            this.cbJob.AutoSize = true;
            this.cbJob.Location = new System.Drawing.Point(302, 24);
            this.cbJob.Name = "cbJob";
            this.cbJob.Size = new System.Drawing.Size(59, 22);
            this.cbJob.TabIndex = 3;
            this.cbJob.Text = "job";
            this.cbJob.UseVisualStyleBackColor = true;
            // 
            // cbEmail
            // 
            this.cbEmail.AutoSize = true;
            this.cbEmail.Location = new System.Drawing.Point(112, 24);
            this.cbEmail.Name = "cbEmail";
            this.cbEmail.Size = new System.Drawing.Size(75, 22);
            this.cbEmail.TabIndex = 2;
            this.cbEmail.Text = "email";
            this.cbEmail.UseVisualStyleBackColor = true;
            // 
            // cbName
            // 
            this.cbName.AutoSize = true;
            this.cbName.Location = new System.Drawing.Point(12, 24);
            this.cbName.Name = "cbName";
            this.cbName.Size = new System.Drawing.Size(79, 22);
            this.cbName.TabIndex = 1;
            this.cbName.Text = "name";
            this.cbName.UseVisualStyleBackColor = true;
            this.cbName.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnInit
            // 
            this.btnInit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInit.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnInit.Location = new System.Drawing.Point(965, 12);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(103, 39);
            this.btnInit.TabIndex = 0;
            this.btnInit.Text = "Search";
            this.btnInit.UseVisualStyleBackColor = true;
            this.btnInit.Click += new System.EventHandler(this.btnInit_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.myComDataGridView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1076, 418);
            this.panel2.TabIndex = 2;
            // 
            // myComDataGridView
            // 
            this.myComDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myComDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myComDataGridView.Location = new System.Drawing.Point(0, 0);
            this.myComDataGridView.Name = "myComDataGridView";
            this.myComDataGridView.RowHeadersWidth = 62;
            this.myComDataGridView.RowTemplate.Height = 30;
            this.myComDataGridView.Size = new System.Drawing.Size(1076, 418);
            this.myComDataGridView.TabIndex = 3;
            this.myComDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // DBForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 481);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "DBForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.myComDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView myComDataGridView;
        private System.Windows.Forms.Button btnInit;
        private System.Windows.Forms.CheckBox cbDept;
        private System.Windows.Forms.CheckBox cbSalary;
        private System.Windows.Forms.CheckBox cbLevel;
        private System.Windows.Forms.CheckBox cbJob;
        private System.Windows.Forms.CheckBox cbEmail;
        private System.Windows.Forms.CheckBox cbName;
        private System.Windows.Forms.TextBox txtCont;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

