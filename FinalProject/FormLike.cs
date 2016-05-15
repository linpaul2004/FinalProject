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

namespace FinalProject
{
	public partial class FormLike : Form
	{
		private int selectRow, selectCol;
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
			StreamReader fin = new StreamReader("../../Like.txt");
			int index = 0;
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
			fin.Close();
		}
	}
}
