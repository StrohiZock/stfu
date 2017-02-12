﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STFU.UploadLib.Videos
{
	public class Video
	{
		private FileInfo FileDetails { get; set; }
		public VideoSnippet snippet { get; set; }
		public VideoStatus status { get; set; }
		public string Path { get { return FileDetails.FullName; } }
		public string Name { get { return FileDetails.Name; } }
		public string Extension { get { return FileDetails.Extension.Substring(1); } }
		public long Size { get { return FileDetails.Length; } }

		public Video(string path)
		{
			this.FileDetails = new FileInfo(path);
		}

		public void ChangeVideoPath(string path)
		{
			this.FileDetails = new FileInfo(path);
		}

		public bool ShouldSerializestatus()
		{
			if (status == null || (!status.embeddable && status.licence == null && status.privacyStatus == PrivacyValues.Public && !status.publicStatsViewable))
			{
				return false;
			}
			return true;
		}

		public bool ShouldSerializesnippet()
		{
			if (snippet == null || (snippet.categoryId == 0 && snippet.description == "" && snippet.title == "" && (snippet.tags == null || snippet.tags.Length == 0)))
			{
				return false;
			}
			return true;
		}

		public bool ShouldSerializePath()
		{
			return false;
		}
		public bool ShouldSerializeName()
		{
			return false;
		}
		public bool ShouldSerializeExtension()
		{
			return false;
		}
		public bool ShouldSerializeSize()
		{
			return false;
		}
	}
}