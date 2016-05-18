namespace FinalProject
{
	partial class FormLike
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Head = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Content = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.DelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.buttonOK = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.DelAll = new System.Windows.Forms.Button();
			this.delete = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
			this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Head,
            this.Num,
            this.Content});
			this.dataGridView1.Location = new System.Drawing.Point(12, 34);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(499, 262);
			this.dataGridView1.TabIndex = 0;
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
            this.DelToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(101, 26);
			// 
			// DelToolStripMenuItem
			// 
			this.DelToolStripMenuItem.Name = "DelToolStripMenuItem";
			this.DelToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
			this.DelToolStripMenuItem.Text = "刪除";
			this.DelToolStripMenuItem.Click += new System.EventHandler(this.DelToolStripMenuItem_Click);
			// 
			// buttonOK
			// 
			this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonOK.Location = new System.Drawing.Point(264, 302);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(75, 23);
			this.buttonOK.TabIndex = 2;
			this.buttonOK.Text = "返回";
			this.buttonOK.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(33, 12);
			this.label1.TabIndex = 3;
			this.label1.Text = "label1";
			// 
			// DelAll
			// 
			this.DelAll.Location = new System.Drawing.Point(524, 34);
			this.DelAll.Name = "DelAll";
			this.DelAll.Size = new System.Drawing.Size(75, 23);
			this.DelAll.TabIndex = 4;
			this.DelAll.Text = "全部刪除";
			this.DelAll.UseVisualStyleBackColor = true;
			this.DelAll.Click += new System.EventHandler(this.DelAll_Click);
			// 
			// delete
			// 
			this.delete.Location = new System.Drawing.Point(524, 64);
			this.delete.Name = "delete";
			this.delete.Size = new System.Drawing.Size(75, 23);
			this.delete.TabIndex = 5;
			this.delete.Text = "刪除";
			this.delete.UseVisualStyleBackColor = true;
			this.delete.Click += new System.EventHandler(this.delete_Click);
			// 
			// FormLike
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(611, 337);
			this.Controls.Add(this.delete);
			this.Controls.Add(this.DelAll);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.dataGridView1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormLike";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "我的最愛";
			this.Load += new System.EventHandler(this.FormLike_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ToolStripMenuItem DelToolStripMenuItem;
		private System.Windows.Forms.Button DelAll;
		protected internal System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Head;
		private System.Windows.Forms.DataGridViewTextBoxColumn Num;
		private System.Windows.Forms.DataGridViewTextBoxColumn Content;
		private System.Windows.Forms.Button delete;
	}
}