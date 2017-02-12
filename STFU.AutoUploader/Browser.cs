﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STFU.AutoUploader
{
	public partial class Browser : Form
	{
		private string Url { get; set; }
		public string AuthToken { get; private set; }

		public Browser(string url)
		{
			InitializeComponent();

			Url = url;
		}

		private void BrowserLoad(object sender, EventArgs e)
		{
			if (!string.IsNullOrWhiteSpace(Url))
			{
				WebBrowser.Navigate(Url);
				WebBrowser.Document?.Cookie?.Remove(0);
			}
		}

		private void BrowserFormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult = DialogResult.Abort;

			if (!string.IsNullOrWhiteSpace(AuthToken))
			{
				DialogResult = DialogResult.OK;
			}
		}

		private void WebBrowserNavigated(object sender, WebBrowserNavigatedEventArgs e)
		{
			if (WebBrowser.Url.AbsoluteUri.StartsWith("http://localhost"))
			{
				AuthToken = WebBrowser.Url.Query.Remove(0, 6);
				Close();
			}

			//Console.WriteLine(e.Url);
		}
	}
}