using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Configuration;
using Model;
using BLL;

namespace SingleVehicle_Refactoring
{

    public partial class FrmManual : Form
    {
        private readonly FrmMain _frmMain;

        private List<Control> controlButtons = new List<Control>();
        private Color controlButton_ForeColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFFFF");
        private Color controlButton_BackColor = System.Drawing.ColorTranslator.FromHtml("#FF0000FF");
        private Color controlButton_ActiveColor = System.Drawing.ColorTranslator.FromHtml("#FF008600");
        private ModuleCard moduleCard = new ModuleCard();

        private readonly System.Timers.Timer timerUpdateData = new System.Timers.Timer(500); // 更新显示数据，频率2Hz
        private readonly System.Timers.Timer timerDrawCurve = new System.Timers.Timer(100);  // 绘制曲线，频率10Hz

        private bool acquisitionFlag = false;
        int time = 0; //曲线横坐标
        public FrmManual(FrmMain frmMain)
        {
            InitializeComponent();
            //txtLCG.DataBindings.Add("Text", BLL1.sensorLCG, "Value");
            //txtZDG.DataBindings.Add("Text", BLL1.sensorZDG, "Value");
            //txtFFG.DataBindings.Add("Text", BLL1.sensorFFG, "Value");
            //txtJHFG.DataBindings.Add("Text", BLL1.sensorJHFG, "Value");
            //txtJYFG.DataBindings.Add("Text", BLL1.sensorJYFG, "Value");
            _frmMain = frmMain;
            this.FormClosing += (s, e) => { _frmMain.Show(); }; // Show the main form when this form is closed

            controlButtons.Add(btnFast);
            controlButtons.Add(btnSlow);
            controlButtons.Add(btnSensitivity);
            controlButtons.Add(btnNo5);
            controlButtons.Add(btnNo6);
            controlButtons.Add(btnStability);
            controlButtons.Add(btnEmergency);
            controlButtons.Add(btnSwitchPressure);

            foreach (var btn in controlButtons)
            {
                btn.Click += ControlButton_Click;
                btn.BackColor = controlButton_BackColor;  // 设置按钮初始背景颜色
                btn.ForeColor = controlButton_ForeColor;  // 设置按钮初始前景颜色
            }
            timerUpdateData.Elapsed += UpdateData;
            timerDrawCurve.Elapsed += DrawCurve;
        }

        private void DrawCurve(object sender, ElapsedEventArgs e)
        {
            this.Invoke(new Action(() =>
            {
                float realTime = (float)Math.Round(time / 10d, 1);
                this.chtCurve.Series[0].Points.AddXY(realTime, CommonFunc.sensorLCG.Value);
                this.chtCurve.Series[1].Points.AddXY(realTime, CommonFunc.sensorZDG.Value);
                this.chtCurve.Series[2].Points.AddXY(realTime, CommonFunc.sensorFFG.Value);
                this.chtCurve.Series[3].Points.AddXY(realTime, CommonFunc.sensorJHFG.Value);
                this.chtCurve.Series[4].Points.AddXY(realTime, CommonFunc.sensorJYFG.Value);
                this.chtCurve.Series[5].Points.AddXY(realTime, 0); // 空白系列，保持图表一致性
            }));

            time++;
            //if (time % 50 == 0)
            //{
            //    this.chtCurve.ChartAreas[0].AxisX.Interval = time / 10;
            //}
        }

        private void UpdateData(object sender, ElapsedEventArgs e)
        {
            this.Invoke(new Action(() =>
            {
                this.txtLCG.Text = CommonFunc.sensorLCG.Value.ToString("F1");
                this.txtZDG.Text = CommonFunc.sensorZDG.Value.ToString("F1");
                this.txtFFG.Text = CommonFunc.sensorFFG.Value.ToString("F1");
                this.txtJHFG.Text = CommonFunc.sensorJHFG.Value.ToString("F1");
                this.txtJYFG.Text = CommonFunc.sensorJYFG.Value.ToString("F1");
            }));
        }

        private void FrmManual_Load(object sender, EventArgs e)
        {
            moduleCard.InitCard();
            CommonFunc.InitSensor();
            CommonFunc.InitChart(chtCurve);

            Task.Factory.StartNew(() =>
            {
                CommonFunc.ReadAI(100);
            });
            timerUpdateData.Start();
            btnAcquisitionStart.Enabled = true;
            btnAcquisitionStop.Enabled = false;
            btnSaveData.Enabled = false;
        }

