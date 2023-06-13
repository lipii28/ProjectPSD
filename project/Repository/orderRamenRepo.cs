using project.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace project.Repository
{
    public class orderRamenRepo
    {
        static DatabaseEntities db = new DatabaseEntities();
        public static List<Object> getRamen()
        {
            return db.ramen.Select(ramen => new
            {
                ramen.ramenId,
                ramen.ramenName,
                ramen.ramenBorth,
                ramen.ramenPrice,
                meatName = ramen.meat.meatName
            }).ToList<Object>();
        }
        public class Data
        {
            public string ramenName { get; set; }
            public string meatName { get; set; }
            public string ramenBroth { get; set; }
            public string ramenPrice { get; set; }
            public string quantity { get; set; }
        }

        public static void getRamen(int Id, string ramenName, string meatName, string ramenBroth, string ramenPrice)
        {
            raman ramen = db.ramen.Find(Id);
            ramen.ramenName = ramenName;
            meat = meatName;
            ramen.ramenBorth = ramenBroth;
            ramen.ramenPrice = ramenPrice;
        }
    }
}