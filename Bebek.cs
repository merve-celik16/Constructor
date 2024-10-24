using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    public class Bebek
    {
        //properties
        public string Ad { get; set; }
        public string Soyadi { get; set; }
        public DateTime DogumTarihi { get; set; }

   
        public Bebek()      //Parametre almayan constructor
        {
            DogumTarihi = DateTime.Now; // Şuan ki tarihi ve zamanı getirir.
            Console.WriteLine("Ingaaaaaaa !!! ");
        }
        public Bebek(string _ad,string _soyadi) // parametre alan constructor
        {
            Ad= _ad;
            Soyadi= _soyadi;
            DogumTarihi = DateTime.Now;
            Console.WriteLine("Ingaaaaaaa !! ");


        }
        
    }
}
