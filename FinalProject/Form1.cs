using System;
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

		public Form1()
		{
			InitializeComponent();
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
			WebRequest req = WebRequest.Create(@"http://law.moj.gov.tw/LawClass/LawAll.aspx?PCode=C0000001");
			req.Method = "GET";
			WebResponse reply = req.GetResponse();
			StreamReader sw = new StreamReader(reply.GetResponseStream());
			String pattern = "<a\\shref=\"LawSingle\\.aspx\\?Pcode=[\\w]+&FLNO=(\\d+-?\\d*)[\\s]+\">[\\s\\S]+?<td ><pre>([\\s\\S]+?)<\\/pre><\\/td>";
			Regex regex = new Regex(pattern);
			String result = sw.ReadToEnd();
			Match match = regex.Match(result);
			String find = textSearch.Text;
			while(true)
			{
				if (Regex.IsMatch(match.Groups[2].ToString(), find))
				{
					int index = dataGridView1.Rows.Add();
					dataGridView1.Rows[index].Cells[0].Value = "中華民國刑法";
					dataGridView1.Rows[index].Cells[1].Value = match.Groups[1].ToString();
					dataGridView1.Rows[index].Cells[2].Value = match.Groups[2].ToString();
					match = match.NextMatch();
				}
				match = match.NextMatch();
				if (String.IsNullOrEmpty(match.ToString()))
				{
					break;
				}
			}
			sw.Close();
			reply.Close();
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
	}
}
