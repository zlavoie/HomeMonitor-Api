using System;
using Monitor.Data.Entities;

namespace Monitor.Data.Repositories.Interfaces
{
	public interface IReminderRepository
	{
        Task<int> AddAsync(Reminder reminder);

        Task<Reminder> GetAsync(int reminderId);
    }
}

