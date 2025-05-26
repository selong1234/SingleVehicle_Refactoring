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
                        CommonFun.sensorParameter.SetValue(section, key, textBox.Text);
                    }
                }
                CommonFun.sensorParameter.WriteIniFile();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            MessageBox.Show("Save Success");
        }

        private void FrmSensorConfig_Load(object sender, EventArgs e)
        {
            moduleCard.InitCard();
            CommonFun.SensorInit();
            Task.Factory.StartNew(() =>
            {
                CommonFun.ReadAI(500);
            });
            timerUpdateData.Start();

            foreach (var group in this.Controls.OfType<GroupBox>())
            {
                foreach (var textBox in group.Controls.OfType<TextBox>())
                {
                    textBox.Click += CommonFun.NumberPadInvoke;

                    string section = group.Tag.ToString();
                    string key = textBox.Tag.ToString();
                    textBox.Text = CommonFun.sensorParameter.GetValue(section, key);
                }
            }
        }

        private void UpdateData(object sender, ElapsedEventArgs e)
        {
            this.Invoke(new Action(() =>
            {
                lblLCG_Volt.Text = CommonFun.sensorLCG.Voltage.ToString();
                lblLCG_Value.Text = CommonFun.sensorLCG.Value.ToString();
                lblFFG_Volt.Text = CommonFun.sensorFFG.Voltage.ToString();
                lblFFG_Value.Text = CommonFun.sensorFFG.Value.ToString();
                lblJHFG_Volt.Text = CommonFun.sensorJHFG.Voltage.ToString();
                lblJHFG_Value.Text = CommonFun.sensorJHFG.Value.ToString();
                lblJYFG_Volt.Text = CommonFun.sensorJYFG.Voltage.ToString();
                lblJYFG_Value.Text = CommonFun.sensorJYFG.Value.ToString();
                lblZDG_Volt.Text = CommonFun.sensorZDG.Voltage.ToString();
                lblZDG_Value.Text = CommonFun.sensorZDG.Value.ToString();
            }));
        }
    }
}
