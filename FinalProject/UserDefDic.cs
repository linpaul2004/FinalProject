using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
			for (int i = 0; i < checkedListBox1.Items.Count; i++)
			{
				if (name == checkedListBox1.Items[i].ToString())
				{
					MessageBox.Show("Error", "這個名字已經被使用", MessageBoxButtons.OK);
					return;
				}
			}
			Form1 form = (Form1)this.Owner;
			int num = form.address[0].Count;
			FileInfo file = new FileInfo("../../" + name + ".txt");
			if (file.Exists == false)
			{
				FileStream fs = file.Create();
				fs.Close();
			}

			StreamWriter fout = new StreamWriter("../../" + name + ".txt");
			fout.WriteLine("Mixed");
			for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
			{
				fout.WriteLine(checkedListBox1.CheckedItems[i].ToString());
			}

			fout.Flush();
			fout.Close();

			checkedListBox1.Items.Add(name);
			form.address[0].Add(name);
			form.address[1].Add("");
			form.comboBoxChoice.Items.Add(name);
			form.DataStore();
		}

		private void UserDefDic_Load(object sender, EventArgs e)
		{
			checkedListBox1.Items.Clear();
			buttonOK.DialogResult = DialogResult.OK;
			for (int i = 0; i < con.Length; i++)
			{
				checkedListBox1.Items.Add(con[i]);
			}
		}
	}
}
