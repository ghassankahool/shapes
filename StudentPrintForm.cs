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
    public partial class StudentPrintForm : RibbonForm
    {
        public StudentPrintForm()
        {
            this.LocalRenderer.ColorScheme = Program.colorTheme;
            InitializeComponent();
        }

        private void StudentPrintForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'examdb.student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.examdb.student);
            // TODO: This line of code loads data into the 'examdb.exam' table. You can move, or remove it, as needed.
            this.examTableAdapter.Fill(this.examdb.exam);

            this.reportViewer1.RefreshReport();
        }
    }
}
