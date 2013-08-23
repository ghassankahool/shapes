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
    public partial class ImageForm : RibbonForm
    {

        ExamImage exImage;

        internal ExamImage ExImage
        {
            get { return exImage; }
            set { exImage = value;
            img.Image = value.Orgimg;
            img.Size = value.Orgimg.Size;
            img.Refresh();
           // num_l.Text = value.StuNumber.ToString();
            mark_l.Text = value.Mark.ToString();
            switch (value.StuNumber)
            {
                case -1: 
                    num_l.Text = "ورقة خاطئة";
                    break;
                case -2:
                    num_l.Text = "رقم خاطئ";
                    break;
                case -3: 
                    num_l.Text = "خطأ مجهول";
                    break;

                default:
                    num_l.Text = value.StuNumber.ToString();
                    break;
            }
            }
        }

       

        public ImageForm()
        {
            this.LocalRenderer.ColorScheme = Program.colorTheme;
            InitializeComponent();
        }

        private void rot_btn_Click(object sender, EventArgs e)
        {
            img.Image.RotateFlip(RotateFlipType.Rotate180FlipNone);
            img.Refresh();
        }
    }
}
