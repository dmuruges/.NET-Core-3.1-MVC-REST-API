using System.Collections.Generic;
using Commander.Data.Interfaces;
using Commander.Models;

namespace Commander.Data 
{
    public class MockCommanderRepository : ICommanderRepository
    {
        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command> 
            {
                new Command {Id = 1, HowTo = "Boil and egg", Line="Boil water", Platform="Kettle & Pan"},
                new Command {Id = 2, HowTo = "Cut bread", Line="Get a knife", Platform="Knife & Chopping Board"},
                new Command {Id = 3, HowTo = "Make cup of tea", Line="Place a tea bag in a cup", Platform="Kettle & Cup"}
            };
            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command {Id = 1, HowTo = "Boil and egg", Line="Boil water", Platform="Kettle & Pan"};
        }
    }
}