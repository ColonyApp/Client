using System;
namespace ColonyClient
{
	public class InfomationOfUser
	{
		public Guid UserID { get; set; }

		public string NickName { get; set; }

		public string MailAddress { get; set; }

		public bool IsLogicalDelete { get; set; }

		public Guid GroupID01 { get; set; }

		public string GroupName01 { get; set; }

		public string OldNickName { get; set; }

		public string OldMailAddress { get; set; }

		public string OldGroupName01 { get; set; }

		public bool IsInitial { get; set; }
	}
}

