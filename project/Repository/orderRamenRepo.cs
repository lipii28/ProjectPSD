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
        static mainDatabaseEntities1 db = new mainDatabaseEntities1();
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
            ramen Ramen = db.ramen1.Find(Id);
            Ramen.ramenName = ramenName;
            Ramen.meatNam
            Ramen.ramenBorth = ramenBroth;
            Ramen.ramenPrice = ramenPrice;
        }
    }
}