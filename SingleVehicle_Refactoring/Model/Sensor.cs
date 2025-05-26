using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Model
{

    public class Sensor : INotifyPropertyChanged
    {
        public int RangeMin;  //量程
        public int RangeMax;  //量程
        public int SignalMin;
        //int SignalMax;
        //int Resistance;
        private float _value;
        public float Value
        {
            //private set
            //{
            //    this._value = value;
            //    //OnPropertyChanged("Value");
            //}
            get
            {
                this._value = (this._voltage - this.Zero) * (this.Coef) / 1000;
                return this._value > 0 ? (int)this._value : 0;
            }
        }
        private float _voltage;
        public float Voltage
        {
            set
            {
                if (this._voltage == value)
                    return;

                this._voltage = value;
            }
            get
            {
                return this._voltage;
            }
        }
        public float Zero;  //零点
        public float Coef;  //标定
        public float Modify;  //修正
        //float CalVolt1;  //校准电压
        //float CalVolt2;  //校准电压
        //float CalValue1;  //校准表显示值
        //float CalValue2;  //校准表显示值

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
