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

		private void buttonOK_Click(object sender, EventArgs e)
		{
			if (String.IsNullOrEmpty(textAddress.Text) == false)
			{
				if (Regex.IsMatch(textAddress.Text, "http:\\/\\/law\\.moj\\.gov\\.tw\\/LawClass\\/LawAll\\.aspx\\?PCode=[A-Z][\\d]{7}"))
				{
					if (String.IsNullOrEmpty(textName.Text))
					{
						buttonAuto.PerformClick();
					}
					this.DialogResult = DialogResult.Yes;
					return;
				}
			}
			MessageBox.Show("輸入的網址不合法", "錯誤訊息");
			this.DialogResult = DialogResult.None;
		}

		private void buttonAuto_Click(object sender, EventArgs e)
		{
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
	}
}
