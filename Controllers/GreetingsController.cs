using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Remoting.Messaging;
using System.Web.Http;

namespace Assignment1_N01588784.Controllers
{
    [Route("[Greetings")]
    //Assignment1 Question4
    //Return the string "Hello World!" === Greeting
    public class GreetingsController : ApiController
    {
        public string Post (string id)
        {
            return "Hello World!";
        }  
    }
}
