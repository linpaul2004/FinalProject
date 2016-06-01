namespace FinalProject
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
		/// 修改這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.Label label2;
			this.lbSearch = new System.Windows.Forms.Label();
			this.textSearch = new System.Windows.Forms.TextBox();
			this.buttonSearch = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Head = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Content = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.CopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.SetToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.comboBoxChoice = new System.Windows.Forms.ComboBox();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.buttonRefresh = new System.Windows.Forms.Button();
			this.checkBoxConsistent = new System.Windows.Forms.CheckBox();
			this.labelTotal = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.PrintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.OutputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pdfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.txtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.RefreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.OptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.LikeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.UserDefinedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.BackgroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.FontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.word8 = new System.Windows.Forms.ToolStripMenuItem();
			this.word10 = new System.Windows.Forms.ToolStripMenuItem();
			this.word12 = new System.Windows.Forms.ToolStripMenuItem();
			this.word15 = new System.Windows.Forms.ToolStripMenuItem();
			this.word20 = new System.Windows.Forms.ToolStripMenuItem();
			this.word28 = new System.Windows.Forms.ToolStripMenuItem();
			this.word36 = new System.Windows.Forms.ToolStripMenuItem();
			this.word72 = new System.Windows.Forms.ToolStripMenuItem();
			this.SetFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			this.printDialog1 = new System.Windows.Forms.PrintDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.printDocument1 = new System.Drawing.Printing.PrintDocument();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.labelLastUpdate = new System.Windows.Forms.Label();
			this.change = new System.Windows.Forms.Button();
			this.multisearch = new System.Windows.Forms.Button();
			this.multichoice = new System.Windows.Forms.Button();
			label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new System.Drawing.Point(3, 37);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(89, 12);
			label2.TabIndex = 10;
			label2.Text = "最後更新時間：";
			// 
			// lbSearch
			// 
			this.lbSearch.AutoSize = true;
			this.lbSearch.Location = new System.Drawing.Point(10, 34);
			this.lbSearch.Name = "lbSearch";
			this.lbSearch.Size = new System.Drawing.Size(65, 12);
			this.lbSearch.TabIndex = 0;
			this.lbSearch.Text = "搜尋字串：";
			// 
			// textSearch
			// 
			this.textSearch.Location = new System.Drawing.Point(81, 31);
			this.textSearch.Name = "textSearch";
			this.textSearch.Size = new System.Drawing.Size(255, 22);
			this.textSearch.TabIndex = 1;
			this.textSearch.Enter += new System.EventHandler(this.textSearch_Enter);
			this.textSearch.Leave += new System.EventHandler(this.textSearch_Leave);
			// 
			// buttonSearch
			// 
			this.buttonSearch.Location = new System.Drawing.Point(41, 85);
			this.buttonSearch.Name = "buttonSearch";
			this.buttonSearch.Size = new System.Drawing.Size(75, 23);
			this.buttonSearch.TabIndex = 3;
			this.buttonSearch.Text = "搜尋";
			this.buttonSearch.UseVisualStyleBackColor = true;
			this.buttonSearch.Click += new System.EventHandler(this.button1_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
			this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridView1.CausesValidation = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Head,
            this.Num,
            this.Content});
			this.dataGridView1.Location = new System.Drawing.Point(12, 114);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(590, 282);
			this.dataGridView1.TabIndex = 4;
			this.dataGridView1.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDown);
			// 
			// Head
			// 
			this.Head.HeaderText = "法律名稱";
			this.Head.Name = "Head";
			this.Head.ReadOnly = true;
			this.Head.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.Head.Width = 78;
			// 
			// Num
			// 
			this.Num.HeaderText = "條號";
			this.Num.Name = "Num";
			this.Num.ReadOnly = true;
			this.Num.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.Num.Width = 54;
			// 
			// Content
			// 
			this.Content.HeaderText = "條文";
			this.Content.Name = "Content";
			this.Content.ReadOnly = true;
			this.Content.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.Content.Width = 54;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CopyToolStripMenuItem,
            this.SetToolStripMenuItem1});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(164, 48);
			// 
			// CopyToolStripMenuItem
			// 
			this.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem";
			this.CopyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
			this.CopyToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
			this.CopyToolStripMenuItem.Text = "複製(C)";
			this.CopyToolStripMenuItem.Click += new System.EventHandler(this.CopyToolStripMenuItem_Click);
			// 
			// SetToolStripMenuItem1
			// 
			this.SetToolStripMenuItem1.Name = "SetToolStripMenuItem1";
			this.SetToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
			this.SetToolStripMenuItem1.Size = new System.Drawing.Size(163, 22);
			this.SetToolStripMenuItem1.Text = "我的最愛";
			this.SetToolStripMenuItem1.Click += new System.EventHandler(this.SetToolStripMenuItem1_Click);
			// 
			// comboBoxChoice
			// 
			this.comboBoxChoice.FormattingEnabled = true;
			this.comboBoxChoice.Location = new System.Drawing.Point(81, 59);
			this.comboBoxChoice.Name = "comboBoxChoice";
			this.comboBoxChoice.Size = new System.Drawing.Size(143, 20);
			this.comboBoxChoice.TabIndex = 6;
			// 
			// buttonAdd
			// 
			this.buttonAdd.Location = new System.Drawing.Point(122, 85);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(75, 23);
			this.buttonAdd.TabIndex = 7;
			this.buttonAdd.Text = "法律管理";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(10, 62);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 12);
			this.label1.TabIndex = 8;
			this.label1.Text = "搜尋法律：";
			// 
			// buttonRefresh
			// 
			this.buttonRefresh.Location = new System.Drawing.Point(3, 3);
			this.buttonRefresh.Name = "buttonRefresh";
			this.buttonRefresh.Size = new System.Drawing.Size(128, 23);
			this.buttonRefresh.TabIndex = 9;
			this.buttonRefresh.Text = "更新法條內容";
			this.buttonRefresh.UseVisualStyleBackColor = true;
			this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
			// 
			// checkBoxConsistent
			// 
			this.checkBoxConsistent.AutoSize = true;
			this.checkBoxConsistent.Checked = true;
			this.checkBoxConsistent.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxConsistent.Location = new System.Drawing.Point(342, 33);
			this.checkBoxConsistent.Name = "checkBoxConsistent";
			this.checkBoxConsistent.Size = new System.Drawing.Size(72, 16);
			this.checkBoxConsistent.TabIndex = 10;
			this.checkBoxConsistent.Text = "一致搜尋";
			this.checkBoxConsistent.UseVisualStyleBackColor = true;
			// 
			// labelTotal
			// 
			this.labelTotal.AutoSize = true;
			this.labelTotal.Location = new System.Drawing.Point(203, 90);
			this.labelTotal.Name = "labelTotal";
			this.labelTotal.Size = new System.Drawing.Size(86, 12);
			this.labelTotal.TabIndex = 11;
			this.labelTotal.Text = "搜尋結果：0 項";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.OptionToolStripMenuItem,
            this.HelpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(622, 24);
			this.menuStrip1.TabIndex = 12;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// FileToolStripMenuItem
			// 
			this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PrintToolStripMenuItem,
            this.OutputToolStripMenuItem,
            this.RefreshToolStripMenuItem,
            this.ExitToolStripMenuItem});
			this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
			this.FileToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
			this.FileToolStripMenuItem.Text = "檔案";
			// 
			// PrintToolStripMenuItem
			// 
			this.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem";
			this.PrintToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.PrintToolStripMenuItem.Text = "列印";
			this.PrintToolStripMenuItem.Click += new System.EventHandler(this.PrintToolStripMenuItem_Click);
			// 
			// OutputToolStripMenuItem
			// 
			this.OutputToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pdfToolStripMenuItem,
            this.txtToolStripMenuItem});
			this.OutputToolStripMenuItem.Name = "OutputToolStripMenuItem";
			this.OutputToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.OutputToolStripMenuItem.Text = "輸出到";
			// 
			// pdfToolStripMenuItem
			// 
			this.pdfToolStripMenuItem.Name = "pdfToolStripMenuItem";
			this.pdfToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.pdfToolStripMenuItem.Text = "PDF 檔 (.pdf)";
			this.pdfToolStripMenuItem.Click += new System.EventHandler(this.pdfToolStripMenuItem_Click);
			// 
			// txtToolStripMenuItem
			// 
			this.txtToolStripMenuItem.Name = "txtToolStripMenuItem";
			this.txtToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.txtToolStripMenuItem.Text = "純文字檔 (.txt)";
			this.txtToolStripMenuItem.Click += new System.EventHandler(this.txtToolStripMenuItem_Click);
			// 
			// RefreshToolStripMenuItem
			// 
			this.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem";
			this.RefreshToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.RefreshToolStripMenuItem.Text = "更新法條內容";
			this.RefreshToolStripMenuItem.Click += new System.EventHandler(this.RefreshToolStripMenuItem_Click);
			// 
			// ExitToolStripMenuItem
			// 
			this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
			this.ExitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.ExitToolStripMenuItem.Text = "離開";
			this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
			// 
			// OptionToolStripMenuItem
			// 
			this.OptionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LikeToolStripMenuItem,
            this.UserDefinedToolStripMenuItem,
            this.BackgroundToolStripMenuItem,
            this.FontToolStripMenuItem,
            this.ColorToolStripMenuItem});
			this.OptionToolStripMenuItem.Name = "OptionToolStripMenuItem";
			this.OptionToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
			this.OptionToolStripMenuItem.Text = "設定";
			// 
			// LikeToolStripMenuItem
			// 
			this.LikeToolStripMenuItem.Name = "LikeToolStripMenuItem";
			this.LikeToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
			this.LikeToolStripMenuItem.Text = "我的最愛";
			this.LikeToolStripMenuItem.Click += new System.EventHandler(this.LikeToolStripMenuItem_Click);
			// 
			// UserDefinedToolStripMenuItem
			// 
			this.UserDefinedToolStripMenuItem.Name = "UserDefinedToolStripMenuItem";
			this.UserDefinedToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
			this.UserDefinedToolStripMenuItem.Text = "自定義法典";
			this.UserDefinedToolStripMenuItem.Click += new System.EventHandler(this.UserDefinedToolStripMenuItem_Click);
			// 
			// BackgroundToolStripMenuItem
			// 
			this.BackgroundToolStripMenuItem.Name = "BackgroundToolStripMenuItem";
			this.BackgroundToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
			this.BackgroundToolStripMenuItem.Text = "背景顏色";
			this.BackgroundToolStripMenuItem.Click += new System.EventHandler(this.BackgroundToolStripMenuItem_Click);
			// 
			// FontToolStripMenuItem
			// 
			this.FontToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.word8,
            this.word10,
            this.word12,
            this.word15,
            this.word20,
            this.word28,
            this.word36,
            this.word72,
            this.SetFontToolStripMenuItem});
			this.FontToolStripMenuItem.Name = "FontToolStripMenuItem";
			this.FontToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
			this.FontToolStripMenuItem.Text = "字體大小";
			// 
			// word8
			// 
			this.word8.Name = "word8";
			this.word8.Size = new System.Drawing.Size(98, 22);
			this.word8.Text = "8";
			this.word8.Click += new System.EventHandler(this.word8_Click);
			// 
			// word10
			// 
			this.word10.Name = "word10";
			this.word10.Size = new System.Drawing.Size(98, 22);
			this.word10.Text = "10";
			this.word10.Click += new System.EventHandler(this.word10_Click);
			// 
			// word12
			// 
			this.word12.Name = "word12";
			this.word12.Size = new System.Drawing.Size(98, 22);
			this.word12.Text = "12";
			this.word12.Click += new System.EventHandler(this.word12_Click);
			// 
			// word15
			// 
			this.word15.Name = "word15";
			this.word15.Size = new System.Drawing.Size(98, 22);
			this.word15.Text = "15";
			this.word15.Click += new System.EventHandler(this.word15_Click);
			// 
			// word20
			// 
			this.word20.Name = "word20";
			this.word20.Size = new System.Drawing.Size(98, 22);
			this.word20.Text = "20";
			this.word20.Click += new System.EventHandler(this.word20_Click);
			// 
			// word28
			// 
			this.word28.Name = "word28";
			this.word28.Size = new System.Drawing.Size(98, 22);
			this.word28.Text = "28";
			this.word28.Click += new System.EventHandler(this.word28_Click);
			// 
			// word36
			// 
			this.word36.Name = "word36";
			this.word36.Size = new System.Drawing.Size(98, 22);
			this.word36.Text = "36";
			this.word36.Click += new System.EventHandler(this.word36_Click);
			// 
			// word72
			// 
			this.word72.Name = "word72";
			this.word72.Size = new System.Drawing.Size(98, 22);
			this.word72.Text = "72";
			this.word72.Click += new System.EventHandler(this.word72_Click);
			// 
			// SetFontToolStripMenuItem
			// 
			this.SetFontToolStripMenuItem.Name = "SetFontToolStripMenuItem";
			this.SetFontToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
			this.SetFontToolStripMenuItem.Text = "自訂";
			this.SetFontToolStripMenuItem.Click += new System.EventHandler(this.SetFontToolStripMenuItem_Click);
			// 
			// ColorToolStripMenuItem
			// 
			this.ColorToolStripMenuItem.Name = "ColorToolStripMenuItem";
			this.ColorToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
			this.ColorToolStripMenuItem.Text = "字體顏色";
			this.ColorToolStripMenuItem.Click += new System.EventHandler(this.ColorToolStripMenuItem_Click);
			// 
			// HelpToolStripMenuItem
			// 
			this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
			this.HelpToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
			this.HelpToolStripMenuItem.Text = "說明";
			// 
			// printDialog1
			// 
			this.printDialog1.UseEXDialog = true;
			// 
			// printDocument1
			// 
			this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.buttonRefresh, 0, 0);
			this.tableLayoutPanel1.Controls.Add(label2, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.labelLastUpdate, 0, 2);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(420, 27);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(134, 75);
			this.tableLayoutPanel1.TabIndex = 13;
			// 
			// labelLastUpdate
			// 
			this.labelLastUpdate.Location = new System.Drawing.Point(3, 55);
			this.labelLastUpdate.Name = "labelLastUpdate";
			this.labelLastUpdate.Size = new System.Drawing.Size(128, 20);
			this.labelLastUpdate.TabIndex = 11;
			this.labelLastUpdate.Text = "label3";
			this.labelLastUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// change
			// 
			this.change.Location = new System.Drawing.Point(12, 85);
			this.change.Name = "change";
			this.change.Size = new System.Drawing.Size(23, 23);
			this.change.TabIndex = 15;
			this.change.Text = "c";
			this.change.UseVisualStyleBackColor = true;
			this.change.Click += new System.EventHandler(this.change_Click);
			// 
			// multisearch
			// 
			this.multisearch.Location = new System.Drawing.Point(41, 85);
			this.multisearch.Name = "multisearch";
			this.multisearch.Size = new System.Drawing.Size(75, 23);
			this.multisearch.TabIndex = 16;
			this.multisearch.Text = "多重搜尋";
			this.multisearch.UseVisualStyleBackColor = true;
			this.multisearch.Click += new System.EventHandler(this.multisearch_Click);
			// 
			// multichoice
			// 
			this.multichoice.Location = new System.Drawing.Point(81, 60);
			this.multichoice.Name = "multichoice";
			this.multichoice.Size = new System.Drawing.Size(79, 23);
			this.multichoice.TabIndex = 17;
			this.multichoice.Text = "多選";
			this.multichoice.UseVisualStyleBackColor = true;
			this.multichoice.Click += new System.EventHandler(this.multichoice_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(622, 409);
			this.Controls.Add(this.multichoice);
			this.Controls.Add(this.multisearch);
			this.Controls.Add(this.change);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.labelTotal);
			this.Controls.Add(this.checkBoxConsistent);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.comboBoxChoice);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.buttonSearch);
			this.Controls.Add(this.textSearch);
			this.Controls.Add(this.lbSearch);
			this.Name = "Form1";
			this.Text = "法條查詢系統";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbSearch;
		private System.Windows.Forms.TextBox textSearch;
		private System.Windows.Forms.Button buttonSearch;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem CopyToolStripMenuItem;
		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.Label label1;
		protected internal System.Windows.Forms.ComboBox comboBoxChoice;
		private System.Windows.Forms.Button buttonRefresh;
		private System.Windows.Forms.CheckBox checkBoxConsistent;
		private System.Windows.Forms.Label labelTotal;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem PrintToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem OutputToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pdfToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem txtToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem RefreshToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem OptionToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem LikeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem UserDefinedToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem BackgroundToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem FontToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem word8;
		private System.Windows.Forms.ToolStripMenuItem word10;
		private System.Windows.Forms.ToolStripMenuItem word12;
		private System.Windows.Forms.ToolStripMenuItem word15;
		private System.Windows.Forms.ToolStripMenuItem word20;
		private System.Windows.Forms.ToolStripMenuItem word28;
		private System.Windows.Forms.ToolStripMenuItem word36;
		private System.Windows.Forms.ToolStripMenuItem word72;
		private System.Windows.Forms.ToolStripMenuItem SetFontToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ColorToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem SetToolStripMenuItem1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Head;
		private System.Windows.Forms.DataGridViewTextBoxColumn Num;
		private System.Windows.Forms.DataGridViewTextBoxColumn Content;
		private System.Windows.Forms.ColorDialog colorDialog1;
		private System.Windows.Forms.PrintDialog printDialog1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Drawing.Printing.PrintDocument printDocument1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label labelLastUpdate;
		private System.Windows.Forms.Button change;
		private System.Windows.Forms.Button multisearch;
		private System.Windows.Forms.Button multichoice;
	}
}

