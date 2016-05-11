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
		protected internal List<String>[] address=new List<String>[2];
		public Form1()
		{
			InitializeComponent();
			for (int i = 0; i < 2; i++)
			{
				address[i]=new List<string>();
			}
			comboBoxChoice.DropDownStyle = ComboBoxStyle.DropDownList;
			comboBoxChoice.Items.Add("中華民國刑法");
			comboBoxChoice.Items.Add("民法");
			comboBoxChoice.SelectedIndex = 0;
			// 0 存的是名字， 1 存的是網址
			address[0].Add("中華民國刑法");
			address[1].Add(@"http://law.moj.gov.tw/LawClass/LawAll.aspx?PCode=C0000001");
			address[0].Add("民法");
			address[1].Add(@"http://law.moj.gov.tw/LawClass/LawAll.aspx?PCode=B0000001");
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
			dataGridView1.ContextMenuStrip = contextMenuStrip1;
			selectCol = selectRow = -1;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if(String.IsNullOrEmpty(textSearch.Text)){
				return;
			}
			dataGridView1.Rows.Clear();
			try
			{
				//選擇的法律網址
				string selectAddress = address[1][address[0].IndexOf(comboBoxChoice.SelectedItem.ToString())];
				WebRequest req = WebRequest.Create(selectAddress);
				req.Method = "GET";
				WebResponse reply = req.GetResponse();
				StreamReader sw = new StreamReader(reply.GetResponseStream());
				String pattern = "<a\\s(id=\"rtAlllaw_ctl\\d\\d_HYNo\"\\s)?href=\"LawSingle\\.aspx\\?Pcode=[A-Z][0-9]{7}&a?m?p?;?FLNO=(\\d+-?\\d*)[\\s]*\">[\\s\\S]+?<pre>([\\s\\S]+?)<\\/pre><\\/td>";
				Regex regex = new Regex(pattern);
				String result = sw.ReadToEnd();
				Match match = regex.Match(result);
				String find = textSearch.Text;
				while (true)
				{
					if (Regex.IsMatch(match.Groups[3].ToString(), find))
					{
						int index = dataGridView1.Rows.Add();
						dataGridView1.Rows[index].Cells[0].Value = comboBoxChoice.SelectedItem.ToString();
						dataGridView1.Rows[index].Cells[1].Value = match.Groups[2].ToString();
						dataGridView1.Rows[index].Cells[2].Value = match.Groups[3].ToString();
					}
					match = match.NextMatch();
					if (String.IsNullOrEmpty(match.ToString()))
					{
						break;
					}
				}
				sw.Close();
				req.Abort();
				reply.Close();
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
	}
}
