using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Access_Layer;

namespace LogicLayer
{
    public class LogicPersonel
    {
        public static List<EntityPersonel> LLPersonelList()
        {
            return DALPersonel.PersonelList();
        }

        public static int LLPersonelAdd(EntityPersonel p)
        {
            if (p.PersonelAd != "" && p.PersonelSoyad != "" && p.PersonelAd.Length >= 3 && p.PersonelSoyad.Length >= 3 && p.PersonelMaas > 3500 && p.PersonelSehir != "" && p.PersonelSehir.Length >= 3 && p.PersonelGorev != "" && p.PersonelGorev.Length >= 3)
            {
                return DALPersonel.PersonelAdd(p);
            }
            else
            {
                return -1;
            }
        }
    
        public static bool LLPersonelDelete(int p)
        {
            if (p >= 1)
            {
                return DALPersonel.PersonelDelete(p);
            }
            else
            {
                return false;
            }
        }

        public static bool LLPersonelUpdate(EntityPersonel ent)
        {
            if (ent.PersonelAd != "" && ent.PersonelSoyad != "" && ent.PersonelAd.Length >= 3 && ent.PersonelSoyad.Length >= 3 && ent.PersonelMaas > 3500 && ent.PersonelSehir != "" && ent.PersonelSehir.Length >= 3 && ent.PersonelGorev != "" && ent.PersonelGorev.Length >= 3 && ent.PersonelId != 0)
            {
                return DALPersonel.PersonelUpdate(ent);
            }
            else
            {
                return false;
            }
        }
    }
}
