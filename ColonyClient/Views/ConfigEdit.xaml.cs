using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ColonyClient
{
	public partial class ConfigEdit : ContentPage
	{
		
		public ConfigEdit(InfomationOfUser userInfo)
		{
			InitializeComponent();
			BindingContext = transrateInitData(userInfo);
		}

		public void OnSubmitClicked(object sender, EventArgs e)
		{
		}

		private InfomationOfUser transrateInitData(InfomationOfUser userInfo)
		{
			return new InfomationOfUser
			{
				UserID = userInfo.UserID,
				NickName = userInfo.NickName,
				OldNickName = userInfo.NickName,
				MailAddress = userInfo.MailAddress,
				OldMailAddress = userInfo.MailAddress,
				IsLogicalDelete = userInfo.IsLogicalDelete,
				GroupID01 = userInfo.GroupID01,
				GroupName01 = userInfo.GroupName01,
				OldGroupName01 = userInfo.GroupName01
			};
		}
	}
}

