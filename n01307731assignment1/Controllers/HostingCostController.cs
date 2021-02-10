using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01307731assignment1.Controllers
{//GET http://localhost/api/HostingCost/{id}
 //<summary>this method calculates the total cost for charging
 //client. they are being charged $5.50 / FN (fortnight = 14 days)
 //plus 13% hst. the method takes an input of number of days
 //and returns the total cost</summary>
 //<parameters>input int returns int after calculating</parameters>
 //<example>id = 6 returns 19</example>
    public class HostingCostController : ApiController
    {//<comment>i think i have the correct logic for this method but i have been
     //unable to get the code to function properly. The userinput is an int
     //but the formula used to calculate the final cost would return a new
     //value as double, decimal or float. during our lab discussion as a group
     //we figured out this method to calculate the final cost. costcalc=(userinput+1)/14
     //that new value [costcalc] would then get multiplied
     //by 5.5[cost per fortnight] and 1.13[hst]
     //the resulting [final] value should be the correct amount</comment>
        public double get(int userinput)
        {
            double costcalc = (userinput + 1) / 14;//a method we came up with in group disscussion of dealing with Fortnights and days
            Math.Ceiling(costcalc);//round up costcalc to nearest int
            double fn = costcalc * 5.5;
            double hst = fn * 0.13;
            double total = fn + hst;
            return {
                costcalc.Tostring() + " fortnights at $5.50/FN = " + fn.ToString() + " CAD";
                "HST 13% = $" + hst.ToString() + " CAD";
                "Total = S" + total.ToString() + " CAD";
            }
            //i have been unable to get the code to run as it is
            //i believe it has to do with the way c# deals with different
            //number types. i.e. int, double, float. the userinput is an int
            //but the final return value is a dollar amount so should be 2
            //decimal places. i did some google searching but wasnt able to
            //figure out how to manage the two number types in this case.
            //i am not sure how to deal with 2 number types in my formula
            //or how to display them correctly in the return function.
        }
    }
}
