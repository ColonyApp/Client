using System;
namespace ColonyClient
{
	public class ModelConfigEdit
	{
		private ConfigAccessor _configAccessor;

		public ModelConfigEdit()
		{
			_configAccessor = new ConfigAccessor();
		}

		public InfomationOfUser GetInitialData()
		{
			return _configAccessor.readAsync().Result;
		}

		public bool SetUserInfo(InfomationOfUser user)
		{
			return _configAccessor.writeAsync(user).Result;
		}

		public bool UpdateUserInfo(InfomationOfUser user)
		{
			var result = App.DataManeger.ModifyUserAsync(user.OldNickName
			                                             , user.NickName
			                                             , user.OldMailAddress
			                                             , user.MailAddress
			                                             , user.UserID);
			return result.Result;
		}
	}
}

