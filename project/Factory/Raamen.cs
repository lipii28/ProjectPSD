using project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace project.Factory
{
    public class Raamen
    {
        public static ramen ramen(int meatid, string name, string borth, string price)
        {
            ramen ramen = new ramen();
            ramen.meatId = meatid;
            ramen.ramenName = name;
            ramen.ramenBorth = borth;
            ramen.ramenPrice = price;

            return ramen;


        }
    }
}