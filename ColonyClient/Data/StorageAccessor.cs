using System;
using PCLStorage;
using System.Threading.Tasks;


namespace ColonyClient
{
	public class StorageAccessor
	{
		public string FileName { get; private set;}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:ColonyClient.StorageAccessor"/> class.
		/// </summary>
		/// <param name="fileName">File name.</param>
		public StorageAccessor(string fileName)
		{
			FileName = fileName;
		}

		//public async Task<bool> WriteAsync(string contents)
		//{
		//	bool returnValue = false;
		//	try
		//	{
		//		IFolder rootFolder = FileSystem.Current.LocalStorage;
		//		IFile file = await rootFolder.CreateFileAsync(FileName, CreationCollisionOption.ReplaceExisting);
		//		await file.WriteAllTextAsync(contents);
		//		returnValue = true;
		//	}
		//	catch
		//	{
		//		returnValue = false;
		//	}
		//	return returnValue;
		//}

		//public async Task<string> ReadAsync()
		//{
		//	string returnValue = string.Empty;
		//	IFolder rootFolder = FileSystem.Current.LocalStorage;
		//	var res = await rootFolder.CheckExistsAsync(FileName);
		//	if (res == ExistenceCheckResult.FileExists)
		//	{
		//		IFile file = await rootFolder.GetFileAsync(FileName);
		//		returnValue = await file.ReadAllTextAsync();
		//	}
		//	else
		//	{
		//		throw new Exception("Couldn't read");
		//	}
		//	return returnValue;
		//}

		public async Task<bool> Save(string contents)
		{
			bool returnValue = false;
			try
			{
				IFolder rootFolder = FileSystem.Current.LocalStorage;
				IFile file = await rootFolder.CreateFileAsync(FileName, CreationCollisionOption.ReplaceExisting);
				await file.WriteAllTextAsync(contents);
				returnValue = true;
			}
			catch
			{
				returnValue = false;
				throw new Exception("Didn't Save!");
			}
			return returnValue;
		}
		public string Load()
		{
			try
			{
				IFolder rootFolder = FileSystem.Current.LocalStorage;
				IFile file = rootFolder.GetFileAsync(FileName).Result;
				return file.ReadAllTextAsync().Result;
			}
			catch
			{
				throw new Exception("Didn't Load!");
			}
		}

		public async Task<bool> CheckExistsFile()
		{
			var returnValue = false;
			IFolder rootFolder = FileSystem.Current.LocalStorage;
			var res = await rootFolder.CheckExistsAsync(FileName);
			if (res == ExistenceCheckResult.FileExists)
			{
				returnValue = true;
			}
			else
			{
				returnValue = false;
			}
			return returnValue;
		}
	}
}

