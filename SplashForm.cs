using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace shapes
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            //SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            
            InitializeComponent();
         // this.BackColor = Color.Transparent;
        }

        private void linkl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:ghassan.kahool@mail.com");

        }

        private void SplashForm_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }
    }
}
