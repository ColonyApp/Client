using System;
using System.Threading.Tasks;

namespace ColonyClient
{
	public interface IApplicationProperties
	{
		void SetValue<T>(T value) where T : class;

		T GetValue<T>() where T : class;

		bool initilize();

		Task<bool> LoadAsync();

		Task<bool> SaveAsync();
	}
}
