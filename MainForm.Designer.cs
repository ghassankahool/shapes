namespace shapes
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            Divelements.SandRibbon.StatusBarStrip statusBarStrip1;
            Divelements.SandRibbon.Rendering.RibbonRenderer ribbonRenderer1 = new Divelements.SandRibbon.Rendering.RibbonRenderer();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.stat_l = new Divelements.SandRibbon.Label();
            this.ribbon = new Divelements.SandRibbon.RibbonManager(this.components);
            this.statusBar1 = new Divelements.SandRibbon.StatusBar();
            this.ofdlg = new System.Windows.Forms.OpenFileDialog();
            this.sfdlg = new System.Windows.Forms.SaveFileDialog();
            this.scanner = new Atalasoft.Twain.Acquisition();
            this.printdlg = new System.Windows.Forms.PrintDialog();
            this.ppdlg = new System.Windows.Forms.PrintPreviewDialog();
            this.ribbon1 = new Divelements.SandRibbon.Ribbon();
            this.applicationMenu1 = new Divelements.SandRibbon.ApplicationMenu();
            this.new_exam_menu = new Divelements.SandRibbon.MainMenuItem();
            this.open_exam_menu = new Divelements.SandRibbon.MainMenuItem();
            this.scaner_menu = new Divelements.SandRibbon.MainMenuItem();
            this.print_form_menu = new Divelements.SandRibbon.MainMenuItem();
            this.option_menu = new Divelements.SandRibbon.MainMenuItem();
            this.about_menu = new Divelements.SandRibbon.MainMenuItem();
            this.orginal = new Divelements.SandRibbon.RibbonTab();
            this.file_chunck = new Divelements.SandRibbon.RibbonChunk();
            this.new_btn = new Divelements.SandRibbon.Button();
            this.open_btn = new Divelements.SandRibbon.Button();
            this.close_btn = new Divelements.SandRibbon.Button();
            this.ribbonChunk1 = new Divelements.SandRibbon.RibbonChunk();
            this.scan_select_btn = new Divelements.SandRibbon.Button();
            this.scan_btn1 = new Divelements.SandRibbon.Button();
            this.todb_btn = new Divelements.SandRibbon.Button();
            this.ribbonChunk2 = new Divelements.SandRibbon.RibbonChunk();
            this.res_window_btn = new Divelements.SandRibbon.Button();
            this.ribbonTab3 = new Divelements.SandRibbon.RibbonTab();
            this.ribbonChunk4 = new Divelements.SandRibbon.RibbonChunk();
            this.print_exam_btn = new Divelements.SandRibbon.Button();
            this.ribbonChunk3 = new Divelements.SandRibbon.RibbonChunk();
            this.print_form_btn = new Divelements.SandRibbon.Button();
            this.a_print_form_btn = new Divelements.SandRibbon.Button();
            this.v_form_btn = new Divelements.SandRibbon.Button();
            this.quickAccessToolBar1 = new Divelements.SandRibbon.QuickAccessToolBar();
            statusBarStrip1 = new Divelements.SandRibbon.StatusBarStrip();
            this.ribbon1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusBarStrip1
            // 
            statusBarStrip1.Items.AddRange(new Divelements.SandRibbon.WidgetBase[] {
            this.stat_l});
            // 
            // stat_l
            // 
            this.stat_l.TextSpace = 200;
            // 
            // ribbon
            // 
            this.ribbon.Customization = Divelements.SandRibbon.RibbonCustomizationType.Full;
            this.ribbon.OwnerForm = this;
            ribbonRenderer1.ColorScheme = Divelements.SandRibbon.Rendering.Office2007ColorScheme.System;
            this.ribbon.Renderer = ribbonRenderer1;
            // 
            // statusBar1
            // 
            this.statusBar1.ExtendedStrip = null;
            resources.ApplyResources(this.statusBar1, "statusBar1");
            this.statusBar1.MainStrip = statusBarStrip1;
            this.statusBar1.Manager = this.ribbon;
            this.statusBar1.Name = "statusBar1";
            // 
            // ofdlg
            // 
            resources.ApplyResources(this.ofdlg, "ofdlg");
            this.ofdlg.RestoreDirectory = true;
            // 
            // sfdlg
            // 
            this.sfdlg.DefaultExt = "gdb";
            resources.ApplyResources(this.sfdlg, "sfdlg");
            this.sfdlg.RestoreDirectory = true;
            // 
            // scanner
            // 
            this.scanner.ApplicationIdentity.Country = Atalasoft.Twain.CountryCode.Usa;
            this.scanner.ApplicationIdentity.Info = "";
            this.scanner.ApplicationIdentity.Language = Atalasoft.Twain.LanguageType.EnglishUsa;
            this.scanner.ApplicationIdentity.Manufacturer = "Atalasoft";
            this.scanner.ApplicationIdentity.ProductFamily = "Imaging";
            this.scanner.ApplicationIdentity.ProductName = "DotTwain";
            this.scanner.ApplicationIdentity.ProtocolMajor = 1;
            this.scanner.ApplicationIdentity.ProtocolMinor = 9;
            this.scanner.ApplicationIdentity.SupportedGroups = ((Atalasoft.Twain.TwainDataGroupFlags)(((Atalasoft.Twain.TwainDataGroupFlags.DG_CONTROL | Atalasoft.Twain.TwainDataGroupFlags.DG_IMAGE)
                        | Atalasoft.Twain.TwainDataGroupFlags.DG_AUDIO)));
            this.scanner.ApplicationIdentity.VersionMajor = 2;
            this.scanner.ApplicationIdentity.VersionMinor = 0;
            this.scanner.Parent = this;
            this.scanner.ImageAcquired += new Atalasoft.Twain.ImageAcquiredEventHandler(this.scanner_ImageAcquired);
            this.scanner.AcquireFinished += new System.EventHandler(this.scanner_AcquireFinished);
            // 
            // printdlg
            // 
            this.printdlg.UseEXDialog = true;
            // 
            // ppdlg
            // 
            resources.ApplyResources(this.ppdlg, "ppdlg");
            this.ppdlg.Name = "ppdlg";
            // 
            // ribbon1
            // 
            this.ribbon1.ApplicationImage = global::shapes.Properties.Resources.ico32;
            this.ribbon1.ApplicationMenu = this.applicationMenu1;
            resources.ApplyResources(this.ribbon1, "ribbon1");
            this.ribbon1.Controls.Add(this.orginal);
            this.ribbon1.Controls.Add(this.ribbonTab3);
            this.ribbon1.Manager = this.ribbon;
            this.ribbon1.Name = "ribbon1";
            this.ribbon1.ToolBar = this.quickAccessToolBar1;
            this.ribbon1.Click += new System.EventHandler(this.ribbon1_Click);
            // 
            // applicationMenu1
            // 
            this.applicationMenu1.ExitButtonImage = ((System.Drawing.Image)(resources.GetObject("applicationMenu1.ExitButtonImage")));
            resources.ApplyResources(this.applicationMenu1, "applicationMenu1");
            this.applicationMenu1.Items.AddRange(new Divelements.SandRibbon.WidgetBase[] {
            this.new_exam_menu,
            this.open_exam_menu,
            this.scaner_menu,
            this.print_form_menu,
            this.option_menu,
            this.about_menu});
            this.applicationMenu1.LayoutOrder = Divelements.SandRibbon.LayoutOrder.FarToNear;
            this.applicationMenu1.OptionsButtonImage = ((System.Drawing.Image)(resources.GetObject("applicationMenu1.OptionsButtonImage")));
            this.applicationMenu1.ShowOptions += new System.EventHandler(this.applicationMenu1_ShowOptions);
            this.applicationMenu1.LoadDocument += new Divelements.SandRibbon.DocumentInformationEventHandler(this.applicationMenu1_LoadDocument);
            // 
            // new_exam_menu
            // 
            this.new_exam_menu.Guid = new System.Guid("fc4d5938-3246-433c-ade4-e37b09149a69");
            this.new_exam_menu.Image = global::shapes.Properties.Resources.newfile32;
            resources.ApplyResources(this.new_exam_menu, "new_exam_menu");
            this.new_exam_menu.Activate += new System.EventHandler(this.new_exam_menu_Activate);
            // 
            // open_exam_menu
            // 
            this.open_exam_menu.Guid = new System.Guid("0a3586ed-b7b5-4182-8c74-f08697124072");
            this.open_exam_menu.Image = global::shapes.Properties.Resources.openfile32;
            resources.ApplyResources(this.open_exam_menu, "open_exam_menu");
            this.open_exam_menu.Activate += new System.EventHandler(this.open_exam_menu_Activate);
            // 
            // scaner_menu
            // 
            this.scaner_menu.BeginGroup = true;
            this.scaner_menu.Guid = new System.Guid("b5df4159-eacd-4f75-96b4-b5fc00b4ebd8");
            this.scaner_menu.Image = global::shapes.Properties.Resources.scanner32;
            resources.ApplyResources(this.scaner_menu, "scaner_menu");
            this.scaner_menu.Activate += new System.EventHandler(this.scaner_menu_Activate);
            // 
            // print_form_menu
            // 
            this.print_form_menu.Guid = new System.Guid("c103461b-4dc9-4899-a3c3-a73f63b9caed");
            this.print_form_menu.Image = global::shapes.Properties.Resources.printform32;
            resources.ApplyResources(this.print_form_menu, "print_form_menu");
            this.print_form_menu.Activate += new System.EventHandler(this.print_form_menu_Activate);
            // 
            // option_menu
            // 
            this.option_menu.BeginGroup = true;
            this.option_menu.Guid = new System.Guid("3e8134f8-b231-494d-b892-e58280488602");
            this.option_menu.Image = global::shapes.Properties.Resources.option32;
            resources.ApplyResources(this.option_menu, "option_menu");
            this.option_menu.Activate += new System.EventHandler(this.option_menu_Activate);
            // 
            // about_menu
            // 
            this.about_menu.BeginGroup = true;
            this.about_menu.Guid = new System.Guid("e550ecb2-a249-4717-b545-57493c31699e");
            this.about_menu.Image = global::shapes.Properties.Resources.about32;
            resources.ApplyResources(this.about_menu, "about_menu");
            this.about_menu.Activate += new System.EventHandler(this.about_menu_Activate);
            // 
            // orginal
            // 
            this.orginal.Chunks.AddRange(new Divelements.SandRibbon.WidgetBase[] {
            this.file_chunck,
            this.ribbonChunk1,
            this.ribbonChunk2});
            resources.ApplyResources(this.orginal, "orginal");
            this.orginal.Manager = this.ribbon;
            this.orginal.Name = "orginal";
            // 
            // file_chunck
            // 
            this.file_chunck.Items.AddRange(new Divelements.SandRibbon.WidgetBase[] {
            this.new_btn,
            this.open_btn,
            this.close_btn});
            resources.ApplyResources(this.file_chunck, "file_chunck");
            // 
            // new_btn
            // 
            this.new_btn.Guid = new System.Guid("0af1b73b-9c49-42a2-9405-e6918f14b2a2");
            this.new_btn.Image = global::shapes.Properties.Resources.newfile;
            resources.ApplyResources(this.new_btn, "new_btn");
            this.new_btn.TextContentRelation = Divelements.SandRibbon.TextContentRelation.Underneath;
            this.new_btn.Activate += new System.EventHandler(this.new_btn_Activate);
            // 
            // open_btn
            // 
            this.open_btn.Guid = new System.Guid("6d55fd65-a126-44d2-b828-93bd78587456");
            this.open_btn.Image = ((System.Drawing.Image)(resources.GetObject("open_btn.Image")));
            resources.ApplyResources(this.open_btn, "open_btn");
            this.open_btn.TextContentRelation = Divelements.SandRibbon.TextContentRelation.Underneath;
            this.open_btn.Activate += new System.EventHandler(this.open_btn_Activate);
            // 
            // close_btn
            // 
            this.close_btn.Guid = new System.Guid("33911bdd-d3e3-4145-be36-f517c2db25e8");
            this.close_btn.Image = global::shapes.Properties.Resources.close36;
            resources.ApplyResources(this.close_btn, "close_btn");
            this.close_btn.TextContentRelation = Divelements.SandRibbon.TextContentRelation.Underneath;
            this.close_btn.Activate += new System.EventHandler(this.close_btn_Activate);
            // 
            // ribbonChunk1
            // 
            this.ribbonChunk1.Items.AddRange(new Divelements.SandRibbon.WidgetBase[] {
            this.scan_select_btn,
            this.scan_btn1,
            this.todb_btn});
            resources.ApplyResources(this.ribbonChunk1, "ribbonChunk1");
            // 
            // scan_select_btn
            // 
            this.scan_select_btn.Guid = new System.Guid("77b4fdb4-4c39-44d8-aa38-8d8fe9af8071");
            this.scan_select_btn.Image = global::shapes.Properties.Resources.scanner;
            resources.ApplyResources(this.scan_select_btn, "scan_select_btn");
            this.scan_select_btn.TextContentRelation = Divelements.SandRibbon.TextContentRelation.Underneath;
            this.scan_select_btn.Activate += new System.EventHandler(this.scan_select_btn_Activate);
            // 
            // scan_btn1
            // 
            this.scan_btn1.Guid = new System.Guid("21277d70-d56a-4f5d-9f59-5ca29b973dc0");
            this.scan_btn1.Image = global::shapes.Properties.Resources.scanstart;
            resources.ApplyResources(this.scan_btn1, "scan_btn1");
            this.scan_btn1.TextContentRelation = Divelements.SandRibbon.TextContentRelation.Underneath;
            this.scan_btn1.Activate += new System.EventHandler(this.scan_btn1_Activate);
            // 
            // todb_btn
            // 
            this.todb_btn.Guid = new System.Guid("2afcf4de-1398-4e3d-bbbf-c67ec0aeb9fd");
            this.todb_btn.Image = global::shapes.Properties.Resources.todb36;
            resources.ApplyResources(this.todb_btn, "todb_btn");
            this.todb_btn.TextContentRelation = Divelements.SandRibbon.TextContentRelation.Underneath;
            this.todb_btn.Activate += new System.EventHandler(this.todb_btn_Activate);
            // 
            // ribbonChunk2
            // 
            this.ribbonChunk2.Image = global::shapes.Properties.Resources.about32;
            this.ribbonChunk2.Items.AddRange(new Divelements.SandRibbon.WidgetBase[] {
            this.res_window_btn});
            this.ribbonChunk2.Padding = new Divelements.SandRibbon.WidgetEdges(15, 4, 15, 4);
            resources.ApplyResources(this.ribbonChunk2, "ribbonChunk2");
            // 
            // res_window_btn
            // 
            this.res_window_btn.Guid = new System.Guid("37f1a075-7f44-4001-8786-6b7a43a0d123");
            this.res_window_btn.Image = global::shapes.Properties.Resources.reswindow36;
            resources.ApplyResources(this.res_window_btn, "res_window_btn");
            this.res_window_btn.TextContentRelation = Divelements.SandRibbon.TextContentRelation.Underneath;
            this.res_window_btn.Activate += new System.EventHandler(this.res_window_btn_Activate);
            // 
            // ribbonTab3
            // 
            this.ribbonTab3.Chunks.AddRange(new Divelements.SandRibbon.WidgetBase[] {
            this.ribbonChunk4,
            this.ribbonChunk3});
            resources.ApplyResources(this.ribbonTab3, "ribbonTab3");
            this.ribbonTab3.Manager = this.ribbon;
            this.ribbonTab3.Name = "ribbonTab3";
            // 
            // ribbonChunk4
            // 
            this.ribbonChunk4.Items.AddRange(new Divelements.SandRibbon.WidgetBase[] {
            this.print_exam_btn});
            resources.ApplyResources(this.ribbonChunk4, "ribbonChunk4");
            // 
            // print_exam_btn
            // 
            this.print_exam_btn.Guid = new System.Guid("28066c4b-8630-4c70-a043-7d6440bc4712");
            this.print_exam_btn.Image = global::shapes.Properties.Resources.print;
            resources.ApplyResources(this.print_exam_btn, "print_exam_btn");
            this.print_exam_btn.TextContentRelation = Divelements.SandRibbon.TextContentRelation.Underneath;
            this.print_exam_btn.Activate += new System.EventHandler(this.print_exam_btn_Activate);
            // 
            // ribbonChunk3
            // 
            this.ribbonChunk3.Items.AddRange(new Divelements.SandRibbon.WidgetBase[] {
            this.print_form_btn,
            this.a_print_form_btn,
            this.v_form_btn});
            resources.ApplyResources(this.ribbonChunk3, "ribbonChunk3");
            // 
            // print_form_btn
            // 
            this.print_form_btn.Guid = new System.Guid("38c474f0-c7ce-486d-b156-fafee3674cf5");
            this.print_form_btn.Image = global::shapes.Properties.Resources.printform;
            resources.ApplyResources(this.print_form_btn, "print_form_btn");
            this.print_form_btn.TextContentRelation = Divelements.SandRibbon.TextContentRelation.Underneath;
            this.print_form_btn.Activate += new System.EventHandler(this.print_form_btn_Activate);
            // 
            // a_print_form_btn
            // 
            this.a_print_form_btn.Guid = new System.Guid("371da95d-9c32-4023-afa2-994fb632c64f");
            this.a_print_form_btn.Image = global::shapes.Properties.Resources.aprintform;
            resources.ApplyResources(this.a_print_form_btn, "a_print_form_btn");
            this.a_print_form_btn.TextContentRelation = Divelements.SandRibbon.TextContentRelation.Underneath;
            this.a_print_form_btn.Activate += new System.EventHandler(this.a_print_form_btn_Activate);
            // 
            // v_form_btn
            // 
            this.v_form_btn.Guid = new System.Guid("175c9e05-d4ed-4184-aa89-0b9b8cc71142");
            this.v_form_btn.Image = global::shapes.Properties.Resources.printview;
            resources.ApplyResources(this.v_form_btn, "v_form_btn");
            this.v_form_btn.TextContentRelation = Divelements.SandRibbon.TextContentRelation.Underneath;
            this.v_form_btn.Activate += new System.EventHandler(this.v_form_btn_Activate);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ribbon1);
            this.Controls.Add(this.statusBar1);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ribbon1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Divelements.SandRibbon.Ribbon ribbon1;
        private Divelements.SandRibbon.RibbonTab orginal;
        private Divelements.SandRibbon.RibbonChunk file_chunck;
        private Divelements.SandRibbon.QuickAccessToolBar quickAccessToolBar1;
        private Divelements.SandRibbon.StatusBar statusBar1;
        private Divelements.SandRibbon.ApplicationMenu applicationMenu1;
        private Divelements.SandRibbon.MainMenuItem new_exam_menu;
        private Divelements.SandRibbon.Button new_btn;
        private Divelements.SandRibbon.Button open_btn;
        private Divelements.SandRibbon.RibbonChunk ribbonChunk1;
        private Divelements.SandRibbon.MainMenuItem open_exam_menu;
        private Divelements.SandRibbon.MainMenuItem scaner_menu;
        private Divelements.SandRibbon.MainMenuItem print_form_menu;
        private System.Windows.Forms.OpenFileDialog ofdlg;
        private Divelements.SandRibbon.Button scan_select_btn;
        private Divelements.SandRibbon.Button scan_btn1;
        private Divelements.SandRibbon.RibbonTab ribbonTab3;
        private Divelements.SandRibbon.RibbonChunk ribbonChunk3;
        private Divelements.SandRibbon.Button print_form_btn;
        private Divelements.SandRibbon.Button a_print_form_btn;
        private Divelements.SandRibbon.RibbonChunk ribbonChunk4;
        private Divelements.SandRibbon.Button print_exam_btn;
        private Divelements.SandRibbon.Button v_form_btn;
        private System.Windows.Forms.SaveFileDialog sfdlg;
        private Divelements.SandRibbon.MainMenuItem option_menu;
        private Divelements.SandRibbon.MainMenuItem about_menu;
        private Atalasoft.Twain.Acquisition scanner;
        private Divelements.SandRibbon.Label stat_l;
        private Divelements.SandRibbon.Button todb_btn;
        private Divelements.SandRibbon.RibbonChunk ribbonChunk2;
        private Divelements.SandRibbon.Button close_btn;
        private Divelements.SandRibbon.Button res_window_btn;
        private System.Windows.Forms.PrintDialog printdlg;
        private System.Windows.Forms.PrintPreviewDialog ppdlg;
        internal Divelements.SandRibbon.RibbonManager ribbon;
    }
}

