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
            return db.ramen1.Select(ramen => new
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
            ramen ramen = db.ramen1.Find(Id);
            ramen.ramenName = ramenName;
            ramen.ramenBorth = ramenBroth;
            ramen.ramenPrice = ramenPrice;
        }
    }
}