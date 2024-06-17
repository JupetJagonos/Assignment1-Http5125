using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Web.Http;

namespace Assignment1_N01588784.Controllers
{
    [Route ("api/AddTen/{id}")]
    //Assignment1 Question1 : Return 10 More than the integer input {id}
    public class AddTenController : ApiController
    {
        
        public int Get(int id)
        {
            id = id + 10;
            return id;

        }

    }
}

