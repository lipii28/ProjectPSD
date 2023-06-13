using project.Factory;
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
        public static DatabaseEntities db = new DatabaseEntities();
        public static List<object> GetRamens()
        {
            var ramens = db.ramen1.ToList();
            var ramenObjects = ramens.Select(ramen => new
            {
                ramen.ramenId,
                ramen.ramenName,
                ramen.ramenBorth,
                ramen.ramenPrice,
                MeatName = ramen.meat.meatName
            }).Cast<object>().ToList();
            return ramenObjects;
        }

        public static void Createramen(int meatid, string name, string borth, string price)
        {
            ramen ramen = Raamen.ramen(meatid, name, borth, price);
            db.ramen1.Add(ramen);
            db.SaveChanges();
            return;
        }

        public static void Deleteramen(int meatid)
        {
            ramen ramen = (from data in db.ramen1 where data.ramenId.Equals(meatid) select data).FirstOrDefault();
            db.ramen1.Remove(ramen);
            db.SaveChanges();
            return;
        }

        public static void Updateramen(int meatid, string name, string borth, string price)
        {
            ramen ramen = (from data in db.ramen1 where data.ramenId.Equals(meatid) select data).FirstOrDefault();

            if (meatid == null)
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