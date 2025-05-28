using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using BLL;
using Model; // Assuming INIHelper is in the Model namespace

namespace SingleVehicle_Refactoring.View
{
    public partial class FrmSensorConfig : Form
    {
        private readonly FrmMain _frmMain;
        private readonly System.Timers.Timer timerUpdateData = new System.Timers.Timer(500); // 更新显示数据，频率2Hz
        private readonly ModuleCard moduleCard = new ModuleCard();

        public FrmSensorConfig(FrmMain frmMain)
        {
            InitializeComponent();
            _frmMain = frmMain;
            this.FormClosing += (s, e) => { _frmMain.Show(); }; // Show the main form when this form is closed
            timerUpdateData.Elapsed += UpdateData;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var group in this.Controls.OfType<GroupBox>())
                {
                    foreach (var textBox in group.Controls.OfType<TextBox>())
                    {
                        string section = group.Tag.ToString();
                        string key = textBox.Tag.ToString();
                        CommonFunc.sensorParameter.SetValue(section, key, textBox.Text);
                    }
                }
                CommonFunc.sensorParameter.WriteIniFile();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            MessageBox.Show("Save Success");
            CommonFunc.InitSensor();
        }

        private void FrmSensorConfig_Load(object sender, EventArgs e)
        {
            moduleCard.InitCard();
            CommonFunc.InitSensor();
            Task.Factory.StartNew(() =>
            {
                CommonFunc.ReadAI(500);
            });
            timerUpdateData.Start();

            foreach (var group in this.Controls.OfType<GroupBox>())
            {
                foreach (var textBox in group.Controls.OfType<TextBox>())
                {
                    textBox.Click += CommonFunc.NumberPadInvoke;

                    string section = group.Tag.ToString();
                    string key = textBox.Tag.ToString();
                    textBox.Text = CommonFunc.sensorParameter.GetValue(section, key);
                }
            }
        }

        private void UpdateData(object sender, ElapsedEventArgs e)
        {
            this.Invoke(new Action(() =>
            {
                lblLCG_Volt.Text = CommonFunc.sensorLCG.Voltage.ToString("F1");
                lblLCG_Value.Text = CommonFunc.sensorLCG.Value.ToString("F1");
                lblFFG_Volt.Text = CommonFunc.sensorFFG.Voltage.ToString("F1");
                lblFFG_Value.Text = CommonFunc.sensorFFG.Value.ToString("F1");
                lblJHFG_Volt.Text = CommonFunc.sensorJHFG.Voltage.ToString("F1");
                lblJHFG_Value.Text = CommonFunc.sensorJHFG.Value.ToString("F1");
                lblJYFG_Volt.Text = CommonFunc.sensorJYFG.Voltage.ToString("F1");
                lblJYFG_Value.Text = CommonFunc.sensorJYFG.Value.ToString("F1");
                lblZDG_Volt.Text = CommonFunc.sensorZDG.Voltage.ToString("F1");
                lblZDG_Value.Text = CommonFunc.sensorZDG.Value.ToString("F1");
            }));
        }
    }
}
