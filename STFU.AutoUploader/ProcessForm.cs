﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace STFU.AutoUploader
{
	public partial class ProcessForm : Form
	{
		public IReadOnlyCollection<Process> Selected { get { return selectedProcesses; } }

		private List<Process> selectedProcesses = new List<Process>();
		private Process[] AllProcesses { get; set; }
		private bool reactToCheckedEvents = true;


		public ProcessForm()
		{
			InitializeComponent();
		}

		private void ProcessWindowLoad(object sender, EventArgs e)
		{
			RefreshAllProcs();
		}

		private void RefreshAllProcs()
		{
			reactToCheckedEvents = false;
			lvProcs.BeginUpdate();

			lvProcs.Items.Clear();
			var currentSessionID = Process.GetCurrentProcess().SessionId;

			AllProcesses = Process.GetProcesses()
				.OrderBy(item => item.ProcessName)
				.Where(p => p.SessionId == currentSessionID)
				.ToArray();

			foreach (var item in AllProcesses)
			{
				if (item.Id == Process.GetCurrentProcess().Id)
				{
					// Wäre totaler Quatch, wenn wir uns selbst überwachen.
					continue;
				}

				ListViewItem newItem = new ListViewItem(string.Empty);
				newItem.SubItems.Add(item.ProcessName);

				if (selectedProcesses.Any(proc => item.Id == proc.Id))
				{
					newItem.Checked = true;
				}

				try
				{
					newItem.SubItems.Add(item.MainModule.FileVersionInfo.FileDescription);
				}
				catch (Exception)
				{ }

				lvProcs.Items.Add(newItem);
			}

			lvProcs.Columns[0].Width = -1;
			lvProcs.Columns[1].Width = -1;
			lvProcs.Columns[2].Width = -2;

			lvProcs.EndUpdate();
			reactToCheckedEvents = true;
		}

		private void btnRefreshClick(object sender, EventArgs e)
		{
			RefreshAllProcs();
		}

		private void lvProcsItemChecked(object sender, ItemCheckedEventArgs e)
		{
			if (!reactToCheckedEvents)
			{
				return;
			}

			Process item = AllProcesses[e.Item.Index];

			if (selectedProcesses.Contains(item))
			{
				selectedProcesses.Remove(item);
			}
			else
			{
				selectedProcesses.Add(item);
			}
		}

		private void btnSubmitClick(object sender, EventArgs e)
		{
			DialogResult = DialogResult.OK;
			Close();
		}
	}
}
