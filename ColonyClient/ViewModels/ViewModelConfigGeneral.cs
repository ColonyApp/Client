using System;
using Xamarin.Forms;
using System.Windows.Input;

namespace ColonyClient
{
	public class ViewModelConfigGeneral : BindableBase
	{
		//private ModelConfigGeneral model = new ModelConfigGeneral();

		/// <summary>
		/// The navigation.
		/// </summary>
		private INavigation _navigation;

		/// <summary>
		/// Gets the go to edit page.
		/// </summary>
		/// <value>The go to edit page.</value>
		public ICommand GoToEditPage{ get; private set;}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:ColonyClient.ViewModelConfigGeneral"/> class.
		/// </summary>
		/// <param name="navigation">Navigation.</param>
		public ViewModelConfigGeneral(INavigation navigation)
		{
			_navigation = navigation;
			this.GoToEditPage = new Command(async () =>
			{
				await _navigation.PushAsync(new ConfigEdit(UserInfo));
			});
		}

		/// <summary>
		/// The user info.
		/// </summary>
		private InfomationOfUser userInfo;
		/// <summary>
		/// Gets or sets the user info.
		/// </summary>
		/// <value>The user info.</value>
		public InfomationOfUser UserInfo
		{
			get { return userInfo; }
			set
			{
				if (userInfo != null)
				{
					userInfo.OldNickName = userInfo.NickName;
					userInfo.OldMailAddress = userInfo.MailAddress;
					userInfo.OldGroupName01 = userInfo.GroupName01;
					userInfo = value;
					SetProperty(ref this.userInfo, value);
				}
			}
		}
	}
}

