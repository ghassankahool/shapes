using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AForge.Imaging.Filters;
using System.Drawing.Drawing2D;

namespace shapes
{
    public partial class PrintForm : Divelements.SandRibbon.RibbonForm
    {

        Boolean round = true;

        int boxh = 25;
        int boxw = 25;
        int hboxpading = 2;
        int vboxpading = 50;
        int hmarg = 160;
        int vmarg = 130;
        int pwidth = 0;

        int syncboxh = 6;
        int syncboxw = 30;

        int hheader =40;

        String headertxt = "";

        Font font = new Font("Arial", 8);

        public String Headertxt
        {
            get { return headertxt; }
            set { headertxt = value; }
        }



        Font nfont = new Font("Arial", 12, FontStyle.Bold);

        int circleOffset = 3;

        public PrintForm()
        {
            this.LocalRenderer.ColorScheme = Program.colorTheme;
            InitializeComponent();
        }

        private void p_doc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            Graphics g = e.Graphics;
            vmarg = (e.PageSettings.PaperSize.Width - (3 * (vboxpading + (boxw * 6)) - vboxpading)) / 2;
            pwidth = e.PageSettings.PaperSize.Width;

            g.DrawLine(Pens.DarkGray, vmarg, hmarg, vmarg + 3 * (vboxpading + (boxw * 6)) - vboxpading, hmarg);
            g.DrawLine(Pens.DarkGray, vmarg, hmarg + 3, vmarg + 3 * (vboxpading + (boxw * 6)) - vboxpading, hmarg + 3);
            for (int j = 0; j < 3; j++)
            {
                for (int i = 1; i <= 34; i++)
                {
                    drawBox(g, i, j);
                }
            }

            for (int i = 0; i < 3; i++)
            {
                drawNum(g, i);
            }

            drawNameBox(g);
            drawText(g);



            // Bitmap map = new Bitmap(e.PageSettings.PaperSize.Width, e.PageSettings.PaperSize.Height, g);

            //  map.Save(@"c:\map.bmp");
        }

        void drawBox(Graphics g, int row, int col)
        {
            int s = ((col * 34) + row);
            switch (col)
            {
                case 0: s += 68;
                    break;
                case 2: s -= 68;
                    break;
                default:
                    break;
            }

            if (s > 100)
            {
                return;
            }

            


            String rn = s.ToString();
            row = row * (boxh + hboxpading) + hmarg;
            col = col * (boxw * 6 + vboxpading) + vmarg;


            Rectangle rec = new Rectangle();
            rec.Height = syncboxh;
            rec.Width = syncboxw;
            rec.X = 10;
            rec.Y = row + (boxh/2)-(syncboxh/2);
            g.FillRectangle(Brushes.Black, rec);



            StringFormat format1 = new StringFormat(StringFormatFlags.NoClip);
            format1.LineAlignment = StringAlignment.Center;
            format1.Alignment = StringAlignment.Center;
            format1.SetDigitSubstitution(0x0C01,
            StringDigitSubstitute.Traditional);


            if (round)
            {
                DrawRoundRect(g, Pens.LightGray, col, row, boxw * 6, boxh, 3);
            }
            else
            {

                g.DrawRectangle(Pens.LightGray, col, row, boxw * 6, boxh);
            }
            Rectangle num = new Rectangle(boxw * 5 + col, row, boxw, boxh);
            if (s == 100)
            {
                
                g.DrawString(rn, font, Brushes.Red, num, format1);
            }
            else
            {
                g.DrawString(rn, this.Font, Brushes.Red, num, format1);
            }


            Rectangle h = new Rectangle(col + circleOffset, row + circleOffset, boxw - circleOffset * 2, boxh - circleOffset * 2);
            Rectangle d = new Rectangle(boxw + col + circleOffset, row + circleOffset, boxw - circleOffset * 2, boxh - circleOffset * 2);
            Rectangle c = new Rectangle(boxw * 2 + col + circleOffset, row + circleOffset, boxw - circleOffset * 2, boxh - circleOffset * 2);
            Rectangle b = new Rectangle(boxw * 3 + col + circleOffset, row + circleOffset, boxw - circleOffset * 2, boxh - circleOffset * 2);
            Rectangle a = new Rectangle(boxw * 4 + col + circleOffset, row + circleOffset, boxw - circleOffset * 2, boxh - circleOffset * 2);


            g.DrawArc(Pens.LightGray, d, 0, 360);
            g.DrawString("د", this.Font, Brushes.Red, d, format1);


            g.DrawArc(Pens.LightGray, c, 0, 360);
            g.DrawString("جـ", this.Font, Brushes.Red, c, format1);


            g.DrawArc(Pens.LightGray, b, 0, 360);
            g.DrawString("ب", this.Font, Brushes.Red, b, format1);


            g.DrawArc(Pens.LightGray, a, 0, 360);
            g.DrawString("ا", this.Font, Brushes.Red, a, format1);


            g.DrawArc(Pens.LightGray, h, 0, 360);
            g.DrawString("هـ", this.Font, Brushes.Red, h, format1);

            g.DrawLine(Pens.LightGray, 3 * boxw + col, row, boxw * 3 + col, row + boxh);
            g.DrawLine(Pens.LightGray, boxw + col, row, boxw + col, row + boxh);
            g.DrawLine(Pens.LightGray, boxw * 4 + col, row, boxw * 4 + col, row + boxh);
            g.DrawLine(Pens.LightGray, boxw * 5 + col, row, boxw * 5 + col, row + boxh);
            g.DrawLine(Pens.LightGray, 2 * boxw + col, row, 2 * boxw + col, row + boxh);
        }

