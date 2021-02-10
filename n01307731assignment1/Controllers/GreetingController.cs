using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01307731assignment1.Controllers
{//POST http://localhost/api/Greeting
 //<summary>this method returns string "Hello World!"</summary>
 //<parameters>single string</parameters>
 //<example>returns "Hello World!"</example>
    public class GreetingController : ApiController
    {
        public string Post()
        {
            return "Hello World!";
        }
        //GET http://localhost/api/Greeting/{id}
        //<summary>this method returns a string
        //“Greetings to {id} people!” where id is an integer value.</summary>
        //<parameters>single string</parameters>
        //<example>returns "Greeting to {id} people"</example>
        
        public string Get(int id)
        {
            return "Greeting to " + id.ToString() + " people.";
        }

    }
}
