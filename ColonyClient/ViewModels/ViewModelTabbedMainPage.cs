using System;
namespace ColonyClient
{
	public class ViewModelTabbedMainPage
	{
		public InfomationOfUser UserInfo { get; set;}
		private ModelTabbedMainPage _model = null;
		public ViewModelTabbedMainPage()
		{
			_model = new ModelTabbedMainPage();
			UserInfo = GetUserInfo();
		}
		public InfomationOfUser GetUserInfo()
		{
			return _model.GetUserInfo();
		}
		public bool SetUserInfo(InfomationOfUser user)
		{
			return _model.SetUserInfo(user);
		}
		public InfomationOfUser GetInitialData()
		{
			return _model.initialData();
		}
		public bool SetInitialRun(bool flag)
		{
			return _model.SetInitialRun(flag);
		}
		public InfomationOfUser GetInitialRun()
		{
			return _model.GetInitialRun();
		}
	}
}
