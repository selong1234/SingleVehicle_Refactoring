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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.grpX = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnRestoreX = new System.Windows.Forms.Button();
            this.btnScaleX = new System.Windows.Forms.Button();
            this.txtMaxX = new System.Windows.Forms.TextBox();
            this.txtMinX = new System.Windows.Forms.TextBox();
            this.grpY = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMinY = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMaxY = new System.Windows.Forms.TextBox();
            this.btnRestoreY = new System.Windows.Forms.Button();
            this.btnScaleY = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chtCurve)).BeginInit();
            this.grpX.SuspendLayout();
            this.grpY.SuspendLayout();
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
            chartArea1.Name = "ChartArea1";
            this.chtCurve.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chtCurve.Legends.Add(legend1);
            this.chtCurve.Location = new System.Drawing.Point(14, 64);
            this.chtCurve.Name = "chtCurve";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chtCurve.Series.Add(series1);
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
            this.chkJYFG.BackColor = System.Drawing.Color.White;
            this.chkJYFG.Checked = true;
            this.chkJYFG.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkJYFG.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkJYFG.Location = new System.Drawing.Point(724, 307);
            this.chkJYFG.Name = "chkJYFG";
            this.chkJYFG.Size = new System.Drawing.Size(57, 21);
            this.chkJYFG.TabIndex = 14;
            this.chkJYFG.Text = "JYFG";
            this.chkJYFG.UseVisualStyleBackColor = false;
            this.chkJYFG.Click += new System.EventHandler(this.chkSeries_CheckedChanged);
            // 
            // chkJHFG
            // 
            this.chkJHFG.AutoSize = true;
            this.chkJHFG.BackColor = System.Drawing.Color.White;
            this.chkJHFG.Checked = true;
            this.chkJHFG.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkJHFG.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkJHFG.Location = new System.Drawing.Point(724, 285);
            this.chkJHFG.Name = "chkJHFG";
            this.chkJHFG.Size = new System.Drawing.Size(59, 21);
            this.chkJHFG.TabIndex = 15;
            this.chkJHFG.Text = "JHFG";
            this.chkJHFG.UseVisualStyleBackColor = false;
            this.chkJHFG.Click += new System.EventHandler(this.chkSeries_CheckedChanged);
            // 
            // chkFFG
            // 
            this.chkFFG.AutoSize = true;
            this.chkFFG.BackColor = System.Drawing.Color.White;
            this.chkFFG.Checked = true;
            this.chkFFG.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFFG.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkFFG.Location = new System.Drawing.Point(724, 263);
            this.chkFFG.Name = "chkFFG";
            this.chkFFG.Size = new System.Drawing.Size(50, 21);
            this.chkFFG.TabIndex = 16;
            this.chkFFG.Text = "FFG";
            this.chkFFG.UseVisualStyleBackColor = false;
            this.chkFFG.Click += new System.EventHandler(this.chkSeries_CheckedChanged);
            // 
            // chkZDG
            // 
            this.chkZDG.AutoSize = true;
            this.chkZDG.BackColor = System.Drawing.Color.White;
            this.chkZDG.Checked = true;
            this.chkZDG.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkZDG.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkZDG.Location = new System.Drawing.Point(724, 241);
            this.chkZDG.Name = "chkZDG";
            this.chkZDG.Size = new System.Drawing.Size(54, 21);
            this.chkZDG.TabIndex = 17;
            this.chkZDG.Text = "ZDG";
            this.chkZDG.UseVisualStyleBackColor = false;
            this.chkZDG.Click += new System.EventHandler(this.chkSeries_CheckedChanged);
            // 
            // chkLCG
            // 
            this.chkLCG.AutoSize = true;
            this.chkLCG.BackColor = System.Drawing.Color.White;
            this.chkLCG.Checked = true;
            this.chkLCG.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLCG.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkLCG.Location = new System.Drawing.Point(724, 219);
            this.chkLCG.Name = "chkLCG";
            this.chkLCG.Size = new System.Drawing.Size(51, 21);
            this.chkLCG.TabIndex = 18;
            this.chkLCG.Text = "LCG";
            this.chkLCG.UseVisualStyleBackColor = false;
            this.chkLCG.Click += new System.EventHandler(this.chkSeries_CheckedChanged);
            // 
            // grpX
            // 
            this.grpX.BackColor = System.Drawing.Color.White;
            this.grpX.Controls.Add(this.label6);
            this.grpX.Controls.Add(this.txtMinX);
            this.grpX.Controls.Add(this.label7);
            this.grpX.Controls.Add(this.txtMaxX);
            this.grpX.Controls.Add(this.btnRestoreX);
            this.grpX.Controls.Add(this.btnScaleX);
            this.grpX.Location = new System.Drawing.Point(719, 357);
            this.grpX.Name = "grpX";
            this.grpX.Size = new System.Drawing.Size(118, 122);
            this.grpX.TabIndex = 19;
            this.grpX.TabStop = false;
            this.grpX.Text = "X轴";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 24;
            this.label6.Text = "最大值：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 25;
            this.label7.Text = "最小值：";
            // 
            // btnRestoreX
            // 
            this.btnRestoreX.Location = new System.Drawing.Point(61, 79);
            this.btnRestoreX.Name = "btnRestoreX";
            this.btnRestoreX.Size = new System.Drawing.Size(50, 35);
            this.btnRestoreX.TabIndex = 23;
            this.btnRestoreX.Text = "还原X";
            this.btnRestoreX.UseVisualStyleBackColor = true;
            this.btnRestoreX.Click += new System.EventHandler(this.btnRestoreX_Click);
            // 
            // btnScaleX
            // 
            this.btnScaleX.Location = new System.Drawing.Point(5, 79);
            this.btnScaleX.Name = "btnScaleX";
            this.btnScaleX.Size = new System.Drawing.Size(50, 35);
            this.btnScaleX.TabIndex = 22;
            this.btnScaleX.Text = "缩放X";
            this.btnScaleX.UseVisualStyleBackColor = true;
            this.btnScaleX.Click += new System.EventHandler(this.btnScaleX_Click);
            // 
            // txtMaxX
            // 
            this.txtMaxX.Location = new System.Drawing.Point(63, 52);
            this.txtMaxX.Name = "txtMaxX";
            this.txtMaxX.Size = new System.Drawing.Size(46, 21);
            this.txtMaxX.TabIndex = 20;
            // 
            // txtMinX
            // 
            this.txtMinX.Location = new System.Drawing.Point(63, 23);
            this.txtMinX.Name = "txtMinX";
            this.txtMinX.Size = new System.Drawing.Size(46, 21);
            this.txtMinX.TabIndex = 21;
            // 
            // grpY
            // 
            this.grpY.BackColor = System.Drawing.Color.White;
            this.grpY.Controls.Add(this.label8);
            this.grpY.Controls.Add(this.txtMinY);
            this.grpY.Controls.Add(this.label9);
            this.grpY.Controls.Add(this.txtMaxY);
            this.grpY.Controls.Add(this.btnRestoreY);
            this.grpY.Controls.Add(this.btnScaleY);
            this.grpY.Location = new System.Drawing.Point(719, 485);
            this.grpY.Name = "grpY";
            this.grpY.Size = new System.Drawing.Size(118, 122);
            this.grpY.TabIndex = 19;
            this.grpY.TabStop = false;
            this.grpY.Text = "Y轴";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 24;
            this.label8.Text = "最大值：";
            // 
            // txtMinY
            // 
            this.txtMinY.Location = new System.Drawing.Point(63, 23);
            this.txtMinY.Name = "txtMinY";
            this.txtMinY.Size = new System.Drawing.Size(46, 21);
            this.txtMinY.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 25;
            this.label9.Text = "最小值：";
            // 
            // txtMaxY
            // 
            this.txtMaxY.Location = new System.Drawing.Point(63, 52);
            this.txtMaxY.Name = "txtMaxY";
            this.txtMaxY.Size = new System.Drawing.Size(46, 21);
            this.txtMaxY.TabIndex = 20;
            // 
            // btnRestoreY
            // 
            this.btnRestoreY.Location = new System.Drawing.Point(61, 79);
            this.btnRestoreY.Name = "btnRestoreY";
            this.btnRestoreY.Size = new System.Drawing.Size(50, 35);
            this.btnRestoreY.TabIndex = 23;
            this.btnRestoreY.Text = "还原Y";
            this.btnRestoreY.UseVisualStyleBackColor = true;
            this.btnRestoreY.Click += new System.EventHandler(this.btnRestoreY_Click);
            // 
            // btnScaleY
            // 
            this.btnScaleY.Location = new System.Drawing.Point(5, 79);
            this.btnScaleY.Name = "btnScaleY";
            this.btnScaleY.Size = new System.Drawing.Size(50, 35);
            this.btnScaleY.TabIndex = 22;
            this.btnScaleY.Text = "缩放Y";
            this.btnScaleY.UseVisualStyleBackColor = true;
            this.btnScaleY.Click += new System.EventHandler(this.btnScaleY_Click);
            // 
            // FrmManual
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
            this.grpX.ResumeLayout(false);
            this.grpX.PerformLayout();
            this.grpY.ResumeLayout(false);
            this.grpY.PerformLayout();
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
        private System.Windows.Forms.GroupBox grpX;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMinX;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaxX;
        private System.Windows.Forms.Button btnRestoreX;
        private System.Windows.Forms.Button btnScaleX;
        private System.Windows.Forms.GroupBox grpY;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMinY;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMaxY;
        private System.Windows.Forms.Button btnRestoreY;
        private System.Windows.Forms.Button btnScaleY;
    }
}

