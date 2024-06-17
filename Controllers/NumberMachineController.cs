using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_N01588784.Controllers
{
    [Route("api/NumberMachine/{id}")]
    //Assignment1 Question5
    //Create a method which has an input {id} and applies 4 Mathematical operations to it.
    public class NumberMachineController : ApiController
    {
        public int Get(int id)
        {
            int result = ((id + 5) * 2 / 3 - 7);
            return result;
        }
    }
}
//localhost/NumberMachine/10 ---> response = 3
//localhost/NumberMachine/-5 ---> response = -7
//localhost/NumberMachine/30 ---> response = 16