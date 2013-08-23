namespace shapes
{
    partial class ExamImagesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExamImagesForm));
            this.imagelist = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.del_sel_btn = new System.Windows.Forms.Button();
            this.del_all_btn = new System.Windows.Forms.Button();
            this.del_err_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // imagelist
            // 
            this.imagelist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imagelist.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.imagelist.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imagelist.FormattingEnabled = true;
            this.imagelist.ItemHeight = 28;
            this.imagelist.Location = new System.Drawing.Point(3, 16);
            this.imagelist.Name = "imagelist";
            this.imagelist.Size = new System.Drawing.Size(608, 200);
            this.imagelist.TabIndex = 0;
            this.imagelist.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.imagelist_DrawItem);
            this.imagelist.DoubleClick += new System.EventHandler(this.imagelist_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.del_sel_btn);
            this.panel1.Controls.Add(this.del_all_btn);
            this.panel1.Controls.Add(this.del_err_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(4, 335);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(614, 51);
            this.panel1.TabIndex = 1;
            // 
            // del_sel_btn
            // 
            this.del_sel_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.del_sel_btn.Location = new System.Drawing.Point(257, 8);
            this.del_sel_btn.Name = "del_sel_btn";
            this.del_sel_btn.Size = new System.Drawing.Size(113, 33);
            this.del_sel_btn.TabIndex = 2;
            this.del_sel_btn.Text = "حذف المحدد";
            this.del_sel_btn.UseVisualStyleBackColor = true;
            this.del_sel_btn.Click += new System.EventHandler(this.del_sel_btn_Click);
            // 
            // del_all_btn
            // 
            this.del_all_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.del_all_btn.Location = new System.Drawing.Point(376, 8);
            this.del_all_btn.Name = "del_all_btn";
            this.del_all_btn.Size = new System.Drawing.Size(113, 33);
            this.del_all_btn.TabIndex = 1;
            this.del_all_btn.Text = "حذف  كافة الأوراق";
            this.del_all_btn.UseVisualStyleBackColor = true;
            this.del_all_btn.Click += new System.EventHandler(this.del_all_btn_Click);
            // 
            // del_err_btn
            // 
            this.del_err_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.del_err_btn.Location = new System.Drawing.Point(495, 8);
            this.del_err_btn.Name = "del_err_btn";
            this.del_err_btn.Size = new System.Drawing.Size(113, 33);
            this.del_err_btn.TabIndex = 0;
            this.del_err_btn.Text = "حذف الأوراق الخاطئة";
            this.del_err_btn.UseVisualStyleBackColor = true;
            this.del_err_btn.Click += new System.EventHandler(this.del_err_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.imagelist);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(4, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(614, 241);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "قائمة الأرقام والعلامات";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(4, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(614, 64);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(183, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "الأوراق المصححة";
            // 
            // ExamImagesForm
            // 
            this.ApplicationText = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 390);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ExamImagesForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.WindowText = "الأوراق الممسوحة والمصححة";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox imagelist;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button del_all_btn;
        private System.Windows.Forms.Button del_err_btn;
        private System.Windows.Forms.Button del_sel_btn;
        private System.Windows.Forms.Label label1;
    }
}