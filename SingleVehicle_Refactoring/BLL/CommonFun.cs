using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Timers;
//using S7.Net;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;
using SingleVehicle_Refactoring.View;


namespace BLL
{
    public static class CommonFun
    {
        const ushort Sample = 500;  //每次采集采样数 
        const ushort SensorAmount = 6;  //传感器数量
        static ModuleCard moduleCard = new ModuleCard();
        public static Sensor sensorLCG = new Sensor();
        public static Sensor sensorZDG = new Sensor();
        public static Sensor sensorFFG = new Sensor();
        public static Sensor sensorJHFG = new Sensor();
        public static Sensor sensorJYFG = new Sensor();

        static string iniFilePath = AppDomain.CurrentDomain.BaseDirectory + "Config.ini";

        static string sensorParameterFilePath = AppDomain.CurrentDomain.BaseDirectory + "/SensorParameter.ini";

        public static readonly INIHelper sensorParameter = new INIHelper(sensorParameterFilePath);


        public static void ReadSensorParams(string section, ref Sensor sensor)
        {          
            sensor.Zero = float.Parse(sensorParameter.GetValue(section, "Zero"));
            sensor.Coef = float.Parse(sensorParameter.GetValue(section, "Coef"));
            //sensor.Modify = float.Parse(iniHelper.GetValue(section, "Modify", filePath));
        }

        public static void SensorInit()
        {
            ReadSensorParams("LCG", ref sensorLCG);
            ReadSensorParams("ZDG", ref sensorZDG);
            ReadSensorParams("FFG", ref sensorFFG);
            ReadSensorParams("JHFG", ref sensorJHFG);
            ReadSensorParams("JYFG", ref sensorJYFG);
        }

        public static void ReadAI(int period)
        {
            float[] res = new float[SensorAmount];
            while (true)
            {
                res = moduleCard.ReadAI(Sample, SensorAmount);
                sensorLCG.Voltage = res[0];
                sensorZDG.Voltage = res[1];
                sensorFFG.Voltage = res[2];
                sensorJHFG.Voltage = res[3];
                sensorJYFG.Voltage = res[4];

                Thread.Sleep(period);
            }
        }

        #region 图表初始化
        public static void InitChart(Chart chart)
        {
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            dataPoint1.IsEmpty = true;

            chart.ChartAreas.Clear();
            ChartArea chartArea = new ChartArea("C1");
            chart.ChartAreas.Add(chartArea);

            chart.Series.Clear();

            Series seriesLCG = new Series("LCG");
            seriesLCG.ChartArea = "C1";
            chart.Series.Add(seriesLCG);

            Series seriesZDG = new Series("ZDG");
            seriesZDG.ChartArea = "C1";
            chart.Series.Add(seriesZDG);

            Series seriesFFG = new Series("FFG");
            seriesFFG.ChartArea = "C1";
            chart.Series.Add(seriesFFG);

            Series seriesJHFG = new Series("JHFG");
            seriesJHFG.ChartArea = "C1";
            chart.Series.Add(seriesJHFG);

            Series seriesJYFG = new Series("JYFG");
            seriesJYFG.ChartArea = "C1";
            chart.Series.Add(seriesJYFG);

            // 防止所有通道都不显示后，程序报错
            Series s0 = new Series("  ");
            s0.ChartArea = "C1";
            chart.Series.Add(s0);
            chart.Series["  "].Color = Color.White;
            chart.Series["  "].ChartType = SeriesChartType.Line;

            // 防止初始化时图表不显示
            Series s1 = new Series(" ");
            s1.ChartArea = "C1";
            chart.Series.Add(s1);
            s1.Points.Add(dataPoint1);
            chart.Series[" "].Color = Color.White;
            chart.Series[" "].ChartType = SeriesChartType.Line;

            chartArea.AxisX.Minimum = 0;
            chartArea.AxisX.Maximum = double.NaN; // NaN表示自动计算最大值
            chartArea.AxisX.MajorGrid.Interval = 0; // 0表示自动计算间隔
            chartArea.AxisX.MajorGrid.LineColor = System.Drawing.ColorTranslator.FromHtml("#FF555555");
            chartArea.AxisX.MinorGrid.Enabled = true;
            chartArea.AxisX.MinorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea.AxisX.MinorGrid.Interval = 0; // 0表示自动计算间隔

            chartArea.AxisY.Minimum = 0;
            chartArea.AxisY.Maximum = double.NaN; // NaN表示自动计算最大值
            chartArea.AxisY.MajorGrid.Interval = 100; // 0表示自动计算间隔
            chartArea.AxisY.MajorGrid.LineColor = System.Drawing.ColorTranslator.FromHtml("#FF555555");
            chartArea.AxisY.MinorGrid.Enabled = true;
            chartArea.AxisY.MinorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea.AxisY.MinorGrid.Interval = 0; // 0表示自动计算间隔

            chartArea.AxisX.Title = "相对时间 / s";
            chartArea.AxisY.Title = "压力 / kPa";

            chart.Titles.Clear();
            chart.Titles.Add("T01");
            chart.Titles[0].Text = "曲线显示";
            chart.Titles[0].ForeColor = System.Drawing.Color.RoyalBlue;

            seriesLCG.Color = System.Drawing.Color.Red;
            seriesLCG.ChartType = SeriesChartType.Line;
            seriesZDG.Color = System.Drawing.Color.Orange;
            seriesZDG.ChartType = SeriesChartType.Line;
            seriesFFG.Color = System.Drawing.Color.Blue;
            seriesFFG.ChartType = SeriesChartType.Line;
            seriesJHFG.Color = System.Drawing.Color.Green;
            seriesJHFG.ChartType = SeriesChartType.Line;
            seriesJYFG.Color = System.Drawing.Color.Cyan;
            seriesJYFG.ChartType = SeriesChartType.Line;
        }
        #endregion

