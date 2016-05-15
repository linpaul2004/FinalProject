using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
	public partial class Form1 : Form
	{
		private int selectRow, selectCol;
		private FormAdd formAdd = new FormAdd();
		private FormLike formLike = new FormLike();
		private string filepath = "../../LAddStore.txt";
		private string pattern = "<a\\s(id=\"rtAlllaw_ctl\\d\\d_HYNo\"\\s)?href=\"LawSingle\\.aspx\\?Pcode=[A-Z][0-9]{7}&a?m?p?;?FLNO=(\\d+-?\\d*)[\\s]*\">[\\s\\S]+?<pre>([\\s\\S]+?)<\\/pre><\\/td>";
		protected internal List<String>[] address=new List<String>[2];

		protected internal void DataStore()
		{
			StreamWriter LAddStore = new StreamWriter(filepath);
			for (int i = 0; i < comboBoxChoice.Items.Count; i++)
			{
				LAddStore.WriteLine(address[0][i]);
				LAddStore.WriteLine(address[1][i]);
			}
			LAddStore.Flush();
			LAddStore.Close();
			this.ReadAddress();
		}

		private void DataRead()
		{
			FileInfo file = new FileInfo(filepath);
			if (file.Exists == false)
			{
				FileStream fs = file.Create();
				fs.Close();
			}
			StreamReader LAddRead = new StreamReader(filepath);
			while (true)
			{
				string tmp = LAddRead.ReadLine();
				if (tmp == null)
				{
					break;
				}
				address[0].Add(tmp);
				tmp = LAddRead.ReadLine();
				address[1].Add(tmp);
			}
			LAddRead.Close();
		}

		public Form1()
		{
			InitializeComponent();
			for (int i = 0; i < 2; i++)
			{
				address[i] = new List<string>();
			}
			DataRead();
			comboBoxChoice.DropDownStyle = ComboBoxStyle.DropDownList;
			for (int i = 0; i < address[0].Count; i++)
			{
				comboBoxChoice.Items.Add(address[0][i]);
			}
			if (comboBoxChoice.Items.Count > 0)
			{
				comboBoxChoice.SelectedIndex = 0;
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
			dataGridView1.ContextMenuStrip = contextMenuStrip1;
			selectCol = selectRow = -1;
		}

		private void ReadAddress()
		{
			for (int i = 0; i < address[0].Count; i++)
			{
				WebRequest req = WebRequest.Create(address[1][i]);
				req.Method = "GET";
				WebResponse reply = req.GetResponse();
				StreamReader sw = new StreamReader(reply.GetResponseStream());
				Regex regex = new Regex(pattern);
				String result = sw.ReadToEnd();
				Match match = regex.Match(result);
				StreamWriter LConStore = new StreamWriter("../../Law" + i + ".txt");
				LConStore.WriteLine(address[0][i]);
				while (true)
				{
					LConStore.WriteLine(match.Groups[2].ToString());
					LConStore.WriteLine(match.Groups[3].ToString().Trim());
					LConStore.WriteLine(match.Groups[2].ToString());
					match = match.NextMatch();
					if (String.IsNullOrEmpty(match.ToString()))
					{
						break;
					}
				}
				LConStore.Flush();
				LConStore.Close();
				sw.Close();
				req.Abort();
				reply.Close();
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			textSearch.Text = textSearch.Text.Trim();
			if(String.IsNullOrEmpty(textSearch.Text))
			{
				return;
			}
			dataGridView1.Rows.Clear();
			try
			{
				//選擇的法律網址
				int selectLaw = comboBoxChoice.SelectedIndex, index = 0;
				StreamReader sw = new StreamReader("../../Law" + selectLaw + ".txt");
				Regex regex = new Regex("(\\d+-?\\d*)([\\s\\S]+?)\\1");
				String result = sw.ReadToEnd();
				Match match = regex.Match(result);
				while (true)
				{
					if (String.IsNullOrEmpty(match.ToString()))
					{
						break;
					}
					if (checkBoxConsistent.Checked)
					{
						if (Regex.IsMatch(match.Groups[2].ToString(), Regex.Escape(textSearch.Text)) == false)
						{
							match = match.NextMatch();
							continue;
						}
					}
					else
					{
						int i;
						for (i = 0; i < textSearch.Text.Length; i++)
						{
							if (textSearch.Text[i] != ' ' && Regex.IsMatch(match.Groups[2].ToString(), Regex.Escape(textSearch.Text[i].ToString())) == false)
							{
								break;
							}
						}
						if (i < textSearch.Text.Length)
						{
							match = match.NextMatch();
							continue;
						}
					}
					index = dataGridView1.Rows.Add();
					dataGridView1.Rows[index].Cells[0].Value = comboBoxChoice.SelectedItem.ToString();
					dataGridView1.Rows[index].Cells[1].Value = match.Groups[1].ToString();
					dataGridView1.Rows[index].Cells[2].Value = match.Groups[2].ToString();
					match = match.NextMatch();
				}
				labelTotal.Text = "搜尋結果：" + (index+1) + " 項";
				sw.Close();
			}
			catch (Exception def)
			{
				MessageBox.Show("發生例外錯誤：\n錯誤訊息："+def.ToString(), "錯誤訊息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				textSearch.Text = "";
			}
		}

		private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (selectCol >= 0 && selectRow >= 0)
			{
				Clipboard.SetText(dataGridView1.Rows[selectRow].Cells[selectCol].Value.ToString());
			}
		}

		private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
		{
			selectRow = e.RowIndex;
			selectCol = e.ColumnIndex;
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			formAdd.textAddress.Text = "";
			formAdd.textName.Text = "";
			formAdd.ShowDialog(this);
		}

		private void buttonRefresh_Click(object sender, EventArgs e)
		{
			DataStore();
		}

		private void textSearch_Enter(object sender, EventArgs e)
		{
			textSearch.BackColor = Color.Yellow;
		}

		private void textSearch_Leave(object sender, EventArgs e)
		{
			textSearch.BackColor = Color.White;
		}

		private void SetToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			if (selectCol >= 0 && selectRow >= 0)
			{
				StreamReader fin = new StreamReader("../../Like.txt");
				while (true)
				{
					string check = fin.ReadLine();
					if (check == null)
					{
						break;
					}
					if (Regex.IsMatch(check, dataGridView1.Rows[selectRow].Cells[0].Value.ToString()) == true)
					{
						check = fin.ReadLine();
						if (Regex.IsMatch(check, dataGridView1.Rows[selectRow].Cells[1].Value.ToString()) == true)
						{
							MessageBox.Show("這個結果已被加入我的最愛", "Error", MessageBoxButtons.OK);
							fin.Close();
							return;
						}
					}
				}
				fin.Close();
				StreamWriter fo = new StreamWriter("../../Like.txt", true);
				fo.WriteLine("cut");
				for (int i = 0; i < 3; i++)
				{
					fo.WriteLine(dataGridView1.Rows[selectRow].Cells[i].Value.ToString());
				}
				fo.WriteLine("end");
				fo.Flush();
				fo.Close();
			}
		}

		private void LikeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			
			formLike.ShowDialog(this);
		}
	}
}
