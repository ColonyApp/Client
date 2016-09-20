using System;
using System.Threading.Tasks;
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
			InfomationOfUser returnValue = null;
			var configFileContents = _configAccessor.readAsync();
			if (configFileContents != null)
			{
				returnValue = configFileContents;
			}
			else
			{
				returnValue = new InfomationOfUser
				{
					UserID = Guid.NewGuid(),
					NickName = string.Empty,
					MailAddress = string.Empty,
					IsLogicalDelete = false,
					GroupID01 = Guid.NewGuid(),
					GroupName01 = string.Empty,
					OldNickName = string.Empty,
					OldMailAddress =  string.Empty,
					OldGroupName01 = string.Empty
				};
			}
			return returnValue;
		}

		public bool SetUserInfo(InfomationOfUser user)
		{
			return _configAccessor.writeAsync(user);
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

