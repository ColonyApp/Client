using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ColonyClient
{
	public partial class SearchConditionDetail : ContentPage
	{
		public SearchConditionDetail()
		{
			InitializeComponent();
		}

		public async void GoToSimpleSearchButtonClicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new SearchCondition());
		}

		public async void SearchButtonClicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new SearchResult());
		}
	}
}

