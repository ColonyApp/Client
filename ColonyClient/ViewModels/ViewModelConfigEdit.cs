using System;
using Xamarin.Forms;
using System.Windows.Input;

namespace ColonyClient
{
	public class ViewModelConfigEdit : BindableBase
	{
		
		private InfomationOfUser _userInfo;
		public InfomationOfUser UserInfo
		{
			get
			{
				return _userInfo;
			}
			set
			{
				this._userInfo = value;
				SetProperty(ref this._userInfo, value);
			}
		}

		private RelayCommand _updateChanging;
		public RelayCommand UpdateChanging
		{
			get
			{
				return _updateChanging = _updateChanging ?? new RelayCommand(update);
			}
		}

		private void update()
		{
			_model.SetUserInfo(UserInfo);
		}

		private ModelConfigEdit _model;
		public ViewModelConfigEdit()
		{
			_model = new ModelConfigEdit();
			getInitialData();
		}

		private void getInitialData()
		{
			UserInfo = _model.GetInitialData();
		}

	}
}

