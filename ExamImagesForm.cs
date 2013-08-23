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
    public partial class ExamImagesForm : RibbonForm
    {
        List<ExamImage> list = new List<ExamImage>();

        internal List<ExamImage> List
        {
            get { return list; }
            set
            {
                list = value;
                imagelist.DataSource = null;
                imagelist.DataSource = value;
            }
        }



        public ExamImagesForm()
        {
            this.LocalRenderer.ColorScheme = Program.colorTheme;
            InitializeComponent();
        }

        private void imagelist_DoubleClick(object sender, EventArgs e)
        {
            MouseEventArgs ee = e as MouseEventArgs;

            if (ee != null)
            {
                int index = imagelist.IndexFromPoint(ee.Location);
                if (index != -1)
                {
                    ImageForm frm = new ImageForm();
                    frm.ExImage = imagelist.Items[index] as ExamImage;
                    frm.MdiParent = this.MdiParent;
                    frm.Visible = true;
                }
            }
        }

        private void imagelist_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index == -1)
            {
                return;
            }
            String stg = "";
            Graphics g = e.Graphics;
            ExamImage eximg = imagelist.Items[e.Index] as ExamImage;
            if (eximg != null)
            {
                Bitmap ic = null;
                Color bg = SystemColors.ActiveCaption;
                Color fc = SystemColors.WindowText;
                switch (eximg.StuNumber)
                {
                    case -1: ic = global::shapes.Properties.Resources.red24;
                        bg = Color.FromArgb(245, 164, 174);
                        stg = "ورقة خاطئة";
                        break;
                    case -2: ic = global::shapes.Properties.Resources.yellow24;
                        bg = Color.FromArgb(252, 248, 177);
                        stg = "رقم خاطئ";
                        break;
                    case -3: ic = global::shapes.Properties.Resources.yellow24;
                        bg = Color.FromArgb(252, 248, 177);
                        stg = "خطأ مجهول";
                        break;

                    default: ic = global::shapes.Properties.Resources.green24;
                        bg = Color.FromArgb(210, 245, 164);
                        stg = eximg.StuNumber.ToString()  ;
                        break;
                }
                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                {
                    bg = SystemColors.Highlight;
                    fc = SystemColors.HighlightText;
                }
                g.FillRectangle(new SolidBrush(bg), e.Bounds);
                Pen p = new Pen(Color.DarkGray);
                p.DashStyle =System.Drawing.Drawing2D.DashStyle.Dot;
                p.Width = 1;
                g.DrawRectangle(p, e.Bounds);
                g.DrawImage(ic, e.Bounds.Width - 24 - 2, e.Bounds.Y + 2);
                StringFormat sf = new StringFormat(StringFormatFlags.DirectionRightToLeft);
                sf.Alignment = StringAlignment.Center;
                Rectangle rec = new Rectangle(new Point(e.Bounds.X - 30, e.Bounds.Y), e.Bounds.Size);
               
                g.DrawString(String.Format("الرقم:{0}   العلامة:{1}", stg, eximg.Mark), imagelist.Font, new SolidBrush(fc), e.Bounds, sf);
            }

        }

        private static bool isErrorImage(ExamImage im)
        {
            return im.StuNumber <= 0;
        }


        private void del_err_btn_Click(object sender, EventArgs e)
        {
            list.RemoveAll(isErrorImage);
            imagelist.DataSource = null;
            imagelist.DataSource = list;
        }

        private void del_all_btn_Click(object sender, EventArgs e)
        {
            list.Clear();
            imagelist.DataSource = null;
            imagelist.DataSource = list;
        }

        private void del_sel_btn_Click(object sender, EventArgs e)
        {
            if (imagelist.SelectedIndex!=-1)
            {
                list.RemoveAt(imagelist.SelectedIndex);
                imagelist.DataSource = null;
                imagelist.DataSource = list;
            }
        }
    }
}
