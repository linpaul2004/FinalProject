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
			Form1 form = (Form1)this.Owner;
			name = Dic.Text;
			if (name == "")
			{
				MessageBox.Show("名稱不能空白", "Error", MessageBoxButtons.OK);
				return;
			}
			if (checkedListBox1.Items.Count == 0)
			{
				MessageBox.Show("你正在新增一個空的自定義法典，\n這是不被允許的，\n請再試一次。", "Warning", MessageBoxButtons.OK);
				return;
			}
			for (int i = 0; i < form.address[0].Count; i++)
			{
				if (name == form.address[0][i])
				{
					MessageBox.Show("這個名字已經被使用", "Error", MessageBoxButtons.OK);
					return;
				}
			}
			int num = form.address[0].Count;
			FileInfo file = new FileInfo("../../" + name + ".txt");
			if (file.Exists == false)
			{
				FileStream fs = file.Create();
				fs.Close();
			}

			StreamWriter fout = new StreamWriter("../../" + name + ".txt");
			fout.WriteLine("Mixed");
			for (int i = 0; i < checkedListBox1.Items.Count; i++)
			{
				fout.WriteLine(checkedListBox1.Items[i].ToString());
			}

			fout.Flush();
			fout.Close();

			comboBox1.Items.Add(name);
			form.address[0].Add(name);
			form.address[1].Add("");
			form.comboBoxChoice.Items.Add(name);
			form.DataStore();

			StreamWriter write = new StreamWriter("../../MixedLaw.txt", true);
			write.WriteLine(name);
			write.Flush();
			write.Close();
			checkedListBox1.Items.Clear();
			checkedListBox2.Items.Clear();

			addition.Visible = true;
			check.Enabled = false;
			back.Enabled = false;
			fix.Enabled = true;

			dicname.Visible = false;
			Dic.Visible = false;
			comboBox1.Visible = true;
			exist.Visible = true;
		}

		private void UserDefDic_Load(object sender, EventArgs e)
		{
			Dic.Visible = false;
			Dic.Clear();
			dicname.Visible = false;
			comboBox1.Visible = true;
			exist.Visible = true;

			fix.Enabled = true;
			addition.Visible = true;
			check.Enabled = false;
			back.Enabled = false;

			checkedListBox1.Items.Clear();
			checkedListBox2.Items.Clear();
			comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
			comboBox1.Items.Clear();
			
			check.Visible = false;
			buttonOK.DialogResult = DialogResult.OK;
			FileInfo file = new FileInfo("../../MixedLaw.txt");
			if (file.Exists == false)
			{
				FileStream fs = file.Create();
				fs.Close();
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
			sw.Close();
		}

		private void addition_Click(object sender, EventArgs e)
		{
			check.Visible = true;
			addition.Visible = false;
			fix.Enabled = false;
			check.Enabled = true;
			back.Enabled = true;

			comboBox1.Visible = false;
			dicname.Visible = true;
			Dic.Visible = true;
			Dic.Clear();
			exist.Visible = false;

			checkedListBox1.Items.Clear();
			checkedListBox2.Items.Clear();
			for (int i = 0; i < con.Length; i++)
			{
				checkedListBox2.Items.Add(con[i]);
				for (int j = 0; j < check2.Length; j++)
				{
					if (con[i] == check2[j])
					{
						checkedListBox2.Items.Remove(con[i]);
						break;
					}
				}
			}
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (comboBox1.SelectedIndex == -1)
			{
				comboBox1.SelectedIndex = 0;
			}
			checkedListBox1.Items.Clear();
			checkedListBox2.Items.Clear();
			List<string> contain = new List<string>(0);
			StreamReader read = new StreamReader("../../" + comboBox1.SelectedItem.ToString() + ".txt");
			string now = read.ReadLine();
			while (true)
			{
				now = read.ReadLine();
				if (now == null)
				{
					break;
				}

				checkedListBox1.Items.Add(now);
			}
			read.Close();
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
						if (j == check2.Length - 1)
						{
							contain.Add(form.address[0][i]);
						}
					}
				}

				for(int j = 0;j<checkedListBox1.Items.Count;j++)
				{
					if(form.address[0][i] == checkedListBox1.Items[j].ToString())
					{
						contain.Remove(form.address[0][i]);
					}
				}
			}

			for (int i = 0; i < contain.Count; i++)
			{
				checkedListBox2.Items.Add(contain[i]);
			}
		}

		private void add_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < checkedListBox2.CheckedItems.Count; i++)
			{
				checkedListBox1.Items.Add(checkedListBox2.CheckedItems[i]);
			}

			string[] del = new string[checkedListBox2.CheckedItems.Count];
			checkedListBox2.CheckedItems.CopyTo(del, 0);
			for (int i = 0; i < del.Length; i++)
			{
				checkedListBox2.Items.Remove(del[i]);
			}
		}

		private void del_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
			{
				checkedListBox2.Items.Add(checkedListBox1.CheckedItems[i]);
			}

			string[] del = new string[checkedListBox1.CheckedItems.Count];
			checkedListBox1.CheckedItems.CopyTo(del, 0);
			for (int i = 0; i < del.Length; i++)
			{
				checkedListBox1.Items.Remove(del[i]);
			}
		}

		private void fix_Click(object sender, EventArgs e)
		{
			if (comboBox1.SelectedItem == null)
			{
				return;
			}
			if (checkedListBox1.Items.Count == 0)
			{
				MessageBox.Show("你正在一個自定義法典清空，\n這是不被允許的。\n建議:使用法典管理刪除它。", "Warning", MessageBoxButtons.OK);
			}
			StreamWriter write = new StreamWriter("../../" + comboBox1.SelectedItem.ToString() + ".txt");
			write.WriteLine("Mixed");
			for (int i = 0; i < checkedListBox1.Items.Count; i++)
			{
				write.WriteLine(checkedListBox1.Items[i]);
			}

			write.Flush();
			write.Close();
			MessageBox.Show("修改完成", "Finish", MessageBoxButtons.OK);
		}

		private void back_Click(object sender, EventArgs e)
		{
			addition.Visible = true;
			check.Enabled = false;
			back.Enabled = false;
			fix.Enabled = true;

			dicname.Visible = false;
			Dic.Visible = false;
			comboBox1.Visible = true;
			exist.Visible = true;

			checkedListBox1.Items.Clear();
			checkedListBox2.Items.Clear();
			comboBox1.SelectedIndex = -1;
		}
	}
}
