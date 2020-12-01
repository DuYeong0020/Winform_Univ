namespace UpDownGameWindowsFormsApp
{
    partial class SimpleBM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCoin = new System.Windows.Forms.Button();
            this.cbCoin = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCoffee700 = new System.Windows.Forms.Button();
            this.btnCider300 = new System.Windows.Forms.Button();
            this.btnCoke500 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbChangesValue = new System.Windows.Forms.Label();
            this.lbChanges = new System.Windows.Forms.Label();
            this.btnChanges = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCoin);
            this.panel1.Controls.Add(this.cbCoin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 90);
            this.panel1.TabIndex = 0;
            // 
            // btnCoin
            // 
            this.btnCoin.Location = new System.Drawing.Point(424, 32);
            this.btnCoin.Margin = new System.Windows.Forms.Padding(4);
            this.btnCoin.Name = "btnCoin";
            this.btnCoin.Size = new System.Drawing.Size(107, 34);
            this.btnCoin.TabIndex = 1;
            this.btnCoin.Text = "투입";
            this.btnCoin.UseVisualStyleBackColor = true;
            this.btnCoin.Click += new System.EventHandler(this.btnCoin_Click);
            // 
            // cbCoin
            // 
            this.cbCoin.FormattingEnabled = true;
            this.cbCoin.Location = new System.Drawing.Point(69, 32);
            this.cbCoin.Margin = new System.Windows.Forms.Padding(4);
            this.cbCoin.Name = "cbCoin";
            this.cbCoin.Size = new System.Drawing.Size(325, 26);
            this.cbCoin.TabIndex = 0;
            this.cbCoin.SelectedIndexChanged += new System.EventHandler(this.cbCoin_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCoffee700);
            this.panel2.Controls.Add(this.btnCider300);
            this.panel2.Controls.Add(this.btnCoke500);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 90);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 226);
            this.panel2.TabIndex = 1;
            // 
            // btnCoffee700
            // 
            this.btnCoffee700.Location = new System.Drawing.Point(396, 68);
            this.btnCoffee700.Margin = new System.Windows.Forms.Padding(4);
            this.btnCoffee700.Name = "btnCoffee700";
            this.btnCoffee700.Size = new System.Drawing.Size(136, 90);
            this.btnCoffee700.TabIndex = 2;
            this.btnCoffee700.Text = "커피 700원";
            this.btnCoffee700.UseVisualStyleBackColor = true;
            this.btnCoffee700.Click += new System.EventHandler(this.btnCoffee700_Click);
            // 
            // btnCider300
            // 
            this.btnCider300.Location = new System.Drawing.Point(233, 68);
            this.btnCider300.Margin = new System.Windows.Forms.Padding(4);
            this.btnCider300.Name = "btnCider300";
            this.btnCider300.Size = new System.Drawing.Size(136, 90);
            this.btnCider300.TabIndex = 1;
            this.btnCider300.Text = "사이다 300원";
            this.btnCider300.UseVisualStyleBackColor = true;
            this.btnCider300.Click += new System.EventHandler(this.btnCider300_Click);
            // 
            // btnCoke500
            // 
            this.btnCoke500.Location = new System.Drawing.Point(69, 68);
            this.btnCoke500.Margin = new System.Windows.Forms.Padding(4);
            this.btnCoke500.Name = "btnCoke500";
            this.btnCoke500.Size = new System.Drawing.Size(136, 90);
            this.btnCoke500.TabIndex = 0;
            this.btnCoke500.Text = "콜라 500원";
            this.btnCoke500.UseVisualStyleBackColor = true;
            this.btnCoke500.Click += new System.EventHandler(this.btnCoke500_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbChangesValue);
            this.panel3.Controls.Add(this.lbChanges);
            this.panel3.Controls.Add(this.btnChanges);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 316);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(600, 90);
            this.panel3.TabIndex = 2;
            // 
            // lbChangesValue
            // 
            this.lbChangesValue.AutoSize = true;
            this.lbChangesValue.Location = new System.Drawing.Point(136, 39);
            this.lbChangesValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbChangesValue.Name = "lbChangesValue";
            this.lbChangesValue.Size = new System.Drawing.Size(17, 18);
            this.lbChangesValue.TabIndex = 2;
            this.lbChangesValue.Text = "-";
            // 
            // lbChanges
            // 
            this.lbChanges.AutoSize = true;
            this.lbChanges.Location = new System.Drawing.Point(73, 39);
            this.lbChanges.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbChanges.Name = "lbChanges";
            this.lbChanges.Size = new System.Drawing.Size(62, 18);
            this.lbChanges.TabIndex = 1;
            this.lbChanges.Text = "잔액 : ";
            // 
            // btnChanges
            // 
            this.btnChanges.Location = new System.Drawing.Point(424, 32);
            this.btnChanges.Margin = new System.Windows.Forms.Padding(4);
            this.btnChanges.Name = "btnChanges";
            this.btnChanges.Size = new System.Drawing.Size(107, 34);
            this.btnChanges.TabIndex = 0;
            this.btnChanges.Text = "환전";
            this.btnChanges.UseVisualStyleBackColor = true;
            this.btnChanges.Click += new System.EventHandler(this.btnChanges_Click);
            // 
            // SimpleBM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 406);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SimpleBM";
            this.Text = "201901234 홍길동";
            this.Load += new System.EventHandler(this.SimpleBM_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCoin;
        private System.Windows.Forms.ComboBox cbCoin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCoffee700;
        private System.Windows.Forms.Button btnCider300;
        private System.Windows.Forms.Button btnCoke500;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbChangesValue;
        private System.Windows.Forms.Label lbChanges;
        private System.Windows.Forms.Button btnChanges;
    }
}