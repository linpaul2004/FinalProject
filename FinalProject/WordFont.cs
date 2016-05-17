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
		public WordFont()
		{
			InitializeComponent();
		}

		private void WordFont_Load(object sender, EventArgs e)
		{
			button1.DialogResult = DialogResult.OK;
			button2.DialogResult = DialogResult.Cancel;
		}
	}
}
