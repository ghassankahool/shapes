namespace shapes
{
    partial class InputDLG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputDLG));
            this.clientPanel1 = new Divelements.SandRibbon.ClientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.input = new System.Windows.Forms.TextBox();
            this.clientPanel2 = new Divelements.SandRibbon.ClientPanel();
            this.ok_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.clientPanel1.SuspendLayout();
            this.clientPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // clientPanel1
            // 
            this.clientPanel1.Controls.Add(this.label1);
            this.clientPanel1.Controls.Add(this.input);
            this.clientPanel1.DrawShadows = false;
            this.clientPanel1.Location = new System.Drawing.Point(4, 30);
            this.clientPanel1.Name = "clientPanel1";
            this.clientPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.clientPanel1.Size = new System.Drawing.Size(384, 136);
            this.clientPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(300, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "عدد الصفحات:";
            // 
            // input
            // 
            this.input.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.input.Location = new System.Drawing.Point(10, 28);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(284, 20);
            this.input.TabIndex = 0;
            // 
            // clientPanel2
            // 
            this.clientPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clientPanel2.Controls.Add(this.ok_btn);
            this.clientPanel2.Controls.Add(this.cancel_btn);
            this.clientPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.clientPanel2.DrawShadows = false;
            this.clientPanel2.Location = new System.Drawing.Point(4, 113);
            this.clientPanel2.Name = "clientPanel2";
            this.clientPanel2.Size = new System.Drawing.Size(384, 53);
            this.clientPanel2.TabIndex = 1;
            // 
            // ok_btn
            // 
            this.ok_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ok_btn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ok_btn.Location = new System.Drawing.Point(192, 9);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(112, 32);
            this.ok_btn.TabIndex = 1;
            this.ok_btn.Text = "موافق";
            this.ok_btn.UseVisualStyleBackColor = true;
            // 
            // cancel_btn
            // 
            this.cancel_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancel_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel_btn.Location = new System.Drawing.Point(74, 9);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(112, 32);
            this.cancel_btn.TabIndex = 0;
            this.cancel_btn.Text = "إلغاء الأمر";
            this.cancel_btn.UseVisualStyleBackColor = true;
            // 
            // InputDLG
            // 
            this.AcceptButton = this.ok_btn;
            this.ApplicationText = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancel_btn;
            this.ClientSize = new System.Drawing.Size(392, 170);
            this.Controls.Add(this.clientPanel2);
            this.Controls.Add(this.clientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InputDLG";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.WindowText = "عدد الصفحات";
            this.Load += new System.EventHandler(this.InputDLG_Load);
            this.clientPanel1.ResumeLayout(false);
            this.clientPanel1.PerformLayout();
            this.clientPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Divelements.SandRibbon.ClientPanel clientPanel1;
        private Divelements.SandRibbon.ClientPanel clientPanel2;
        private System.Windows.Forms.Button ok_btn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox input;

    }
}