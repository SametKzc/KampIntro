internal class Program
{
     static void Main(string[] args)
    {
        Urun urun1 = new Urun();
        urun1.UrunMarkasi = "Samsung";
        urun1.UrunAdi = "Telefon";
        urun1.UrunFiyati = 15000;

        Urun urun2 = new Urun();
        urun2.UrunMarkasi = "HP";
        urun2.UrunAdi = "Bilgisayar";
        urun2.UrunFiyati = 26800;

        Urun urun3 = new Urun();
        urun3.UrunMarkasi = "LG";
        urun3.UrunAdi = "Televizyon";
        urun3.UrunFiyati = 36000;

        Urun urun4 = new Urun();
        urun4.UrunMarkasi = "Arçelik";
        urun4.UrunAdi = "Buzdolabı";
        urun4.UrunFiyati = 19000;

        Urun[] urunler = new Urun[] {urun1, urun2, urun3, urun4 };
        //Foreach döngüsü ile ürünler dizisini listeleme
        foreach (var urun in urunler)
        {
            Console.WriteLine(urun.UrunMarkasi + " : " + urun.UrunAdi + " : " + urun.UrunFiyati);
        }

        //string[] urunler = new string[] { "Samsung Telefon: 15000 TL", "HP Bilgisayar: 26800 TL", "LG Televizyon: 36000 TL", "Arçelik Buzdolabı: 19000 TL"};
        //For döngüsü ile ürünler dizisini listeleme
        /* for (int i = 0; i < urunler.Length; i++)
         {
             Console.WriteLine(urunler[i]);      
         }*/
        //While Döngüsü ile ürünler dizisini listeleme
        /*int i = 0;
        while (i < urunler.Length)
        {
            Console.WriteLine(urunler[i]);
            i++;
        }*/
    }
    class Urun
    {
        public string UrunMarkasi { get; set; }
        public string UrunAdi { get; set; }
        public int UrunFiyati { get; set; }
    }
}