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
	public partial class FormAdd : Form
	{
		public FormAdd()
		{
			InitializeComponent();
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			Form1 parent = (Form1)this.Owner;
			if (String.IsNullOrEmpty(textAddress.Text) == false)
			{
				if (Regex.IsMatch(textAddress.Text, "http:\\/\\/law\\.moj\\.gov\\.tw\\/LawClass\\/LawAll\\.aspx\\?PCode=[A-Z][\\d]{7}"))
				{
					if (String.IsNullOrEmpty(textName.Text))
					{
						buttonAuto.PerformClick();
					}
					checkedListBox1.Items.Add(textName.Text);
					parent.address[0].Add(textName.Text);
					parent.address[1].Add(textAddress.Text);
					parent.comboBoxChoice.Items.Add(textName.Text);
					parent.DataStore();
					return;
				}
			}
			MessageBox.Show("輸入的網址不合法", "錯誤訊息");
			textAddress.Text = "";
			textName.Text = "";
		}

		private void buttonAuto_Click(object sender, EventArgs e)
		{
			if (Regex.IsMatch(textAddress.Text, "http:\\/\\/law\\.moj\\.gov\\.tw\\/LawClass\\/LawAll\\.aspx\\?PCode=[A-Z][\\d]{7}") == false)
			{
				return;
			}
			WebRequest req = WebRequest.Create(textAddress.Text);
			req.Method = "GET";
			WebResponse reply = req.GetResponse();
			StreamReader sw = new StreamReader(reply.GetResponseStream());
			String pattern = "<a href=\"LawContent\\.aspx\\?PCODE=[A-Z][\\d]{7}\">([\\s\\S]+?)<\\/a>";
			Regex regex = new Regex(pattern);
			String result = sw.ReadToEnd();
			Match match = regex.Match(result);
			textName.Text = match.Groups[1].ToString();
			reply.Close();
			req.Abort();
			sw.Close();
		}

		private void FormAdd_Load(object sender, EventArgs e)
		{
			Form1 parent = (Form1)this.Owner;
			checkedListBox1.Items.Clear();
			checkedListBox1.Items.AddRange(parent.address[0].ToArray());
		}

		private void buttonDel_Click(object sender, EventArgs e)
		{
			Form1 parent = (Form1)this.Owner;
			while (checkedListBox1.SelectedIndices.Count > 0)
			{
				FileInfo file = new FileInfo("../../Law" + checkedListBox1.SelectedIndices[0].ToString() + ".txt");
				if (file.Exists == false)
				{
					FileInfo name = new FileInfo("../../" + (parent.address[0][checkedListBox1.SelectedIndices[0]]).ToString() + ".txt");
					if (name.Exists == true)
					{
						name.Delete();
					}
				}
				else
				{
					file.Delete();
				}
				parent.address[0].RemoveAt(checkedListBox1.SelectedIndices[0]);
				parent.address[1].RemoveAt(checkedListBox1.SelectedIndices[0]);
				parent.comboBoxChoice.Items.Remove(checkedListBox1.Items[checkedListBox1.SelectedIndices[0]]);
				checkedListBox1.Items.RemoveAt(checkedListBox1.SelectedIndices[0]);
				parent.DataStore();
			}
		}
	}
}
