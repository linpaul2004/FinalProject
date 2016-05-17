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
using System.Text.RegularExpressions;
using System.Drawing.Printing;

namespace FinalProject
{
	public partial class FormLike : Form
	{
		private int selectRow, selectCol;
		int index = -1;
		private void DelRow()
		{
			dataGridView1.Rows.Remove(dataGridView1.Rows[selectRow]);
			index -= 1;
			StreamWriter fo = new StreamWriter("../../Like.txt");
			for (int i = 0; i < index+1; i++)
			{
				fo.WriteLine("cut");
				for (int j = 0; j < 3; j++)
				{
					fo.WriteLine(dataGridView1.Rows[i].Cells[j].Value.ToString());
				}
				fo.WriteLine("end");
			}
			fo.Flush();
			fo.Close();
			label1.Text = "目前有 " + (index + 1) + " 條最愛項目";
		}
		public FormLike()
		{
			InitializeComponent();
			buttonOK.DialogResult = DialogResult.OK;
			dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
			dataGridView1.ContextMenuStrip = contextMenuStrip1;
			selectCol = selectRow = -1;
		}

		private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
		{
			selectCol = e.ColumnIndex;
			selectRow = e.RowIndex;
		}

		private void FormLike_Load(object sender, EventArgs e)
		{
			dataGridView1.Rows.Clear();
			FileInfo file = new FileInfo("../../Like.txt");
			if (file.Exists == false)
			{
				FileStream fs = file.Create();
				fs.Close();
			}
			StreamReader fin = new StreamReader("../../Like.txt");
			index = -1;
			while (true)
			{
				string tmp = fin.ReadLine();
				if (tmp == null)
				{
					break;
				}
				if (tmp == "cut" || tmp == "")
				{
					tmp = fin.ReadLine();
				}
				index = dataGridView1.Rows.Add();
				dataGridView1.Rows[index].Cells[0].Value = tmp;
				tmp = fin.ReadLine();
				dataGridView1.Rows[index].Cells[1].Value = tmp;
				string con = "";
				while (true)
				{
					tmp = fin.ReadLine();
					if (tmp == "end")
					{
						break;
					}
					con += (tmp + "\n");
				}
				dataGridView1.Rows[index].Cells[2].Value = con;
			}
			label1.Text = "目前有 " + (index+1) + " 條最愛項目";
			fin.Close();
		}

		private void DelToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (selectCol >= 0 && selectRow >= 0)
			{
				DelRow();
			}
		}

		private void DelAll_Click(object sender, EventArgs e)
		{
			dataGridView1.Rows.Clear();
			index = -1;
			selectCol = selectRow = -1;
			label1.Text = "目前有 " + (index + 1) + " 條最愛項目";
			StreamWriter fo = new StreamWriter("../../Like.txt");
			fo.Write("");
			fo.Flush();
			fo.Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			
		}

	}
}
