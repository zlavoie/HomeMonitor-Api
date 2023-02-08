using System;
namespace Monitor.Data.DTOs
{
	public class ReminderDto
	{
		public int ReminderId { get; set; }

        public int FrequencyInMonths { get; set; }

        public string Name { get; set; }

        public string? RelatedItem { get; set; }

        public DateTime RemindOn { get; set; }

        public DateTime LastReminder { get; set; }

        public int UserId { get; set; }

        public int HouseholdId { get; set; }
    }
}

