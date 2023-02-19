namespace _11_DizilerMetot;
class Program
{
    static void Main(string[] args)
    {
        //Array Sınıfı Metotları

        //Sort
        int[] sayiDizisi = {23, 12, 4, 65, 66, 21, 90, 23 };
        Console.WriteLine("*****Sirasiz Dizi******");
        foreach (var sayi in sayiDizisi)
        {
            Console.WriteLine(sayi);
        }
        
        Console.WriteLine("*****Sayisiz Dizi******");
        Array.Sort(sayiDizisi); //Doğrudan dizisi sıralayacak.

        foreach (var sayi in sayiDizisi)
        {
            Console.WriteLine(sayi);
        }

        //Clear
        Console.WriteLine("*****Array Clear******");
        Array.Clear(sayiDizisi,2,2); //önce array ister, sonra hangi index'ten başlayacağını, sonra da o indeksten sonraki uzunluğunu.
                                     //İkinci indeksten itibaren 2 tane elemanın değerini sıfır yapar.
        foreach (var sayi in sayiDizisi)
        {
            Console.WriteLine(sayi);
        }

        //Reverse
        Console.WriteLine("*****Reverse Array******");
        Array.Reverse(sayiDizisi);
        foreach (var sayi in sayiDizisi)
        {
            Console.WriteLine(sayi);
        }

        //IndexOf
        Console.WriteLine("*****IndexOf******");        
        Console.WriteLine(Array.IndexOf(sayiDizisi, 23));

        //Resize
        Console.WriteLine("*****Resize******");
        Array.Resize<int>(ref sayiDizisi,9); //normalde dizimiz 8 elemanlıydı, şimdi 9 elemanlı yaptık.
        sayiDizisi[8] = 99;                  //genişlettiğimiz son elemana yeni değer atadık.
        foreach (var sayilar in sayiDizisi)
        {
            Console.WriteLine(sayilar);
        }


    }
}
