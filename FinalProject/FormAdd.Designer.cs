namespace FinalProject
{
	partial class FormAdd
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
			this.label1 = new System.Windows.Forms.Label();
			this.textAddress = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textName = new System.Windows.Forms.TextBox();
			this.buttonOK = new System.Windows.Forms.Button();
			this.buttonAuto = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 44);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(173, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "法律網址（全國法律資料庫）：";
			// 
			// textAddress
			// 
			this.textAddress.Location = new System.Drawing.Point(14, 60);
			this.textAddress.Name = "textAddress";
			this.textAddress.Size = new System.Drawing.Size(279, 22);
			this.textAddress.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(14, 110);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(65, 12);
			this.label2.TabIndex = 2;
			this.label2.Text = "法律名稱：";
			// 
			// textName
			// 
			this.textName.Location = new System.Drawing.Point(14, 125);
			this.textName.Name = "textName";
			this.textName.Size = new System.Drawing.Size(279, 22);
			this.textName.TabIndex = 3;
			// 
			// buttonOK
			// 
			this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOK.Location = new System.Drawing.Point(110, 183);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(75, 23);
			this.buttonOK.TabIndex = 4;
			this.buttonOK.Text = "OK";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
			// 
			// buttonAuto
			// 
			this.buttonAuto.Location = new System.Drawing.Point(14, 154);
			this.buttonAuto.Name = "buttonAuto";
			this.buttonAuto.Size = new System.Drawing.Size(108, 23);
			this.buttonAuto.TabIndex = 5;
			this.buttonAuto.Text = "自動取得名稱";
			this.buttonAuto.UseVisualStyleBackColor = true;
			this.buttonAuto.Click += new System.EventHandler(this.buttonAuto_Click);
			// 
			// FormAdd
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(350, 219);
			this.Controls.Add(this.buttonAuto);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.textName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textAddress);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormAdd";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "新增法律";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.Button buttonAuto;
		public System.Windows.Forms.TextBox textAddress;
		public System.Windows.Forms.TextBox textName;
	}
}