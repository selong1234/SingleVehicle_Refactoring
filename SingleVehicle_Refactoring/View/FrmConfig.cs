using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Model;
using BLL;

namespace SingleVehicle_Refactoring
{
    public partial class FrmConfig : Form
    {
        private readonly FrmMain _frmMain;


        public FrmConfig(FrmMain frmMain)
        {
            InitializeComponent();
            _frmMain = frmMain;
            this.FormClosing += (s, e) => { frmMain.Show(); }; // Show the main form when this form is closed
        }

        // Load configuration settings from INI file


        public void FrmConfig_Load(object sender, EventArgs e)
        {
            string[] paras = BLL1.LoadUserConfiguration();
            txtDataSavePath.Text = paras[0];
        }

        private void btnSaveCfg_Click(object sender, EventArgs e)
        {
            string[] paras = new string[50];
            paras[0] = txtDataSavePath.Text;
            BLL1.SaveUserConfiguration(paras);
        }

    }
}
