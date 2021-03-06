﻿using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using STFU.UploadLib.Videos;

namespace STFU.UploadLib.Communication.Youtube.Serializable
{
	public class EnumConverter : JsonConverter
	{
		public override bool CanConvert(Type objectType)
		{
			throw new NotImplementedException();
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			string jValue = (string)new JValue(reader.Value).Value;

			if (objectType == typeof(PrivacyStatus))
			{
				foreach (PrivacyStatus value in typeof(PrivacyStatus).GetEnumValues())
				{
					if (jValue == value.GetAttribute<EnumMemberAttribute>().Value)
					{
						return value;
					}
				}
			}
			else if (objectType == typeof(License))
			{
				foreach (License value in typeof(License).GetEnumValues())
				{
					if (jValue == value.GetAttribute<EnumMemberAttribute>().Value)
					{
						return value;
					}
				}
			}

			return null;
		}

		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			if (value is PrivacyStatus)
			{
				PrivacyStatus status = (PrivacyStatus)value;
				writer.WriteValue(status.GetAttribute<EnumMemberAttribute>().Value);
			}

			if (value is License)
			{
				License lic = (License)value;
				writer.WriteValue(lic.GetAttribute<EnumMemberAttribute>().Value);
			}
		}
	}
}
