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

namespace FileShredder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSrcFile_Click(object sender, EventArgs e)
        {
            ofdSrcFile.ShowDialog();

            txtSrcFile.Text = ofdSrcFile.FileName; 

        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            fbdTarget.ShowDialog();

            txtTargetFolder.Text = fbdTarget.SelectedPath;
        }

        private void btnShredIt_Click(object sender, EventArgs e)
        {
            Shredder shre = new Shredder();
            shre.SourceFile = txtSrcFile.Text;
            shre.TargetFolder = txtTargetFolder.Text;

            try
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();

                shre.ShredFile();

                sw.Stop();

                //long microseconds = sw.ElapsedTicks / (Stopwatch.Frequency / (1000L * 1000L));

                TimeSpan ts = new TimeSpan(sw.ElapsedTicks);

                MessageBox.Show(ts.ToString()); 

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
