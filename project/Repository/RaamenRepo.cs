using project.Factory;
using project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace project.Repository
{
    public class RaamenRepo
    {
        static mainDatabaseEntities1 db = new mainDatabaseEntities1();
        

        public static void Createramen(int meatid, string name, string borth, string price)
        {
            raman ramen = Raamen.ramen(meatid,name,borth,price);
            db.SaveChanges();
            return;
        }

        public static void Deleteramen(int meatid)
        {
            raman ramen = (from data in db.ramen where data.ramenId.Equals(meatid) select data).FirstOrDefault();
            db.ramen.Remove(ramen);
            db.SaveChanges();
            return;
        }

        public static void Updateramen(int meatid, string name, string borth, string price)
        {
            raman ramen = (from data in db.ramen where data.ramenId.Equals(meatid) select data).FirstOrDefault();

            if(meatid == null)
            {
                return;
            }

            ramen.meatId = meatid;
            ramen.ramenName = name;
            ramen.ramenBorth = borth;
            ramen.ramenPrice = price;

            db.SaveChanges();
            return;
        }


    }
}