namespace SingleVehicle_Refactoring
{
    partial class FrmManual
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnFast = new System.Windows.Forms.Button();
            this.btnSlow = new System.Windows.Forms.Button();
            this.btnSensitivity = new System.Windows.Forms.Button();
            this.btnNo5 = new System.Windows.Forms.Button();
            this.btnStability = new System.Windows.Forms.Button();
            this.btnEmergency = new System.Windows.Forms.Button();
            this.btnSwitchPressure = new System.Windows.Forms.Button();
            this.btnNo6 = new System.Windows.Forms.Button();
            this.txtLCG = new System.Windows.Forms.TextBox();
            this.txtZDG = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFFG = new System.Windows.Forms.TextBox();
            this.txtJHFG = new System.Windows.Forms.TextBox();
            this.txtJYFG = new System.Windows.Forms.TextBox();
            this.chtCurve = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnAcquisitionStart = new System.Windows.Forms.Button();
            this.btnAcquisitionStop = new System.Windows.Forms.Button();
            this.btnSaveData = new System.Windows.Forms.Button();
            this.chkJYFG = new System.Windows.Forms.CheckBox();
            this.chkJHFG = new System.Windows.Forms.CheckBox();
            this.chkFFG = new System.Windows.Forms.CheckBox();
            this.chkZDG = new System.Windows.Forms.CheckBox();
            this.chkLCG = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.chtCurve)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFast
            // 
            this.btnFast.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnFast.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnFast.Location = new System.Drawing.Point(869, 64);
            this.btnFast.Name = "btnFast";
            this.btnFast.Size = new System.Drawing.Size(123, 60);
            this.btnFast.TabIndex = 6;
            this.btnFast.Text = "一位";
            this.btnFast.UseVisualStyleBackColor = false;
            // 
            // btnSlow
            // 
            this.btnSlow.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSlow.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSlow.Location = new System.Drawing.Point(869, 140);
            this.btnSlow.Name = "btnSlow";
            this.btnSlow.Size = new System.Drawing.Size(123, 60);
            this.btnSlow.TabIndex = 7;
            this.btnSlow.Text = "二位";
            this.btnSlow.UseVisualStyleBackColor = false;
            // 
            // btnSensitivity
            // 
            this.btnSensitivity.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSensitivity.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSensitivity.Location = new System.Drawing.Point(869, 216);
            this.btnSensitivity.Name = "btnSensitivity";
            this.btnSensitivity.Size = new System.Drawing.Size(123, 60);
            this.btnSensitivity.TabIndex = 8;
            this.btnSensitivity.Text = "四位";
            this.btnSensitivity.UseVisualStyleBackColor = false;
            // 
            // btnNo5
            // 
            this.btnNo5.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnNo5.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnNo5.Location = new System.Drawing.Point(869, 292);
            this.btnNo5.Name = "btnNo5";
            this.btnNo5.Size = new System.Drawing.Size(123, 60);
            this.btnNo5.TabIndex = 9;
            this.btnNo5.Text = "五位";
            this.btnNo5.UseVisualStyleBackColor = false;
            // 
            // btnStability
            // 
            this.btnStability.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnStability.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStability.Location = new System.Drawing.Point(869, 444);
            this.btnStability.Name = "btnStability";
            this.btnStability.Size = new System.Drawing.Size(123, 60);
            this.btnStability.TabIndex = 11;
            this.btnStability.Text = "常用";
            this.btnStability.UseVisualStyleBackColor = false;
            // 
            // btnEmergency
            // 
            this.btnEmergency.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEmergency.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnEmergency.Location = new System.Drawing.Point(869, 520);
            this.btnEmergency.Name = "btnEmergency";
            this.btnEmergency.Size = new System.Drawing.Size(123, 60);
            this.btnEmergency.TabIndex = 12;
            this.btnEmergency.Text = "紧急";
            this.btnEmergency.UseVisualStyleBackColor = false;
            // 
            // btnSwitchPressure
            // 
            this.btnSwitchPressure.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSwitchPressure.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSwitchPressure.Location = new System.Drawing.Point(869, 596);
            this.btnSwitchPressure.Name = "btnSwitchPressure";
            this.btnSwitchPressure.Size = new System.Drawing.Size(123, 60);
            this.btnSwitchPressure.TabIndex = 13;
            this.btnSwitchPressure.Text = "风压切换\n500kPa";
            this.btnSwitchPressure.UseVisualStyleBackColor = false;
            // 
            // btnNo6
            // 
            this.btnNo6.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnNo6.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnNo6.Location = new System.Drawing.Point(869, 368);
            this.btnNo6.Name = "btnNo6";
            this.btnNo6.Size = new System.Drawing.Size(123, 60);
            this.btnNo6.TabIndex = 10;
            this.btnNo6.Text = "六位";
            this.btnNo6.UseVisualStyleBackColor = false;
            // 
            // txtLCG
            // 
            this.txtLCG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLCG.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLCG.Location = new System.Drawing.Point(103, 20);
            this.txtLCG.Name = "txtLCG";
            this.txtLCG.ReadOnly = true;
            this.txtLCG.Size = new System.Drawing.Size(64, 19);
            this.txtLCG.TabIndex = 1;
            // 
            // txtZDG
            // 
            this.txtZDG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtZDG.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZDG.Location = new System.Drawing.Point(817, 20);
            this.txtZDG.Name = "txtZDG";
            this.txtZDG.ReadOnly = true;
            this.txtZDG.Size = new System.Drawing.Size(64, 19);
            this.txtZDG.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(19, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "列 车 管：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(194, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "副 风 缸：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(369, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "加缓风缸：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(731, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "制 动 缸：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(550, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "降压风缸：";
            // 
            // txtFFG
            // 
            this.txtFFG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFFG.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFFG.Location = new System.Drawing.Point(280, 20);
            this.txtFFG.Name = "txtFFG";
            this.txtFFG.ReadOnly = true;
            this.txtFFG.Size = new System.Drawing.Size(64, 19);
            this.txtFFG.TabIndex = 2;
            // 
            // txtJHFG
            // 
            this.txtJHFG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtJHFG.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJHFG.Location = new System.Drawing.Point(460, 20);
            this.txtJHFG.Name = "txtJHFG";
            this.txtJHFG.ReadOnly = true;
            this.txtJHFG.Size = new System.Drawing.Size(64, 19);
            this.txtJHFG.TabIndex = 3;
            // 
            // txtJYFG
            // 
            this.txtJYFG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtJYFG.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJYFG.Location = new System.Drawing.Point(640, 20);
            this.txtJYFG.Name = "txtJYFG";
            this.txtJYFG.ReadOnly = true;
            this.txtJYFG.Size = new System.Drawing.Size(64, 19);
            this.txtJYFG.TabIndex = 4;
            // 
            // chtCurve
            // 
            chartArea2.Name = "ChartArea1";
            this.chtCurve.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chtCurve.Legends.Add(legend2);
            this.chtCurve.Location = new System.Drawing.Point(14, 64);
            this.chtCurve.Name = "chtCurve";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chtCurve.Series.Add(series2);
            this.chtCurve.Size = new System.Drawing.Size(834, 592);
            this.chtCurve.TabIndex = 7;
            this.chtCurve.Text = "chart1";
            // 
            // btnAcquisitionStart
            // 
            this.btnAcquisitionStart.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAcquisitionStart.Location = new System.Drawing.Point(15, 660);
            this.btnAcquisitionStart.Name = "btnAcquisitionStart";
            this.btnAcquisitionStart.Size = new System.Drawing.Size(104, 50);
            this.btnAcquisitionStart.TabIndex = 0;
            this.btnAcquisitionStart.Text = "开始采集";
            this.btnAcquisitionStart.UseVisualStyleBackColor = true;
            this.btnAcquisitionStart.Click += new System.EventHandler(this.btnAcquisitionStart_Click);
            // 
            // btnAcquisitionStop
            // 
            this.btnAcquisitionStop.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAcquisitionStop.Location = new System.Drawing.Point(168, 660);
            this.btnAcquisitionStop.Name = "btnAcquisitionStop";
            this.btnAcquisitionStop.Size = new System.Drawing.Size(104, 50);
            this.btnAcquisitionStop.TabIndex = 1;
            this.btnAcquisitionStop.Text = "结束采集";
            this.btnAcquisitionStop.UseVisualStyleBackColor = true;
            this.btnAcquisitionStop.Click += new System.EventHandler(this.btnAcquisitionStop_Click);
            // 
            // btnSaveData
            // 
            this.btnSaveData.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSaveData.Location = new System.Drawing.Point(321, 660);
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.Size = new System.Drawing.Size(104, 50);
            this.btnSaveData.TabIndex = 2;
            this.btnSaveData.Text = "保存数据";
            this.btnSaveData.UseVisualStyleBackColor = true;
            this.btnSaveData.Click += new System.EventHandler(this.btnSaveData_Click);
            // 
            // chkJYFG
            // 
            this.chkJYFG.AutoSize = true;
            this.chkJYFG.Checked = true;
            this.chkJYFG.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkJYFG.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkJYFG.Location = new System.Drawing.Point(760, 586);
            this.chkJYFG.Name = "chkJYFG";
            this.chkJYFG.Size = new System.Drawing.Size(57, 21);
            this.chkJYFG.TabIndex = 14;
            this.chkJYFG.Text = "JYFG";
            this.chkJYFG.UseVisualStyleBackColor = true;
            this.chkJYFG.Click += new System.EventHandler(this.chkSeries_CheckedChanged);
            // 
            // chkJHFG
            // 
            this.chkJHFG.AutoSize = true;
            this.chkJHFG.Checked = true;
            this.chkJHFG.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkJHFG.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkJHFG.Location = new System.Drawing.Point(760, 564);
            this.chkJHFG.Name = "chkJHFG";
            this.chkJHFG.Size = new System.Drawing.Size(59, 21);
            this.chkJHFG.TabIndex = 15;
            this.chkJHFG.Text = "JHFG";
            this.chkJHFG.UseVisualStyleBackColor = true;
            this.chkJHFG.Click += new System.EventHandler(this.chkSeries_CheckedChanged);
            // 
            // chkFFG
            // 
            this.chkFFG.AutoSize = true;
            this.chkFFG.Checked = true;
            this.chkFFG.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFFG.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkFFG.Location = new System.Drawing.Point(760, 542);
            this.chkFFG.Name = "chkFFG";
            this.chkFFG.Size = new System.Drawing.Size(50, 21);
            this.chkFFG.TabIndex = 16;
            this.chkFFG.Text = "FFG";
            this.chkFFG.UseVisualStyleBackColor = true;
            this.chkFFG.Click += new System.EventHandler(this.chkSeries_CheckedChanged);
            // 
            // chkZDG
            // 
            this.chkZDG.AutoSize = true;
            this.chkZDG.Checked = true;
            this.chkZDG.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkZDG.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkZDG.Location = new System.Drawing.Point(760, 520);
            this.chkZDG.Name = "chkZDG";
            this.chkZDG.Size = new System.Drawing.Size(54, 21);
            this.chkZDG.TabIndex = 17;
            this.chkZDG.Text = "ZDG";
            this.chkZDG.UseVisualStyleBackColor = true;
            this.chkZDG.Click += new System.EventHandler(this.chkSeries_CheckedChanged);
            // 
            // chkLCG
            // 
            this.chkLCG.AutoSize = true;
            this.chkLCG.Checked = true;
            this.chkLCG.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLCG.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkLCG.Location = new System.Drawing.Point(760, 498);
            this.chkLCG.Name = "chkLCG";
            this.chkLCG.Size = new System.Drawing.Size(51, 21);
            this.chkLCG.TabIndex = 18;
            this.chkLCG.Text = "LCG";
            this.chkLCG.UseVisualStyleBackColor = true;
            this.chkLCG.Click += new System.EventHandler(this.chkSeries_CheckedChanged);
            // 
            // FrmManual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.chkJYFG);
            this.Controls.Add(this.chkJHFG);
            this.Controls.Add(this.chkFFG);
            this.Controls.Add(this.chkZDG);
            this.Controls.Add(this.chkLCG);
            this.Controls.Add(this.btnSaveData);
            this.Controls.Add(this.btnAcquisitionStop);
            this.Controls.Add(this.btnAcquisitionStart);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFFG);
            this.Controls.Add(this.txtZDG);
            this.Controls.Add(this.txtJHFG);
            this.Controls.Add(this.txtJYFG);
            this.Controls.Add(this.txtLCG);
            this.Controls.Add(this.btnSwitchPressure);
            this.Controls.Add(this.btnNo5);
            this.Controls.Add(this.btnEmergency);
            this.Controls.Add(this.btnSensitivity);
            this.Controls.Add(this.btnNo6);
            this.Controls.Add(this.btnStability);
            this.Controls.Add(this.btnSlow);
            this.Controls.Add(this.btnFast);
            this.Controls.Add(this.chtCurve);
            this.Name = "FrmManual";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "手动试验";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmManual_FormClosing);
            this.Load += new System.EventHandler(this.FrmManual_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chtCurve)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFast;
        private System.Windows.Forms.Button btnSlow;
        private System.Windows.Forms.Button btnSensitivity;
        private System.Windows.Forms.Button btnNo5;
        private System.Windows.Forms.Button btnStability;
        private System.Windows.Forms.Button btnEmergency;
        private System.Windows.Forms.Button btnSwitchPressure;
        private System.Windows.Forms.Button btnNo6;
        private System.Windows.Forms.TextBox txtLCG;
        private System.Windows.Forms.TextBox txtZDG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFFG;
        private System.Windows.Forms.TextBox txtJHFG;
        private System.Windows.Forms.TextBox txtJYFG;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtCurve;
        private System.Windows.Forms.Button btnAcquisitionStart;
        private System.Windows.Forms.Button btnAcquisitionStop;
        private System.Windows.Forms.Button btnSaveData;
        private System.Windows.Forms.CheckBox chkJYFG;
        private System.Windows.Forms.CheckBox chkJHFG;
        private System.Windows.Forms.CheckBox chkFFG;
        private System.Windows.Forms.CheckBox chkZDG;
        private System.Windows.Forms.CheckBox chkLCG;
    }
}

