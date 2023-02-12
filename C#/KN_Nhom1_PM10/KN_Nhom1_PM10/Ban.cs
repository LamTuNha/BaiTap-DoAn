using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KN_Nhom1_PM10
{
    class Ban
    {
        string _MaB;
        string _TenB;
        string _DiaChiB;
        string _SDTB;
        private string text;
        private object p;
        public Ban(string MaB, string TenB, string DiaChiB, string SDTB)
        {
            _MaB = MaB;
            _TenB = TenB;
            _DiaChiB = DiaChiB;
            _SDTB = SDTB;
        }
        public string MaB { get => _MaB; set => _MaB = value; }
        public string TenB { get => _TenB; set => _TenB = value; }
        public string DiaChiB { get => _DiaChiB; set => _DiaChiB = value; }
        public string SDTB { get => _SDTB; set => _SDTB = value; }
        public void ADDBan(string TenB, string DiaChiB, string SDTB)
        {
            _TenB = TenB;
            _DiaChiB = DiaChiB;
            _SDTB = SDTB;
        }
       
    }
}