        void drawNum(Graphics g, int row)
        {

            row = row * (boxh + hboxpading) + hheader;
            int col = 0;
            col = col * (boxw * 10 + vboxpading) + vmarg;
            if (round)
            {
                DrawRoundRect(g, Pens.DarkGray, col, row, boxw * 10, boxh, 5);
            }
            else {
            g.DrawRectangle(Pens.LightGray, col, row, boxw * 10, boxh);

            }
           // 
            Rectangle rec = new Rectangle();
            rec.Height = syncboxh;
            rec.Width = syncboxw;
            rec.X = 10;
            rec.Y = row + (boxh / 2) - (syncboxh / 2);
            g.FillRectangle(Brushes.Black, rec);


            StringFormat format1 = new StringFormat(StringFormatFlags.NoClip);
            format1.LineAlignment = StringAlignment.Center;
            format1.Alignment = StringAlignment.Center;
            format1.SetDigitSubstitution(0x0C01,
            StringDigitSubstitute.Traditional);



            Rectangle _9 = new Rectangle(col + circleOffset, row + circleOffset, boxw - circleOffset * 2, boxh - circleOffset * 2);
            Rectangle _8 = new Rectangle(col + boxw + circleOffset, row + circleOffset, boxw - circleOffset * 2, boxh - circleOffset * 2);
            Rectangle _7 = new Rectangle(col + boxw * 2 + circleOffset, row + circleOffset, boxw - circleOffset * 2, boxh - circleOffset * 2);
            Rectangle _6 = new Rectangle(col + boxw * 3 + circleOffset, row + circleOffset, boxw - circleOffset * 2, boxh - circleOffset * 2);
            Rectangle _5 = new Rectangle(col + boxw * 4 + circleOffset, row + circleOffset, boxw - circleOffset * 2, boxh - circleOffset * 2);
            Rectangle _4 = new Rectangle(col + boxw * 5 + circleOffset, row + circleOffset, boxw - circleOffset * 2, boxh - circleOffset * 2);
            Rectangle _3 = new Rectangle(col + boxw * 6 + circleOffset, row + circleOffset, boxw - circleOffset * 2, boxh - circleOffset * 2);
            Rectangle _2 = new Rectangle(col + boxw * 7 + circleOffset, row + circleOffset, boxw - circleOffset * 2, boxh - circleOffset * 2);
            Rectangle _1 = new Rectangle(col + boxw * 8 + circleOffset, row + circleOffset, boxw - circleOffset * 2, boxh - circleOffset * 2);
            Rectangle _0 = new Rectangle(col + boxw * 9 + circleOffset, row + circleOffset, boxw - circleOffset * 2, boxh - circleOffset * 2);


            g.DrawArc(Pens.LightGray, _8, 0, 360);
            g.DrawString("8", this.Font, Brushes.Red, _8, format1);


            g.DrawArc(Pens.LightGray, _7, 0, 360);
            g.DrawString("7", this.Font, Brushes.Red, _7, format1);


            g.DrawArc(Pens.LightGray, _6, 0, 360);
            g.DrawString("6", this.Font, Brushes.Red, _6, format1);


            g.DrawArc(Pens.LightGray, _5, 0, 360);
            g.DrawString("5", this.Font, Brushes.Red, _5, format1);


            g.DrawArc(Pens.LightGray, _9, 0, 360);
            g.DrawString("9", this.Font, Brushes.Red, _9, format1);

            g.DrawArc(Pens.LightGray, _4, 0, 360);
            g.DrawString("4", this.Font, Brushes.Red, _4, format1);

            g.DrawArc(Pens.LightGray, _3, 0, 360);
            g.DrawString("3", this.Font, Brushes.Red, _3, format1);

            g.DrawArc(Pens.LightGray, _2, 0, 360);
            g.DrawString("2", this.Font, Brushes.Red, _2, format1);

            g.DrawArc(Pens.LightGray, _1, 0, 360);
            g.DrawString("1", this.Font, Brushes.Red, _1, format1);

            g.DrawArc(Pens.LightGray, _0, 0, 360);
            g.DrawString("0", this.Font, Brushes.Red, _0, format1);
            g.DrawLine(Pens.LightGray, col + boxw, row, col + boxw, row + boxh);
            g.DrawLine(Pens.LightGray, col + boxw * 2, row, col + boxw * 2, row + boxh);
            g.DrawLine(Pens.LightGray, col + boxw * 3, row, col + boxw * 3, row + boxh);
            g.DrawLine(Pens.LightGray, col + boxw * 4, row, col + boxw * 4, row + boxh);
            g.DrawLine(Pens.LightGray, col + boxw * 5, row, col + boxw * 5, row + boxh);
            g.DrawLine(Pens.LightGray, col + boxw * 6, row, col + boxw * 6, row + boxh);
            g.DrawLine(Pens.LightGray, col + boxw * 7, row, col + boxw * 7, row + boxh);
            g.DrawLine(Pens.LightGray, col + boxw * 8, row, col + boxw * 8, row + boxh);
            g.DrawLine(Pens.LightGray, col + boxw * 9, row, col + boxw * 9, row + boxh);

        }

