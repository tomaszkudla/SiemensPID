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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cbHand = new System.Windows.Forms.CheckBox();
            this.tbPV = new System.Windows.Forms.TextBox();
            this.lbPV = new System.Windows.Forms.Label();
            this.lbSP = new System.Windows.Forms.Label();
            this.tbSP = new System.Windows.Forms.TextBox();
            this.lbOUT = new System.Windows.Forms.Label();
            this.tbOUT = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbTlag = new System.Windows.Forms.Label();
            this.tbTlag = new System.Windows.Forms.TextBox();
            this.lbTi = new System.Windows.Forms.Label();
            this.tbTi = new System.Windows.Forms.TextBox();
            this.lbK = new System.Windows.Forms.Label();
            this.tbK = new System.Windows.Forms.TextBox();
            this.lbYmin = new System.Windows.Forms.Label();
            this.tbYmin = new System.Windows.Forms.TextBox();
            this.lbYmax = new System.Windows.Forms.Label();
            this.tbYmax = new System.Windows.Forms.TextBox();
            this.lbTd = new System.Windows.Forms.Label();
            this.tbTd = new System.Windows.Forms.TextBox();
            this.lbDeadband = new System.Windows.Forms.Label();
            this.tbDeadband = new System.Windows.Forms.TextBox();
            this.cbDerivative = new System.Windows.Forms.CheckBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbOUTman = new System.Windows.Forms.Label();
            this.tbOUTman = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbHand
            // 
            this.cbHand.AutoSize = true;
            this.cbHand.Location = new System.Drawing.Point(173, 29);
            this.cbHand.Name = "cbHand";
            this.cbHand.Size = new System.Drawing.Size(81, 17);
            this.cbHand.TabIndex = 0;
            this.cbHand.Text = "Hand mode";
            this.cbHand.UseVisualStyleBackColor = true;
            this.cbHand.CheckedChanged += new System.EventHandler(this.cbHand_CheckedChanged);
            // 
            // tbPV
            // 
            this.tbPV.Location = new System.Drawing.Point(83, 52);
            this.tbPV.Name = "tbPV";
            this.tbPV.Size = new System.Drawing.Size(171, 20);
            this.tbPV.TabIndex = 1;
            this.tbPV.Click += new System.EventHandler(this.tbPV_Click);
            this.tbPV.Enter += new System.EventHandler(this.tbPV_Enter);
            this.tbPV.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPV_KeyDown);
            this.tbPV.Leave += new System.EventHandler(this.tbPV_Leave);
            // 
            // lbPV
            // 
            this.lbPV.AutoSize = true;
            this.lbPV.Location = new System.Drawing.Point(56, 55);
            this.lbPV.Name = "lbPV";
            this.lbPV.Size = new System.Drawing.Size(21, 13);
            this.lbPV.TabIndex = 2;
            this.lbPV.Text = "PV";
            // 
            // lbSP
            // 
            this.lbSP.AutoSize = true;
            this.lbSP.Location = new System.Drawing.Point(56, 81);
            this.lbSP.Name = "lbSP";
            this.lbSP.Size = new System.Drawing.Size(21, 13);
            this.lbSP.TabIndex = 4;
            this.lbSP.Text = "SP";
            // 
            // tbSP
            // 
            this.tbSP.Location = new System.Drawing.Point(83, 78);
            this.tbSP.Name = "tbSP";
            this.tbSP.Size = new System.Drawing.Size(171, 20);
            this.tbSP.TabIndex = 3;
            this.tbSP.Click += new System.EventHandler(this.tbSP_Click);
            this.tbSP.Enter += new System.EventHandler(this.tbSP_Enter);
            this.tbSP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSP_KeyDown);
            this.tbSP.Leave += new System.EventHandler(this.tbSP_Leave);
            // 
            // lbOUT
            // 
            this.lbOUT.AutoSize = true;
            this.lbOUT.Location = new System.Drawing.Point(47, 107);
            this.lbOUT.Name = "lbOUT";
            this.lbOUT.Size = new System.Drawing.Size(30, 13);
            this.lbOUT.TabIndex = 6;
            this.lbOUT.Text = "OUT";
            // 
            // tbOUT
            // 
            this.tbOUT.Location = new System.Drawing.Point(83, 104);
            this.tbOUT.Name = "tbOUT";
            this.tbOUT.Size = new System.Drawing.Size(171, 20);
            this.tbOUT.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbTlag
            // 
            this.lbTlag.AutoSize = true;
            this.lbTlag.Location = new System.Drawing.Point(47, 248);
            this.lbTlag.Name = "lbTlag";
            this.lbTlag.Size = new System.Drawing.Size(31, 13);
            this.lbTlag.TabIndex = 12;
            this.lbTlag.Text = "T lag";
            // 
            // tbTlag
            // 
            this.tbTlag.Location = new System.Drawing.Point(83, 245);
            this.tbTlag.Name = "tbTlag";
            this.tbTlag.Size = new System.Drawing.Size(171, 20);
            this.tbTlag.TabIndex = 11;
            this.tbTlag.Enter += new System.EventHandler(this.tbTlag_Enter);
            this.tbTlag.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbTlag_KeyDown);
            this.tbTlag.Leave += new System.EventHandler(this.tbTlag_Leave);
            // 
            // lbTi
            // 
            this.lbTi.AutoSize = true;
            this.lbTi.Location = new System.Drawing.Point(56, 222);
            this.lbTi.Name = "lbTi";
            this.lbTi.Size = new System.Drawing.Size(16, 13);
            this.lbTi.TabIndex = 10;
            this.lbTi.Text = "Ti";
            // 
            // tbTi
            // 
            this.tbTi.Location = new System.Drawing.Point(83, 219);
            this.tbTi.Name = "tbTi";
            this.tbTi.Size = new System.Drawing.Size(171, 20);
            this.tbTi.TabIndex = 9;
            this.tbTi.Enter += new System.EventHandler(this.tbTi_Enter);
            this.tbTi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbTi_KeyDown);
            this.tbTi.Leave += new System.EventHandler(this.tbTi_Leave);
            // 
            // lbK
            // 
            this.lbK.AutoSize = true;
            this.lbK.Location = new System.Drawing.Point(56, 196);
            this.lbK.Name = "lbK";
            this.lbK.Size = new System.Drawing.Size(14, 13);
            this.lbK.TabIndex = 8;
            this.lbK.Text = "K";
            // 
            // tbK
            // 
            this.tbK.Location = new System.Drawing.Point(83, 193);
            this.tbK.Name = "tbK";
            this.tbK.Size = new System.Drawing.Size(171, 20);
            this.tbK.TabIndex = 7;
            this.tbK.Enter += new System.EventHandler(this.tbK_Enter);
            this.tbK.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbK_KeyDown);
            this.tbK.Leave += new System.EventHandler(this.tbK_Leave);
            // 
            // lbYmin
            // 
            this.lbYmin.AutoSize = true;
            this.lbYmin.Location = new System.Drawing.Point(47, 326);
            this.lbYmin.Name = "lbYmin";
            this.lbYmin.Size = new System.Drawing.Size(30, 13);
            this.lbYmin.TabIndex = 18;
            this.lbYmin.Text = "Ymin";
            // 
            // tbYmin
            // 
            this.tbYmin.Location = new System.Drawing.Point(83, 323);
            this.tbYmin.Name = "tbYmin";
            this.tbYmin.Size = new System.Drawing.Size(171, 20);
            this.tbYmin.TabIndex = 17;
            this.tbYmin.Enter += new System.EventHandler(this.tbYmin_Enter);
            this.tbYmin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbYmin_KeyDown);
            this.tbYmin.Leave += new System.EventHandler(this.tbYmin_Leave);
            // 
            // lbYmax
            // 
            this.lbYmax.AutoSize = true;
            this.lbYmax.Location = new System.Drawing.Point(47, 300);
            this.lbYmax.Name = "lbYmax";
            this.lbYmax.Size = new System.Drawing.Size(33, 13);
            this.lbYmax.TabIndex = 16;
            this.lbYmax.Text = "Ymax";
            // 
            // tbYmax
            // 
            this.tbYmax.Location = new System.Drawing.Point(83, 297);
            this.tbYmax.Name = "tbYmax";
            this.tbYmax.Size = new System.Drawing.Size(171, 20);
            this.tbYmax.TabIndex = 15;
            this.tbYmax.Enter += new System.EventHandler(this.tbYmax_Enter);
            this.tbYmax.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbYmax_KeyDown);
            this.tbYmax.Leave += new System.EventHandler(this.tbYmax_Leave);
            // 
            // lbTd
            // 
            this.lbTd.AutoSize = true;
            this.lbTd.Location = new System.Drawing.Point(56, 274);
            this.lbTd.Name = "lbTd";
            this.lbTd.Size = new System.Drawing.Size(20, 13);
            this.lbTd.TabIndex = 14;
            this.lbTd.Text = "Td";
            // 
            // tbTd
            // 
            this.tbTd.Location = new System.Drawing.Point(83, 271);
            this.tbTd.Name = "tbTd";
            this.tbTd.Size = new System.Drawing.Size(171, 20);
            this.tbTd.TabIndex = 13;
            this.tbTd.Enter += new System.EventHandler(this.tbTd_Enter);
            this.tbTd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbTd_KeyDown);
            this.tbTd.Leave += new System.EventHandler(this.tbTd_Leave);
            // 
            // lbDeadband
            // 
            this.lbDeadband.AutoSize = true;
            this.lbDeadband.Location = new System.Drawing.Point(23, 352);
            this.lbDeadband.Name = "lbDeadband";
            this.lbDeadband.Size = new System.Drawing.Size(57, 13);
            this.lbDeadband.TabIndex = 20;
            this.lbDeadband.Text = "Deadband";
            // 
            // tbDeadband
            // 
            this.tbDeadband.Location = new System.Drawing.Point(83, 349);
            this.tbDeadband.Name = "tbDeadband";
            this.tbDeadband.Size = new System.Drawing.Size(171, 20);
            this.tbDeadband.TabIndex = 19;
            this.tbDeadband.Enter += new System.EventHandler(this.tbDeadband_Enter);
            this.tbDeadband.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbDeadband_KeyDown);
            this.tbDeadband.Leave += new System.EventHandler(this.tbDeadband_Leave);
            // 
            // cbDerivative
            // 
            this.cbDerivative.AutoSize = true;
            this.cbDerivative.Location = new System.Drawing.Point(260, 274);
            this.cbDerivative.Name = "cbDerivative";
            this.cbDerivative.Size = new System.Drawing.Size(129, 17);
            this.cbDerivative.TabIndex = 21;
            this.cbDerivative.Text = "Enable derivative part";
            this.cbDerivative.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Cursor = System.Windows.Forms.Cursors.IBeam;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(395, 12);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(623, 426);
            this.chart1.TabIndex = 23;
            this.chart1.Text = "chart1";
            // 
            // lbOUTman
            // 
            this.lbOUTman.AutoSize = true;
            this.lbOUTman.Location = new System.Drawing.Point(24, 133);
            this.lbOUTman.Name = "lbOUTman";
            this.lbOUTman.Size = new System.Drawing.Size(56, 13);
            this.lbOUTman.TabIndex = 25;
            this.lbOUTman.Text = " OUT man";
            // 
            // tbOUTman
            // 
            this.tbOUTman.Location = new System.Drawing.Point(83, 130);
            this.tbOUTman.Name = "tbOUTman";
            this.tbOUTman.Size = new System.Drawing.Size(171, 20);
            this.tbOUTman.TabIndex = 24;
            this.tbOUTman.Click += new System.EventHandler(this.tbOUTman_Click);
            this.tbOUTman.Enter += new System.EventHandler(this.tbOUTman_Enter);
            this.tbOUTman.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbOUTman_KeyDown);
            this.tbOUTman.Leave += new System.EventHandler(this.tbOUTman_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 450);
            this.Controls.Add(this.lbOUTman);
            this.Controls.Add(this.tbOUTman);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.cbDerivative);
            this.Controls.Add(this.lbDeadband);
            this.Controls.Add(this.tbDeadband);
            this.Controls.Add(this.lbYmin);
            this.Controls.Add(this.tbYmin);
            this.Controls.Add(this.lbYmax);
            this.Controls.Add(this.tbYmax);
            this.Controls.Add(this.lbTd);
            this.Controls.Add(this.tbTd);
            this.Controls.Add(this.lbTlag);
            this.Controls.Add(this.tbTlag);
            this.Controls.Add(this.lbTi);
            this.Controls.Add(this.tbTi);
            this.Controls.Add(this.lbK);
            this.Controls.Add(this.tbK);
            this.Controls.Add(this.lbOUT);
            this.Controls.Add(this.tbOUT);
            this.Controls.Add(this.lbSP);
            this.Controls.Add(this.tbSP);
            this.Controls.Add(this.lbPV);
            this.Controls.Add(this.tbPV);
            this.Controls.Add(this.cbHand);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Siemens PID";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
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
        private System.Windows.Forms.Label lbTlag;
        private System.Windows.Forms.TextBox tbTlag;
        private System.Windows.Forms.Label lbTi;
        private System.Windows.Forms.TextBox tbTi;
        private System.Windows.Forms.Label lbK;
        private System.Windows.Forms.TextBox tbK;
        private System.Windows.Forms.Label lbYmin;
        private System.Windows.Forms.TextBox tbYmin;
        private System.Windows.Forms.Label lbYmax;
        private System.Windows.Forms.TextBox tbYmax;
        private System.Windows.Forms.Label lbTd;
        private System.Windows.Forms.TextBox tbTd;
        private System.Windows.Forms.Label lbDeadband;
        private System.Windows.Forms.TextBox tbDeadband;
        private System.Windows.Forms.CheckBox cbDerivative;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label lbOUTman;
        private System.Windows.Forms.TextBox tbOUTman;
    }
}

