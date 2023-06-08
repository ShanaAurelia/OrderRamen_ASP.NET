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

        public static List<RamenMenu> getRamenMenu()
        {
            DatabaseEntities db = new DatabaseEntities();
            List<RamenMenu> ramenMenus = (from ramen in db.Ramen
                                          join meats in db.Meats on ramen.MeatId equals meats.Id
                                          select new RamenMenu
                                          {
                                              Broth = ramen.Broth,
                                              Meat = ramen.Meat.name,
                                              Name = ramen.Name,
                                              Price = ramen.Price
                                          }).ToList();
            return ramenMenus;
        }

        public static void ramenDeleteRepo(int id)
        {
            DatabaseEntities db = new DatabaseEntities();
            Raman deletedRamen = db.Ramen.Find(id);
            db.Ramen.Remove(deletedRamen);
            db.SaveChanges();
        }

        public static void ramenEditingRepo(int id, string name, string meat, string broth, string price)
        {
            DatabaseEntities db = new DatabaseEntities();
            Raman editNewRamen = db.Ramen.Find(id);
            editNewRamen.Meat.name = meat;
            editNewRamen.Name = name;
            editNewRamen.Price = price;
            editNewRamen.Broth = broth;
            db.SaveChanges();
        }

        public static Raman checkRamen(string name)
        {
            DatabaseEntities db = new DatabaseEntities();
            Raman checkRamen = db.Ramen.Where((x) => x.Name.Equals(name)).FirstOrDefault();
            return checkRamen;
        }

        public static Raman checkRamenById(int id)
        {
            DatabaseEntities db = new DatabaseEntities();
            Raman ramen = db.Ramen.Find(id);
            return ramen;
        }
    }
}