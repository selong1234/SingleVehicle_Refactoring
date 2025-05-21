using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SingleVehicle_Refactoring.View
{
    public partial class FrmNumberPad : Form
    {
        TextBox textBox;
        public FrmNumberPad(object sender)
        {
            textBox = sender as TextBox;
            InitializeComponent();
        }

        // 数字键
        private void btnNumber_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            string number = button.Text;
            textBox.AppendText(number);
        }

        // 小数点键
        private void btnDot_Click(object sender, EventArgs e)
        {
            if (textBox.Text.Length == 0 || textBox.Text.Contains("."))
                return;
            textBox.AppendText(".");
        }

        // 退格键
        private void btnBS_Click(object sender, EventArgs e)
        {
            if (textBox.Text.Length == 0)
                return;
            textBox.Text = textBox.Text.Substring(0, textBox.Text.Length - 1);
        }

        // 清除键
        private void btnCE_Click(object sender, EventArgs e)
        {
            textBox.Text = string.Empty;
        }

        // 退出键
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
