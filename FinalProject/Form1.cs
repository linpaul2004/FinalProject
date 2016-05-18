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
using System.Drawing.Printing;

namespace FinalProject
{
	public partial class Form1 : Form
	{
		private int selectRow, selectCol;
		private FormAdd formAdd = new FormAdd();
		private FormLike formLike = new FormLike();
		private WordFont wordfont = new WordFont();
		private UserDefDic userdefdic = new UserDefDic();
		private string filepath = "../../LAddStore.txt";
		private string pattern = "<a\\s(id=\"rtAlllaw_ctl\\d\\d_HYNo\"\\s)?href=\"LawSingle\\.aspx\\?Pcode=[A-Z][0-9]{7}&a?m?p?;?FLNO=(\\d+-?\\d*)[\\s]*\">[\\s\\S]+?<pre>([\\s\\S]+?)<\\/pre><\\/td>";
		protected internal List<String>[] address=new List<String>[2];

		private void Search(string result, string name, int index)
		{
			try
			{
				Regex regex = new Regex("(\\d+-?\\d*)([\\s\\S]+?)\\1");
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
					dataGridView1.Rows[index].Cells[0].Value = name;
					dataGridView1.Rows[index].Cells[1].Value = match.Groups[1].ToString();
					dataGridView1.Rows[index].Cells[2].Value = match.Groups[2].ToString();
					match = match.NextMatch();
				}
				labelTotal.Text = "搜尋結果：" + (index + 1) + " 項";
			}
			catch (Exception def)
			{
				MessageBox.Show("發生例外錯誤：\n錯誤訊息：" + def.ToString(), "錯誤訊息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				textSearch.Text = "";
			}
		}

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
			FileInfo fi = new FileInfo("../../Law0.txt");
			if (fi.Exists)
			{
				labelLastUpdate.Text = fi.LastWriteTime.ToString();
			}
			else
			{
				labelLastUpdate.Text = "尚未新增法律";
			}
		}

