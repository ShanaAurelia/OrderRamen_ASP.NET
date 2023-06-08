using PSD_LAB_PROJECT.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSD_LAB_PROJECT.Factory
{
    public class RamenFactory
    {
        public static Raman CreateRamenFactory(string name, int meatid, string broth, string price)
        {
            Raman ramen = new Raman();
            ramen.Name = name;
            ramen.MeatId = meatid;
            ramen.Broth = broth;
            ramen.Price = price;
            return ramen;
        }
    }
}