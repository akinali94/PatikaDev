using System.Collections.Generic;
using System.Collections;

namespace _19_ArrayLists;
class Program
{
    static void Main(string[] args)
    {
        //ArrayList'ler bir koleksiyon tipi, birden fazla veri tipini içinde barındırabilir.
        //Dinamik olarak veri atabilirsiniz.
        //System.Collesctions namespace'i altında.

        ArrayList liste = new ArrayList();
        
        //Eleman atama
        liste.Add("Ayşe");
        liste.Add(2);
        liste.Add(true);
        liste.Add('A');

        //İçersindeki verilere erişim
        Console.WriteLine(liste[1]);

        foreach(var item in liste)
            Console.WriteLine(item);

        //AddRange -> birden fazla elemanı aynı anda eklemek.
        Console.WriteLine("*******AddRange******");
        string[] renkler = {"kirmizi", "sari", "yesil"};
        List<int> sayilar = new List<int>(){1,3,5,7,9,92,5};
        
        //ArrayList içerisine list ve array eklerken bile problem çıkartmıyor.
        liste.AddRange(renkler);
        liste.AddRange(sayilar);

        foreach(var item in liste)
            Console.WriteLine(item);

        //Sort --> ArrayList'lere bu kadar farklı eleman atamamızda sıkıntı, sort'ta karşımıza çıkacak
        //Compile time'da hata vermezken, runtime'da patlayacaktır. ArrayList'in riskli taraflarından biri.
        //liste.Sort(); //Sadece belirli bir tip içinde olursa, sort'u kullanabiliriz.

        //Binary Search --> kullanabilmek için listenin, arrayList'in sıralanmış olması gerekmektedir. Aradığımız değerin indeksini getirir.
        ArrayList listeSirali = new ArrayList();
        listeSirali.Add(1);
        listeSirali.Add(23);
        listeSirali.Add(12);
        listeSirali.Add(9);
        listeSirali.Sort();
        Console.WriteLine($"Binary Search indeksi: {listeSirali.BinarySearch(9)} ");

        //Reverse --> mirror hale getiriyor.
        listeSirali.Reverse();
        foreach(var item in listeSirali)
            System.Console.WriteLine(item);

        //Clean --> ArrayList'i temizler.
        listeSirali.Clear();
    }
}
