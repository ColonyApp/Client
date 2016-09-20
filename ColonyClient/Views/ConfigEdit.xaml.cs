using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ColonyClient
{
	public partial class ConfigEdit : ContentPage
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="T:ColonyClient.ConfigEdit"/> class.
		/// </summary>
		public ConfigEdit()
		{
			InitializeComponent();
			this.BindingContext = new ViewModelConfigEdit();
		}
	}
}

