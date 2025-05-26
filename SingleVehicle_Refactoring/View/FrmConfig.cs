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
        private string[] _paras = new string[50];

        static string configFilePath = AppDomain.CurrentDomain.BaseDirectory + "Config.ini";

        private static readonly INIHelper sensorParameter = new INIHelper(configFilePath);


        public FrmConfig(FrmMain frmMain)
        {
            InitializeComponent();
            _frmMain = frmMain;
            this.FormClosing += (s, e) => { frmMain.Show(); }; // Show the main form when this form is closed
        }

        // Load configuration settings from INI file


        public void FrmConfig_Load(object sender, EventArgs e)
        {
            //_paras = CommonFun.LoadUserConfiguration();
            //txtDataSavePath.Text = _paras[0];
        }

        private void btnSaveCfg_Click(object sender, EventArgs e)
        {
            //_paras[0] = txtDataSavePath.Text;
            //CommonFun.SaveUserConfiguration(_paras);
        }

    }
}
