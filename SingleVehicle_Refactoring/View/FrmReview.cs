using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace SingleVehicle_Refactoring.View
{
    public partial class FrmReview : Form
    {
        private readonly FrmMain _frmMain;
        public FrmReview(FrmMain frmMain)
        {
            InitializeComponent();
            _frmMain = frmMain;

            this.FormClosing += (s, e) => { _frmMain.Show(); }; // Show the main form when this form is closed
        }

        private void FrmReview_Load(object sender, EventArgs e)
        {
            BLL1.InitChart(chtReviewCurve);
            grpX.Enabled = false;
            grpY.Enabled = false;
        }

        private void ReviewCurve(string[] values)
        {
            float realTime = float.Parse(values[0]);
            this.chtReviewCurve.Series[0].Points.AddXY(realTime, float.Parse(values[1])); // LCG
            this.chtReviewCurve.Series[1].Points.AddXY(realTime, float.Parse(values[2])); // ZDG
            this.chtReviewCurve.Series[2].Points.AddXY(realTime, float.Parse(values[3])); // FFG
            this.chtReviewCurve.Series[3].Points.AddXY(realTime, float.Parse(values[4])); // JHFG
            this.chtReviewCurve.Series[4].Points.AddXY(realTime, float.Parse(values[5])); // JYFG
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            //string file = "";
            OpenFileDialog fileDialog = new OpenFileDialog
            {
                Filter = "CSV Files (*.csv)|*.csv",
                Title = "请选择文件",
                InitialDirectory = "D:\\试验数据",
            };
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (var series in this.chtReviewCurve.Series)
                {
                    if (series.Name != " " & series.Name != " ")
                    { // 排除空白系列
                        series.Points.Clear();
                    }
                }

                chkLCG.Checked = true;
                chkZDG.Checked = true;
                chkFFG.Checked = true;
                chkJHFG.Checked = true;
                chkJYFG.Checked = true;

                string file = fileDialog.FileName;
                string[] lines = System.IO.File.ReadAllLines(file);

                foreach (string line in lines.Skip(1))
                {
                    string[] values = line.Split(','); // 处理每一行的数据
                    ReviewCurve(values); // 调用绘图函数
                }

                grpX.Enabled = true;
                grpY.Enabled = true;
            }
            else
            {
                MessageBox.Show("未选择文件");
            }
        }

        private void chkSeries_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox check = sender as CheckBox;
            chtReviewCurve.Series[check.Text.ToString()].Enabled = check.Checked;
        }

        // 根据输入的最小值和最大值对X轴进行缩放，间隔设置为最大值和最小值之差的十分之一，最小为0.1
        private void btnScaleX_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMinX.Text) || string.IsNullOrEmpty(txtMaxX.Text))
            {
                MessageBox.Show("请输入最小值和最大值");
                return;
            }
            float minX = float.Parse(txtMinX.Text);
            float maxX = float.Parse(txtMaxX.Text);
            if (minX >= maxX)
            {
                MessageBox.Show("最小值必须小于最大值");
                return;
            }
            chtReviewCurve.ChartAreas[0].AxisX.Minimum = minX;
            chtReviewCurve.ChartAreas[0].AxisX.Maximum = maxX;
            chtReviewCurve.ChartAreas[0].AxisX.Interval = maxX - minX >= 1 ? Math.Round((maxX - minX) / 10, 1) : 0.1;
        }

        private void btnRestoreX_Click(object sender, EventArgs e)
        {
            chtReviewCurve.ChartAreas[0].AxisX.Minimum = 0;
            chtReviewCurve.ChartAreas[0].AxisX.Maximum = double.NaN; // NaN表示自动计算最大值
            chtReviewCurve.ChartAreas[0].AxisX.Interval = 0; // 0表示自动计算间隔
        }

        // 根据输入的最小值和最大值对Y轴进行缩放，间隔设置为最大值和最小值之差的十分之一，最小为1
        private void btnScaleY_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMinY.Text) || string.IsNullOrEmpty(txtMaxY.Text))
            {
                MessageBox.Show("请输入最小值和最大值");
                return;
            }
            float minY = float.Parse(txtMinY.Text);
            float maxY = float.Parse(txtMaxY.Text);
            if (minY >= maxY)
            {
                MessageBox.Show("最小值必须小于最大值");
                return;
            }
            chtReviewCurve.ChartAreas[0].AxisY.Minimum = minY;
            chtReviewCurve.ChartAreas[0].AxisY.Maximum = maxY;
            chtReviewCurve.ChartAreas[0].AxisY.Interval = maxY - minY >= 10 ? Math.Round((maxY - minY) / 10, 1) : 1;
        }

        private void btnRestoreY_Click(object sender, EventArgs e)
        {
            chtReviewCurve.ChartAreas[0].AxisY.Minimum = 0;
            chtReviewCurve.ChartAreas[0].AxisY.Maximum = double.NaN; // NaN表示自动计算最大值
            chtReviewCurve.ChartAreas[0].AxisY.Interval = 0; // 0表示自动计算间隔
        }

        private void txtScale_Click(object sender, EventArgs e)
        {
            FrmNumberPad frmNumberPad = new FrmNumberPad(sender);
            frmNumberPad.ShowDialog();
            frmNumberPad.Dispose();
        }

    }
}
