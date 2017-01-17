using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DepInDEmo.Services
{
    public class GreetingService : IGreetingService
    {
        public string GetGreeting()
        {
            return "Hello";
        }
    }
}