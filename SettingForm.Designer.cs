namespace shapes
{
    partial class SettingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingForm));
            this.t1 = new System.Windows.Forms.TrackBar();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.ok_btn = new System.Windows.Forms.Button();
            this.bar = new ProgressODoom.DualProgressBar();
            this.rarProgressPainter2 = new ProgressODoom.RarProgressPainter();
            this.flatGlossPainter2 = new ProgressODoom.FlatGlossPainter();
            this.rarProgressPainter1 = new ProgressODoom.RarProgressPainter();
            this.flatGlossPainter1 = new ProgressODoom.FlatGlossPainter();
            this.t2 = new System.Windows.Forms.TrackBar();
            this.l1 = new System.Windows.Forms.Label();
            this.l2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.t1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.t2)).BeginInit();
            this.SuspendLayout();
            // 
            // t1
            // 
            this.t1.Cursor = System.Windows.Forms.Cursors.Default;
            this.t1.Location = new System.Drawing.Point(134, 122);
            this.t1.Maximum = 200;
            this.t1.Minimum = 100;
            this.t1.Name = "t1";
            this.t1.RightToLeftLayout = true;
            this.t1.Size = new System.Drawing.Size(296, 45);
            this.t1.SmallChange = 5;
            this.t1.TabIndex = 0;
            this.t1.TickFrequency = 10;
            this.t1.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.t1.Value = 150;
            this.t1.Scroll += new System.EventHandler(this.t1_Scroll);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "النظام",
            "أزرق",
            "فضي",
            "أسود"});
            this.comboBox1.Location = new System.Drawing.Point(134, 234);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(295, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "التعبئة:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "الشكل:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cancel_btn);
            this.panel1.Controls.Add(this.ok_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(4, 309);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(463, 48);
            this.panel1.TabIndex = 6;
            // 
            // cancel_btn
            // 
            this.cancel_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel_btn.Location = new System.Drawing.Point(295, 8);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(75, 32);
            this.cancel_btn.TabIndex = 1;
            this.cancel_btn.Text = "إلغاء الأمر";
            this.cancel_btn.UseVisualStyleBackColor = true;
            // 
            // ok_btn
            // 
            this.ok_btn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ok_btn.Location = new System.Drawing.Point(376, 8);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(75, 32);
            this.ok_btn.TabIndex = 0;
            this.ok_btn.Text = "موافق";
            this.ok_btn.UseVisualStyleBackColor = true;
            this.ok_btn.Click += new System.EventHandler(this.ok_btn_Click);
            // 
            // bar
            // 
            this.bar.Location = new System.Drawing.Point(135, 93);
            this.bar.MarqueePercentage = 25;
            this.bar.MarqueeSpeed = 30;
            this.bar.MarqueeStep = 1;
            this.bar.MasterMaximum = 350;
            this.bar.MasterPainter = this.rarProgressPainter2;
            this.bar.MasterProgressPadding = 0;
            this.bar.MasterValue = 200;
            this.bar.Maximum = 350;
            this.bar.Minimum = 100;
            this.bar.Name = "bar";
            this.bar.PaintMasterFirst = true;
            this.bar.ProgressPadding = 0;
            this.bar.ProgressPainter = this.rarProgressPainter1;
            this.bar.ProgressType = ProgressODoom.ProgressType.Smooth;
            this.bar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bar.ShowPercentage = false;
            this.bar.Size = new System.Drawing.Size(295, 23);
            this.bar.TabIndex = 7;
            this.bar.Value = 100;
            // 
            // rarProgressPainter2
            // 
            this.rarProgressPainter2.GlossPainter = this.flatGlossPainter2;
            this.rarProgressPainter2.ProgressBorderPainter = null;
            this.rarProgressPainter2.ProgressType = ProgressODoom.RarProgressPainter.RarProgressType.Silver;
            this.rarProgressPainter2.ShowEdge = false;
            // 
            // flatGlossPainter2
            // 
            this.flatGlossPainter2.Alpha = 128;
            this.flatGlossPainter2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.flatGlossPainter2.PercentageCovered = 50;
            this.flatGlossPainter2.Style = ProgressODoom.GlossStyle.Both;
            this.flatGlossPainter2.Successor = null;
            // 
            // rarProgressPainter1
            // 
            this.rarProgressPainter1.GlossPainter = this.flatGlossPainter1;
            this.rarProgressPainter1.ProgressBorderPainter = null;
            this.rarProgressPainter1.ProgressType = ProgressODoom.RarProgressPainter.RarProgressType.Silver;
            this.rarProgressPainter1.ShowEdge = false;
            // 
            // flatGlossPainter1
            // 
            this.flatGlossPainter1.Alpha = 128;
            this.flatGlossPainter1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.flatGlossPainter1.PercentageCovered = 50;
            this.flatGlossPainter1.Style = ProgressODoom.GlossStyle.Both;
            this.flatGlossPainter1.Successor = null;
            // 
            // t2
            // 
            this.t2.Cursor = System.Windows.Forms.Cursors.Default;
            this.t2.Location = new System.Drawing.Point(135, 170);
            this.t2.Maximum = 350;
            this.t2.Minimum = 200;
            this.t2.Name = "t2";
            this.t2.RightToLeftLayout = true;
            this.t2.Size = new System.Drawing.Size(296, 45);
            this.t2.SmallChange = 5;
            this.t2.TabIndex = 8;
            this.t2.TickFrequency = 10;
            this.t2.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.t2.Value = 200;
            this.t2.Scroll += new System.EventHandler(this.t2_Scroll);
            // 
            // l1
            // 
            this.l1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.l1.Location = new System.Drawing.Point(40, 131);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(88, 23);
            this.l1.TabIndex = 9;
            this.l1.Text = "0";
            this.l1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l2
            // 
            this.l2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.l2.Location = new System.Drawing.Point(40, 178);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(88, 23);
            this.l2.TabIndex = 10;
            this.l2.Text = "0";
            this.l2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(299, 274);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(132, 13);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "مسح كافة الملفات السابقة";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // SettingForm
            // 
            this.AcceptButton = this.ok_btn;
            this.ApplicationText = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancel_btn;
            this.ClientSize = new System.Drawing.Size(471, 361);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.l2);
            this.Controls.Add(this.l1);
            this.Controls.Add(this.t2);
            this.Controls.Add(this.bar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.t1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingForm";
            this.WindowText = "الإعدادات";
            this.Load += new System.EventHandler(this.SettingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.t1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.t2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar t1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button ok_btn;
        private ProgressODoom.DualProgressBar bar;
        private ProgressODoom.RarProgressPainter rarProgressPainter1;
        private ProgressODoom.FlatGlossPainter flatGlossPainter1;
        private ProgressODoom.FlatGlossPainter flatGlossPainter2;
        private ProgressODoom.RarProgressPainter rarProgressPainter2;
        private System.Windows.Forms.TrackBar t2;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}