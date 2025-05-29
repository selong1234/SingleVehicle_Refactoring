namespace SingleVehicle_Refactoring.View
{
    partial class FrmSensorConfig
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
            this.btnSave = new System.Windows.Forms.Button();
            this.grpLCG = new System.Windows.Forms.GroupBox();
            this.lblLCG_Value = new System.Windows.Forms.Label();
            this.lblLCG_Volt = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLCG_Coef = new System.Windows.Forms.TextBox();
            this.txtLCG_Zero = new System.Windows.Forms.TextBox();
            this.grpFFG = new System.Windows.Forms.GroupBox();
            this.lblFFG_Value = new System.Windows.Forms.Label();
            this.lblFFG_Volt = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtFFG_Coef = new System.Windows.Forms.TextBox();
            this.txtFFG_Zero = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblJHFG_Value = new System.Windows.Forms.Label();
            this.lblJHFG_Volt = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtJHFG_Coef = new System.Windows.Forms.TextBox();
            this.txtJHFG_Zero = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblJYFG_Value = new System.Windows.Forms.Label();
            this.lblJYFG_Volt = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtJYFG_Coef = new System.Windows.Forms.TextBox();
            this.txtJYFG_Zero = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblZDG_Value = new System.Windows.Forms.Label();
            this.lblZDG_Volt = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.txtZDG_Coef = new System.Windows.Forms.TextBox();
            this.txtZDG_Zero = new System.Windows.Forms.TextBox();
            this.grpLCG.SuspendLayout();
            this.grpFFG.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(440, 656);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(118, 51);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // grpLCG
            // 
            this.grpLCG.Controls.Add(this.lblLCG_Value);
            this.grpLCG.Controls.Add(this.lblLCG_Volt);
            this.grpLCG.Controls.Add(this.label3);
            this.grpLCG.Controls.Add(this.label2);
            this.grpLCG.Controls.Add(this.label4);
            this.grpLCG.Controls.Add(this.label1);
            this.grpLCG.Controls.Add(this.txtLCG_Coef);
            this.grpLCG.Controls.Add(this.txtLCG_Zero);
            this.grpLCG.Location = new System.Drawing.Point(20, 12);
            this.grpLCG.Name = "grpLCG";
            this.grpLCG.Size = new System.Drawing.Size(467, 109);
            this.grpLCG.TabIndex = 5;
            this.grpLCG.TabStop = false;
            this.grpLCG.Tag = "LCG";
            this.grpLCG.Text = "列车管";
            // 
            // lblLCG_Value
            // 
            this.lblLCG_Value.AutoSize = true;
            this.lblLCG_Value.Location = new System.Drawing.Point(147, 71);
            this.lblLCG_Value.Name = "lblLCG_Value";
            this.lblLCG_Value.Size = new System.Drawing.Size(29, 12);
            this.lblLCG_Value.TabIndex = 2;
            this.lblLCG_Value.Text = "压力";
            // 
            // lblLCG_Volt
            // 
            this.lblLCG_Volt.AutoSize = true;
            this.lblLCG_Volt.Location = new System.Drawing.Point(147, 29);
            this.lblLCG_Volt.Name = "lblLCG_Volt";
            this.lblLCG_Volt.Size = new System.Drawing.Size(29, 12);
            this.lblLCG_Volt.TabIndex = 2;
            this.lblLCG_Volt.Text = "电压";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "传感器标定系数(Pa/mv)：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "传感器零点电压(mv)：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "传感器换算压力(kPa)：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "传感器当前电压(mv)：";
            // 
            // txtLCG_Coef
            // 
            this.txtLCG_Coef.Location = new System.Drawing.Point(377, 67);
            this.txtLCG_Coef.Name = "txtLCG_Coef";
            this.txtLCG_Coef.Size = new System.Drawing.Size(72, 21);
            this.txtLCG_Coef.TabIndex = 0;
            this.txtLCG_Coef.Tag = "Coef";
            // 
            // txtLCG_Zero
            // 
            this.txtLCG_Zero.Location = new System.Drawing.Point(377, 25);
            this.txtLCG_Zero.Name = "txtLCG_Zero";
            this.txtLCG_Zero.Size = new System.Drawing.Size(72, 21);
            this.txtLCG_Zero.TabIndex = 0;
            this.txtLCG_Zero.Tag = "Zero";
            // 
            // grpFFG
            // 
            this.grpFFG.Controls.Add(this.lblFFG_Value);
            this.grpFFG.Controls.Add(this.lblFFG_Volt);
            this.grpFFG.Controls.Add(this.label7);
            this.grpFFG.Controls.Add(this.label8);
            this.grpFFG.Controls.Add(this.label9);
            this.grpFFG.Controls.Add(this.label10);
            this.grpFFG.Controls.Add(this.txtFFG_Coef);
            this.grpFFG.Controls.Add(this.txtFFG_Zero);
            this.grpFFG.Location = new System.Drawing.Point(529, 12);
            this.grpFFG.Name = "grpFFG";
            this.grpFFG.Size = new System.Drawing.Size(467, 109);
            this.grpFFG.TabIndex = 5;
            this.grpFFG.TabStop = false;
            this.grpFFG.Tag = "FFG";
            this.grpFFG.Text = "副风缸";
            // 
            // lblFFG_Value
            // 
            this.lblFFG_Value.AutoSize = true;
            this.lblFFG_Value.Location = new System.Drawing.Point(147, 71);
            this.lblFFG_Value.Name = "lblFFG_Value";
            this.lblFFG_Value.Size = new System.Drawing.Size(29, 12);
            this.lblFFG_Value.TabIndex = 2;
            this.lblFFG_Value.Text = "压力";
            // 
            // lblFFG_Volt
            // 
            this.lblFFG_Volt.AutoSize = true;
            this.lblFFG_Volt.Location = new System.Drawing.Point(147, 29);
            this.lblFFG_Volt.Name = "lblFFG_Volt";
            this.lblFFG_Volt.Size = new System.Drawing.Size(29, 12);
            this.lblFFG_Volt.TabIndex = 2;
            this.lblFFG_Volt.Text = "电压";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(228, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "传感器标定系数(Pa/mv)：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(228, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 12);
            this.label8.TabIndex = 1;
            this.label8.Text = "传感器零点电压(mv)：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 12);
            this.label9.TabIndex = 1;
            this.label9.Text = "传感器换算压力(kPa)：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 12);
            this.label10.TabIndex = 1;
            this.label10.Text = "传感器当前电压(mv)：";
            // 
            // txtFFG_Coef
            // 
            this.txtFFG_Coef.Location = new System.Drawing.Point(377, 67);
            this.txtFFG_Coef.Name = "txtFFG_Coef";
            this.txtFFG_Coef.Size = new System.Drawing.Size(72, 21);
            this.txtFFG_Coef.TabIndex = 0;
            this.txtFFG_Coef.Tag = "Coef";
            // 
            // txtFFG_Zero
            // 
            this.txtFFG_Zero.Location = new System.Drawing.Point(377, 25);
            this.txtFFG_Zero.Name = "txtFFG_Zero";
            this.txtFFG_Zero.Size = new System.Drawing.Size(72, 21);
            this.txtFFG_Zero.TabIndex = 0;
            this.txtFFG_Zero.Tag = "Zero";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblJHFG_Value);
            this.groupBox1.Controls.Add(this.lblJHFG_Volt);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtJHFG_Coef);
            this.groupBox1.Controls.Add(this.txtJHFG_Zero);
            this.groupBox1.Location = new System.Drawing.Point(20, 159);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 109);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Tag = "JHFG";
            this.groupBox1.Text = "加缓风缸";
            // 
            // lblJHFG_Value
            // 
            this.lblJHFG_Value.AutoSize = true;
            this.lblJHFG_Value.Location = new System.Drawing.Point(147, 71);
            this.lblJHFG_Value.Name = "lblJHFG_Value";
            this.lblJHFG_Value.Size = new System.Drawing.Size(29, 12);
            this.lblJHFG_Value.TabIndex = 2;
            this.lblJHFG_Value.Text = "压力";
            // 
            // lblJHFG_Volt
            // 
            this.lblJHFG_Volt.AutoSize = true;
            this.lblJHFG_Volt.Location = new System.Drawing.Point(147, 29);
            this.lblJHFG_Volt.Name = "lblJHFG_Volt";
            this.lblJHFG_Volt.Size = new System.Drawing.Size(29, 12);
            this.lblJHFG_Volt.TabIndex = 2;
            this.lblJHFG_Volt.Text = "电压";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(228, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(143, 12);
            this.label11.TabIndex = 1;
            this.label11.Text = "传感器标定系数(Pa/mv)：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(228, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 12);
            this.label12.TabIndex = 1;
            this.label12.Text = "传感器零点电压(mv)：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 71);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(131, 12);
            this.label13.TabIndex = 1;
            this.label13.Text = "传感器换算压力(kPa)：";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(20, 29);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(125, 12);
            this.label14.TabIndex = 1;
            this.label14.Text = "传感器当前电压(mv)：";
            // 
            // txtJHFG_Coef
            // 
            this.txtJHFG_Coef.Location = new System.Drawing.Point(377, 67);
            this.txtJHFG_Coef.Name = "txtJHFG_Coef";
            this.txtJHFG_Coef.Size = new System.Drawing.Size(72, 21);
            this.txtJHFG_Coef.TabIndex = 0;
            this.txtJHFG_Coef.Tag = "Coef";
            // 
            // txtJHFG_Zero
            // 
            this.txtJHFG_Zero.Location = new System.Drawing.Point(377, 25);
            this.txtJHFG_Zero.Name = "txtJHFG_Zero";
            this.txtJHFG_Zero.Size = new System.Drawing.Size(72, 21);
            this.txtJHFG_Zero.TabIndex = 0;
            this.txtJHFG_Zero.Tag = "Zero";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblJYFG_Value);
            this.groupBox2.Controls.Add(this.lblJYFG_Volt);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.txtJYFG_Coef);
            this.groupBox2.Controls.Add(this.txtJYFG_Zero);
            this.groupBox2.Location = new System.Drawing.Point(529, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(467, 109);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Tag = "JYFG";
            this.groupBox2.Text = "降压风缸";
            // 
            // lblJYFG_Value
            // 
            this.lblJYFG_Value.AutoSize = true;
            this.lblJYFG_Value.Location = new System.Drawing.Point(147, 71);
            this.lblJYFG_Value.Name = "lblJYFG_Value";
            this.lblJYFG_Value.Size = new System.Drawing.Size(29, 12);
            this.lblJYFG_Value.TabIndex = 2;
            this.lblJYFG_Value.Text = "压力";
            // 
            // lblJYFG_Volt
            // 
            this.lblJYFG_Volt.AutoSize = true;
            this.lblJYFG_Volt.Location = new System.Drawing.Point(147, 29);
            this.lblJYFG_Volt.Name = "lblJYFG_Volt";
            this.lblJYFG_Volt.Size = new System.Drawing.Size(29, 12);
            this.lblJYFG_Volt.TabIndex = 2;
            this.lblJYFG_Volt.Text = "电压";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(228, 71);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(143, 12);
            this.label17.TabIndex = 1;
            this.label17.Text = "传感器标定系数(Pa/mv)：";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(228, 29);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(125, 12);
            this.label18.TabIndex = 1;
            this.label18.Text = "传感器零点电压(mv)：";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(20, 71);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(131, 12);
            this.label19.TabIndex = 1;
            this.label19.Text = "传感器换算压力(kPa)：";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(20, 29);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(125, 12);
            this.label20.TabIndex = 1;
            this.label20.Text = "传感器当前电压(mv)：";
            // 
            // txtJYFG_Coef
            // 
            this.txtJYFG_Coef.Location = new System.Drawing.Point(377, 67);
            this.txtJYFG_Coef.Name = "txtJYFG_Coef";
            this.txtJYFG_Coef.Size = new System.Drawing.Size(72, 21);
            this.txtJYFG_Coef.TabIndex = 0;
            this.txtJYFG_Coef.Tag = "Coef";
            // 
            // txtJYFG_Zero
            // 
            this.txtJYFG_Zero.Location = new System.Drawing.Point(377, 25);
            this.txtJYFG_Zero.Name = "txtJYFG_Zero";
            this.txtJYFG_Zero.Size = new System.Drawing.Size(72, 21);
            this.txtJYFG_Zero.TabIndex = 0;
            this.txtJYFG_Zero.Tag = "Zero";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblZDG_Value);
            this.groupBox3.Controls.Add(this.lblZDG_Volt);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.label24);
            this.groupBox3.Controls.Add(this.label25);
            this.groupBox3.Controls.Add(this.label26);
            this.groupBox3.Controls.Add(this.txtZDG_Coef);
            this.groupBox3.Controls.Add(this.txtZDG_Zero);
            this.groupBox3.Location = new System.Drawing.Point(20, 317);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(467, 109);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Tag = "ZDG";
            this.groupBox3.Text = "制动缸";
            // 
            // lblZDG_Value
            // 
            this.lblZDG_Value.AutoSize = true;
            this.lblZDG_Value.Location = new System.Drawing.Point(147, 71);
            this.lblZDG_Value.Name = "lblZDG_Value";
            this.lblZDG_Value.Size = new System.Drawing.Size(29, 12);
            this.lblZDG_Value.TabIndex = 2;
            this.lblZDG_Value.Text = "压力";
            // 
            // lblZDG_Volt
            // 
            this.lblZDG_Volt.AutoSize = true;
            this.lblZDG_Volt.Location = new System.Drawing.Point(147, 29);
            this.lblZDG_Volt.Name = "lblZDG_Volt";
            this.lblZDG_Volt.Size = new System.Drawing.Size(29, 12);
            this.lblZDG_Volt.TabIndex = 2;
            this.lblZDG_Volt.Text = "电压";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(228, 71);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(143, 12);
            this.label23.TabIndex = 1;
            this.label23.Text = "传感器标定系数(Pa/mv)：";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(228, 29);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(125, 12);
            this.label24.TabIndex = 1;
            this.label24.Text = "传感器零点电压(mv)：";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(20, 71);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(131, 12);
            this.label25.TabIndex = 1;
            this.label25.Text = "传感器换算压力(kPa)：";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(20, 29);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(125, 12);
            this.label26.TabIndex = 1;
            this.label26.Text = "传感器当前电压(mv)：";
            // 
            // txtZDG_Coef
            // 
            this.txtZDG_Coef.Location = new System.Drawing.Point(377, 67);
            this.txtZDG_Coef.Name = "txtZDG_Coef";
            this.txtZDG_Coef.Size = new System.Drawing.Size(72, 21);
            this.txtZDG_Coef.TabIndex = 0;
            this.txtZDG_Coef.Tag = "Coef";
            // 
            // txtZDG_Zero
            // 
            this.txtZDG_Zero.Location = new System.Drawing.Point(377, 25);
            this.txtZDG_Zero.Name = "txtZDG_Zero";
            this.txtZDG_Zero.Size = new System.Drawing.Size(72, 21);
            this.txtZDG_Zero.TabIndex = 0;
            this.txtZDG_Zero.Tag = "Zero";
            // 
            // FrmSensorConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpFFG);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpLCG);
            this.Name = "FrmSensorConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSensorConfig";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmSensorConfig_Load);
            this.grpLCG.ResumeLayout(false);
            this.grpLCG.PerformLayout();
            this.grpFFG.ResumeLayout(false);
            this.grpFFG.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox grpLCG;
        private System.Windows.Forms.TextBox txtLCG_Coef;
        private System.Windows.Forms.TextBox txtLCG_Zero;
        private System.Windows.Forms.Label lblLCG_Volt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLCG_Value;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpFFG;
        private System.Windows.Forms.Label lblFFG_Value;
        private System.Windows.Forms.Label lblFFG_Volt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtFFG_Coef;
        private System.Windows.Forms.TextBox txtFFG_Zero;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblJHFG_Value;
        private System.Windows.Forms.Label lblJHFG_Volt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtJHFG_Coef;
        private System.Windows.Forms.TextBox txtJHFG_Zero;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblJYFG_Value;
        private System.Windows.Forms.Label lblJYFG_Volt;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtJYFG_Coef;
        private System.Windows.Forms.TextBox txtJYFG_Zero;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblZDG_Value;
        private System.Windows.Forms.Label lblZDG_Volt;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtZDG_Coef;
        private System.Windows.Forms.TextBox txtZDG_Zero;
    }
}