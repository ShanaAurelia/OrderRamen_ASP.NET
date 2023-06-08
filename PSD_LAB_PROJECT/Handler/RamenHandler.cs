using PSD_LAB_PROJECT.Model;
using PSD_LAB_PROJECT.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSD_LAB_PROJECT.Handler
{
    public class RamenHandler
    {
        public static Raman CreateRamenHandler(string name, int meatid, string broth, string price)
        {
            return RamenRepository.CreateRamenRepo(name, meatid, broth, price);
        }

        public static Meat GetMeatId(string meat)
        {
            return RamenRepository.getMeatId(meat);
        }

        public static List<RamenOutput> getRamenData()
        {
            return RamenRepository.getRamenData();
        }
    }
}