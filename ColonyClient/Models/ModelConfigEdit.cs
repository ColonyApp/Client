using System;
using System.Threading.Tasks;
namespace ColonyClient
{
	public class ModelConfigEdit
	{
		/// <summary>
		/// The vm.
		/// </summary>
		ViewModelTabbedMainPage _vm;
		/// <summary>
		/// Initializes a new instance of the <see cref="T:ColonyClient.ModelConfigEdit"/> class.
		/// </summary>
		/// <param name="tabbedMainPage">Tabbed main page.</param>
		public ModelConfigEdit(ViewModelTabbedMainPage tabbedMainPage)
		{
			_vm = tabbedMainPage;
			//_vm.UserInfo = _vm.GetInitialData();
		}
		/// <summary>
		/// Gets the initial data.
		/// </summary>
		/// <returns>The initial data.</returns>
		public InfomationOfUser GetInitialData()
		{
			if (IsNullOrEmpty(_vm.UserInfo.NickName))
			{
				return _vm.GetInitialData();
			}
			return SearchUserInfoAsync(_vm.UserInfo).Result;
		}
		/// <summary>
		/// Sets the user info.
		/// </summary>
		/// <returns><c>true</c>, if user info was set, <c>false</c> otherwise.</returns>
		/// <param name="user">User.</param>
		public bool SetUserInfo(InfomationOfUser user)
		{
			bool returnValue = false;
			try
			{
				if (HasUserAsync(user).Result)
				{
					_vm.SetUserInfo(user);
					returnValue = UpdateUserInfo(user).Result;
				}
				else
				{
					_vm.SetUserInfo(user);
					returnValue = CreateUserInfoAsync(user).Result;
				}
			}
			catch
			{
				returnValue = false;
			}
			return returnValue;
		}
		/// <summary>
		/// Updates the user info.
		/// </summary>
		/// <returns><c>true</c>, if user info was updated, <c>false</c> otherwise.</returns>
		/// <param name="user">User.</param>
		private async Task<bool> UpdateUserInfo(InfomationOfUser user)
		{
			var result = await App.DataManeger.ModifyUserAsync(user.OldNickName
				                                             , user.NickName
				                                             , user.OldMailAddress
				                                             , user.MailAddress
				                                             , user.UserID);
			return result;
		}

		private async Task<bool> CreateUserInfoAsync(InfomationOfUser user)
		{
			var result = await App.DataManeger.CreateUserAsync(user.NickName, user.MailAddress);
			return result;
		}

		private async Task<bool> HasUserAsync(InfomationOfUser user)
		{
			var result = await App.DataManeger.HasUserWithoutIdAsync(user.NickName, user.MailAddress);
			return result;
		}

		private async Task<InfomationOfUser> SearchUserInfoAsync(InfomationOfUser user)
		{
			var result = await App.DataManeger.SearchUserDataAsync(user.NickName, user.MailAddress);
			return result;
		}
		private bool IsNullOrEmpty(string target)
		{
			bool returnValue = false;
			if (string.IsNullOrEmpty(target) || string.IsNullOrWhiteSpace(target))
			{
				returnValue = true;
			}
			return returnValue;
		}
	}
}

