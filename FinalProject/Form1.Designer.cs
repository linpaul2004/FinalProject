﻿namespace FinalProject
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
			this.button1 = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Head = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Content = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.CopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lbSearch
			// 
			this.lbSearch.AutoSize = true;
			this.lbSearch.Location = new System.Drawing.Point(12, 13);
			this.lbSearch.Name = "lbSearch";
			this.lbSearch.Size = new System.Drawing.Size(65, 12);
			this.lbSearch.TabIndex = 0;
			this.lbSearch.Text = "搜尋字串：";
			// 
			// textSearch
			// 
			this.textSearch.Location = new System.Drawing.Point(84, 10);
			this.textSearch.Name = "textSearch";
			this.textSearch.Size = new System.Drawing.Size(255, 22);
			this.textSearch.TabIndex = 1;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(346, 9);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 3;
			this.button1.Text = "搜尋";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
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
			this.dataGridView1.Location = new System.Drawing.Point(14, 40);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(497, 282);
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
            this.CopyToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(99, 26);
			// 
			// CopyToolStripMenuItem
			// 
			this.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem";
			this.CopyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.CopyToolStripMenuItem.Text = "複製";
			this.CopyToolStripMenuItem.Click += new System.EventHandler(this.CopyToolStripMenuItem_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(551, 334);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textSearch);
			this.Controls.Add(this.lbSearch);
			this.Name = "Form1";
			this.Text = "法條查詢系統";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbSearch;
		private System.Windows.Forms.TextBox textSearch;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Head;
		private System.Windows.Forms.DataGridViewTextBoxColumn Num;
		private System.Windows.Forms.DataGridViewTextBoxColumn Content;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem CopyToolStripMenuItem;
	}
}
