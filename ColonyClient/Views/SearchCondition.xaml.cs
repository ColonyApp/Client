using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ColonyClient
{
	public partial class SearchCondition : ContentPage
	{
		public SearchCondition()
		{
			InitializeComponent();
		}

		public async void SearchDetailButtonClicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new SearchConditionDetail());
		}

		public async void SearchButtonClicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new SearchResult());
		}
	}
}

