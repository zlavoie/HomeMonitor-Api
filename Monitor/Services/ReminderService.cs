using System;
using Monitor.Data.DTOs;
using Monitor.Data.Entities;
using Monitor.Data.Repositories.Interfaces;
using Monitor.Services.Interfaces;

namespace Monitor.Services
{
	public class ReminderService : IReminderService
	{
		private IReminderRepository _reminderRepository;

		public ReminderService(
			IReminderRepository reminderRepository
		)
		{
			_reminderRepository = reminderRepository;
		}

        public async Task<int> CreateAsync(ReminderDto reminderDto)
        {
            var reminderEntity = new Reminder()
            {

            };

            int reminderId = await _reminderRepository.AddAsync(reminderEntity);

            Reminder createdReminder = await _reminderRepository.GetAsync(reminderId);

            return createdReminder.ReminderId;
        }

        public async Task<ReminderDto> GetAsync(int reminderId)
        {
            Reminder reminder = await _reminderRepository.GetAsync(reminderId);

            var reminderDto = new ReminderDto()
            {

            };

            return reminderDto;
        }

        public async Task<ReminderDto> PatchAsync(ReminderDto reminderDto)
        {
            Reminder reminder = await _reminderRepository.GetAsync(reminderDto.ReminderId);

            await _reminderRepository.PatchAsync(reminderDto);



            var reminderDto = new ReminderDto()
            {

            };

            return reminderDto;
        }
    }
}

