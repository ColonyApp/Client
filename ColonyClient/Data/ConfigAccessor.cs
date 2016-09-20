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

		public async Task<bool> writeAsync(InfomationOfUser target)
		{
			var contents = JsonConvert.SerializeObject(transrate2JSONInformationOfUser(target));
			var storage = new StorageAccessor(_fileName);
			return await storage.WriteAsync(contents);
		}

		public async Task<InfomationOfUser> readAsync()
		{
			var returnValue = new InfomationOfUser();
			var storage = new StorageAccessor(_fileName);
			var readData = await storage.ReadAsync();
			if (!string.IsNullOrEmpty(readData))
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

