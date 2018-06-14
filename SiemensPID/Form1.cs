using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiemensPID
{
    public partial class Form1 : Form
    {
        PID pid;
     
        public Form1()
        {
            InitializeComponent();
            pid = new PID { CYCLE = 100, GAIN = 0.1, I_SEL = true, P_SEL = true, TI = 100.0 , PV_IN = 90.0, SP_INT=95.0, MAN_ON=false};
            cbHand.Checked = pid.MAN_ON;
            tbPV.Text = pid.PV_IN.ToString();
            tbSP.Text = pid.SP_INT.ToString();
            timer1.Start();

        }

        private void cbHand_CheckedChanged(object sender, EventArgs e)
        {
            pid.MAN_ON = cbHand.Checked;
        }

        private void tbPV_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void tbSP_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pid.Go();
            tbOUT.Text = pid.LMN.ToString("F5");
        }

        private void tbPV_Validated(object sender, EventArgs e)
        {
            double.TryParse(tbPV.Text, out pid.PV_IN);
        }

        private void tbPV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter)) double.TryParse(tbPV.Text, out pid.PV_IN);
        }

        private void tbSP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter)) double.TryParse(tbSP.Text, out pid.SP_INT);
        }

        private void tbSP_Leave(object sender, EventArgs e)
        {
            tbSP.Text = pid.SP_INT.ToString();
        }

        private void tbSP_Enter(object sender, EventArgs e)
        {
            tbSP.Text = "";
        }
    }
}
