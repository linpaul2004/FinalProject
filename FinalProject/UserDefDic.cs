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
		private string[] check2 = new string[0];
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

			StreamWriter write = new StreamWriter("../../MixedLaw.txt", true);
			write.WriteLine(name);
			write.Close();
			comboBox1.Items.Add(name);
		}

		private void UserDefDic_Load(object sender, EventArgs e)
		{
			Dic.Visible = false;
			dicname.Visible = false;
			checkedListBox1.Items.Clear();
			checkedListBox2.Items.Clear();
			comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
			
			check.Visible = false;
			buttonOK.DialogResult = DialogResult.OK;
			FileInfo file = new FileInfo("../../MixedLaw.txt");
			if (file.Exists == false)
			{
				file.Create();
			}
			StreamReader sw = new StreamReader("../../MixedLaw.txt");
			string tmp = sw.ReadLine();
			while (true)
			{
				if (tmp == null)
				{
					break;
				}

				Array.Resize(ref check2,check2.Length + 1);
				check2[check2.Length-1] = tmp;
				comboBox1.Items.Add(tmp);
				tmp = sw.ReadLine();
			}
			if (comboBox1.Items.Count > 0)
			{
				comboBox1.SelectedIndex = 0;
			}
		}

		private void addition_Click(object sender, EventArgs e)
		{
			check.Visible = true;
			addition.Visible = false;
			comboBox1.Visible = false;
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			string na = comboBox1.SelectedItem.ToString();
			List<string> contain = new List<string>(0);
			StreamReader read = new StreamReader("../../" + comboBox1.SelectedItem.ToString() + ".txt");
			string now = read.ReadLine();
			while (true)
			{
				if (now == null)
				{
					break;
				}

				checkedListBox1.Items.Add(now);
			}

			Form1 form = (Form1)this.Owner;
			for (int i = 0; i < form.address[0].Count; i++)
			{
				for (int j = 0; j < check2.Length; j++)
				{
					if (form.address[0][i] == check2[j])
					{
						break;
					}
					else
					{
						contain.Add(form.address[0][1]);
					}
				}

				for(int j = 0;j<checkedListBox1.Items.Count;i++)
				{
					if(form.address[0][i] == checkedListBox1.Items[j].ToString())
					{
						contain.Remove(form.address[0][1]);
					}
				}
			}
		}
	}
}
