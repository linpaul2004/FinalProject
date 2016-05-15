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
			this.檔案ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.列印ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.輸出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pdfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.txtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.刷新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.離開ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.LikeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.自訂法典ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.字彙表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.背景ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.字體ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
			this.自訂ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.顏色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.說明ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
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
			this.buttonSearch.Location = new System.Drawing.Point(12, 85);
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
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
			this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Head,
            this.Num,
            this.Content});
			this.dataGridView1.Location = new System.Drawing.Point(12, 114);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(564, 282);
			this.dataGridView1.TabIndex = 4;
			this.dataGridView1.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDown);
			// 
			// Head
			// 
			this.Head.HeaderText = "法律名稱";
			this.Head.Name = "Head";
			this.Head.ReadOnly = true;
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
			this.Content.Width = 54;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CopyToolStripMenuItem,
            this.SetToolStripMenuItem1});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(167, 48);
			// 
			// CopyToolStripMenuItem
			// 
			this.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem";
			this.CopyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
			this.CopyToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
			this.CopyToolStripMenuItem.Text = "複製(C)";
			this.CopyToolStripMenuItem.Click += new System.EventHandler(this.CopyToolStripMenuItem_Click);
			// 
			// SetToolStripMenuItem1
			// 
			this.SetToolStripMenuItem1.Name = "SetToolStripMenuItem1";
			this.SetToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
			this.SetToolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
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
			this.buttonAdd.Location = new System.Drawing.Point(93, 85);
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
			this.buttonRefresh.Location = new System.Drawing.Point(174, 85);
			this.buttonRefresh.Name = "buttonRefresh";
			this.buttonRefresh.Size = new System.Drawing.Size(75, 23);
			this.buttonRefresh.TabIndex = 9;
			this.buttonRefresh.Text = "刷新";
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
			this.labelTotal.Location = new System.Drawing.Point(255, 90);
			this.labelTotal.Name = "labelTotal";
			this.labelTotal.Size = new System.Drawing.Size(86, 12);
			this.labelTotal.TabIndex = 11;
			this.labelTotal.Text = "搜尋結果：0 項";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.檔案ToolStripMenuItem,
            this.設定ToolStripMenuItem,
            this.說明ToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(596, 24);
			this.menuStrip1.TabIndex = 12;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// 檔案ToolStripMenuItem
			// 
			this.檔案ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.列印ToolStripMenuItem,
            this.輸出ToolStripMenuItem,
            this.刷新ToolStripMenuItem,
            this.離開ToolStripMenuItem});
			this.檔案ToolStripMenuItem.Name = "檔案ToolStripMenuItem";
			this.檔案ToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.檔案ToolStripMenuItem.Text = "檔案";
			// 
			// 列印ToolStripMenuItem
			// 
			this.列印ToolStripMenuItem.Name = "列印ToolStripMenuItem";
			this.列印ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.列印ToolStripMenuItem.Text = "列印";
			// 
			// 輸出ToolStripMenuItem
			// 
			this.輸出ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pdfToolStripMenuItem,
            this.txtToolStripMenuItem});
			this.輸出ToolStripMenuItem.Name = "輸出ToolStripMenuItem";
			this.輸出ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.輸出ToolStripMenuItem.Text = "輸出";
			// 
			// pdfToolStripMenuItem
			// 
			this.pdfToolStripMenuItem.Name = "pdfToolStripMenuItem";
			this.pdfToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
			this.pdfToolStripMenuItem.Text = "pdf";
			// 
			// txtToolStripMenuItem
			// 
			this.txtToolStripMenuItem.Name = "txtToolStripMenuItem";
			this.txtToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
			this.txtToolStripMenuItem.Text = "txt";
			// 
			// 刷新ToolStripMenuItem
			// 
			this.刷新ToolStripMenuItem.Name = "刷新ToolStripMenuItem";
			this.刷新ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.刷新ToolStripMenuItem.Text = "刷新";
			// 
			// 離開ToolStripMenuItem
			// 
			this.離開ToolStripMenuItem.Name = "離開ToolStripMenuItem";
			this.離開ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.離開ToolStripMenuItem.Text = "離開";
			// 
			// 設定ToolStripMenuItem
			// 
			this.設定ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LikeToolStripMenuItem,
            this.自訂法典ToolStripMenuItem,
            this.字彙表ToolStripMenuItem,
            this.背景ToolStripMenuItem,
            this.字體ToolStripMenuItem,
            this.顏色ToolStripMenuItem});
			this.設定ToolStripMenuItem.Name = "設定ToolStripMenuItem";
			this.設定ToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.設定ToolStripMenuItem.Text = "設定";
			// 
			// LikeToolStripMenuItem
			// 
			this.LikeToolStripMenuItem.Name = "LikeToolStripMenuItem";
			this.LikeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.LikeToolStripMenuItem.Text = "我的最愛";
			this.LikeToolStripMenuItem.Click += new System.EventHandler(this.LikeToolStripMenuItem_Click);
			// 
			// 自訂法典ToolStripMenuItem
			// 
			this.自訂法典ToolStripMenuItem.Name = "自訂法典ToolStripMenuItem";
			this.自訂法典ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.自訂法典ToolStripMenuItem.Text = "自定義法典";
			// 
			// 字彙表ToolStripMenuItem
			// 
			this.字彙表ToolStripMenuItem.Name = "字彙表ToolStripMenuItem";
			this.字彙表ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.字彙表ToolStripMenuItem.Text = "字彙表";
			// 
			// 背景ToolStripMenuItem
			// 
			this.背景ToolStripMenuItem.Name = "背景ToolStripMenuItem";
			this.背景ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.背景ToolStripMenuItem.Text = "背景";
			// 
			// 字體ToolStripMenuItem
			// 
			this.字體ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7,
            this.toolStripMenuItem8,
            this.toolStripMenuItem9,
            this.自訂ToolStripMenuItem});
			this.字體ToolStripMenuItem.Name = "字體ToolStripMenuItem";
			this.字體ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.字體ToolStripMenuItem.Text = "字體";
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(100, 22);
			this.toolStripMenuItem2.Text = "8";
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(100, 22);
			this.toolStripMenuItem3.Text = "10";
			// 
			// toolStripMenuItem4
			// 
			this.toolStripMenuItem4.Name = "toolStripMenuItem4";
			this.toolStripMenuItem4.Size = new System.Drawing.Size(100, 22);
			this.toolStripMenuItem4.Text = "12";
			// 
			// toolStripMenuItem5
			// 
			this.toolStripMenuItem5.Name = "toolStripMenuItem5";
			this.toolStripMenuItem5.Size = new System.Drawing.Size(100, 22);
			this.toolStripMenuItem5.Text = "15";
			// 
			// toolStripMenuItem6
			// 
			this.toolStripMenuItem6.Name = "toolStripMenuItem6";
			this.toolStripMenuItem6.Size = new System.Drawing.Size(100, 22);
			this.toolStripMenuItem6.Text = "20";
			// 
			// toolStripMenuItem7
			// 
			this.toolStripMenuItem7.Name = "toolStripMenuItem7";
			this.toolStripMenuItem7.Size = new System.Drawing.Size(100, 22);
			this.toolStripMenuItem7.Text = "28";
			// 
			// toolStripMenuItem8
			// 
			this.toolStripMenuItem8.Name = "toolStripMenuItem8";
			this.toolStripMenuItem8.Size = new System.Drawing.Size(100, 22);
			this.toolStripMenuItem8.Text = "36";
			// 
			// toolStripMenuItem9
			// 
			this.toolStripMenuItem9.Name = "toolStripMenuItem9";
			this.toolStripMenuItem9.Size = new System.Drawing.Size(100, 22);
			this.toolStripMenuItem9.Text = "72";
			// 
			// 自訂ToolStripMenuItem
			// 
			this.自訂ToolStripMenuItem.Name = "自訂ToolStripMenuItem";
			this.自訂ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
			this.自訂ToolStripMenuItem.Text = "自訂";
			// 
			// 顏色ToolStripMenuItem
			// 
			this.顏色ToolStripMenuItem.Name = "顏色ToolStripMenuItem";
			this.顏色ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.顏色ToolStripMenuItem.Text = "顏色";
			// 
			// 說明ToolStripMenuItem
			// 
			this.說明ToolStripMenuItem.Name = "說明ToolStripMenuItem";
			this.說明ToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.說明ToolStripMenuItem.Text = "說明";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(596, 409);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.labelTotal);
			this.Controls.Add(this.checkBoxConsistent);
			this.Controls.Add(this.buttonRefresh);
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
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbSearch;
		private System.Windows.Forms.TextBox textSearch;
		private System.Windows.Forms.Button buttonSearch;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Head;
		private System.Windows.Forms.DataGridViewTextBoxColumn Num;
		private System.Windows.Forms.DataGridViewTextBoxColumn Content;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem CopyToolStripMenuItem;
		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.Label label1;
		protected internal System.Windows.Forms.ComboBox comboBoxChoice;
		private System.Windows.Forms.Button buttonRefresh;
		private System.Windows.Forms.CheckBox checkBoxConsistent;
		private System.Windows.Forms.Label labelTotal;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem 檔案ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 列印ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 輸出ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pdfToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem txtToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 刷新ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 離開ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 設定ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem LikeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 自訂法典ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 字彙表ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 背景ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 字體ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
		private System.Windows.Forms.ToolStripMenuItem 自訂ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 顏色ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 說明ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem SetToolStripMenuItem1;
	}
}

