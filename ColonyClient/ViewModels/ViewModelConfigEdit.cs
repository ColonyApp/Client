using System;
using Xamarin.Forms;
using System.Windows.Input;

namespace ColonyClient
{
	public class ViewModelConfigEdit : BindableBase
	{
		/// <summary>
		/// The model.
		/// </summary>
		private ModelConfigEdit _model;
		/// <summary>
		/// The user info.
		/// </summary>
		private InfomationOfUser _userInfo;

		/// <summary>
		/// Gets or sets the user info.
		/// </summary>
		/// <value>The user info.</value>
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

		/// <summary>
		/// The update changing.
		/// </summary>
		private RelayCommand _updateChanging;
		/// <summary>
		/// Gets the update changing.
		/// </summary>
		/// <value>The update changing.</value>
		public RelayCommand UpdateChanging
		{
			get
			{
				return _updateChanging = _updateChanging ?? new RelayCommand(update);
			}
		}
		/// <summary>
		/// Update this instance.
		/// </summary>
		private void update()
		{
			_model.SetUserInfo(UserInfo);
		}
		/// <summary>
		/// Initializes a new instance of the <see cref="T:ColonyClient.ViewModelConfigEdit"/> class.
		/// </summary>
		/// <param name="tabbedMainPage">Tabbed main page.</param>
		public ViewModelConfigEdit(ViewModelTabbedMainPage tabbedMainPage)
		{
			_model = new ModelConfigEdit(tabbedMainPage);
			UserInfo = _model.GetInitialData();
		}
	}
}

