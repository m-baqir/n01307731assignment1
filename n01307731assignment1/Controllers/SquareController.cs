using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01307731assignment1.Controllers
{//GET http://localhost/api/Square/{id}
 //<summary>this method squares an input integer</summary>
 //<parameters>int id*id returns new int value</parameters>
 //<example>input id = 10 returns 100</example>
    public class SquareController : ApiController
    {
        public int Get(int id)
        {
            return id * id;
        }
    }
}
