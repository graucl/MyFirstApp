using MyFirstApp.ForeachLoop;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;

namespace MyFirstApp.ForLoop
{
    public partial class frmForLoop : Form
    {
        public frmForLoop()
        {
            InitializeComponent();
        }

        private void frmForLoop_Load(object sender, EventArgs e)
        {
            String sAttr = ConfigurationManager.AppSettings.Get("CsvFile");
            MessageBox.Show(sAttr);
        }
    }
}
