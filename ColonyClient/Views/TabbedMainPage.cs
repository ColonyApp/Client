using System;
using Xamarin.Forms;

namespace ColonyClient
{
	public class TabbedMainPage : TabbedPage
	{
		#region Default Constractor
		public TabbedMainPage()
		{
			this.Title = Const.THIS_APP_NAME;

			#region Create "CONFIG_GENERAL" XAML PAGE
			var _configGeneral = new NavigationPage(new ConfigGeneral());
			_configGeneral.Title = Const.CONFIG_GENERAL_XAML;
			_configGeneral.Icon = Const.CONFIG_GENERAL_ICON;
			#endregion

			#region Create "SEARCH_CONDITION" XAML PAGE
			var _searchCondition = new NavigationPage(new SearchCondition());
			_searchCondition.Title = Const.SEARCH_CONDITION_XAML;
			_searchCondition.Icon = Const.SEARCH_CONDITION_ICON;
			#endregion

			#region Create "WANT" XAML PAGE
			var _want = new NavigationPage(new Want());
			_want.Title = Const.WANT_XAML;
			_want.Icon = Const.WANT_ICON;
			#endregion

			#region Create "GIVE" XAML PAGE
			var _give = new NavigationPage(new Give());
			_give.Title = Const.GIVE_XAML;
			_give.Icon = Const.GIVE_ICON;
			#endregion

			#region Add NavigationPages
			this.Children.Add(_configGeneral);
			this.Children.Add(_searchCondition);
			this.Children.Add(_want);
			this.Children.Add(_give);
			#endregion
		}
		#endregion
	}
}