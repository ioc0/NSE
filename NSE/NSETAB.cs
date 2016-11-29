using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScintillaNET;




namespace NSE
{
    public partial class NSETAB : TabPage
    {
        private Scintilla tabTextBox = new Scintilla();

        public NSETAB()
        {
            
            Text = "New";
            
            this.tabTextBox.Dock = DockStyle.Fill;
            this.tabTextBox.Location = new Point(0, 0);
            this.tabTextBox.Name = "tabTextBox";
            this.tabTextBox.TabIndex = 0;

            this.tabTextBox.Lexer = Lexer.Cpp;
            this.tabTextBox.Margins[0].Width = 10;
            InitializeComponent();
            Controls.Add(tabTextBox);
        }

        private void InitColors()
        {
            tabTextBox.SetSelectionBackColor(true, IntToColor(0x114D9C));
        }

        public static Color IntToColor(int rgb)
        {
            return Color.FromArgb(255, (byte) (rgb >> 16), (byte) (rgb >> 8), (byte) rgb);
        }

        public void LoadDataFromFile(string path)
        {
            
            tabTextBox.Text = File.ReadAllText(path);
        }

    }
}
