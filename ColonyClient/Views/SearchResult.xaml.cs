using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using Xamarin.Forms;

namespace ColonyClient
{
	public partial class SearchResult : ContentPage
	{
		public SearchResult()
		{
			InitializeComponent();
		}

		void OnSelected(object sender, SelectedItemChangedEventArgs e)
		{
			if (e.SelectedItem == null)
			{
				return;
			}
		}

		void OnTapped(object sender, ItemTappedEventArgs e)
		{
		}

		void OnRefresh(object sender, EventArgs e)
		{
			var list = (ListView)sender;
		}

		async void OnWanted(object sender, ItemTappedEventArgs e)
		{
			await Navigation.PushAsync(new Want());
		}

		async void OnGot(object sender, ItemTappedEventArgs e)
		{
			await Navigation.PushAsync(new Get());
		}
	}
}

