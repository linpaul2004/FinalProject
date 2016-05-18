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
	public partial class UserDefDic : Form
	{
		private string name = "";
		public string[] con;
		public UserDefDic()
		{
			InitializeComponent();
		}

		private void check_Click(object sender, EventArgs e)
		{
			name = Dic.Text;
		}

		private void UserDefDic_Load(object sender, EventArgs e)
		{
			buttonOK.DialogResult = DialogResult.OK;
			for (int i = 0; i < con.Length; i++)
			{
				checkedListBox1.Items.Add(con[i]);
			}
		}
	}
}
