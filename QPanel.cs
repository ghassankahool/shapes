using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace shapes
{
    public partial class QPanel : UserControl
    {

        public string Num
        {
            set
            {
                t.Text = value;
            }
            get
            {
                return t.Text;
            }
        }

        public int NumSelect
        {
            get
            {
                if (a.Checked)
                {
                    return 1;
                }
                if (b.Checked)
                {
                    return 2;
                }
                if (c.Checked)
                {
                    return 3;
                }
                if (d.Checked)
                {
                    return 4;
                }
                if (e.Checked)
                {
                    return 5;
                }
                return 0;
            }

            set
            {
                switch (value)
                {
                    case 1: a.Checked = true;
                        break;
                    case 2: b.Checked = true;
                        break;
                    case 3: c.Checked = true;
                        break;
                    case 4: d.Checked = true;
                        break;
                    case 5: e.Checked = true;
                        break;
                    default: a.Checked = false;
                        b.Checked = false;
                        c.Checked = false;
                        d.Checked = false;
                        e.Checked = false;
                        break;
                }

            }
        }

        public QPanel()
        {
            InitializeComponent();
        }

        private void t_DoubleClick(object sender, EventArgs e1)
        {
            a.Checked = false;
            b.Checked = false;
            c.Checked = false;
            d.Checked = false;
            e.Checked = false;
        }
    }
}
