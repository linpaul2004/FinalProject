using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
	public partial class WordFont : Form
	{
		public double font;
		public WordFont()
		{
			InitializeComponent();
		}

		private void WordFont_Load(object sender, EventArgs e)
		{
			font = 0;
			textBox1.Clear();
			button1.DialogResult = DialogResult.OK;
			button2.DialogResult = DialogResult.OK;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (textBox1.Text == "0")
			{
				MessageBox.Show("Error", "文字大小設定不正確", MessageBoxButtons.RetryCancel);
			}
			else
			{
				font = Convert.ToDouble(textBox1.Text);
			}
		}
	}
}
