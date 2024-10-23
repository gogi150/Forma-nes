using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Windows_kontrola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            while (cbxAction.Checked)
            {
                groupBox1.Hide();
            }

        }

        private void cmbRun_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (cmbRun.SelectedIndex == 0)
            {
                ProcessStartInfo startInfo = new ProcessStartInfo("Notepad.exe");
                startInfo.WindowStyle = ProcessWindowStyle.Normal;
                Process.Start("Notepad.exe");
            }
            else if (cmbRun.SelectedIndex == 1)
            {
                ProcessStartInfo startInfo = new ProcessStartInfo("Bojanje.exe");
                startInfo.WindowStyle = ProcessWindowStyle.Normal;
                Process.Start("Bojanje.exe");
            }
        }

    }
}
