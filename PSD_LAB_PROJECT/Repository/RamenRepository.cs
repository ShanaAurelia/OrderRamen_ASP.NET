using PSD_LAB_PROJECT.Factory;
using PSD_LAB_PROJECT.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSD_LAB_PROJECT.Repository
{
    public class RamenRepository
    {
        public static Raman CreateRamenRepo(string name, int meatid, string broth, string price)
        {
            DatabaseEntities db = new DatabaseEntities();
            Raman ramen = RamenFactory.CreateRamenFactory(name, meatid, broth, price);
            db.Ramen.Add(ramen);
            db.SaveChanges();
            return ramen;
        }

        public static Meat getMeatId(string meat)
        {
            DatabaseEntities db = new DatabaseEntities();
            return db.Meats.Where((x) => x.name.Equals(meat)).FirstOrDefault();
        }

        public static List<RamenOutput> getRamenData()
        {
            DatabaseEntities db = new DatabaseEntities();
            List<RamenOutput> ramenData = (from ramen in db.Ramen
                                           join meats in db.Meats on ramen.MeatId equals meats.Id
                                           select new RamenOutput
                                           {
                                               Id = ramen.Id,
                                               Broth = ramen.Broth,
                                               Meat = ramen.Meat.name,
                                               Name = ramen.Name,
                                               Price = ramen.Price
                                           }).ToList();
            return ramenData;
                                           
        }
    }
}