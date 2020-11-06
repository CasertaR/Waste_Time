namespace Waste_Time
{
    partial class frmMain
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.chkBackGroundWorker = new System.Windows.Forms.CheckBox();
            this.btnAvvia = new System.Windows.Forms.Button();
            this.btnFerma = new System.Windows.Forms.Button();
            this.prgProgressBar = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // chkBackGroundWorker
            // 
            this.chkBackGroundWorker.AutoSize = true;
            this.chkBackGroundWorker.Location = new System.Drawing.Point(153, 50);
            this.chkBackGroundWorker.Name = "chkBackGroundWorker";
            this.chkBackGroundWorker.Size = new System.Drawing.Size(157, 17);
            this.chkBackGroundWorker.TabIndex = 0;
            this.chkBackGroundWorker.Text = "Utilizza BackGroundWorker";
            this.chkBackGroundWorker.UseVisualStyleBackColor = true;
            // 
            // btnAvvia
            // 
            this.btnAvvia.Location = new System.Drawing.Point(52, 110);
            this.btnAvvia.Name = "btnAvvia";
            this.btnAvvia.Size = new System.Drawing.Size(75, 23);
            this.btnAvvia.TabIndex = 1;
            this.btnAvvia.Text = "Avvia";
            this.btnAvvia.UseVisualStyleBackColor = true;
            this.btnAvvia.Click += new System.EventHandler(this.btnAvvia_Click);
            // 
            // btnFerma
            // 
            this.btnFerma.Location = new System.Drawing.Point(338, 111);
            this.btnFerma.Name = "btnFerma";
            this.btnFerma.Size = new System.Drawing.Size(75, 23);
            this.btnFerma.TabIndex = 2;
            this.btnFerma.Text = "Ferma";
            this.btnFerma.UseVisualStyleBackColor = true;
            this.btnFerma.Click += new System.EventHandler(this.btnFerma_Click);
            // 
            // prgProgressBar
            // 
            this.prgProgressBar.Location = new System.Drawing.Point(153, 110);
            this.prgProgressBar.Name = "prgProgressBar";
            this.prgProgressBar.Size = new System.Drawing.Size(164, 23);
            this.prgProgressBar.TabIndex = 3;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 191);
            this.Controls.Add(this.prgProgressBar);
            this.Controls.Add(this.btnFerma);
            this.Controls.Add(this.btnAvvia);
            this.Controls.Add(this.chkBackGroundWorker);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkBackGroundWorker;
        private System.Windows.Forms.Button btnAvvia;
        private System.Windows.Forms.Button btnFerma;
        private System.Windows.Forms.ProgressBar prgProgressBar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

