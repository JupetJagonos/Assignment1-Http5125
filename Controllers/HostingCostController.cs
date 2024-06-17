using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_N01588784.Controllers
{
    [Route("api/HostingCost/{id:int}")]
    
    //Assignment1 Question6
    //Charging clinet $5.50/FN {fortnight = 14 days], add 13%HST.
    public class HostingCostController : ApiController
    {
        public int Get(int id);

        

        int Fortnights = ( "id" / 14) + 1;

        double hostingCost = Fortnights * 5.50;

        double hst = hostingCost + 0.13;

        double totalCost = hostingcost + hst;


        //stringResponses 
        string FortnightString = { Fortnights } fornights at $5.50/FN = {hostingCost.tostring("0.00")} CAD";
        string hstString = "HST 13% = {hst.tostring("0.00")} CAD";
        string totalString = "Total = {totalCost.Tostring ("0.00")} CAD"; 

        Return string[] { FortnightString , hstString , totalString };

    }
}
//My apologies I 