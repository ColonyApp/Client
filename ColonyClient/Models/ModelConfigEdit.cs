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
			bool returnvalue = false;
			//var service = new
			return returnvalue;
		}
	}
}

