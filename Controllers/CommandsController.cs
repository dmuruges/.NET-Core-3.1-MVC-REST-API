using System.Collections.Generic;
using Commander.Data.Interfaces;
using Commander.Models;
using Microsoft.AspNetCore.Mvc;

namespace Commander.Controllers
{
    //api/Commands
    [Route("api/[controller]")]
    [ApiController]
    public class CommandsController : ControllerBase
    {

        private readonly ICommanderRepository _commanderRepository; 
        public CommandsController(ICommanderRepository commanderRepository)
        {
            _commanderRepository = commanderRepository;
        }
        //GET api/commands
        [HttpGet]
        public ActionResult<IEnumerable<Command>> GetAllCommands()
        {
            var commandItems = _commanderRepository.GetAppCommands();
            return Ok(commandItems);
        }

        //GET api/commands/5
        [HttpGet("{id}")]
        public ActionResult<Command> GetCommandById(int id)
        {
            var commandItem = _commanderRepository.GetCommandById(id);
            return Ok(commandItem);
        }
    }
}