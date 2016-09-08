using System;
using Newtonsoft.Json;

namespace ColonyClient
{
	[JsonObject("JSONTargetData")]
	public class JSONTargetData
	{
		[JsonProperty("UserInfo")]
		public InfomationOfUser UserInfo { get; set; }

		[JsonProperty("TargetDataId")]
		public Guid TargetDataId { get; set; }

		[JsonProperty("Mode")]
		public int Mode { get; set; }

		[JsonProperty("Tags")]
		public string Tags { get; set; }

		[JsonProperty("OccurrenceDateTime")]
		public DateTime? OccurrenceDateTime { get; set; }

		[JsonProperty("WhatAttribute")]
		public string WhatAttribute { get; set; }

		[JsonProperty("WhenAttribute")]
		public DateTime? WhenAttribute { get; set; }

		[JsonProperty("WhyAttribute")]
		public string WhyAttribute { get; set; }

		[JsonProperty("WhoAttribute")]
		public System.Guid WhoAttribute { get; set; }

		[JsonProperty("WhenAttribute")]
		public string WhereAttribute { get; set; }

		[JsonProperty("WhomAttribute")]
		public string WhomAttribute { get; set; }

		[JsonProperty("HowAttribute")]
		public string HowAttribute { get; set; }

		[JsonProperty("HowMuchAttribute")]
		public decimal? HowMuchAttribute { get; set; }

		[JsonProperty("HowManyAttribute")]
		public decimal? HowManyAttribute { get; set; }
	}
}

