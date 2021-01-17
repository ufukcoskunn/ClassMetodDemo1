using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetodDemo1
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {

            Console.WriteLine("Yeni bir müşteri eklediniz : " + musteri.FirstAndLastName + "/ Yaş; " + musteri.Age + "/ Id; " + musteri.Id + "/ Tel; " + musteri.TelNumber);

        }
    }
}
