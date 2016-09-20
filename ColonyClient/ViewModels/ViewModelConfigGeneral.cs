using System;
using Xamarin.Forms;
using System.Windows.Input;

namespace ColonyClient
{
	public class ViewModelConfigGeneral : BindableBase
	{
		//private ModelConfigGeneral _model = new ModelConfigGeneral();

		/// <summary>
		/// The navigation.
		/// </summary>
		private INavigation _navigation;

		/// <summary>
		/// Gets the go to edit page.
		/// </summary>
		/// <value>The go to edit page.</value>
		public ICommand GoToEditPage { get; private set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="T:ColonyClient.ViewModelConfigGeneral"/> class.
		/// </summary>
		/// <param name="navigation">Navigation.</param>
		public ViewModelConfigGeneral(INavigation navigation)
		{
			_navigation = navigation;
			//this.GoToEditPage = new Command(async () =>
			//{
			//	await _navigation.PushAsync(new ConfigEdit(UserInfo));
			//});
		}

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
			get { return _userInfo; }
			set
			{
				if (_userInfo != null)
				{
					_userInfo = value;
					_userInfo.OldNickName = _userInfo.NickName;
					_userInfo.OldMailAddress = _userInfo.MailAddress;
					_userInfo.OldGroupName01 = _userInfo.GroupName01;
					SetProperty(ref this._userInfo, value);
				}
			}
		}
	}
}