        #region 保存数据到CSV文件
        /// <summary>
        /// 保存数据到CSV文件
        /// </summary>
        /// <param name="chart">数据图表</param>
        /// <param name="path">保存路径</param>
        public static void SaveCSV(Chart chart, string path)
        {
            string fileName = path + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + ".csv";//文件名
            //string Datedate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");//年月日小时分钟秒
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            if (!File.Exists(fileName))
            {
                using (StreamWriter sw = new StreamWriter(fileName, true, Encoding.UTF8))
                {
                    string title = "相对时间" + "," + "LCG" + "," + "ZDG" + "," + "FFG" + "," + "JHFG" + "," + "JYFG";
                    sw.WriteLine(title);

                    for (int i = 0; i < chart.Series[0].Points.Count; i++)
                    {
                        sw.WriteLine(
                            $"{chart.Series[0].Points[i].XValue}, " +
                            $"{chart.Series[0].Points[i].YValues[0]}, " +
                            $"{chart.Series[1].Points[i].YValues[0]}, " +
                            $"{chart.Series[2].Points[i].YValues[0]}, " +
                            $"{chart.Series[3].Points[i].YValues[0]}, " +
                            $"{chart.Series[4].Points[i].YValues[0]}");
                    }
                }
            }
            else
            {
                MessageBox.Show("文件名已存在，请稍后再试！");
            }
        }
        #endregion

        //public static string[] LoadUserConfiguration()
        //{
        //    string section;

        //    string[] value = new string[50];

        //    section = "DataSavePath";
        //    value[0] = iniHelper.GetValue(section, "Path");
        //    if (string.IsNullOrEmpty(value[0]))
        //    {
        //        value[0] = "D:\\试验数据";
        //    }

        //    return value;
        //}

        //public static void SaveUserConfiguration(string[] value)
        //{
        //    string section = "DataSavePath";
        //    INIHelper.INIWrite(section, "Path", value[0], iniFilePath);
        //}

        public static void NumberPadInvoke(object sender, EventArgs e)
        {
            FrmNumberPad frmNumberPad = new FrmNumberPad(sender);
            frmNumberPad.ShowDialog();
            frmNumberPad.Dispose();
        }
    }
}


