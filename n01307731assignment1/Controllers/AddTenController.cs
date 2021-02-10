using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01307731assignment1.Controllers
{
    public class AddTenController : ApiController
    {//GET http://localhost/api/AddTen/{id}
     //<summary>this method adds 10 to an input integer</summary>
     //<parameters>int id+10 returns new int value</parameters>
     //<example>input id = 10 returns 20</example>
        public int Get(int id)
        {
            return id+10;
        }

    }
}
