namespace _20_Dictionary;
class Program
{
    static void Main(string[] args)
    {
        //Verileri, anahtar ve değer'ler ile tutarlar. Key and Value. 
        //Kullanırken key ve value'suna ayrı ayrı erişilebilir.
        //Daha kolay anlaşılması için, Array'leri düşünelim, bunların indeksini key, içindeki elemanları da value olarak düşünebiliriz. 
        //Key'ler unique olmak durumunda. Aynı iki key kullanınca Compile Time'da değil, ancak compile time'da sıkıntı çıkartacaktır.

        Dictionary<int, string> kullanicilar = new Dictionary<int, string>();
        kullanicilar.Add(10,"Ayşe Yilmaz");
        kullanicilar.Add(12,"Ahmet Yilmaz");
        kullanicilar.Add(18, "Deniz Arda");
        kullanicilar.Add(20,"Özcan Coşar");

        //Elemanlara erişim
        Console.WriteLine("****Elemanlara Erişim****");
        Console.WriteLine(kullanicilar[12]); //12 key'ine sahip elemanı getir.
        foreach(var item in kullanicilar)
            Console.WriteLine(item);

        //Count --> Eleman Sayısı
        Console.WriteLine("****Count****");
        Console.WriteLine(kullanicilar.Count);

        //Contains --> true/false verecek.
        Console.WriteLine("****Contains****");
        Console.WriteLine(kullanicilar.ContainsKey(12));
        Console.WriteLine(kullanicilar.ContainsValue("Zikriye Ürkmez"));

        //Aynı key'i eklemeye çalışalım.
        //kullanicilar.Add(12,"Ali Akin"); //Compile'da hata vermiyor, runtime'da verecek, büyük kodlarda risk barındırıyor.

        //Remove
        Console.WriteLine("****Remove****");
        kullanicilar.Remove(12);
        foreach(var item in kullanicilar)
            Console.WriteLine(item.Value); //Sadece value gösteriyor.

        //Keys ve Values ile erişim
        Console.WriteLine("****Keys****");
        foreach(var item in kullanicilar.Keys)
            Console.WriteLine(item);

        Console.WriteLine("****Values****");
        foreach(var item in kullanicilar.Values)
            Console.WriteLine(item);
    }
}
