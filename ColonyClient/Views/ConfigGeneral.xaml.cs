using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ColonyClient
{
	public partial class ConfigGeneral : ContentPage
	{
		public ConfigGeneral()
		{
			InitializeComponent();
			this.BindingContext = new ViewModelConfigGeneral(this.Navigation);
		}
	}
}

