using System;
using System.Threading.Tasks;
using System.Collections.Generic;

/*
 * https://msdn.microsoft.com/ja-jp/library/hh873178(v=vs.110).aspx 
 */

namespace ColonyClient.iOS
{
	public class SoapService : ISoapService
	{
		/// <summary>
		/// The web service.
		/// </summary>
		colonywebservices.azurewebsites.net.ColonyWebService webService;
		/// <summary>
		/// Initializes a new instance of the <see cref="T:ColonyClient.iOS.SoapService"/> class.
		/// </summary>
		public SoapService()
		{
			webService = new colonywebservices.azurewebsites.net.ColonyWebService();
		}
		/// <summary>
		/// Tos the web service class infomation of user.
		/// </summary>
		/// <returns>The web service class infomation of user.</returns>
		/// <param name="item">Item.</param>
		colonywebservices.azurewebsites.net.InfomationOfUser ToWebServiceClassInfomationOfUser(InfomationOfUser item)
		{
			return new colonywebservices.azurewebsites.net.InfomationOfUser
			{
				UserID = item.UserID,
				NickName = item.NickName,
				MailAddress = item.MailAddress,
				IsLogicalDelete = item.IsLogicalDelete,
				GroupID01 = item.GroupID01,
				GroupName01 = item.GroupName01
			};
		}
		/// <summary>
		/// Froms the web service class infomation of user.
		/// </summary>
		/// <returns>The web service class infomation of user.</returns>
		/// <param name="item">Item.</param>
		InfomationOfUser FromWebServiceClassInfomationOfUser(colonywebservices.azurewebsites.net.InfomationOfUser item)
		{
			return new InfomationOfUser
			{
				UserID = item.UserID,
				NickName = item.NickName,
				MailAddress = item.MailAddress,
				IsLogicalDelete = item.IsLogicalDelete,
				GroupID01 = item.GroupID01,
				GroupName01 = item.GroupName01
			};
		}
		/// <summary>
		/// Tos the web service class target data.
		/// </summary>
		/// <returns>The web service class target data.</returns>
		/// <param name="item">Item.</param>
		colonywebservices.azurewebsites.net.TargetData ToWebServiceClassTargetData(TargetData item)
		{
			return new colonywebservices.azurewebsites.net.TargetData
			{
				UserInfo = ToWebServiceClassInfomationOfUser(item.UserInfo),
				TargetDataId = item.TargetDataId,
				Mode = item.Mode,
				Tags = item.Tags,
				OccurrenceDataTime = item.OccurrenceDataTime,
				WhatAttribute = item.WhatAttribute,
				WhenAttribute = item.WhenAttribute,
				WhyAttribute = item.WhyAttribute,
				WhoAttribute = item.WhoAttribute,
				WhereAttribute = item.WhereAttribute,
				WhomAttribute = item.WhomAttribute,
				HowAttribute = item.HowAttribute,
				HowMuchAttribute = item.HowMuchAttribute,
				HowManyAttribute = item.HowManyAttribute
			};
		}
		/// <summary>
		/// Froms the web service class targe data.
		/// </summary>
		/// <returns>The web service class targe data.</returns>
		/// <param name="item">Item.</param>
		TargetData FromWebServiceClassTargeData(colonywebservices.azurewebsites.net.TargetData item)
		{
			return new TargetData
			{
				UserInfo = FromWebServiceClassInfomationOfUser(item.UserInfo),
				TargetDataId = item.TargetDataId,
				Mode = item.Mode,
				Tags = item.Tags,
				OccurrenceDataTime = item.OccurrenceDataTime,
				WhatAttribute = item.WhatAttribute,
				WhenAttribute = item.WhenAttribute,
				WhyAttribute = item.WhyAttribute,
				WhoAttribute = item.WhoAttribute,
				WhereAttribute = item.WhereAttribute,
				WhomAttribute = item.WhomAttribute,
				HowAttribute = item.HowAttribute,
				HowMuchAttribute = item.HowMuchAttribute,
				HowManyAttribute = item.HowManyAttribute
			};
		}
		/// <summary>
		/// Hellos the world async.
		/// </summary>
		/// <returns>The world async.</returns>
		public Task<string> HelloWorldAsync()
		{
			var tcs = new TaskCompletionSource<string>();
			webService.HelloWorldCompleted += (sender, e) =>
			{
				if (e.Error != null)
				{
					tcs.TrySetException(e.Error);
				}
				else if (e.Cancelled)
				{
					tcs.TrySetCanceled();
				}
				else
				{
					tcs.TrySetResult(e.Result);
				}
			};
			webService.HelloWorldAsync();
			return tcs.Task;
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
			var tcs = new TaskCompletionSource<bool>();
			webService.CreateDataCompleted += (sender, e) =>
			{
				if (e.Error != null)
				{
					tcs.TrySetException(e.Error);
				}
				else if (e.Cancelled)
				{
					tcs.TrySetCanceled();
				}
				else
				{
					tcs.TrySetResult(e.Result);
				}
			};
			webService.CreateDataAsync(nickName, mailAddress, mode, whatAttribute, whenAttribute, whyAttribute, whoAttribute, whereAttribute, whomAttribute, howAttribute, howMuchAttribute, howManyAttribute);
			return tcs.Task;
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
			var tcs = new TaskCompletionSource<bool>();
			webService.CreateGroupCompleted += (sender, e) =>
			{
				if (e.Error != null)
				{
					tcs.TrySetException(e.Error);
				}
				else if (e.Cancelled)
				{
					tcs.TrySetCanceled();
				}
				else
				{
					tcs.TrySetResult(e.Result);
				}
			};
			webService.CreateGroupAsync(number, groupName, nickName, mailAddress);
			return tcs.Task;
		}
		/// <summary>
		/// Creates the user async.
		/// </summary>
		/// <returns>The user async.</returns>
		/// <param name="nickName">Nick name.</param>
		/// <param name="mailAddress">Mail address.</param>
		public Task<bool> CreateUserAsync(string nickName, string mailAddress)
		{
			var tcs = new TaskCompletionSource<bool>();
			webService.CreateUserCompleted += (sender, e) =>
			{
				if (e.Error != null)
				{
					tcs.TrySetException(e.Error);
				}
				else if (e.Cancelled)
				{
					tcs.TrySetCanceled();
				}
				else
				{
					tcs.TrySetResult(e.Result);
				}
			};
			webService.CreateUserAsync(nickName, mailAddress);
			return tcs.Task;
		}
		/// <summary>
		/// Hases the user by identifier async.
		/// </summary>
		/// <returns>The user by identifier async.</returns>
		/// <param name="UserId">User identifier.</param>
		public Task<bool> HasUserByIdAsync(Guid UserId)
		{
			var tcs = new TaskCompletionSource<bool>();
			webService.HasUserByIdCompleted += (sender, e) =>
			{
				if (e.Error != null)
				{
					tcs.TrySetException(e.Error);
				}
				else if (e.Cancelled)
				{
					tcs.TrySetCanceled();
				}
				else
				{
					tcs.TrySetResult(e.Result);
				}
			};
			webService.HasUserByIdAsync(UserId);
			return tcs.Task;
		}
		/// <summary>
		/// Hases the user without identifier async.
		/// </summary>
		/// <returns>The user without identifier async.</returns>
		/// <param name="nickName">Nick name.</param>
		/// <param name="mailAddress">Mail address.</param>
		public Task<bool> HasUserWithoutIdAsync(string nickName, string mailAddress)
		{
			var tcs = new TaskCompletionSource<bool>();
			webService.HasUserWithoutIdCompleted += (sender, e) =>
			{
				if (e.Error != null)
				{
					tcs.TrySetException(e.Error);
				}
				else if (e.Cancelled)
				{
					tcs.TrySetCanceled();
				}
				else
				{
					tcs.TrySetResult(e.Result);
				}
			};
			webService.HasUserWithoutIdAsync(nickName, mailAddress);
			return tcs.Task;
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
			var tcs = new TaskCompletionSource<bool>();
			webService.ModifyDataCompleted += (sender, e) =>
			{
				if (e.Error != null)
				{
					tcs.TrySetException(e.Error);
				}
				else if (e.Cancelled)
				{
					tcs.TrySetCanceled();
				}
				else
				{
					tcs.TrySetResult(e.Result);
				}
			};
			webService.ModifyDataAsync(nickName, mailAddress, mode, whatAttribute, occurrenceDateTime, whenAttribute, whyAttribute, whoAttribute, whereAttribute, whomAttribute, howAttribute, howMuchAttribute, howManyAttribute, targetDataId, isLogicalDelete);
			return tcs.Task;
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
			var tcs = new TaskCompletionSource<bool>();
			webService.ModifyGroupCompleted += (sender, e) =>
			{
				if (e.Error != null)
				{
					tcs.TrySetException(e.Error);
				}
				else if (e.Cancelled)
				{
					tcs.TrySetCanceled();
				}
				else
				{
					tcs.TrySetResult(e.Result);
				}
			};
			webService.ModifyGroupAsync(number, oldGroupName, newGroupName, nickName, mailAddress);
			return tcs.Task;
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
			var tcs = new TaskCompletionSource<bool>();
			webService.ModifyUserCompleted += (sender, e) =>
			{
				if (e.Error != null)
				{
					tcs.TrySetException(e.Error);
				}
				else if (e.Cancelled)
				{
					tcs.TrySetCanceled();
				}
				else
				{
					tcs.TrySetResult(e.Result);
				}
			};
			webService.ModifyUserAsync(oldNickName, newNickName, oldMailAddress, newMailAddress, UserId);
			return tcs.Task;
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
			var tcs = new TaskCompletionSource<List<TargetData>>();
			var items = new List<TargetData>();
			webService.SearchTargetDataByIdCompleted += (sender, e) =>
			{
				if (e.Error != null)
				{
					tcs.TrySetException(e.Error);
				}
				else if (e.Cancelled)
				{
					tcs.TrySetCanceled();
				}
				else
				{
					foreach (colonywebservices.azurewebsites.net.TargetData item in e.Result)
					{
						items.Add(FromWebServiceClassTargeData(item));
					}
					tcs.TrySetResult(items);
				}
			};
			webService.SearchTargetDataByIdAsync(nickName, mailAddress, targetDataId);
			return tcs.Task;
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
			var tcs = new TaskCompletionSource<List<TargetData>>();
			var items = new List<TargetData>();
			webService.SearchTargetDataDetailCompleted += (sender, e) =>
			{
				if (e.Error != null)
				{
					tcs.TrySetException(e.Error);
				}
				else if (e.Cancelled)
				{
					tcs.TrySetCanceled();
				}
				else
				{
					foreach (colonywebservices.azurewebsites.net.TargetData item in e.Result)
					{
						items.Add(FromWebServiceClassTargeData(item));
					}
					tcs.TrySetResult(items);
				}
			};
			webService.SearchTargetDataDetailAsync(nickName, mailAddress, mode, whatAttribute, occurrenceDateTime, whenAttribute, whyAttribute, whoAttribute, whereAttribute, whomAttribute, howAttribute, howMuchAttribute, howManyAttribute);
			return tcs.Task;
		}
		/// <summary>
		/// Searchs the target data general async.
		/// </summary>
		/// <returns>The target data general async.</returns>
		/// <param name="mode">Mode.</param>
		/// <param name="condition">Condition.</param>
		public Task<List<TargetData>> SearchTargetDataGeneralAsync(string mode, string condition)
		{
			var tcs = new TaskCompletionSource<List<TargetData>>();
			var items = new List<TargetData>();
			webService.SearchTargetDataGeneralCompleted += (sender, e) =>
			{
				if (e.Error != null)
				{
					tcs.TrySetException(e.Error);
				}
				else if (e.Cancelled)
				{
					tcs.TrySetCanceled();
				}
				else
				{
					foreach (colonywebservices.azurewebsites.net.TargetData item in e.Result)
					{
						items.Add(FromWebServiceClassTargeData(item));
					}
					tcs.TrySetResult(items);
				}
			};
			webService.SearchTargetDataGeneralAsync(mode, condition);
			return tcs.Task;
		}
		/// <summary>
		/// Searchs the user data async.
		/// </summary>
		/// <returns>The user data async.</returns>
		/// <param name="nickName">Nick name.</param>
		/// <param name="mailAddress">Mail address.</param>
		public Task<InfomationOfUser> SearchUserDataAsync(string nickName, string mailAddress)
		{
			var tcs = new TaskCompletionSource<InfomationOfUser>();
			webService.SearchUserDataCompleted += (sender, e) =>
			{
				if (e.Error != null)
				{
					tcs.TrySetException(e.Error);
				}
				else if (e.Cancelled)
				{
					tcs.TrySetCanceled();
				}
				else
				{
					tcs.TrySetResult(FromWebServiceClassInfomationOfUser(e.Result));
				}
			};
			webService.SearchUserDataAsync(nickName, mailAddress);
			return tcs.Task;
		}
	}
}

