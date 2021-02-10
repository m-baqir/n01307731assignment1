using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01307731assignment1.Controllers
{//Get http://localhost/api/NumberMachine/{id}
 //<summary>this method returns a single int value after
 //applying 4 mathematical operations to a single input int</summary>
 //<parameters>int id returns a single int value</parameters>
 //<example>id = 6 returns 19</example>
    public class NumberMachineController : ApiController
    {
        public int Get(int id)
        {
            return (id / 2) * 5 + 6 - 2;
        }
    }
}
