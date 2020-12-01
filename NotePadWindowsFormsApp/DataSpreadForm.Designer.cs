namespace NotePadWindowsFormsApp
{
    partial class DataSpreadForm
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnInit = new System.Windows.Forms.Button();
            this.bpnCenter = new System.Windows.Forms.Panel();
            this.analysisDataGrid = new System.Windows.Forms.DataGridView();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.selectedDataGroupBox = new System.Windows.Forms.GroupBox();
            this.lbSelectedData = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlTop.SuspendLayout();
            this.bpnCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.analysisDataGrid)).BeginInit();
            this.pnlBottom.SuspendLayout();
            this.panel2.SuspendLayout();
            this.selectedDataGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.btnRemove);
            this.pnlTop.Controls.Add(this.btnAdd);
            this.pnlTop.Controls.Add(this.btnInit);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(800, 62);
            this.pnlTop.TabIndex = 0;
            this.pnlTop.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTop_Paint);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.Location = new System.Drawing.Point(688, 11);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(100, 41);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(572, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 41);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnInit
            // 
            this.btnInit.Location = new System.Drawing.Point(16, 12);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(100, 41);
            this.btnInit.TabIndex = 0;
            this.btnInit.Text = "InitData";
            this.btnInit.UseVisualStyleBackColor = true;
            this.btnInit.Click += new System.EventHandler(this.btnInit_Click);
            // 
            // bpnCenter
            // 
            this.bpnCenter.Controls.Add(this.analysisDataGrid);
            this.bpnCenter.Location = new System.Drawing.Point(0, 62);
            this.bpnCenter.Name = "bpnCenter";
            this.bpnCenter.Size = new System.Drawing.Size(800, 252);
            this.bpnCenter.TabIndex = 1;
            // 
            // analysisDataGrid
            // 
            this.analysisDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.analysisDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.analysisDataGrid.Location = new System.Drawing.Point(0, 0);
            this.analysisDataGrid.Name = "analysisDataGrid";
            this.analysisDataGrid.RowHeadersWidth = 62;
            this.analysisDataGrid.RowTemplate.Height = 30;
            this.analysisDataGrid.Size = new System.Drawing.Size(800, 252);
            this.analysisDataGrid.TabIndex = 0;
            this.analysisDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.analysisDataGrid_CellContentClick);
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.panel2);
            this.pnlBottom.Controls.Add(this.panel1);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 320);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(800, 130);
            this.pnlBottom.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.selectedDataGroupBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 81);
            this.panel2.TabIndex = 1;
            // 
            // selectedDataGroupBox
            // 
            this.selectedDataGroupBox.Controls.Add(this.lbSelectedData);
            this.selectedDataGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectedDataGroupBox.Location = new System.Drawing.Point(0, 0);
            this.selectedDataGroupBox.Name = "selectedDataGroupBox";
            this.selectedDataGroupBox.Size = new System.Drawing.Size(800, 81);
            this.selectedDataGroupBox.TabIndex = 0;
            this.selectedDataGroupBox.TabStop = false;
            this.selectedDataGroupBox.Text = "SelectedData";
            this.selectedDataGroupBox.Enter += new System.EventHandler(this.selectedDataGroupBox_Enter);
            // 
            // lbSelectedData
            // 
            this.lbSelectedData.AutoSize = true;
            this.lbSelectedData.Location = new System.Drawing.Point(13, 28);
            this.lbSelectedData.Name = "lbSelectedData";
            this.lbSelectedData.Size = new System.Drawing.Size(112, 18);
            this.lbSelectedData.TabIndex = 0;
            this.lbSelectedData.Text = "selectedData";
            this.lbSelectedData.Click += new System.EventHandler(this.lbSelectedData_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 130);
            this.panel1.TabIndex = 0;
            // 
            // DataSpreadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.bpnCenter);
            this.Controls.Add(this.pnlTop);
            this.Name = "DataSpreadForm";
            this.Text = "  ";
            this.pnlTop.ResumeLayout(false);
            this.bpnCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.analysisDataGrid)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.selectedDataGroupBox.ResumeLayout(false);
            this.selectedDataGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel bpnCenter;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnInit;
        private System.Windows.Forms.DataGridView analysisDataGrid;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox selectedDataGroupBox;
        private System.Windows.Forms.Label lbSelectedData;
        private System.Windows.Forms.Panel panel1;
    }
}