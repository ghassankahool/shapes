namespace shapes
{
    partial class SplashForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashForm));
            this.linkl = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // linkl
            // 
            this.linkl.BackColor = System.Drawing.Color.Transparent;
            this.linkl.Location = new System.Drawing.Point(172, 302);
            this.linkl.Name = "linkl";
            this.linkl.Size = new System.Drawing.Size(249, 30);
            this.linkl.TabIndex = 2;
            this.linkl.TabStop = true;
            this.linkl.Text = "                                                                                 " +
                "";
            this.linkl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkl.Visible = false;
            this.linkl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkl_LinkClicked);
            // 
            // SplashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            
            this.BackgroundImage = global::shapes.Properties.Resources.splash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(472, 348);
            this.Controls.Add(this.linkl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SplashForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashForm";this.BackColor = System.Drawing.Color.Magenta;
            this.TransparencyKey = System.Drawing.Color.Magenta;
            this.Click += new System.EventHandler(this.SplashForm_Click);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.LinkLabel linkl;


    }
}