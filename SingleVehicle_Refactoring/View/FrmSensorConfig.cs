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
    public partial class FrmSensorConfig : Form
    {
        private readonly FrmMain _frmMain;
        public FrmSensorConfig(FrmMain frmMain)
        {
            InitializeComponent();
            _frmMain = frmMain;
            this.FormClosing += (s, e) => { _frmMain.Show(); }; // Show the main form when this form is closed
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
