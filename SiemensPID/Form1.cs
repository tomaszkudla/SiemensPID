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
        double temp;
        
        public Form1()
        {
            InitializeComponent();
            pid = new PID { CYCLE = 100, GAIN = 0.1, I_SEL = true, P_SEL = true, TI = 100.0 , PV_IN = 90.0, SP_INT=95.0, MAN_ON=false};
            cbHand.Checked = pid.MAN_ON;
            tbPV.Text = pid.PV_IN.ToString("F5");
            tbSP.Text = pid.SP_INT.ToString("F5");
            tbK.Text = pid.GAIN.ToString("F5");
            tbTi.Text = pid.TI.ToString("F5");
            tbTlag.Text = pid.TM_LAG.ToString("F5");
            tbTd.Text = pid.TD.ToString("F5");
            tbYmax.Text = pid.LMN_HLM.ToString("F5");
            tbYmin.Text = pid.LMN_LLM.ToString("F5");
            tbDeadband.Text = pid.DEADB_W.ToString("F5");
            timer1.Start();

        }

        private void cbHand_CheckedChanged(object sender, EventArgs e)
        {
            pid.MAN_ON = cbHand.Checked;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pid.Go();
            tbOUT.Text = pid.LMN.ToString("F5");
        }

        private void tbPV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                if (double.TryParse(tbPV.Text, out temp))
                {
                    pid.PV_IN = temp;
                    tbPV.Text = pid.PV_IN.ToString("F5");
                    tbPV.BackColor = Color.White;
                }
                else
                {
                    tbPV.BackColor = Color.LightPink;
                }

            }
        }

        private void tbSP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                if (double.TryParse(tbSP.Text, out temp))
                {
                    pid.SP_INT = temp;
                    tbSP.Text = pid.SP_INT.ToString("F5");
                    tbSP.BackColor = Color.White;
                }
                else
                {
                    tbSP.BackColor = Color.LightPink;
                }

            }
        }

        private void tbSP_Leave(object sender, EventArgs e)
        {
            tbSP.Text = pid.SP_INT.ToString("F5");
        }

        private void tbSP_Enter(object sender, EventArgs e)
        {
            tbSP.Text = "";
        }

        private void tbK_Enter(object sender, EventArgs e)
        {
            tbK.Text = "";
        }

        private void tbK_Leave(object sender, EventArgs e)
        {
            tbK.Text = pid.GAIN.ToString("F5");
            tbK.BackColor = Color.White;
        }

        private void tbK_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                if (double.TryParse(tbK.Text, out temp))
                {
                    pid.GAIN = temp;
                    tbTi.Focus();
                    tbK.BackColor = Color.White;
                }
                else
                {
                    tbK.BackColor = Color.LightPink;
                }

            }
        }

        private void tbTi_Enter(object sender, EventArgs e)
        {
            tbTi.Text = "";
        }

        private void tbTi_Leave(object sender, EventArgs e)
        {
            tbTi.Text = pid.TI.ToString("F5");
        }

        private void tbTi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                if (double.TryParse(tbTi.Text, out temp))
                {
                    pid.TI = temp;
                    tbTlag.Focus();
                    tbTi.BackColor = Color.White;
                }
                else
                {
                    tbTi.BackColor = Color.LightPink;
                }
            }
        }

        private void tbTlag_Enter(object sender, EventArgs e)
        {
            tbTlag.Text = "";
        }

        private void tbTlag_Leave(object sender, EventArgs e)
        {
            tbTlag.Text = pid.TM_LAG.ToString("F5");
        }

        private void tbTlag_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                if (double.TryParse(tbTlag.Text, out temp))
                {
                    pid.TM_LAG = temp;
                    tbTd.Focus();
                    tbTlag.BackColor = Color.White;
                }
                else
                {
                    tbTlag.BackColor = Color.LightPink;
                }
            }
        }

        private void tbTd_Enter(object sender, EventArgs e)
        {
            tbTd.Text = "";
        }

        private void tbTd_Leave(object sender, EventArgs e)
        {
            tbTd.Text = pid.TD.ToString("F5");
        }

        private void tbTd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                if (double.TryParse(tbTd.Text, out temp))
                {
                    pid.TD = temp;
                    tbYmax.Focus();
                    tbTd.BackColor = Color.White;
                }
                else
                {
                    tbTd.BackColor = Color.LightPink;
                }
            }
        }

        private void tbYmax_Enter(object sender, EventArgs e)
        {
            tbYmax.Text = "";
        }

        private void tbYmax_Leave(object sender, EventArgs e)
        {
            tbYmax.Text = pid.LMN_HLM.ToString("F5");
        }

        private void tbYmax_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                if (double.TryParse(tbYmax.Text, out temp))
                {
                    pid.LMN_HLM = temp;
                    tbYmin.Focus();
                    tbYmax.BackColor = Color.White;
                }
                else
                {
                    tbYmax.BackColor = Color.LightPink;
                }
            }
        }

        private void tbYmin_Enter(object sender, EventArgs e)
        {
            tbYmin.Text = "";
        }

        private void tbYmin_Leave(object sender, EventArgs e)
        {
            tbYmin.Text = pid.LMN_LLM.ToString("F5");
        }

        private void tbYmin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                if (double.TryParse(tbYmin.Text, out temp))
                {
                    pid.LMN_LLM = temp;
                    tbDeadband.Focus();
                    tbYmin.BackColor = Color.White;
                }
                else
                {
                    tbYmin.BackColor = Color.LightPink;
                }
            }
        }

        private void tbDeadband_Enter(object sender, EventArgs e)
        {
            tbDeadband.Text = "";
        }

        private void tbDeadband_Leave(object sender, EventArgs e)
        {
            tbDeadband.Text = pid.DEADB_W.ToString("F5");
        }

        private void tbDeadband_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                if (double.TryParse(tbDeadband.Text, out temp))
                {
                    pid.DEADB_W = temp;
                    tbDeadband.Text = pid.DEADB_W.ToString("F5");
                    tbDeadband.BackColor = Color.White;
                }
                else
                {
                    tbDeadband.BackColor = Color.LightPink;
                }
            }
        }

        private void tbPV_Enter(object sender, EventArgs e)
        {
            tbPV.Text = "";
        }

        private void tbPV_Leave(object sender, EventArgs e)
        {
            tbPV.Text = pid.SP_INT.ToString("F5");
        }
    }
}
