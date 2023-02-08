using Microsoft.AspNetCore.Mvc;
using Monitor.Data.DTOs;
using Monitor.Services.Interfaces;

namespace Monitor.Controllers;

[ApiController]
[Route("[controller]")]
public class ReminderController : ControllerBase
{
    private readonly ILogger<ReminderController> _logger;
    private readonly IReminderService _reminderService;

    public ReminderController(
        ILogger<ReminderController> logger,
        IReminderService reminderService
    )
    {
        _logger = logger;
        _reminderService = reminderService;
    }

    [HttpPost]
    public async Task<ActionResult<int>> CreateAsync(ReminderDto reminderDto)
    {
        if(reminderDto.Equals(null))
            return BadRequest();

        int reminderId = await _reminderService.CreateAsync(reminderDto);

        return Ok(reminderId);
    }

    //[HttpGet]
    //public async Task<ActionResult<ReminderDto>> Get(int reminderId)
    //{
    //    ReminderDto reminderDto = await _reminderService.Get(reminderDto);

    //    return Ok(reminderDto);
    //}
}

