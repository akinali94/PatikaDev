namespace _10_WhileForeach;
class Program
{
    static void Main(string[] args)
    {
        //While döngüsünün yanındaki koşul, döngünün devamlılığını belirlemektedir.
        
        //1'den başlayarak Console'a girilen sayıya kadar (sayı dahil)toplam hesaplayan program.
            
        Console.Write("Sayi Giriniz: ");
        int sayi1 = Convert.ToInt32(Console.ReadLine());
        int sayac = 1;
        int toplam = 0;

        while(sayac <= sayi1)
        {
            toplam += sayac;
            sayac++;
        }

        Console.WriteLine(toplam);


        //a'dan z'ye kadar tüm harfleri console'a yazdır.

        char character = 'a';
        while(character <= 'z')
        {
            Console.Write(character);
            Console.WriteLine();
            character ++;
        }



    }
}
