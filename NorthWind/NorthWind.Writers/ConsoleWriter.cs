using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthWind.Entities.Interfaces;
using NorthWind.Entities.ValueObjects;

namespace NorthWind.Writers
{
    internal class ConsoleWriter : IUserActionWriter
    {
        public void Write(UserAction action) 
        { 
            Console.WriteLine("ConsoleWriter: {0}, {1}, {2}",
                action.CreatedDateTime, action.User, action.Description);
        }
    }
}
