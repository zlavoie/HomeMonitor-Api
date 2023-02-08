using System;
using Monitor.Data.Entities;
using Monitor.Data.Repositories.Interfaces;

namespace Monitor.Data.Repositories
{
	public class ReminderRepository : IReminderRepository
	{
		public async Task<int> AddAsync(Reminder reminder)
		{

		}

        public async Task<Reminder> GetAsync(int reminderId)
        {

        }

        public async Task<Reminder> PatchAsync(Reminder reminder)
        {

        }
    }
}

