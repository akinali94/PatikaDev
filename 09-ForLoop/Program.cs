namespace _09_ForLoop;
class Program
{
    static void Main(string[] args)
    {
        //Döngüler: for, while ve foreach

        //Ekrana girilen sayıya kadar tek sayıları yazdıralım.
        Console.Write("Sayi Giriniz: ");
        int sayi1 = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < sayi1; i++)
        {
            if( i % 2 == 1)
                Console.WriteLine(i);

        }

        //1 ile 1000 arasındaki tek sayıların toplamını ekrana yazdıralım.
        
        int tekToplam = 0, ciftToplam = 0;
        for(int i = 0; i < 1000; i++)
        {
            if(i % 2 == 1)
                tekToplam += i;
            else
                ciftToplam += i;
        }
        Console.WriteLine("Tek Sayıların Toplamı: {0}", tekToplam);
        Console.WriteLine("Çift Sayıların Toplamı: {0}", ciftToplam);
    }
}
