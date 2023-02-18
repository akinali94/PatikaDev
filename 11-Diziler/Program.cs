namespace _11_Diziler;
class Program
{
    static void Main(string[] args)
    {
        //Diziler

        /*Diziler nasıl tanımlanırDizilerin elemanlarına nasıl değer atanır, dizilerin elemanlarına nasıl erişilir
         *ve son olarak da döngüler ile nasıl kullanılır.
         *
         *Diziler, aynı tipte elemanlara sahiptir ve sıfırıncı elemandan başlamaktadır.
         */

        //Dizi Tanımlama
        string[] renkler = new string[5];

        string[] hayvanlar = {"Kedi", "Köpek", "Kuş", "Maymun"};

        int[] dizi;
        dizi = new int [5];

        //Dizilere değer atama ve erişim
        renkler[0] = "Mavi";
        dizi[3] = 10;

        Console.WriteLine(hayvanlar[1]);
        Console.WriteLine(dizi[3]);
        Console.WriteLine(renkler[0]);

        
        //Döngüler ile dizilerin kullanımı

        //Klavyeden girilen n tane sayının ortalamasını alan program.

        Console.Write("Dizinin eleman sayisini giriniz: ");
        int diziUzunlugu = int.Parse(Console.ReadLine());
        int[] sayiDizisi = new int[diziUzunlugu];

        for(int i = 0; i < diziUzunlugu; i++)
        {
            Console.Write($"Lütfen {i}. sayiyi giriniz: ");
            sayiDizisi[i] = int.Parse(Console.ReadLine());
        }

        int toplam = 0;
        foreach(var sayi in sayiDizisi)
            toplam += sayi;
        
        Console.WriteLine("Ortalama: " + toplam/diziUzunlugu);




    }
}
