namespace SingleVehicle_Refactoring.View
{
    partial class FrmReview
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chtReviewCurve = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.chkLCG = new System.Windows.Forms.CheckBox();
            this.chkZDG = new System.Windows.Forms.CheckBox();
            this.chkFFG = new System.Windows.Forms.CheckBox();
            this.chkJHFG = new System.Windows.Forms.CheckBox();
            this.chkJYFG = new System.Windows.Forms.CheckBox();
            this.txtMinX = new System.Windows.Forms.TextBox();
            this.txtMaxX = new System.Windows.Forms.TextBox();
            this.btnScaleX = new System.Windows.Forms.Button();
            this.btnRestoreX = new System.Windows.Forms.Button();
            this.grpX = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpY = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRestoreY = new System.Windows.Forms.Button();
            this.btnScaleY = new System.Windows.Forms.Button();
            this.txtMaxY = new System.Windows.Forms.TextBox();
            this.txtMinY = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chtReviewCurve)).BeginInit();
            this.grpX.SuspendLayout();
            this.grpY.SuspendLayout();
            this.SuspendLayout();
            // 
            // chtReviewCurve
            // 
            chartArea1.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            chartArea1.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            chartArea1.Name = "ChartArea1";
            this.chtReviewCurve.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chtReviewCurve.Legends.Add(legend1);
            this.chtReviewCurve.Location = new System.Drawing.Point(12, 12);
            this.chtReviewCurve.Name = "chtReviewCurve";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chtReviewCurve.Series.Add(series1);
            this.chtReviewCurve.Size = new System.Drawing.Size(984, 637);
            this.chtReviewCurve.TabIndex = 8;
            this.chtReviewCurve.Text = "chart1";
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(12, 666);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(110, 43);
            this.btnSelectFile.TabIndex = 9;
            this.btnSelectFile.Text = "选择文件";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // chkLCG
            // 
            this.chkLCG.AutoSize = true;
            this.chkLCG.Checked = true;
            this.chkLCG.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLCG.Location = new System.Drawing.Point(914, 313);
            this.chkLCG.Name = "chkLCG";
            this.chkLCG.Size = new System.Drawing.Size(42, 16);
            this.chkLCG.TabIndex = 10;
            this.chkLCG.Text = "LCG";
            this.chkLCG.UseVisualStyleBackColor = true;
            this.chkLCG.CheckedChanged += new System.EventHandler(this.chkSeries_CheckedChanged);
            // 
            // chkZDG
            // 
            this.chkZDG.AutoSize = true;
            this.chkZDG.Checked = true;
            this.chkZDG.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkZDG.Location = new System.Drawing.Point(914, 335);
            this.chkZDG.Name = "chkZDG";
            this.chkZDG.Size = new System.Drawing.Size(42, 16);
            this.chkZDG.TabIndex = 10;
            this.chkZDG.Text = "ZDG";
            this.chkZDG.UseVisualStyleBackColor = true;
            this.chkZDG.CheckedChanged += new System.EventHandler(this.chkSeries_CheckedChanged);
            // 
            // chkFFG
            // 
            this.chkFFG.AutoSize = true;
            this.chkFFG.Checked = true;
            this.chkFFG.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFFG.Location = new System.Drawing.Point(914, 357);
            this.chkFFG.Name = "chkFFG";
            this.chkFFG.Size = new System.Drawing.Size(42, 16);
            this.chkFFG.TabIndex = 10;
            this.chkFFG.Text = "FFG";
            this.chkFFG.UseVisualStyleBackColor = true;
            this.chkFFG.CheckedChanged += new System.EventHandler(this.chkSeries_CheckedChanged);
            // 
            // chkJHFG
            // 
            this.chkJHFG.AutoSize = true;
            this.chkJHFG.Checked = true;
            this.chkJHFG.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkJHFG.Location = new System.Drawing.Point(914, 379);
            this.chkJHFG.Name = "chkJHFG";
            this.chkJHFG.Size = new System.Drawing.Size(48, 16);
            this.chkJHFG.TabIndex = 10;
            this.chkJHFG.Text = "JHFG";
            this.chkJHFG.UseVisualStyleBackColor = true;
            this.chkJHFG.CheckedChanged += new System.EventHandler(this.chkSeries_CheckedChanged);
            // 
            // chkJYFG
            // 
            this.chkJYFG.AutoSize = true;
            this.chkJYFG.Checked = true;
            this.chkJYFG.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkJYFG.Location = new System.Drawing.Point(914, 401);
            this.chkJYFG.Name = "chkJYFG";
            this.chkJYFG.Size = new System.Drawing.Size(48, 16);
            this.chkJYFG.TabIndex = 10;
            this.chkJYFG.Text = "JYFG";
            this.chkJYFG.UseVisualStyleBackColor = true;
            this.chkJYFG.CheckedChanged += new System.EventHandler(this.chkSeries_CheckedChanged);
            // 
            // txtMinX
            // 
            this.txtMinX.Location = new System.Drawing.Point(68, 19);
            this.txtMinX.Name = "txtMinX";
            this.txtMinX.Size = new System.Drawing.Size(63, 21);
            this.txtMinX.TabIndex = 11;
            // 
            // txtMaxX
            // 
            this.txtMaxX.Location = new System.Drawing.Point(209, 19);
            this.txtMaxX.Name = "txtMaxX";
            this.txtMaxX.Size = new System.Drawing.Size(63, 21);
            this.txtMaxX.TabIndex = 11;
            // 
            // btnScaleX
            // 
            this.btnScaleX.Location = new System.Drawing.Point(297, 12);
            this.btnScaleX.Name = "btnScaleX";
            this.btnScaleX.Size = new System.Drawing.Size(57, 35);
            this.btnScaleX.TabIndex = 12;
            this.btnScaleX.Text = "缩放X";
            this.btnScaleX.UseVisualStyleBackColor = true;
            this.btnScaleX.Click += new System.EventHandler(this.btnScaleX_Click);
            // 
            // btnRestoreX
            // 
            this.btnRestoreX.Location = new System.Drawing.Point(360, 12);
            this.btnRestoreX.Name = "btnRestoreX";
            this.btnRestoreX.Size = new System.Drawing.Size(57, 35);
            this.btnRestoreX.TabIndex = 13;
            this.btnRestoreX.Text = "还原X";
            this.btnRestoreX.UseVisualStyleBackColor = true;
            this.btnRestoreX.Click += new System.EventHandler(this.btnRestoreX_Click);
            // 
            // grpX
            // 
            this.grpX.Controls.Add(this.label2);
            this.grpX.Controls.Add(this.label1);
            this.grpX.Controls.Add(this.btnRestoreX);
            this.grpX.Controls.Add(this.btnScaleX);
            this.grpX.Controls.Add(this.txtMaxX);
            this.grpX.Controls.Add(this.txtMinX);
            this.grpX.Location = new System.Drawing.Point(150, 655);
            this.grpX.Name = "grpX";
            this.grpX.Size = new System.Drawing.Size(423, 54);
            this.grpX.TabIndex = 14;
            this.grpX.TabStop = false;
            this.grpX.Text = "X轴";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 14;
            this.label2.Text = "最大值：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "最小值：";
            // 
            // grpY
            // 
            this.grpY.Controls.Add(this.label3);
            this.grpY.Controls.Add(this.label4);
            this.grpY.Controls.Add(this.btnRestoreY);
            this.grpY.Controls.Add(this.btnScaleY);
            this.grpY.Controls.Add(this.txtMaxY);
            this.grpY.Controls.Add(this.txtMinY);
            this.grpY.Location = new System.Drawing.Point(579, 655);
            this.grpY.Name = "grpY";
            this.grpY.Size = new System.Drawing.Size(423, 54);
            this.grpY.TabIndex = 14;
            this.grpY.TabStop = false;
            this.grpY.Text = "Y轴";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "最大值：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 14;
            this.label4.Text = "最小值：";
            // 
            // btnRestoreY
            // 
            this.btnRestoreY.Location = new System.Drawing.Point(360, 12);
            this.btnRestoreY.Name = "btnRestoreY";
            this.btnRestoreY.Size = new System.Drawing.Size(57, 35);
            this.btnRestoreY.TabIndex = 13;
            this.btnRestoreY.Text = "还原Y";
            this.btnRestoreY.UseVisualStyleBackColor = true;
            this.btnRestoreY.Click += new System.EventHandler(this.btnRestoreY_Click);
            // 
            // btnScaleY
            // 
            this.btnScaleY.Location = new System.Drawing.Point(297, 12);
            this.btnScaleY.Name = "btnScaleY";
            this.btnScaleY.Size = new System.Drawing.Size(57, 35);
            this.btnScaleY.TabIndex = 12;
            this.btnScaleY.Text = "缩放Y";
            this.btnScaleY.UseVisualStyleBackColor = true;
            this.btnScaleY.Click += new System.EventHandler(this.btnScaleY_Click);
            // 
            // txtMaxY
            // 
            this.txtMaxY.Location = new System.Drawing.Point(209, 19);
            this.txtMaxY.Name = "txtMaxY";
            this.txtMaxY.Size = new System.Drawing.Size(63, 21);
            this.txtMaxY.TabIndex = 11;
            // 
            // txtMinY
            // 
            this.txtMinY.Location = new System.Drawing.Point(68, 19);
            this.txtMinY.Name = "txtMinY";
            this.txtMinY.Size = new System.Drawing.Size(63, 21);
            this.txtMinY.TabIndex = 11;
            // 
            // FrmReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.grpY);
            this.Controls.Add(this.grpX);
            this.Controls.Add(this.chkJYFG);
            this.Controls.Add(this.chkJHFG);
            this.Controls.Add(this.chkFFG);
            this.Controls.Add(this.chkZDG);
            this.Controls.Add(this.chkLCG);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.chtReviewCurve);
            this.Name = "FrmReview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "曲线查看";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmReview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chtReviewCurve)).EndInit();
            this.grpX.ResumeLayout(false);
            this.grpX.PerformLayout();
            this.grpY.ResumeLayout(false);
            this.grpY.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chtReviewCurve;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.CheckBox chkLCG;
        private System.Windows.Forms.CheckBox chkZDG;
        private System.Windows.Forms.CheckBox chkFFG;
        private System.Windows.Forms.CheckBox chkJHFG;
        private System.Windows.Forms.CheckBox chkJYFG;
        private System.Windows.Forms.TextBox txtMinX;
        private System.Windows.Forms.TextBox txtMaxX;
        private System.Windows.Forms.Button btnScaleX;
        private System.Windows.Forms.Button btnRestoreX;
        private System.Windows.Forms.GroupBox grpX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRestoreY;
        private System.Windows.Forms.Button btnScaleY;
        private System.Windows.Forms.TextBox txtMaxY;
        private System.Windows.Forms.TextBox txtMinY;
    }
}