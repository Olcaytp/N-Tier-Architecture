using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityPersonel
    {
        private int _PersonelId;
        private string _PersonelAd;
        private string _PersonelSoyad;
        private string _PersonelSehir;
        private string _PersonelGorev;
        private short _PersonelMaas;

        public int PersonelId { get => _PersonelId; set => _PersonelId = value; }
        public string PersonelAd { get => _PersonelAd; set => _PersonelAd = value; }
        public string PersonelSoyad { get => _PersonelSoyad; set => _PersonelSoyad = value; }
        public string PersonelSehir { get => _PersonelSehir; set => _PersonelSehir = value; }
        public string PersonelGorev { get => _PersonelGorev; set => _PersonelGorev = value; }
        public short PersonelMaas { get => _PersonelMaas; set => _PersonelMaas = value; }
    }
}
