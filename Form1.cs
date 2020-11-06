using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Waste_Time
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void WasteCPUCycles()
        {
            DateTime startTime = DateTime.Now;
            double value = Math.E;
            while (DateTime.Now<startTime.AddMilliseconds(100))
            {
                value /= Math.PI;
                value *= Math.Sqrt(2);
            }
        }

        private void btnAvvia_Click(object sender, EventArgs e)
        {
            btnAvvia.Enabled = false;
            if (!chkBackGroundWorker.Checked)
            {
                for (int i = 0; i <= 100; i++)
                {
                    WasteCPUCycles();
                    prgProgressBar.Value = i;
                }
                btnAvvia.Enabled = true;
            }
            else
            {
                btnFerma.Enabled = true;
                backgroundWorker1.RunWorkerAsync();
            }
        }
      

        

        private void btnFerma_Click(object sender, EventArgs e)
        {
            backgroundWorker1.CancelAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Console.WriteLine("Background Worker argument: " + (e.Argument ?? "null"));
            for (int i = 0; i <= 100; i++)
            {
                WasteCPUCycles();
                backgroundWorker1.ReportProgress(i);
                if (backgroundWorker1.CancellationPending)
                {
                    Console.WriteLine("Cancelled");
                    break;
                }
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            prgProgressBar.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnAvvia.Enabled = true;
            btnFerma.Enabled = false;
        }
    }
}