        void drawNameBox(Graphics g)
        {
            String txt = "الاسم الثلاثي:.......................";
            String num = "الرقم:.......................";
            Rectangle rec = new Rectangle(pwidth - vmarg - 225, hheader, 225, 80);
            Rectangle rec2 = new Rectangle(pwidth - vmarg - 227, hheader-2, 229, 84);
            if (round)
            {
                DrawRoundRect(g, Pens.DarkGray, rec, 10);
                DrawRoundRect(g, Pens.DarkGray, rec2, 10);
            }
            else {
                g.DrawRectangle(Pens.LightGray, rec);
                g.DrawRectangle(Pens.LightGray, rec2);
            }

           
            StringFormat sf = new StringFormat(StringFormatFlags.DirectionRightToLeft);
            SizeF nsize = g.MeasureString(txt, nfont);
            RectangleF namerec = new RectangleF(new PointF(pwidth - vmarg - nsize.Width - 5, hheader+10), nsize);
            g.DrawString(txt, nfont, Brushes.Black, namerec, sf);

            SizeF numsize = g.MeasureString(num, nfont);
            RectangleF numerec = new RectangleF(new PointF(pwidth - vmarg - numsize.Width - 5, nsize.Height + 5 + hheader+10), numsize);
            g.DrawString(num, nfont, Brushes.Black, numerec, sf);
        }

