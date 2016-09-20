using System;
using System.Threading.Tasks;
using System.Collections.Generic;


namespace ColonyClient
{
	public class DataManeger
	{
		/// <summary>
		/// The SOAP service.
		/// </summary>
		ISoapService soapService;
		/// <summary>
		/// Initializes a new instance of the <see cref="T:ColonyClient.DataManeger"/> class.
		/// </summary>
		/// <param name="service">Service.</param>
		public DataManeger(ISoapService service)
		{
			soapService = service;
		}
		/// <summary>
		/// Hellos the world async.
		/// </summary>
		/// <returns>The world async.</returns>
		public Task<string> HelloWorldAsync()
		{
			return soapService.HelloWorldAsync();
		}
		/// <summary>
		/// Creates the data async.
		/// </summary>
		/// <returns>The data async.</returns>
		/// <param name="nickName">Nick name.</param>
		/// <param name="mailAddress">Mail address.</param>
		/// <param name="mode">Mode.</param>
		/// <param name="whatAttribute">What attribute.</param>
		/// <param name="whenAttribute">When attribute.</param>
		/// <param name="whyAttribute">Why attribute.</param>
		/// <param name="whoAttribute">Who attribute.</param>
		/// <param name="whereAttribute">Where attribute.</param>
		/// <param name="whomAttribute">Whom attribute.</param>
		/// <param name="howAttribute">How attribute.</param>
		/// <param name="howMuchAttribute">How much attribute.</param>
		/// <param name="howManyAttribute">How many attribute.</param>
		public Task<bool> CreateDataAsync(string nickName, string mailAddress, int mode, string whatAttribute, System.DateTime whenAttribute, string whyAttribute, string whoAttribute, string whereAttribute, string whomAttribute, string howAttribute, decimal howMuchAttribute, decimal howManyAttribute)
		{
			return soapService.CreateDataAsync(nickName, mailAddress, mode, whatAttribute, whenAttribute, whyAttribute, whoAttribute, whereAttribute, whomAttribute, howAttribute, howMuchAttribute, howManyAttribute);
		}
		/// <summary>
		/// Creates the group async.
		/// </summary>
		/// <returns>The group async.</returns>
		/// <param name="number">Number.</param>
		/// <param name="groupName">Group name.</param>
		/// <param name="nickName">Nick name.</param>
		/// <param name="mailAddress">Mail address.</param>
		public Task<bool> CreateGroupAsync(int number, string groupName, string nickName, string mailAddress)
		{
			return soapService.CreateGroupAsync(number, groupName, nickName, mailAddress);
		}
		/// <summary>
		/// Creates the user async.
		/// </summary>
		/// <returns>The user async.</returns>
		/// <param name="nickName">Nick name.</param>
		/// <param name="mailAddress">Mail address.</param>
		public Task<bool> CreateUserAsync(string nickName, string mailAddress)
		{
			return soapService.CreateUserAsync(nickName, mailAddress);
		}
		/// <summary>
		/// Hases the user by identifier async.
		/// </summary>
		/// <returns>The user by identifier async.</returns>
		/// <param name="UserId">User identifier.</param>
		public Task<bool> HasUserByIdAsync(Guid UserId)
		{
			return soapService.HasUserByIdAsync(UserId);
		}
		/// <summary>
		/// Hases the user without identifier async.
		/// </summary>
		/// <returns>The user without identifier async.</returns>
		/// <param name="nickName">Nick name.</param>
		/// <param name="mailAddress">Mail address.</param>
		public Task<bool> HasUserWithoutIdAsync(string nickName, string mailAddress)
		{
			return soapService.HasUserWithoutIdAsync(nickName, mailAddress);
		}
		/// <summary>
		/// Modifies the data async.
		/// </summary>
		/// <returns>The data async.</returns>
		/// <param name="nickName">Nick name.</param>
		/// <param name="mailAddress">Mail address.</param>
		/// <param name="mode">Mode.</param>
		/// <param name="whatAttribute">What attribute.</param>
		/// <param name="occurrenceDateTime">Occurrence date time.</param>
		/// <param name="whenAttribute">When attribute.</param>
		/// <param name="whyAttribute">Why attribute.</param>
		/// <param name="whoAttribute">Who attribute.</param>
		/// <param name="whereAttribute">Where attribute.</param>
		/// <param name="whomAttribute">Whom attribute.</param>
		/// <param name="howAttribute">How attribute.</param>
		/// <param name="howMuchAttribute">How much attribute.</param>
		/// <param name="howManyAttribute">How many attribute.</param>
		/// <param name="targetDataId">Target data identifier.</param>
		/// <param name="isLogicalDelete">If set to <c>true</c> is logical delete.</param>
		public Task<bool> ModifyDataAsync(string nickName, string mailAddress, string mode, string whatAttribute, System.DateTime occurrenceDateTime, System.DateTime whenAttribute, string whyAttribute, string whoAttribute, string whereAttribute, string whomAttribute, string howAttribute, decimal howMuchAttribute, decimal howManyAttribute, System.Guid targetDataId, bool isLogicalDelete)
		{
			return soapService.ModifyDataAsync(nickName, mailAddress, mode, whatAttribute, occurrenceDateTime, whenAttribute, whyAttribute, whoAttribute, whereAttribute, whomAttribute, howAttribute, howMuchAttribute, howManyAttribute, targetDataId, isLogicalDelete);
		}
		/// <summary>
		/// Modifies the group async.
		/// </summary>
		/// <returns>The group async.</returns>
		/// <param name="number">Number.</param>
		/// <param name="oldGroupName">Old group name.</param>
		/// <param name="newGroupName">New group name.</param>
		/// <param name="nickName">Nick name.</param>
		/// <param name="mailAddress">Mail address.</param>
		public Task<bool> ModifyGroupAsync(int number, string oldGroupName, string newGroupName, string nickName, string mailAddress)
		{
			return soapService.ModifyGroupAsync(number, oldGroupName, newGroupName, nickName, mailAddress);
		}
		/// <summary>
		/// Modifies the user async.
		/// </summary>
		/// <returns>The user async.</returns>
		/// <param name="oldNickName">Old nick name.</param>
		/// <param name="newNickName">New nick name.</param>
		/// <param name="oldMailAddress">Old mail address.</param>
		/// <param name="newMailAddress">New mail address.</param>
		/// <param name="UserId">User identifier.</param>
		public Task<bool> ModifyUserAsync(string oldNickName, string newNickName, string oldMailAddress, string newMailAddress, Guid UserId)
		{
			return soapService.ModifyUserAsync(oldNickName, newNickName, oldMailAddress, newMailAddress, UserId);
		}
		/// <summary>
		/// Searchs the target data by identifier async.
		/// </summary>
		/// <returns>The target data by identifier async.</returns>
		/// <param name="nickName">Nick name.</param>
		/// <param name="mailAddress">Mail address.</param>
		/// <param name="targetDataId">Target data identifier.</param>
		public Task<List<TargetData>> SearchTargetDataByIdAsync(string nickName, string mailAddress, System.Guid targetDataId)
		{
			return soapService.SearchTargetDataByIdAsync(nickName, mailAddress, targetDataId);
		}
		/// <summary>
		/// Searchs the target data detail async.
		/// </summary>
		/// <returns>The target data detail async.</returns>
		/// <param name="nickName">Nick name.</param>
		/// <param name="mailAddress">Mail address.</param>
		/// <param name="mode">Mode.</param>
		/// <param name="whatAttribute">What attribute.</param>
		/// <param name="occurrenceDateTime">Occurrence date time.</param>
		/// <param name="whenAttribute">When attribute.</param>
		/// <param name="whyAttribute">Why attribute.</param>
		/// <param name="whoAttribute">Who attribute.</param>
		/// <param name="whereAttribute">Where attribute.</param>
		/// <param name="whomAttribute">Whom attribute.</param>
		/// <param name="howAttribute">How attribute.</param>
		/// <param name="howMuchAttribute">How much attribute.</param>
		/// <param name="howManyAttribute">How many attribute.</param>
		public Task<List<TargetData>> SearchTargetDataDetailAsync(string nickName, string mailAddress, string mode, string whatAttribute, System.DateTime occurrenceDateTime, System.DateTime whenAttribute, string whyAttribute, string whoAttribute, string whereAttribute, string whomAttribute, string howAttribute, decimal howMuchAttribute, decimal howManyAttribute)
		{
			return soapService.SearchTargetDataDetailAsync(nickName, mailAddress, mode, whatAttribute, occurrenceDateTime, whenAttribute, whyAttribute, whoAttribute, whereAttribute, whomAttribute, howAttribute, howMuchAttribute, howManyAttribute);
		}
		/// <summary>
		/// Searchs the target data general async.
		/// </summary>
		/// <returns>The target data general async.</returns>
		/// <param name="mode">Mode.</param>
		/// <param name="condition">Condition.</param>
		public Task<List<TargetData>> SearchTargetDataGeneralAsync(string mode, string condition)
		{
			return soapService.SearchTargetDataGeneralAsync(mode, condition);
		}
		/// <summary>
		/// Searchs the user data async.
		/// </summary>
		/// <returns>The user data async.</returns>
		/// <param name="nickName">Nick name.</param>
		/// <param name="mailAddress">Mail address.</param>
		public Task<InfomationOfUser> SearchUserDataAsync(string nickName, string mailAddress)
		{
			return soapService.SearchUserDataAsync(nickName, mailAddress);
		}
	}
}
