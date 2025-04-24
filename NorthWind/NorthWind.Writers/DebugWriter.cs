using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthWind.Entities.Interfaces;
using NorthWind.Entities.ValueObjects;

namespace NorthWind.Writers
{
    internal class DebugWriter : IUserActionWriter
    {
        public void Write(UserAction action)
        {
            Debug.WriteLine("DebugWriter: {0}, {1}, {2}",
                action.CreatedDateTime, action.User, action.Description);
        }
    }
}
