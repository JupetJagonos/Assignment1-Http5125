using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_N01588784.Controllers
{
    [Route("api/Square/{id}")]
    //Assignment1 Question2 : Return the Square(root) of the integer input {id}

    public class SquareController : ApiController
    {
            public int Get(int id)
            {
                id = id * id;
                return id;
            }
        }



}



