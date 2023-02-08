using System;
namespace Monitor.Data.Entities
{
	public record Reminder
	{
		// PK
		public int ReminderId { get; set; }

		public int FrequencyInMonths { get; set; }

        public string Name { get; set; }

        public string? RelatedItem { get; set; }

        public DateTime RemindOn { get; set; }

		public DateTime LastReminder { get; set; }

		// FKs
		public int UserId { get; set; }

		public int HouseholdId { get; set; }
	}
}

