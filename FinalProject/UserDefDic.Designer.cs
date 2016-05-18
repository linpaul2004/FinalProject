namespace FinalProject
{
	partial class UserDefDic
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
			this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
			this.dicname = new System.Windows.Forms.Label();
			this.Dic = new System.Windows.Forms.TextBox();
			this.check = new System.Windows.Forms.Button();
			this.buttonOK = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// checkedListBox1
			// 
			this.checkedListBox1.FormattingEnabled = true;
			this.checkedListBox1.Location = new System.Drawing.Point(286, 10);
			this.checkedListBox1.Name = "checkedListBox1";
			this.checkedListBox1.Size = new System.Drawing.Size(176, 174);
			this.checkedListBox1.TabIndex = 0;
			// 
			// dicname
			// 
			this.dicname.AutoSize = true;
			this.dicname.Location = new System.Drawing.Point(41, 13);
			this.dicname.Name = "dicname";
			this.dicname.Size = new System.Drawing.Size(29, 12);
			this.dicname.TabIndex = 1;
			this.dicname.Text = "名稱";
			// 
			// Dic
			// 
			this.Dic.Location = new System.Drawing.Point(88, 10);
			this.Dic.Name = "Dic";
			this.Dic.Size = new System.Drawing.Size(153, 22);
			this.Dic.TabIndex = 2;
			// 
			// check
			// 
			this.check.Location = new System.Drawing.Point(88, 161);
			this.check.Name = "check";
			this.check.Size = new System.Drawing.Size(75, 23);
			this.check.TabIndex = 3;
			this.check.Text = "確定";
			this.check.UseVisualStyleBackColor = true;
			this.check.Click += new System.EventHandler(this.check_Click);
			// 
			// buttonOK
			// 
			this.buttonOK.Location = new System.Drawing.Point(210, 206);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(75, 23);
			this.buttonOK.TabIndex = 4;
			this.buttonOK.Text = "返回";
			this.buttonOK.UseVisualStyleBackColor = true;
			// 
			// UserDefDic
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(474, 237);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.check);
			this.Controls.Add(this.Dic);
			this.Controls.Add(this.dicname);
			this.Controls.Add(this.checkedListBox1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "UserDefDic";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "自定義法典";
			this.Load += new System.EventHandler(this.UserDefDic_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckedListBox checkedListBox1;
		private System.Windows.Forms.Label dicname;
		private System.Windows.Forms.TextBox Dic;
		private System.Windows.Forms.Button check;
		private System.Windows.Forms.Button buttonOK;
	}
}