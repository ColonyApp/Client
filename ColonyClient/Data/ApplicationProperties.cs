using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ColonyClient
{
	public class ApplicationProperties : IApplicationProperties
	{
		public ApplicationProperties()
		{
		}

		public void SetValue<T>(T value) where T : class
		{
			App.Current.Properties[typeof(T).FullName] = value;
		}

		public T GetValue<T>() where T : class
		{
			if (!App.Current.Properties.ContainsKey(typeof(T).FullName))
			{
				return null;
			}
			return App.Current.Properties[typeof(T).FullName] as T;
		}

		public bool initilize()
		{
			try
			{
				App.Current.Properties.Clear();
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		public Task<bool> LoadAsync()
		{
			return Task.FromResult(true);
		}

		public Task<bool> SaveAsync()
		{
			return Task.FromResult(true);
		}
	}
}
