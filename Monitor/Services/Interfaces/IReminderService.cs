using System;
using Monitor.Data.DTOs;

namespace Monitor.Services.Interfaces
{
	public interface IReminderService
	{
        Task<int> CreateAsync(ReminderDto reminderDto);
    }
}

