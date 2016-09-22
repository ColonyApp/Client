using System;
using Xamarin.Forms;

namespace ColonyClient
{
	public class TabbedMainPage : TabbedPage
	{
		#region Default Constractor
		public TabbedMainPage()
		{
			var vm = new ViewModelTabbedMainPage();
			this.Title = Const.THIS_APP_NAME;
			this.BackgroundColor = Color.Black;
			this.BindingContext = vm;

			#region Create "CONFIG_GENERAL" XAML PAGE
			var configGeneral = new NavigationPage(new ConfigEdit(vm));
			configGeneral.Title = Const.CONFIG_GENERAL_XAML;
			configGeneral.Icon = Const.CONFIG_GENERAL_ICON;
			configGeneral.BarBackgroundColor = Color.Black;
			configGeneral.BarTextColor = Color.White;
			#endregion

			#region Create "SEARCH_CONDITION" XAML PAGE
			var searchCondition = new NavigationPage(new SearchCondition());
			searchCondition.Title = Const.SEARCH_CONDITION_XAML;
			searchCondition.Icon = Const.SEARCH_CONDITION_ICON;
			searchCondition.BarBackgroundColor = Color.Black;
			searchCondition.BarTextColor = Color.White;
			#endregion

			#region Create "WANT" XAML PAGE
			var want = new NavigationPage(new Want());
			want.Title = Const.WANT_XAML;
			want.Icon = Const.WANT_ICON;
			want.BarBackgroundColor = Color.Black;
			want.BarTextColor = Color.White;
			#endregion

			#region Create "GIVE" XAML PAGE
			var give = new NavigationPage(new Give());
			give.Title = Const.GIVE_XAML;
			give.Icon = Const.GIVE_ICON;
			give.BarBackgroundColor = Color.Black;
			give.BarTextColor = Color.White;
			#endregion

			#region Add NavigationPages
			this.Children.Add(configGeneral);
			this.Children.Add(searchCondition);
			this.Children.Add(want);
			this.Children.Add(give);
			#endregion
		}
		#endregion
	}
}