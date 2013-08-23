namespace shapes
{
    partial class examdbForm
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
            System.Windows.Forms.Label e_nameLabel;
            System.Windows.Forms.Label e_dateLabel;
            System.Windows.Forms.Label e_textLabel;
            System.Windows.Forms.Label e_stunumLabel;
            System.Windows.Forms.Label q_markLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(examdbForm));
            this.examBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.examdb = new shapes.examdb();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chech_page = new System.Windows.Forms.TabPage();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gpan = new System.Windows.Forms.TableLayoutPanel();
            this.stu_page = new System.Windows.Forms.TabPage();
            this.studentDataGridView = new System.Windows.Forms.DataGridView();
            this.stunumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stunameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stumarkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tab_pages = new System.Windows.Forms.TabControl();
            this.exam_page = new System.Windows.Forms.TabPage();
            this.q_markTextBox = new System.Windows.Forms.TextBox();
            this.e_stunumTextBox = new System.Windows.Forms.TextBox();
            this.e_textTextBox = new System.Windows.Forms.TextBox();
            this.e_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.e_nameTextBox = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.studentTableAdapter = new shapes.examdbTableAdapters.studentTableAdapter();
            this.tableAdapterManager = new shapes.examdbTableAdapters.TableAdapterManager();
            this.examTableAdapter = new shapes.examdbTableAdapters.examTableAdapter();
            this.qTableAdapter = new shapes.examdbTableAdapters.qTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.exam_save_btn = new System.Windows.Forms.ToolStripButton();
            this.refresh_exam_btn = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.save_stu_btn = new System.Windows.Forms.ToolStripButton();
            this.save_checker_btn = new System.Windows.Forms.ToolStripButton();
            this.refresh_checker_btn = new System.Windows.Forms.ToolStripButton();
            this.save_exam_btn = new System.Windows.Forms.ToolStripButton();
            this.refresh_btn_exam = new System.Windows.Forms.ToolStripButton();
            e_nameLabel = new System.Windows.Forms.Label();
            e_dateLabel = new System.Windows.Forms.Label();
            e_textLabel = new System.Windows.Forms.Label();
            e_stunumLabel = new System.Windows.Forms.Label();
            q_markLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.examBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examdb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qBindingSource)).BeginInit();
            this.chech_page.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.stu_page.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.tab_pages.SuspendLayout();
            this.exam_page.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // e_nameLabel
            // 
            e_nameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            e_nameLabel.AutoSize = true;
            e_nameLabel.Location = new System.Drawing.Point(827, 72);
            e_nameLabel.Name = "e_nameLabel";
            e_nameLabel.Size = new System.Drawing.Size(48, 13);
            e_nameLabel.TabIndex = 1;
            e_nameLabel.Text = "الامتحان:";
            // 
            // e_dateLabel
            // 
            e_dateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            e_dateLabel.AutoSize = true;
            e_dateLabel.Location = new System.Drawing.Point(827, 99);
            e_dateLabel.Name = "e_dateLabel";
            e_dateLabel.Size = new System.Drawing.Size(72, 13);
            e_dateLabel.TabIndex = 3;
            e_dateLabel.Text = "تاريخ الامتحان:";
            // 
            // e_textLabel
            // 
            e_textLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            e_textLabel.AutoSize = true;
            e_textLabel.Location = new System.Drawing.Point(827, 124);
            e_textLabel.Name = "e_textLabel";
            e_textLabel.Size = new System.Drawing.Size(85, 13);
            e_textLabel.TabIndex = 5;
            e_textLabel.Text = "ترويسة الامتحان:";
            // 
            // e_stunumLabel
            // 
            e_stunumLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            e_stunumLabel.AutoSize = true;
            e_stunumLabel.Location = new System.Drawing.Point(827, 150);
            e_stunumLabel.Name = "e_stunumLabel";
            e_stunumLabel.Size = new System.Drawing.Size(79, 13);
            e_stunumLabel.TabIndex = 7;
            e_stunumLabel.Text = "عدد المتقدمين:";
            // 
            // q_markLabel
            // 
            q_markLabel.AutoSize = true;
            q_markLabel.Location = new System.Drawing.Point(827, 176);
            q_markLabel.Name = "q_markLabel";
            q_markLabel.Size = new System.Drawing.Size(74, 13);
            q_markLabel.TabIndex = 9;
            q_markLabel.Text = "علامة السؤال:";
            // 
            // examBindingSource
            // 
            this.examBindingSource.DataMember = "exam";
            this.examBindingSource.DataSource = this.examdb;
            // 
            // examdb
            // 
            this.examdb.DataSetName = "examdb";
            this.examdb.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "student";
            this.studentBindingSource.DataSource = this.examdb;
            // 
            // qBindingSource
            // 
            this.qBindingSource.DataMember = "q";
            this.qBindingSource.DataSource = this.examdb;
            // 
            // chech_page
            // 
            this.chech_page.Controls.Add(this.toolStrip2);
            this.chech_page.Controls.Add(this.panel1);
            this.chech_page.Location = new System.Drawing.Point(4, 22);
            this.chech_page.Name = "chech_page";
            this.chech_page.Size = new System.Drawing.Size(930, 336);
            this.chech_page.TabIndex = 2;
            this.chech_page.Text = "سلم التصحيح";
            this.chech_page.UseVisualStyleBackColor = true;
            // 
            // toolStrip2
            // 
            this.toolStrip2.AutoSize = false;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.save_checker_btn,
            this.toolStripSeparator1,
            this.refresh_checker_btn});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(930, 30);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 30);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.gpan);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(930, 336);
            this.panel1.TabIndex = 1;
            // 
            // gpan
            // 
            this.gpan.AutoSize = true;
            this.gpan.ColumnCount = 3;
            this.gpan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.gpan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.gpan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.gpan.Location = new System.Drawing.Point(8, 32);
            this.gpan.Name = "gpan";
            this.gpan.RowCount = 34;
            this.gpan.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.gpan.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.gpan.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.gpan.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.gpan.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.gpan.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.gpan.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.gpan.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.gpan.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.gpan.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.gpan.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.gpan.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.gpan.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.gpan.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.gpan.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.gpan.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.gpan.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.gpan.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.gpan.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.gpan.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.gpan.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.gpan.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.gpan.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.gpan.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.gpan.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.gpan.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.gpan.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.gpan.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.gpan.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.gpan.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.gpan.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.gpan.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.gpan.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.gpan.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.gpan.Size = new System.Drawing.Size(914, 296);
            this.gpan.TabIndex = 0;
            // 
            // stu_page
            // 
            this.stu_page.Controls.Add(this.studentDataGridView);
            this.stu_page.Controls.Add(this.bindingNavigator1);
            this.stu_page.Location = new System.Drawing.Point(4, 22);
            this.stu_page.Name = "stu_page";
            this.stu_page.Padding = new System.Windows.Forms.Padding(3);
            this.stu_page.Size = new System.Drawing.Size(930, 336);
            this.stu_page.TabIndex = 1;
            this.stu_page.Text = "الطلاب";
            this.stu_page.UseVisualStyleBackColor = true;
            // 
            // studentDataGridView
            // 
            this.studentDataGridView.AutoGenerateColumns = false;
            this.studentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stunumDataGridViewTextBoxColumn,
            this.stunameDataGridViewTextBoxColumn,
            this.stumarkDataGridViewTextBoxColumn});
            this.studentDataGridView.DataSource = this.studentBindingSource;
            this.studentDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentDataGridView.Location = new System.Drawing.Point(3, 28);
            this.studentDataGridView.Name = "studentDataGridView";
            this.studentDataGridView.Size = new System.Drawing.Size(924, 305);
            this.studentDataGridView.TabIndex = 0;
            // 
            // stunumDataGridViewTextBoxColumn
            // 
            this.stunumDataGridViewTextBoxColumn.DataPropertyName = "stu_num";
            this.stunumDataGridViewTextBoxColumn.HeaderText = "رقم المتقدم";
            this.stunumDataGridViewTextBoxColumn.Name = "stunumDataGridViewTextBoxColumn";
            // 
            // stunameDataGridViewTextBoxColumn
            // 
            this.stunameDataGridViewTextBoxColumn.DataPropertyName = "stu_name";
            this.stunameDataGridViewTextBoxColumn.HeaderText = "اسم المتقدم";
            this.stunameDataGridViewTextBoxColumn.Name = "stunameDataGridViewTextBoxColumn";
            this.stunameDataGridViewTextBoxColumn.Width = 200;
            // 
            // stumarkDataGridViewTextBoxColumn
            // 
            this.stumarkDataGridViewTextBoxColumn.DataPropertyName = "stu_mark";
            this.stumarkDataGridViewTextBoxColumn.HeaderText = "العلامة";
            this.stumarkDataGridViewTextBoxColumn.Name = "stumarkDataGridViewTextBoxColumn";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.studentBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.CountItemFormat = "من {0}";
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.save_stu_btn});
            this.bindingNavigator1.Location = new System.Drawing.Point(3, 3);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(924, 25);
            this.bindingNavigator1.TabIndex = 14;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(40, 22);
            this.bindingNavigatorCountItem.Text = "من {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tab_pages
            // 
            this.tab_pages.Controls.Add(this.exam_page);
            this.tab_pages.Controls.Add(this.stu_page);
            this.tab_pages.Controls.Add(this.chech_page);
            this.tab_pages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_pages.Location = new System.Drawing.Point(4, 30);
            this.tab_pages.Name = "tab_pages";
            this.tab_pages.RightToLeftLayout = true;
            this.tab_pages.SelectedIndex = 0;
            this.tab_pages.Size = new System.Drawing.Size(938, 362);
            this.tab_pages.TabIndex = 0;
            this.tab_pages.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // exam_page
            // 
            this.exam_page.AutoScroll = true;
            this.exam_page.Controls.Add(this.pictureBox1);
            this.exam_page.Controls.Add(q_markLabel);
            this.exam_page.Controls.Add(this.q_markTextBox);
            this.exam_page.Controls.Add(e_stunumLabel);
            this.exam_page.Controls.Add(this.e_stunumTextBox);
            this.exam_page.Controls.Add(e_textLabel);
            this.exam_page.Controls.Add(this.e_textTextBox);
            this.exam_page.Controls.Add(e_dateLabel);
            this.exam_page.Controls.Add(this.e_dateDateTimePicker);
            this.exam_page.Controls.Add(e_nameLabel);
            this.exam_page.Controls.Add(this.e_nameTextBox);
            this.exam_page.Controls.Add(this.toolStrip1);
            this.exam_page.Location = new System.Drawing.Point(4, 22);
            this.exam_page.Name = "exam_page";
            this.exam_page.Padding = new System.Windows.Forms.Padding(3);
            this.exam_page.Size = new System.Drawing.Size(930, 336);
            this.exam_page.TabIndex = 0;
            this.exam_page.Text = "معلومات الامتحان";
            this.exam_page.UseVisualStyleBackColor = true;
            // 
            // q_markTextBox
            // 
            this.q_markTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.examBindingSource, "q_mark", true));
            this.q_markTextBox.Location = new System.Drawing.Point(721, 173);
            this.q_markTextBox.Name = "q_markTextBox";
            this.q_markTextBox.Size = new System.Drawing.Size(100, 20);
            this.q_markTextBox.TabIndex = 10;
            // 
            // e_stunumTextBox
            // 
            this.e_stunumTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.e_stunumTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.examBindingSource, "e_stunum", true));
            this.e_stunumTextBox.Location = new System.Drawing.Point(721, 147);
            this.e_stunumTextBox.Name = "e_stunumTextBox";
            this.e_stunumTextBox.Size = new System.Drawing.Size(100, 20);
            this.e_stunumTextBox.TabIndex = 8;
            // 
            // e_textTextBox
            // 
            this.e_textTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.e_textTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.examBindingSource, "e_text", true));
            this.e_textTextBox.Location = new System.Drawing.Point(307, 121);
            this.e_textTextBox.Name = "e_textTextBox";
            this.e_textTextBox.Size = new System.Drawing.Size(514, 20);
            this.e_textTextBox.TabIndex = 6;
            // 
            // e_dateDateTimePicker
            // 
            this.e_dateDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.e_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.examBindingSource, "e_date", true));
            this.e_dateDateTimePicker.Location = new System.Drawing.Point(621, 95);
            this.e_dateDateTimePicker.Name = "e_dateDateTimePicker";
            this.e_dateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.e_dateDateTimePicker.TabIndex = 4;
            // 
            // e_nameTextBox
            // 
            this.e_nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.e_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.examBindingSource, "e_name", true));
            this.e_nameTextBox.Location = new System.Drawing.Point(621, 69);
            this.e_nameTextBox.Name = "e_nameTextBox";
            this.e_nameTextBox.Size = new System.Drawing.Size(200, 20);
            this.e_nameTextBox.TabIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exam_save_btn,
            this.toolStripSeparator3,
            this.refresh_exam_btn});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(924, 30);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "حفظ";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 30);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.examTableAdapter = this.examTableAdapter;
            this.tableAdapterManager.qTableAdapter = null;
            this.tableAdapterManager.studentTableAdapter = this.studentTableAdapter;
            this.tableAdapterManager.UpdateOrder = shapes.examdbTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // examTableAdapter
            // 
            this.examTableAdapter.ClearBeforeFill = true;
            // 
            // qTableAdapter
            // 
            this.qTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::shapes.Properties.Resources.icons;
            this.pictureBox1.Location = new System.Drawing.Point(307, 173);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 130);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // exam_save_btn
            // 
            this.exam_save_btn.Image = global::shapes.Properties.Resources.save24;
            this.exam_save_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exam_save_btn.Name = "exam_save_btn";
            this.exam_save_btn.Size = new System.Drawing.Size(56, 27);
            this.exam_save_btn.Text = "حفظ";
            this.exam_save_btn.Click += new System.EventHandler(this.save_exam_btn_Click);
            // 
            // refresh_exam_btn
            // 
            this.refresh_exam_btn.Image = global::shapes.Properties.Resources.refresh24;
            this.refresh_exam_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refresh_exam_btn.Name = "refresh_exam_btn";
            this.refresh_exam_btn.Size = new System.Drawing.Size(64, 27);
            this.refresh_exam_btn.Text = "تحديث";
            this.refresh_exam_btn.Click += new System.EventHandler(this.refresh_btn_exam_Click);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "جديد";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "حذف";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "الأول";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "السابق";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "التالي";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "الأخير";
            // 
            // save_stu_btn
            // 
            this.save_stu_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.save_stu_btn.Image = global::shapes.Properties.Resources.save24;
            this.save_stu_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.save_stu_btn.Name = "save_stu_btn";
            this.save_stu_btn.Size = new System.Drawing.Size(23, 22);
            this.save_stu_btn.Text = "حفظ";
            this.save_stu_btn.Click += new System.EventHandler(this.save_stu_btn_Click);
            // 
            // save_checker_btn
            // 
            this.save_checker_btn.Image = global::shapes.Properties.Resources.save24;
            this.save_checker_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.save_checker_btn.Name = "save_checker_btn";
            this.save_checker_btn.Size = new System.Drawing.Size(56, 27);
            this.save_checker_btn.Text = "حفظ";
            this.save_checker_btn.Click += new System.EventHandler(this.save_checker_btn_Click);
            // 
            // refresh_checker_btn
            // 
            this.refresh_checker_btn.Image = global::shapes.Properties.Resources.refresh24;
            this.refresh_checker_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refresh_checker_btn.Name = "refresh_checker_btn";
            this.refresh_checker_btn.Size = new System.Drawing.Size(64, 27);
            this.refresh_checker_btn.Text = "تحديث";
            this.refresh_checker_btn.Click += new System.EventHandler(this.refresh_checker_btn_Click);
            // 
            // save_exam_btn
            // 
            this.save_exam_btn.Image = ((System.Drawing.Image)(resources.GetObject("save_exam_btn.Image")));
            this.save_exam_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.save_exam_btn.Name = "save_exam_btn";
            this.save_exam_btn.Size = new System.Drawing.Size(48, 22);
            this.save_exam_btn.Text = "حفظ";
            this.save_exam_btn.Click += new System.EventHandler(this.save_exam_btn_Click);
            // 
            // refresh_btn_exam
            // 
            this.refresh_btn_exam.Image = ((System.Drawing.Image)(resources.GetObject("refresh_btn_exam.Image")));
            this.refresh_btn_exam.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refresh_btn_exam.Name = "refresh_btn_exam";
            this.refresh_btn_exam.Size = new System.Drawing.Size(56, 22);
            this.refresh_btn_exam.Text = "تحديث";
            this.refresh_btn_exam.Click += new System.EventHandler(this.refresh_btn_exam_Click);
            // 
            // examdbForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 396);
            this.Controls.Add(this.tab_pages);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "examdbForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.WindowText = "معلومات امتحان";
            this.Load += new System.EventHandler(this.examdbForm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.examdbForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.examBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examdb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qBindingSource)).EndInit();
            this.chech_page.ResumeLayout(false);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.stu_page.ResumeLayout(false);
            this.stu_page.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.tab_pages.ResumeLayout(false);
            this.exam_page.ResumeLayout(false);
            this.exam_page.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private shapes.examdbTableAdapters.TableAdapterManager tableAdapterManager;
        private shapes.examdbTableAdapters.examTableAdapter examTableAdapter;
        private System.Windows.Forms.BindingSource examBindingSource;
        private System.Windows.Forms.BindingSource qBindingSource;
        private shapes.examdbTableAdapters.qTableAdapter qTableAdapter;
        private System.Windows.Forms.TabPage chech_page;
        private System.Windows.Forms.ToolStripButton save_checker_btn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton refresh_checker_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel gpan;
        private System.Windows.Forms.TabPage stu_page;
        private System.Windows.Forms.DataGridView studentDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn stunumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stunameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stumarkDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton save_stu_btn;
        private System.Windows.Forms.TabControl tab_pages;
        private System.Windows.Forms.TabPage exam_page;
        private System.Windows.Forms.ToolStripButton save_exam_btn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton refresh_btn_exam;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TextBox e_stunumTextBox;
        private System.Windows.Forms.TextBox e_textTextBox;
        private System.Windows.Forms.DateTimePicker e_dateDateTimePicker;
        private System.Windows.Forms.TextBox e_nameTextBox;
        private System.Windows.Forms.ToolStripButton exam_save_btn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton refresh_exam_btn;
        internal examdb examdb;
        public System.Windows.Forms.BindingSource studentBindingSource;
        public shapes.examdbTableAdapters.studentTableAdapter studentTableAdapter;
        private System.Windows.Forms.TextBox q_markTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStrip toolStrip2;


    }
}