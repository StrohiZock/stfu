﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using STFU.UploadLib.Templates;

namespace STFU.AutoUploader
{
	public partial class ChooseMultipleStartTimesScrollControl : UserControl
	{
		private IList<PublishSettings> publishSettings = new List<PublishSettings>();

		public ChooseMultipleStartTimesScrollControl()
		{
			InitializeComponent();
		}

		public void AddRange(IEnumerable<PublishSettings> info)
		{
			foreach (var item in info)
			{
				publishSettings.Add(item);
			}
		}

		internal IList<PublishSettings> GetPublishSettingsArray()
		{
			foreach (ChooseSingleStartTimeControl control in mainTlp.Controls)
			{
				control.GetPublishSettings();
			}

			return publishSettings.ToList();
		}

		private void ChooseMultipleStartTimesScrollControlLoad(object sender, EventArgs e)
		{
			for (int i = 0; i < publishSettings.Count; i++)
			{
				var control = new ChooseSingleStartTimeControl(publishSettings[i]);
				control.Margin = new Padding(0, 0, 0, 10);
				control.Anchor = AnchorStyles.Left | AnchorStyles.Right;

				mainTlp.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
				mainTlp.RowCount++;
				mainTlp.RowStyles[mainTlp.RowCount - 2].SizeType = SizeType.AutoSize;
				mainTlp.RowStyles[mainTlp.RowCount - 2].Height = 0;
				mainTlp.Controls.Add(control, 0, mainTlp.RowCount - 2);
			}
		}
	}
}
