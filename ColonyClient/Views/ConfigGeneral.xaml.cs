using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ColonyClient
{
	public partial class ConfigGeneral : ContentPage
	{
		InfomationOfUser userInfo=null;
		public ConfigGeneral()
		{
			InitializeComponent();
			//getInitData();
			userInfo = new InfomationOfUser
			{
				UserID = Guid.NewGuid(),
				NickName = string.Empty,
				MailAddress = string.Empty,
				IsLogicalDelete = false,
				GroupID01 = Guid.NewGuid(),
				GroupName01 = string.Empty
			};
			BindingContext = userInfo;
		}

		private async void getInitData()
		{
			//Config.jsonファイル内容取得
			var ca = new ConfigAccessor();
			var configFileData = await ca.readAsync();
			//ファイル内容取得不可：空のInformationOfUserクラスを返す
			//ファイル内容取得可：InformationOfUserクラス型のファイル内容を返す
			if (configFileData == null)
			{
				userInfo = new InfomationOfUser
				{
					UserID = Guid.NewGuid(),
					NickName = string.Empty,
					MailAddress = string.Empty,
					IsLogicalDelete = false,
					GroupID01 = Guid.NewGuid(),
					GroupName01 = string.Empty
				};
			}
			else
			{
				userInfo = configFileData;
			}
		}

		public async void OnEditButtonClicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new ConfigEdit(userInfo));
		}
	}
}

