using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EdutronPortal.Models
{
    public static class Repository
    {
        private static List<EgitimTanim> egitimTanims=new List<EgitimTanim>();

        public static List<EgitimTanim> EgitimTanims
        {
            get
            {
                return egitimTanims;
            }
        }

        public static void AddEgitimTanimla(EgitimTanim egitim)
        {
            egitimTanims.Add(egitim);
        }
    }
}
