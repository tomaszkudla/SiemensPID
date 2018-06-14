namespace SiemensPID
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cbHand = new System.Windows.Forms.CheckBox();
            this.tbPV = new System.Windows.Forms.TextBox();
            this.lbPV = new System.Windows.Forms.Label();
            this.lbSP = new System.Windows.Forms.Label();
            this.tbSP = new System.Windows.Forms.TextBox();
            this.lbOUT = new System.Windows.Forms.Label();
            this.tbOUT = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // cbHand
            // 
            this.cbHand.AutoSize = true;
            this.cbHand.Location = new System.Drawing.Point(288, 44);
            this.cbHand.Name = "cbHand";
            this.cbHand.Size = new System.Drawing.Size(81, 17);
            this.cbHand.TabIndex = 0;
            this.cbHand.Text = "Hand mode";
            this.cbHand.UseVisualStyleBackColor = true;
            this.cbHand.CheckedChanged += new System.EventHandler(this.cbHand_CheckedChanged);
            // 
            // tbPV
            // 
            this.tbPV.Location = new System.Drawing.Point(198, 93);
            this.tbPV.Name = "tbPV";
            this.tbPV.Size = new System.Drawing.Size(171, 20);
            this.tbPV.TabIndex = 1;
            this.tbPV.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPV_KeyDown);
            this.tbPV.Validated += new System.EventHandler(this.tbPV_Validated);
            // 
            // lbPV
            // 
            this.lbPV.AutoSize = true;
            this.lbPV.Location = new System.Drawing.Point(171, 96);
            this.lbPV.Name = "lbPV";
            this.lbPV.Size = new System.Drawing.Size(21, 13);
            this.lbPV.TabIndex = 2;
            this.lbPV.Text = "PV";
            // 
            // lbSP
            // 
            this.lbSP.AutoSize = true;
            this.lbSP.Location = new System.Drawing.Point(171, 122);
            this.lbSP.Name = "lbSP";
            this.lbSP.Size = new System.Drawing.Size(21, 13);
            this.lbSP.TabIndex = 4;
            this.lbSP.Text = "SP";
            // 
            // tbSP
            // 
            this.tbSP.Location = new System.Drawing.Point(198, 119);
            this.tbSP.Name = "tbSP";
            this.tbSP.Size = new System.Drawing.Size(171, 20);
            this.tbSP.TabIndex = 3;
            this.tbSP.Enter += new System.EventHandler(this.tbSP_Enter);
            this.tbSP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSP_KeyDown);
            this.tbSP.Leave += new System.EventHandler(this.tbSP_Leave);
            // 
            // lbOUT
            // 
            this.lbOUT.AutoSize = true;
            this.lbOUT.Location = new System.Drawing.Point(162, 148);
            this.lbOUT.Name = "lbOUT";
            this.lbOUT.Size = new System.Drawing.Size(30, 13);
            this.lbOUT.TabIndex = 6;
            this.lbOUT.Text = "OUT";
            // 
            // tbOUT
            // 
            this.tbOUT.Location = new System.Drawing.Point(198, 145);
            this.tbOUT.Name = "tbOUT";
            this.tbOUT.Size = new System.Drawing.Size(171, 20);
            this.tbOUT.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbOUT);
            this.Controls.Add(this.tbOUT);
            this.Controls.Add(this.lbSP);
            this.Controls.Add(this.tbSP);
            this.Controls.Add(this.lbPV);
            this.Controls.Add(this.tbPV);
            this.Controls.Add(this.cbHand);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbHand;
        private System.Windows.Forms.TextBox tbPV;
        private System.Windows.Forms.Label lbPV;
        private System.Windows.Forms.Label lbSP;
        private System.Windows.Forms.TextBox tbSP;
        private System.Windows.Forms.Label lbOUT;
        private System.Windows.Forms.TextBox tbOUT;
        private System.Windows.Forms.Timer timer1;
    }
}

