using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Divelements.SandRibbon;

namespace shapes
{
    public partial class InputDLG : RibbonForm
    {
        public InputDLG()
        {
            this.LocalRenderer.ColorScheme = Program.colorTheme;
            InitializeComponent();
        }

        private void InputDLG_Load(object sender, EventArgs e)
        {

            MainForm frm = this.Owner as MainForm;
            if (frm!=null)
            {
                
                clientPanel1.Manager = frm.ribbon;
                clientPanel2.Manager = frm.ribbon;
            }
        }
    }
}
