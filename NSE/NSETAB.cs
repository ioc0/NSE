using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScintillaNET;
using ScintillaNET.Design;


namespace NSE
{
    public partial class NSETAB : TabPage
    {
        private Scintilla tabTextBox;

        public NSETAB()
        {
            tabTextBox = new Scintilla();
            Text = "New";

            this.tabTextBox.Dock = DockStyle.Fill;
            this.tabTextBox.Location = new Point(0, 0);
            this.tabTextBox.Name = "tabTextBox";
            this.tabTextBox.Size = new System.Drawing.Size(100, 100);
            this.tabTextBox.Styles.BraceBad.FontName = "Verdana\0\0\0\0\0\0\0\0\0\0\0\0\0";
            this.tabTextBox.Styles.BraceBad.Size = 7F;
            this.tabTextBox.Styles.BraceLight.FontName = "Verdana\0\0\0\0\0\0\0\0\0\0\0\0\0";
            this.tabTextBox.Styles.BraceLight.Size = 7F;
            this.tabTextBox.Styles.CallTip.FontName = "Segoe UI\0\0\0\0\0\0\0\0\0\0\0\0";
            this.tabTextBox.Styles.ControlChar.FontName = "Verdana\0\0\0\0\0\0\0\0\0\0\0\0\0";
            this.tabTextBox.Styles.ControlChar.Size = 7F;
            this.tabTextBox.Styles.Default.BackColor = System.Drawing.SystemColors.Window;
            this.tabTextBox.Styles.Default.FontName = "Verdana\0\0\0\0\0\0\0\0\0\0\0\0\0";
            this.tabTextBox.Styles.Default.Size = 7F;
            this.tabTextBox.Styles.IndentGuide.FontName = "Verdana\0\0\0\0\0\0\0\0\0\0\0\0\0";
            this.tabTextBox.Styles.IndentGuide.Size = 7F;
            this.tabTextBox.Styles.LastPredefined.FontName = "Verdana\0\0\0\0\0\0\0\0\0\0\0\0\0";
            this.tabTextBox.Styles.LastPredefined.Size = 7F;
            this.tabTextBox.Styles.LineNumber.FontName = "Verdana\0\0\0\0\0\0\0\0\0\0\0\0\0";
            this.tabTextBox.Styles.LineNumber.Size = 7F;
            this.tabTextBox.Styles.Max.FontName = "Verdana\0\0\0\0\0\0\0\0\0\0\0\0\0";
            this.tabTextBox.Styles.Max.Size = 7F;
            this.tabTextBox.TabIndex = 0;
            this.tabTextBox.ConfigurationManager.Language = "html";
            this.tabTextBox.Margins[0].Width = 15;
            InitializeComponent();
            Controls.Add(tabTextBox);
        }
    }
}
