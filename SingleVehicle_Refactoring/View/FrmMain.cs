using SingleVehicle_Refactoring.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SingleVehicle_Refactoring
{
    public partial class FrmMain : Form
    {
        
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnManual_Click(object sender, EventArgs e)
        {
            FrmManual frmManual = new FrmManual(this);
            this.Hide();
            frmManual.ShowDialog();
            frmManual.Dispose();
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            FrmSensorConfig frmSensorConfig = new FrmSensorConfig(this);
            this.Hide();
            frmSensorConfig.ShowDialog();
            frmSensorConfig.Dispose();
        }

        private void btnReview_Click(object sender, EventArgs e)
        {
            FrmReview frmReview = new FrmReview(this);
            this.Hide();
            frmReview.ShowDialog();
            frmReview.Dispose();
        }
    }
}
