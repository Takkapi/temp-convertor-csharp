using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TempConvertor
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void About_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink();
            } catch(Exception ex)
            {
                MessageBox.Show("Unable to open link: " + ex);
                
            }
        }

        private void VisitLink()
        {
            linkLabel1.LinkVisited = true;
            ProcessStartInfo start = new ProcessStartInfo("https://github.com/Takkapi");
            Process.Start(start);
        }
    }
}
