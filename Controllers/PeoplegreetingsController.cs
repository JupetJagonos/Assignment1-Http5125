using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_N01588784.Controllers
{
    [Route("api/Greeting/{value}")]

//Assignment1 Question4
//Returns the string "Greetings to {id} people!" id is an integer value
    public class PeoplegreetingsController : ApiController
    {
        public string Get(int value)
        {
            return "Greetings to " + value + " people!";
        }
    }
}
