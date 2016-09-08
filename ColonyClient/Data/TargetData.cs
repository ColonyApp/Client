using System;
namespace ColonyClient
{
	public class TargetData
	{
		public InfomationOfUser UserInfo { get; set;}

		public Guid TargetDataId { get; set; }

		public int Mode { get; set; }

		public string Tags { get; set; }

		public DateTime? OccurrenceDataTime { get; set; }

		public string WhatAttribute { get; set; }

		public DateTime? WhenAttribute { get; set; }

		public string WhyAttribute { get; set; }

		public System.Guid WhoAttribute { get; set; }

		public string WhereAttribute { get; set; }

		public string WhomAttribute { get; set; }

		public string HowAttribute { get; set; }

		public decimal? HowMuchAttribute { get; set; }

		public decimal? HowManyAttribute { get; set; }
	}
}

