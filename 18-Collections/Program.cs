namespace _18_Collections;
class Program
{
    static void Main(string[] args)
    {
        //Koleksiyonlar: List, ArrayList, Dictionary, HashTable, Queue, Stack

        //List syntaxı: List<T> class
        //System.Collections.Generic

        //T-> object türündedir. Liste içerisindeki nesnelerin tipini gösterir.

        List<int> sayiListesi = new List<int>();

        sayiListesi.Add(23);
        sayiListesi.Add(5);
        sayiListesi.Add(12);
        sayiListesi.Add(43);
        sayiListesi.Add(77);

        List<string> renkListesi = new List<string>();
        renkListesi.Add("Mavi");
        renkListesi.Add("Turuncu");
        renkListesi.Add("Sarı");
        renkListesi.Add("Yeşil");
        renkListesi.Add("Kırmızı");

        //Liste içerisinde kaç tane eleman var: //Count
        Console.WriteLine(sayiListesi.Count);
        Console.WriteLine(renkListesi.Count);

        //Listelerin elemanlarını yazdırma
        foreach(var item in sayiListesi)
            Console.WriteLine(item);
        
        //Foreach'in farklı yazımı
        sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
        renkListesi.ForEach(sayi => Console.WriteLine(sayi));

        //Listeden Eleman çıkarma
        sayiListesi.Remove(5);
        renkListesi.Remove("Yeşil");

        foreach(var item in sayiListesi)
            Console.WriteLine(item);
        
        //Indeks ile çıkarma
        sayiListesi.RemoveAt(0);
        renkListesi.RemoveAt(1);

        //Liste içerisinde arama
        if(renkListesi.Contains("Sarı")) //elemanı bulup true atar.
            Console.WriteLine("Sarı Liste içerisinde bulundu");
        
        //Eleman ile indekse erişme
        Console.WriteLine(renkListesi.BinarySearch("Sarı"));

    }
}
