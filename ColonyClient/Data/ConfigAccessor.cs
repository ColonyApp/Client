using System;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ColonyClient
{
	public class ConfigAccessor
	{
		string fileName;
		public JSONInfomationOfUser UserInfo { get; set;}

		public ConfigAccessor()
		{
			fileName = Const.FILE_NAME;
		}

		public async Task<bool> write()
		{
			var contents = JsonConvert.SerializeObject(UserInfo);
			var storage = new StorageAccessor(fileName);
			return await storage.Write(contents);
		}

		public async Task<JSONInfomationOfUser> read()
		{
			var storage = new StorageAccessor(fileName);
			var readData = await storage.read();
			JSONInfomationOfUser returnValue = JsonConvert.DeserializeObject<JSONInfomationOfUser>(readData);
			return returnValue;
		}
	}
}

