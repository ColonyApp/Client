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
			BindingContext = userInfo;
		}

		public void OnSubmitClicked(object sender, EventArgs e)
		{
		}
	}
}

