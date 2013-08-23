namespace shapes
{
    partial class PrintForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintForm));
            this.printv = new System.Windows.Forms.PrintPreviewControl();
            this.p_doc = new System.Drawing.Printing.PrintDocument();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.print_btn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.zoom_box = new System.Windows.Forms.ToolStripComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pdlg = new System.Windows.Forms.PrintDialog();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // printv
            // 
            this.printv.AutoZoom = false;
            this.printv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.printv.Document = this.p_doc;
            this.printv.Location = new System.Drawing.Point(0, 0);
            this.printv.Name = "printv";
            this.printv.Size = new System.Drawing.Size(838, 361);
            this.printv.TabIndex = 0;
            this.printv.Zoom = 1;
            // 
            // p_doc
            // 
            this.p_doc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.p_doc_PrintPage);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.print_btn,
            this.toolStripSeparator1,
            this.zoom_box});
            this.toolStrip1.Location = new System.Drawing.Point(4, 30);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(838, 63);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // print_btn
            // 
            this.print_btn.AutoSize = false;
            this.print_btn.Image = global::shapes.Properties.Resources.printform32;
            this.print_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.print_btn.Name = "print_btn";
            this.print_btn.Size = new System.Drawing.Size(68, 33);
            this.print_btn.Text = "طباعة نموذج";
            this.print_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.print_btn.Click += new System.EventHandler(this.print_btn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 63);
            // 
            // zoom_box
            // 
            this.zoom_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.zoom_box.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.zoom_box.Items.AddRange(new object[] {
            "25%",
            "50%",
            "100%",
            "200%",
            "400%"});
            this.zoom_box.Name = "zoom_box";
            this.zoom_box.Size = new System.Drawing.Size(121, 63);
            this.zoom_box.SelectedIndexChanged += new System.EventHandler(this.zoom_box_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.printv);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(838, 361);
            this.panel1.TabIndex = 2;
            // 
            // pdlg
            // 
            this.pdlg.AllowSelection = true;
            this.pdlg.Document = this.p_doc;
            this.pdlg.UseEXDialog = true;
            // 
            // PrintForm
            // 
            this.ApplicationText = "طباعة";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 458);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PrintForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.WindowText = "نموذج إجابة";
            this.Load += new System.EventHandler(this.PrintForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PrintPreviewControl printv;
        private System.Drawing.Printing.PrintDocument p_doc;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripButton print_btn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox zoom_box;
        private System.Windows.Forms.PrintDialog pdlg;
    }
}