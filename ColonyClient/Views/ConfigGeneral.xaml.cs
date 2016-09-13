using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ColonyClient
{
	public partial class ConfigGeneral : ContentPage
	{
		InfomationOfUser userInfo = null;
		public ConfigGeneral()
		{
			InitializeComponent();
			userInfo = new InfomationOfUser
			{
				UserID = Guid.NewGuid(),
				NickName = string.Empty,
				MailAddress = string.Empty,
				IsLogicalDelete = false,
				GroupID01 = Guid.NewGuid(),
				GroupName01 = string.Empty,
				OldNickName = string.Empty,
				OldMailAddress = string.Empty,
				OldGroupName01 = string.Empty
			};
			BindingContext = userInfo;
		}

		public async void OnEditButtonClicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new ConfigEdit(userInfo));
		}
	}
}

