using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleBusinessLib
{
    public class Insan
    {
        private int _id = 0;
        private string _adi = string.Empty;
        private string _soyadi = string.Empty;
        private DateTime _dogumTarihi;
        private string _dogumYeri;
        private int _boy;
        private int _kilo;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        
        public string Adi
        {
            get { return _adi; }
            set { _adi = value; }
        }
        
        public string Soyadi
        {
            get { return _soyadi; }
            set { _soyadi = value; }
        }
        
        public DateTime DogumTarihi
        {
            get { return _dogumTarihi; }
            set { _dogumTarihi = value; }
        }
        
        public string DogumYeri
        {
            get { return _dogumYeri; }
            set { _dogumYeri = value; }
        }
        
        public int Boy
        {
            get { return _boy; }
            set { _boy = value; }
        }
       
        public int Kilo
        {
            get { return _kilo; }
            set { _kilo = value; }
        }

        public int Yas
        { 
            get { return (int)( DateTime.Now - DogumTarihi).TotalDays/365; } 
        }



    }
}
