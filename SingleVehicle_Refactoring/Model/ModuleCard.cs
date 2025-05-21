using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using P100x_Ns;
using System.Collections;
using System.Diagnostics;

namespace Model
{
    public class ModuleCard
    {
        ushort TotalBoard = 0;
        ushort BoardNo = 0;
        //ushort PortNo = 0;

        /// <summary>
        /// 输出通道
        /// 0是1位-急充风
        /// 1是2位-慢充风
        /// 2是4位-感度位
        /// 3是5位
        /// 4是6位
        /// 5是常用位-安定位
        /// 6是紧急位
        /// </summary>
        BitArray DO_Channel = new BitArray(15);

        public void InitCard()
        {
            ushort rtn = P100x.DriverInit(out TotalBoard);
            if (rtn != P100x.NoError)
            {
                MessageBox.Show("Driver Inital Error!!Error Code:" + rtn.ToString());
                //Close();
                return;
            }
            if (P100x.ActiveBoard(BoardNo) != P100x.NoError)
            {
                MessageBox.Show("Can not active the board");
            }
        }

        public void CloseCard()
        {
            P100x.DriverClose();
        }

        public float[] ReadAI(ushort sample, ushort sensorAmount)
        {
            ushort CfgCode = 0;
            float[] AverageVoltage = new float[sensorAmount];  //采集电压平均值
            float[,] Voltages = new float[sensorAmount, sample];  //采集电压值数组

            for (ushort channel = 0; channel < sensorAmount; channel++)
            {
                float temp = 0;
                P100x.SetChConfig(channel, CfgCode);
                if (P100x.AdMultiPollingF(out Voltages[channel, 0], sample) != P100x.NoError)
                {
                    MessageBox.Show("PCI-1002 AD Polling Error!!!");
                }
                for (int i = 0; i < sample; i++)
                {
                    temp += Voltages[channel, i];
                }
                AverageVoltage[channel] = temp / sample * 1000;
            }

            return AverageVoltage;
        }

        /// <summary>
        /// 快充位
        /// </summary>
        public void Charge_Fast(bool value)
        {
            DO_Channel[0] = value;
            WriteDO();
        }

        /// <summary>
        /// 慢充位
        /// </summary>
        public void Charge_Slow(bool value)
        {
            DO_Channel[1] = value;
            WriteDO();
        }

        /// <summary>
        /// 感度位
        /// </summary>
        public void Discharge_Sensitivity(bool value)
        {
            DO_Channel[2] = value;
            WriteDO();
        }

        /// <summary>
        /// 5位
        /// </summary>
        public void Discharge_5(bool value)
        {
            DO_Channel[3] = value;
            WriteDO();
        }

        /// <summary>
        /// 6位
        /// </summary>
        public void Discharge_6(bool value)
        {
            DO_Channel[4] = value;
            WriteDO();
        }

        /// <summary>
        /// 常用位
        /// </summary>
        public void Discharge_Stability(bool value)
        {
            DO_Channel[5] = value;
            WriteDO();
        }

        /// <summary>
        /// 紧急位
        /// </summary>
        public void Discharge_Emergency(bool value)
        {
            DO_Channel[6] = value;
            WriteDO();
        }

        /// <summary>
        /// 风压切换
        /// </summary>
        public void Switch_Pressure(bool value)
        {
            DO_Channel[8] = value;
            WriteDO();
        }

        /// <summary>
        /// 关闭所有通道
        /// </summary>
        public void CloseAllChannel()
        {
            for (int i = 0; i < DO_Channel.Length; i++)
                DO_Channel[i] = false;
            WriteDO();
        }

        #region other method
        private void WriteDO()
        {
            int output = 0;
            for (int i = 0; i < DO_Channel.Length; i++)
            {
                if (DO_Channel.Get(i))
                {
                    output |= 1 << i;
                }
            }
            P100x.DigitOut(Convert.ToUInt32(output));
        }
        #endregion
    }
}