        private void ControlButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor == controlButton_BackColor)
            {
                switch (btn.Text)
                {
                    case "一位":
                        moduleCard.Charge_Fast(true);
                        btn.Text = "一位开启";
                        break;
                    case "二位":
                        moduleCard.Charge_Slow(true);
                        btn.Text = "二位开启";
                        break;
                    case "四位":
                        moduleCard.Discharge_Sensitivity(true);
                        btn.Text = "四位开启";
                        break;
                    case "五位":
                        moduleCard.Discharge_5(true);
                        btn.Text = "五位开启";
                        break;
                    case "六位":
                        moduleCard.Discharge_6(true);
                        btn.Text = "六位开启";
                        break;
                    case "常用":
                        moduleCard.Discharge_Stability(true);
                        btn.Text = "常用开启";
                        break;
                    case "紧急":
                        moduleCard.Discharge_Emergency(true);
                        btn.Text = "紧急开启";
                        break;
                    case "风压切换\n500kPa":
                        moduleCard.Switch_Pressure(true);
                        btn.Text = "风压切换\n600kPa";
                        break;
                    default:
                        MessageBox.Show("按钮控制出错");
                        return;
                }
                btn.BackColor = controlButton_ActiveColor;
            }
            else
            {
                switch (btn.Text)
                {
                    case "一位开启":
                        moduleCard.Charge_Fast(false);
                        btn.Text = "一位";
                        break;
                    case "二位开启":
                        moduleCard.Charge_Slow(false);
                        btn.Text = "二位";
                        break;
                    case "四位开启":
                        moduleCard.Discharge_Sensitivity(false);
                        btn.Text = "四位";
                        break;
                    case "五位开启":
                        moduleCard.Discharge_5(false);
                        btn.Text = "五位";
                        break;
                    case "六位开启":
                        moduleCard.Discharge_6(false);
                        btn.Text = "六位";
                        break;
                    case "常用开启":
                        moduleCard.Discharge_Stability(false);
                        btn.Text = "常用";
                        break;
                    case "紧急开启":
                        moduleCard.Discharge_Emergency(false);
                        btn.Text = "紧急";
                        break;
                    case "风压切换\n600kPa":
                        moduleCard.Switch_Pressure(false);
                        btn.Text = "风压切换\n500kPa";
                        break;
                    default:
                        MessageBox.Show("按钮控制出错");
                        return;
                }
                btn.BackColor = controlButton_BackColor;
            }

        }

        private void chkSeries_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox check = sender as CheckBox;
            chtCurve.Series[check.Text.ToString()].Enabled = check.Checked;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            moduleCard.CloseAllChannel();  // 关闭所有通道
            foreach (var btn in controlButtons)
            {
                if (!btn.Text.Contains("风压切换"))
                {
                    btn.BackColor = controlButton_BackColor;  // 恢复按钮背景颜色
                    btn.Text = btn.Text.Substring(0, btn.Text.Length - 2);  // 恢复按钮文本
                }
            }
        }

        #region 开始采集
        /// <summary>
        /// 开始采集按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAcquisitionStart_Click(object sender, EventArgs e)
        {
            foreach (var series in this.chtCurve.Series)
            {
                if (series.Name != " ") // 排除空白系列
                {
                    series.Points.Clear();
                }
            }
            time = 0;
            timerDrawCurve.Start();
            btnSaveData.Enabled = false;
            btnAcquisitionStart.Enabled = false;
            btnAcquisitionStop.Enabled = true;
            this.ControlBox = false; // 禁用关闭按钮，防止关闭窗口
        }
        #endregion

        private void btnAcquisitionStop_Click(object sender, EventArgs e)
        {
            timerDrawCurve.Stop();
            btnSaveData.Enabled = true;
            btnAcquisitionStop.Enabled = false;
            btnAcquisitionStart.Enabled = true;
            this.ControlBox = true;
        }

        private void btnSaveData_Click(object sender, EventArgs e)
        {
            string path = ConfigurationManager.AppSettings["DataSavePath"];  // 试验数据保存路径
            CommonFunc.SaveCSV(chtCurve, path);
            MessageBox.Show("数据存储完毕");
        }

        private void FrmManual_FormClosing(object sender, FormClosingEventArgs e)
        {
            moduleCard.CloseAllChannel();
            moduleCard.CloseCard();
        }
    }
}
