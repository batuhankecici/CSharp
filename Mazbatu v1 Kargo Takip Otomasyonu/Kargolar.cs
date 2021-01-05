using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazBatu_v1_Kargo_Takip_Otomasyonu
{
    class Kargolar
    {
        int iKargoNumara;

        public int IKargoNumara
        {
            get { return iKargoNumara; }
            set { iKargoNumara = value; }
        }
        string sKargoVarisYer;

        public string SKargoVarisYer
        {
            get { return sKargoVarisYer; }
            set { sKargoVarisYer = value; }
        }
        string sKargoCikisYer;

        public string SKargoCikisYer
        {
            get { return sKargoCikisYer; }
            set { sKargoCikisYer = value; }
        }
        int iKargoUcreti;

        public int IKargoUcreti
        {
            get { return iKargoUcreti; }
            set { iKargoUcreti = value; }
        }
        string sKargoDurum;

        public string SKargoDurum
        {
            get { return sKargoDurum; }
            set { sKargoDurum = value; }
        }

        DateTime kargoCikisTarihi;

        public DateTime KargoCikisTarihi
        {
            get { return kargoCikisTarihi; }
            set { kargoCikisTarihi = value; }
        }
      






    }
}