        void drawText(Graphics g) {

            SizeF tsize = g.MeasureString(headertxt,nfont);
            RectangleF rec = new RectangleF(vmarg, hmarg - tsize.Height,  3 * (vboxpading + (boxw * 6)) - vboxpading, tsize.Height);
           // g.DrawLine(Pens.Black, vmarg, hmarg, vmarg + 3 * (vboxpading + (boxw * 6)) - vboxpading, hmarg);

            StringFormat format1 = new StringFormat(StringFormatFlags.NoClip);
            format1.LineAlignment = StringAlignment.Center;
            format1.Alignment = StringAlignment.Center;
            format1.SetDigitSubstitution(0x0C01,
            StringDigitSubstitute.Traditional);
            //g.DrawRectangles(Pens.Aqua, new RectangleF[] { rec});
            g.DrawString(headertxt, nfont, Brushes.Black, rec, format1);
        }

        private void print_btn_Click(object sender, EventArgs e)
        {
            p_doc.Print();
            //pdlg.ShowDialog(this);

        }

        private void zoom_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (zoom_box.SelectedIndex)
            {
                case 0: printv.Zoom = 0.25;
                    break;
                case 1: printv.Zoom = 0.5;
                    break;
                case 2: printv.Zoom = 1;
                    break;
                case 3: printv.Zoom = 2;
                    break;
                case 4: printv.Zoom = 4;
                    break;
                default:
                    break;
            }
        }

        public void DrawRoundRect(Graphics g, Pen p, float x, float y, float width, float height, float radius)
        {
            GraphicsPath gp = new GraphicsPath();

            gp.AddLine(x + radius, y, x + width - (radius * 2), y); // Line
            gp.AddArc(x + width - (radius * 2), y, radius * 2, radius * 2, 270, 90); // Corner
            gp.AddLine(x + width, y + radius, x + width, y + height - (radius * 2)); // Line
            gp.AddArc(x + width - (radius * 2), y + height - (radius * 2), radius * 2, radius * 2, 0, 90); // Corner
            gp.AddLine(x + width - (radius * 2), y + height, x + radius, y + height); // Line
            gp.AddArc(x, y + height - (radius * 2), radius * 2, radius * 2, 90, 90); // Corner
            gp.AddLine(x, y + height - (radius * 2), x, y + radius); // Line
            gp.AddArc(x, y, radius * 2, radius * 2, 180, 90); // Corner
            gp.CloseFigure();

            g.DrawPath(p, gp);
            gp.Dispose();
        }

        public void DrawRoundRect(Graphics g, Pen p, RectangleF rec, float radius)
        {
            GraphicsPath gp = new GraphicsPath();
            float x = rec.X;
            float y = rec.Y;
            float width = rec.Width;
            float height = rec.Height;
            gp.AddLine(x + radius, y, x + width - (radius * 2), y); // Line
            gp.AddArc(x + width - (radius * 2), y, radius * 2, radius * 2, 270, 90); // Corner
            gp.AddLine(x + width, y + radius, x + width, y + height - (radius * 2)); // Line
            gp.AddArc(x + width - (radius * 2), y + height - (radius * 2), radius * 2, radius * 2, 0, 90); // Corner
            gp.AddLine(x + width - (radius * 2), y + height, x + radius, y + height); // Line
            gp.AddArc(x, y + height - (radius * 2), radius * 2, radius * 2, 90, 90); // Corner
            gp.AddLine(x, y + height - (radius * 2), x, y + radius); // Line
            gp.AddArc(x, y, radius * 2, radius * 2, 180, 90); // Corner
            gp.CloseFigure();

            g.DrawPath(p, gp);
            gp.Dispose();
        }

        private void PrintForm_Load(object sender, EventArgs e)
        {
            this.Location = new Point(this.MdiParent.Width - this.Width - 10, 0); 
        }

    }
}
