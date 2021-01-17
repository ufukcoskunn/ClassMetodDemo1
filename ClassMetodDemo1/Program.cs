using System;

namespace ClassMetodDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.FirstAndLastName = "Ufuk Çağrı Coşkun";
            musteri1.Id = 1;
            musteri1.Age = 23;
            musteri1.TelNumber = 0507131313;

            Musteri musteri2 = new Musteri();
            musteri2.FirstAndLastName = "Akın  Coşkun";
            musteri2.Id = 2;
            musteri2.Age = 45;
            musteri2.TelNumber = 0505545454;

            Musteri musteri3 = new Musteri();
            musteri3.FirstAndLastName = "Sertap Coskun";
            musteri3.Id = 3;
            musteri3.Age = 40;
            musteri3.TelNumber = 0506505505;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            foreach (Musteri musteri in musteriler)
            {





            }

            Console.WriteLine("------------------------------------------");

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri3);
        }
    }
}
