using System;
namespace ColonyClient
{
	public class ModelConfigGeneral
	{
		private ConfigAccessor _configAccessor;

		public ModelConfigGeneral()
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
	}
}

