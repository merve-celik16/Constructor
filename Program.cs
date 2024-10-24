namespace Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Parametresiz constructor ile nesne oluşturma
            Bebek bebek1 = new Bebek();

            // Parametreli constructor ile nesne oluşturma
            Bebek bebek2 = new Bebek("Kerem", "ATAY");

            // Bebeklerin bilgilerini yazdırma
            Console.WriteLine($"Bebek 1:");
            Console.WriteLine($"Adı: {bebek1.Ad}");
            Console.WriteLine($"Soyadı: {bebek1.Soyadi}");
            Console.WriteLine($"Doğum Tarihi: {bebek1.DogumTarihi}");

            Console.WriteLine();

            Console.WriteLine($"Bebek 2:");
            Console.WriteLine($"Adı: {bebek2.Ad}");
            Console.WriteLine($"Soyadı: {bebek2.Soyadi}");
            Console.WriteLine($"Doğum Tarihi: {bebek2.DogumTarihi}");
        }
    }
}
