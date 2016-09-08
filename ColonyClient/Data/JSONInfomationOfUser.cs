using System;
using Newtonsoft.Json;

namespace ColonyClient
{
	[JsonObject("JSONInfomationOfUser")]
	public class JSONInfomationOfUser
	{
		[JsonProperty("UserID")]
		public Guid UserID { get; set; }

		[JsonProperty("NickName")]
		public string NickName { get; set; }

		[JsonProperty("MailAddress")]
		public string MailAddress { get; set; }

		[JsonProperty("IsLogicalDelete")]
		public bool IsLogicalDelete { get; set; }

		[JsonProperty("GroupID01")]
		public Guid GroupID01 { get; set; }

		[JsonProperty("GroupName01")]
		public string GroupName01 { get; set; }
	}
}

