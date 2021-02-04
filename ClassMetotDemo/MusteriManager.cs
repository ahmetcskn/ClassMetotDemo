using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void musteriEkle(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " Adlı kullanıcı sisteme eklendi. " + "Yaş : " + musteri.yas + " Numara : " + musteri.id );
        }

        public void musteriSil(Musteri musteri)
        {
            Console.WriteLine(musteri.id + " id'li kullanıcı sistemden silindi.");

        }
        public void musteriListele(Musteri musteri)
        {
            Console.WriteLine("Kullanıcı Adı : " + musteri.Ad + "\nKullanıcı Yaş : " + musteri.yas + "\nKullanıcı Id : " + musteri.id);
        }
    }
}
