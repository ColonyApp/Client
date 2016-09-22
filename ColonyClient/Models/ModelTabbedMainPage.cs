using System;
namespace ColonyClient
{
	public class ModelTabbedMainPage
	{
		public ModelTabbedMainPage()
		{
		}
		public InfomationOfUser initialData()
		{
			return new InfomationOfUser()
			{
				UserID = Guid.NewGuid(),
				NickName = string.Empty,
				MailAddress = string.Empty,
				IsLogicalDelete = false,
				GroupID01 = Guid.NewGuid(),
				GroupName01 = string.Empty,
				OldNickName = string.Empty,
				OldMailAddress = string.Empty,
				OldGroupName01 = string.Empty
			};
		}
		public bool SetUserInfo(InfomationOfUser user)
		{
			try
			{
				var target = new InfomationOfUser()
				{
					UserID = user.UserID,
					NickName = user.NickName,
					MailAddress = user.MailAddress,
					IsLogicalDelete = false,
					GroupID01 = user.GroupID01,
					GroupName01 = user.GroupName01,
					OldNickName = user.NickName,
					OldMailAddress = user.MailAddress,
					OldGroupName01 = user.GroupName01
				};
				App.Current.Properties.Add("UserInfo", target);
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}
		public InfomationOfUser GetUserInfo()
		{
			InfomationOfUser returnValue = null;
			try
			{
				if (App.Current.Properties.ContainsKey("UserInfo"))
				{
					returnValue = App.Current.Properties["UserInfo"] as InfomationOfUser;
				}
				else
				{
					returnValue = initialData();
				}
				return returnValue;
			}
			catch (Exception)
			{
				throw new Exception("Didn't get InformationOfUser Data!");
			}
		}
	}
}
