namespace _13_MethodOverloading;
class Program
{
    static void Main(string[] args)
    {
        //Method Overloading ve Out parametresi

        //OUT parametresini konuşalım
        /* En çok kullanıdığımız yöntem TryParse;
        * Bir fonksiyona bir iş yaptırıp, ardından çıkan değeri de set'etmek istiyorsanız
        * ve sonrasında kullanmak istiyorsanız, out kullanıyoruz.
        * Altta bir örnek yazalım.
        */
        string sayi1 = "999"; //Bu sayıyı integer olarak kullanabilmek için Parse etmek gerekiyor.
                              //Ancak parse işlemi sırasında, başarılı veya başarısız olunabilir.
                              //Çeviremeyebilir bu string'i integer'a.
        int outSayi1;

        bool sonuc1 = int.TryParse(sayi1, out outSayi1); //outSayi1'i daha önce tanımlamasaydım "out int outSayi1" yazabilirdim.
                                                         //ilk argüman'da değeri veriyoruz, ikincisinde çıkan değeri istiyoruz.
                                                         //TryPart'ın sonucu boolean çıkıyor!
        if (sonuc1)
        {
            Console.WriteLine("Başarili!");
            Console.WriteLine(outSayi1);
        }
        else
        {
            Console.WriteLine("Başarisiz!");
        }

        Console.WriteLine("************************");

        //Altta bir class yazalım, Topla isimli.
        Metotlar instance1 = new Metotlar();

        instance1.Topla(3,5,out int toplaArgument);
        Console.WriteLine(toplaArgument); //ekstra içerdeki argümanı da yazdıralım.
        

        /*Metot Overloading -- Metotlar sınıfında iki adet aynı isimli ancak farklı metot signature'a
        * sahip metotlar tanımladık, buna metot overloading diyoruz.
        *
        * Method Signature --> metotAdi + parametre sayisi + parametre
        */
    }

    class Metotlar
    {
        public void Topla(int a, int b, out int toplaSonuc)
        {
            toplaSonuc = a+b;
            Console.WriteLine(toplaSonuc);

        }

        //Metot overloading yapalım

        public void EkranaYazdir(string veri1)
        {
            Console.WriteLine(veri1);
        }

        public void EkranaYazdir(string veri1, string veri2)
        {
            Console.WriteLine(veri1 + veri2);
        }
    }
}
