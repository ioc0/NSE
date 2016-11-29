using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NSE
{
    public partial class Form1 : Form
    {
        private string fileName;

        public Form1()
        {
            InitializeComponent();
            tabControl1.TabPages.Add(new NSETAB());
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(new NSETAB());
        }

        private void tsmOpenFIle_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                fileName = ofd.FileName;
            }
            var curTabs = tabControl1.SelectedTab as NSETAB;
            try
            {
                curTabs.LoadDataFromFile(fileName);
            }
            catch (Exception)
            {
                
                throw;
            }
            
            
        }
        
        }
    }
 
