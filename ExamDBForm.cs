using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.IO;
using Divelements.SandRibbon;
using Microsoft.Win32;

namespace shapes
{
    public partial class examdbForm : RibbonForm
    {
        public examdbForm()
        {
            this.LocalRenderer.ColorScheme = Program.colorTheme;
            InitializeComponent();
            
        }

        QPanel[] qs = new QPanel[102];

       

        private void examdbForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'examdb.q' table. You can move, or remove it, as needed.
            this.qTableAdapter.Fill(this.examdb.q);
            // TODO: This line of code loads data into the 'examdb.exam' table. You can move, or remove it, as needed.
            this.examTableAdapter.Fill(this.examdb.exam);
            if (examdb.exam.Rows.Count == 0)
            {
                examdb.exam.AddexamRow(1,"", DateTime.Now, "", 0,1);
            }
            // TODO: This line of code loads data into the 'examdb.student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.examdb.student);

            this.qTableAdapter.Fill(this.examdb.q);


            for (int i = 0; i < 34; i++)
            {
               
                qs[i] = new QPanel();
                qs[i + 34] = new QPanel();
                
                qs[i].Num = (i + 1).ToString();
                qs[i + 34].Num = (i + 35).ToString();
                


                gpan.Controls.Add(qs[i]);
                gpan.Controls.Add(qs[i + 34]);
                if (i + 68 < 100)
                {
                    qs[i + 68] = new QPanel();
                    qs[i + 68].Num = (i + 69).ToString();
                    gpan.Controls.Add(qs[i + 68]);
                }
                else {
                    gpan.Controls.Add(new System.Windows.Forms.Label());
                }
            }

            setChecker();
           
            this.Location = new Point(this.MdiParent.Width - this.Width-15,0); 
        }

        private void setChecker() {
            for (int i = 0; i < examdb.q.Rows.Count; i++)
            {
                shapes.examdb.qRow row = examdb.q.Rows[i] as shapes.examdb.qRow;
                qs[row.q_num-1].NumSelect = (int)row.q_a;
            }
        }

        private void saveChecker() {
            examdb.q.BeginLoadData();
            for (int i = 0; i < qBindingSource.Count; i++)
            {
                (qBindingSource[i] as DataRowView)[1]= (long)qs[i].NumSelect;
            }
            examdb.q.EndLoadData();
        }

        private void save_exam_btn_Click(object sender, EventArgs e)
        {
            examBindingSource.EndEdit();
            examTableAdapter.Update(examdb.exam);
           
        }

        private void save_checker_btn_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            saveChecker();
            qBindingSource.EndEdit();
            qTableAdapter.Update(examdb.q);
            this.Cursor = Cursors.Default;
        }

      

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (tab_pages.SelectedIndex)
            {
                case 0:
                    if (examdb.exam.Rows.Count==0)
                    {
                        examdb.exam.AddexamRow(1,"", DateTime.Now, "", 0,1);
                    }
                    break;
                case 1:
                    break;
                case 2:
                    break;
                default:
                    break;
            }
        }

        private void refresh_btn_exam_Click(object sender, EventArgs e)
        {
            examBindingSource.ResetCurrentItem();
        }

        private void refresh_checker_btn_Click(object sender, EventArgs e)
        {
            setChecker();
        }

        private void save_stu_btn_Click(object sender, EventArgs e)
        {
            studentBindingSource.EndEdit();
            studentTableAdapter.Update(examdb.student);
        }

        private void examdbForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.ApplicationExitCall:
                    break;
                case CloseReason.FormOwnerClosing:
                    break;
                case CloseReason.MdiFormClosing:
                    break;
                case CloseReason.None:
                    break;
                case CloseReason.TaskManagerClosing:
                    break;
                case CloseReason.UserClosing:
                    if (!this.Visible)
                    {
                       e.Cancel=false;
                    }
                    else
                    {
                        e.Cancel = true;
                    }
                    
                    
                    break;
                case CloseReason.WindowsShutDown:
                    break;
                default:
                    break;
            }
        }
    }
}
