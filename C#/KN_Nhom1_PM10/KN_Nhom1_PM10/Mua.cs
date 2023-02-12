using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KN_Nhom1_PM10
{
    internal class Mua
    {
        string _MaM;
        string _TenM;
        string _DiaChiM;
        string _SDTM;
        private string text;
        private object p;

        public Mua(string text, object p)
        {
            this.text = text;
            this.p = p;
        }

        public Mua(string MaM, string TenM, string DiaChiM, string SDTM)
        {
            _MaM = MaM;
            _TenM = TenM;
            _DiaChiM = DiaChiM;
            _SDTM = SDTM;
        }
        public string MaM { get => _MaM; set => _MaM = value; }
        public string TenM { get => _TenM; set => _TenM = value; }
        public string DiaChiM { get => _DiaChiM; set => _DiaChiM = value; }
        public string SDTM { get => _SDTM; set => _SDTM = value; }
        public void ADDMua(string TenM, string DiaChiM, string SDTM)
        {
            _TenM = TenM;
            _DiaChiM = DiaChiM;
            _SDTM = SDTM;
        }
        public string show()
        {
            return string.Format("{0}/{1}/{2}/{3}", MaM, TenM, DiaChiM, SDTM);
        }
    }
}