		private void ReadAddress()
		{
			for (int i = 0; i < address[0].Count; i++)
			{
				if (address[1][i] == "")
				{
					i++;
					continue;
				}
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
			//選擇的法律網址
			int selectLaw = comboBoxChoice.SelectedIndex;
			StreamReader sw;
			FileInfo file = new FileInfo("../../Law" + selectLaw + ".txt");
			if (file.Exists == true)
			{
				sw = new StreamReader("../../Law" + selectLaw + ".txt");
			}
			else
			{
				sw = new StreamReader("../../" + comboBoxChoice.Items[comboBoxChoice.SelectedIndex].ToString() + ".txt");
			}
			string tmp = sw.ReadLine();
			if (tmp == "Mixed")
			{
				tmp = sw.ReadLine();
				int index = 0;
				while (true)
				{
					if (tmp == null || tmp == "")
					{
						break;
					}
					for (int i = 0; i < comboBoxChoice.Items.Count; i++)
					{
						if (tmp == comboBoxChoice.Items[i].ToString())
						{
							FileInfo refile = new FileInfo("../../Law" + i + ".txt");
							if (refile.Exists == true)
							{
								StreamReader re = new StreamReader("../../Law" + i + ".txt");
								string result = re.ReadToEnd();
								Search(result, comboBoxChoice.Items[i].ToString(), index);
								re.Close();
								break;
							}
							else
							{
								FileInfo reagfile = new FileInfo("../../" + comboBoxChoice.Items[i].ToString() + ".txt");
								if (reagfile.Exists == true)
								{
									StreamReader re = new StreamReader("../../" + comboBoxChoice.Items[i].ToString() + ".txt");
									string result = re.ReadToEnd();
									Search(result, comboBoxChoice.Items[i].ToString(), index);
									re.Close();
									break;
								}
								else
								{
									MessageBox.Show("Error", "這個自定義法典中的法律可能被刪除了!!", MessageBoxButtons.OK);
									break;
								}
							}
						}
					}
					tmp = sw.ReadLine();
				}
				sw.Close();
			}
			else
			{
				String result = sw.ReadToEnd();
				int index = 0;
				Search(result, comboBoxChoice.SelectedItem.ToString(), index);
				sw.Close();
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

		private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void RefreshToolStripMenuItem_Click(object sender, EventArgs e)
		{
			buttonRefresh.PerformClick();
		}

		private void ColorToolStripMenuItem_Click(object sender, EventArgs e)
		{
			colorDialog1.Color = dataGridView1.ForeColor;
			if (colorDialog1.ShowDialog(this) == DialogResult.OK)
			{
				dataGridView1.ForeColor = colorDialog1.Color;
				formLike.dataGridView1.ForeColor = colorDialog1.Color;
			}
		}

		private void BackgroundToolStripMenuItem_Click(object sender, EventArgs e)
		{
			colorDialog1.Color = dataGridView1.DefaultCellStyle.BackColor;
			if (colorDialog1.ShowDialog(this) == DialogResult.OK)
			{
				dataGridView1.DefaultCellStyle.BackColor = colorDialog1.Color;
				formLike.dataGridView1.DefaultCellStyle.BackColor = colorDialog1.Color;
			}
		}

		private void SetFontToolStripMenuItem_Click(object sender, EventArgs e)
		{
			wordfont.numericUpDown1.Value = (decimal)dataGridView1.Font.Size;
			wordfont.ShowDialog(this);
			if (wordfont.DialogResult==DialogResult.OK)
			{
				dataGridView1.Font = new Font(dataGridView1.Font.Name, (float)wordfont.numericUpDown1.Value, dataGridView1.Font.Style);
				formLike.dataGridView1.Font = dataGridView1.Font;
			}
		}

		private void word8_Click(object sender, EventArgs e)
		{
			dataGridView1.Font = new Font(dataGridView1.Font.Name, 8, dataGridView1.Font.Style);
			formLike.dataGridView1.Font = dataGridView1.Font;
		}

		private void word10_Click(object sender, EventArgs e)
		{
			dataGridView1.Font = new Font(dataGridView1.Font.Name, 10, dataGridView1.Font.Style);
			formLike.dataGridView1.Font = dataGridView1.Font;
		}

		private void word12_Click(object sender, EventArgs e)
		{
			dataGridView1.Font = new Font(dataGridView1.Font.Name, 12, dataGridView1.Font.Style);
			formLike.dataGridView1.Font = dataGridView1.Font;
		}

		private void word15_Click(object sender, EventArgs e)
		{
			dataGridView1.Font = new Font(dataGridView1.Font.Name, 15, dataGridView1.Font.Style);
			formLike.dataGridView1.Font = dataGridView1.Font;
		}

		private void word20_Click(object sender, EventArgs e)
		{
			dataGridView1.Font = new Font(dataGridView1.Font.Name, 20, dataGridView1.Font.Style);
			formLike.dataGridView1.Font = dataGridView1.Font;
		}

		private void word28_Click(object sender, EventArgs e)
		{
			dataGridView1.Font = new Font(dataGridView1.Font.Name, 28, dataGridView1.Font.Style);
			formLike.dataGridView1.Font = dataGridView1.Font;
		}

		private void word36_Click(object sender, EventArgs e)
		{
			dataGridView1.Font = new Font(dataGridView1.Font.Name, 36, dataGridView1.Font.Style);
			formLike.dataGridView1.Font = dataGridView1.Font;
		}

		private void word72_Click(object sender, EventArgs e)
		{
			dataGridView1.Font = new Font(dataGridView1.Font.Name, 72, dataGridView1.Font.Style);
			formLike.dataGridView1.Font = dataGridView1.Font;
		}

		private void PrintToolStripMenuItem_Click(object sender, EventArgs e)
		{
			printDialog1.Document = printDocument1;
			if (printDialog1.ShowDialog(this) == DialogResult.OK)
			{
				printDocument1.Print();
			}
		}

		private void txtToolStripMenuItem_Click(object sender, EventArgs e)
		{
			saveFileDialog1.Filter = "TXT File|*.txt";
			if (saveFileDialog1.ShowDialog(this) == DialogResult.OK && saveFileDialog1.FileName != "")
			{
				FileInfo file = new FileInfo(saveFileDialog1.FileName);
				StreamWriter fout;
				if (file.Exists == false)
				{
					FileStream fs = file.Create();
					fs.Close();
				}
				fout = new StreamWriter(saveFileDialog1.FileName);
				for (int i = 0; i < dataGridView1.Rows.Count; i++)
				{
					fout.WriteLine(dataGridView1.Rows[i].Cells[0].Value.ToString());
					fout.WriteLine(dataGridView1.Rows[i].Cells[1].Value.ToString());
					fout.WriteLine(dataGridView1.Rows[i].Cells[2].Value.ToString());
				}
				fout.Flush();
				fout.Close();
			}
		}

		private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
		{
			printDocument1.DocumentName = "查詢結果";
			string text = "搜尋字串：" + textSearch.Text + "\n";
			text += "搜尋法律：" + comboBoxChoice.SelectedItem.ToString() + "\n";
			for (int i = 0; i < dataGridView1.Rows.Count; i++)
			{
				text += dataGridView1.Rows[i].Cells[0].Value.ToString();
				text += "\n第 ";
				text += dataGridView1.Rows[i].Cells[1].Value.ToString();
				text += " 條\n";
				text += dataGridView1.Rows[i].Cells[2].Value.ToString();
				text += "\n";
			}
			e.Graphics.DrawString(text, new System.Drawing.Font("新細明體", 9, FontStyle.Regular), System.Drawing.Brushes.Black, 10, 10);
		}

		private void UserDefinedToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string[] tmp = new string[address[0].Count];
			for (int i = 0; i < address[0].Count; i++)
			{
				tmp[i] = address[0][i];
			}
			userdefdic.con = tmp;
			userdefdic.ShowDialog(this);
		}
	}
}
