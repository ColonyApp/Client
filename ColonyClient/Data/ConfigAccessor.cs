using System;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ColonyClient
{
	public class ConfigAccessor
	{
		string _fileName;

		public ConfigAccessor()
		{
			_fileName = Const.FILE_NAME;
		}

		public bool writeAsync(InfomationOfUser target)
		{
			var contents = JsonConvert.SerializeObject(transrate2JSONInformationOfUser(target));
			var storage = new StorageAccessor(_fileName);
			return storage.Save(contents).Result;
			//return await storage.WriteAsync(contents);
		}

		public InfomationOfUser readAsync()
		{
			InfomationOfUser returnValue = null;
			var storage = new StorageAccessor(_fileName);
			//var readData = await storage.ReadAsync();
			var readData = storage.Load();
			if (!string.IsNullOrEmpty(readData) || !string.IsNullOrWhiteSpace(readData))
			{
				JSONInfomationOfUser content = JsonConvert.DeserializeObject<JSONInfomationOfUser>(readData);
				returnValue = transrate2InformationOfUser(content);
			}
			return returnValue;
		}

		public async Task<bool> IsExistConfigFile()
		{
			var storage = new StorageAccessor(_fileName);
			return await storage.CheckExistsFile();
		}

		private InfomationOfUser transrate2InformationOfUser(JSONInfomationOfUser target)
		{
			return new InfomationOfUser
			{
				UserID = target.UserID,
				NickName = target.NickName,
				MailAddress = target.MailAddress,
				IsLogicalDelete = target.IsLogicalDelete,
				GroupID01 = target.GroupID01,
				GroupName01 = target.GroupName01
			};
		}

		private JSONInfomationOfUser transrate2JSONInformationOfUser(InfomationOfUser target)
		{
			return new JSONInfomationOfUser
			{
				UserID = target.UserID,
				NickName = target.NickName,
				MailAddress = target.MailAddress,
				IsLogicalDelete = target.IsLogicalDelete,
				GroupID01 = target.GroupID01,
				GroupName01 = target.GroupName01
			};
		}
	}
}

