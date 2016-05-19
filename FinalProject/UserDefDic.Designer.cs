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
			this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
			this.add = new System.Windows.Forms.Button();
			this.del = new System.Windows.Forms.Button();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.fix = new System.Windows.Forms.Button();
			this.addition = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.back = new System.Windows.Forms.Button();
			this.exist = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// checkedListBox1
			// 
			this.checkedListBox1.FormattingEnabled = true;
			this.checkedListBox1.Location = new System.Drawing.Point(21, 92);
			this.checkedListBox1.Name = "checkedListBox1";
			this.checkedListBox1.Size = new System.Drawing.Size(176, 174);
			this.checkedListBox1.TabIndex = 0;
			// 
			// dicname
			// 
			this.dicname.AutoSize = true;
			this.dicname.Location = new System.Drawing.Point(19, 20);
			this.dicname.Name = "dicname";
			this.dicname.Size = new System.Drawing.Size(29, 12);
			this.dicname.TabIndex = 1;
			this.dicname.Text = "名稱";
			// 
			// Dic
			// 
			this.Dic.Location = new System.Drawing.Point(65, 17);
			this.Dic.Name = "Dic";
			this.Dic.Size = new System.Drawing.Size(153, 22);
			this.Dic.TabIndex = 2;
			// 
			// check
			// 
			this.check.Location = new System.Drawing.Point(21, 272);
			this.check.Name = "check";
			this.check.Size = new System.Drawing.Size(75, 23);
			this.check.TabIndex = 3;
			this.check.Text = "確定";
			this.check.UseVisualStyleBackColor = true;
			this.check.Click += new System.EventHandler(this.check_Click);
			// 
			// buttonOK
			// 
			this.buttonOK.Location = new System.Drawing.Point(342, 272);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(75, 23);
			this.buttonOK.TabIndex = 4;
			this.buttonOK.Text = "返回";
			this.buttonOK.UseVisualStyleBackColor = true;
			// 
			// checkedListBox2
			// 
			this.checkedListBox2.FormattingEnabled = true;
			this.checkedListBox2.Location = new System.Drawing.Point(241, 92);
			this.checkedListBox2.Name = "checkedListBox2";
			this.checkedListBox2.Size = new System.Drawing.Size(176, 174);
			this.checkedListBox2.TabIndex = 5;
			// 
			// add
			// 
			this.add.Location = new System.Drawing.Point(203, 150);
			this.add.Name = "add";
			this.add.Size = new System.Drawing.Size(32, 23);
			this.add.TabIndex = 6;
			this.add.Text = "<<";
			this.add.UseVisualStyleBackColor = true;
			this.add.Click += new System.EventHandler(this.add_Click);
			// 
			// del
			// 
			this.del.Location = new System.Drawing.Point(203, 179);
			this.del.Name = "del";
			this.del.Size = new System.Drawing.Size(32, 23);
			this.del.TabIndex = 7;
			this.del.Text = ">>";
			this.del.UseVisualStyleBackColor = true;
			this.del.Click += new System.EventHandler(this.del_Click);
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(97, 17);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 20);
			this.comboBox1.TabIndex = 8;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// fix
			// 
			this.fix.Location = new System.Drawing.Point(241, 273);
			this.fix.Name = "fix";
			this.fix.Size = new System.Drawing.Size(75, 23);
			this.fix.TabIndex = 9;
			this.fix.Text = "修改";
			this.fix.UseVisualStyleBackColor = true;
			this.fix.Click += new System.EventHandler(this.fix_Click);
			// 
			// addition
			// 
			this.addition.Location = new System.Drawing.Point(21, 273);
			this.addition.Name = "addition";
			this.addition.Size = new System.Drawing.Size(75, 23);
			this.addition.TabIndex = 10;
			this.addition.Text = "新增";
			this.addition.UseVisualStyleBackColor = true;
			this.addition.Click += new System.EventHandler(this.addition_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(17, 77);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 12);
			this.label1.TabIndex = 11;
			this.label1.Text = "目前項目";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(239, 77);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 12);
			this.label2.TabIndex = 12;
			this.label2.Text = "所有項目";
			// 
			// back
			// 
			this.back.Location = new System.Drawing.Point(122, 273);
			this.back.Name = "back";
			this.back.Size = new System.Drawing.Size(75, 23);
			this.back.TabIndex = 13;
			this.back.Text = "取消";
			this.back.UseVisualStyleBackColor = true;
			this.back.Click += new System.EventHandler(this.back_Click);
			// 
			// exist
			// 
			this.exist.AutoSize = true;
			this.exist.Location = new System.Drawing.Point(19, 20);
			this.exist.Name = "exist";
			this.exist.Size = new System.Drawing.Size(65, 12);
			this.exist.TabIndex = 14;
			this.exist.Text = "自定義法典";
			// 
			// UserDefDic
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(435, 308);
			this.Controls.Add(this.exist);
			this.Controls.Add(this.back);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.addition);
			this.Controls.Add(this.fix);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.del);
			this.Controls.Add(this.add);
			this.Controls.Add(this.checkedListBox2);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.check);
			this.Controls.Add(this.Dic);
			this.Controls.Add(this.dicname);
			this.Controls.Add(this.checkedListBox1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "UserDefDic";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "自定義法典 :";
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
		private System.Windows.Forms.CheckedListBox checkedListBox2;
		private System.Windows.Forms.Button add;
		private System.Windows.Forms.Button del;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Button fix;
		private System.Windows.Forms.Button addition;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button back;
		private System.Windows.Forms.Label exist;
	}
}