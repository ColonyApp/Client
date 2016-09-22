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
			_vm.UserInfo = _vm.GetInitialData();
		}
		/// <summary>
		/// Gets the initial data.
		/// </summary>
		/// <returns>The initial data.</returns>
		public InfomationOfUser GetInitialData()
		{
			return _vm.GetInitialData();
		}
		/// <summary>
		/// Sets the user info.
		/// </summary>
		/// <returns><c>true</c>, if user info was set, <c>false</c> otherwise.</returns>
		/// <param name="user">User.</param>
		public bool SetUserInfo(InfomationOfUser user)
		{
			bool returnValue = false;
			if (_vm.SetUserInfo(user))
			{
				returnValue = UpdateUserInfo(user);
			}
			else
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
		private bool UpdateUserInfo(InfomationOfUser user)
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

