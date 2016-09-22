using Xamarin.Forms;
using Microsoft.Practices.Unity;

namespace ColonyClient
{
	public partial class App : Application
	{
		public IApplicationProperties sessionRepository = null;
		public static UnityContainer Container = new UnityContainer();
		public static DataManeger DataManeger { get; set; }
		public App()
		{
			InitializeComponent();

			//MainPage = new ColonyClientPage();
			MainPage = new TabbedMainPage();

			Container.RegisterType<IApplicationProperties, ApplicationProperties>(new ContainerControlledLifetimeManager());
			this.sessionRepository = Container.Resolve<IApplicationProperties>();
			this.sessionRepository.initilize();
		}

		protected override async void OnStart()
		{
			await this.sessionRepository.LoadAsync();
			var vm = this.sessionRepository.GetValue<ViewModelTabbedMainPage>();
			if (vm != null)
			{
				this.MainPage.BindingContext = vm;
			}
			else
			{
				this.MainPage.BindingContext = new ViewModelTabbedMainPage();
				this.sessionRepository.SetValue<ViewModelTabbedMainPage>(this.MainPage.BindingContext as ViewModelTabbedMainPage);
				await this.sessionRepository.SaveAsync();
			}
 		}

		protected override void OnSleep()
		{
		}

		protected override async void OnResume()
		{
			this.sessionRepository = Container.Resolve<IApplicationProperties>();
			await this.sessionRepository.LoadAsync();
			var vm = this.sessionRepository.GetValue<ViewModelTabbedMainPage>();

			if (vm != null)
			{
				this.MainPage.BindingContext = vm;
			}
		}
	}
}

