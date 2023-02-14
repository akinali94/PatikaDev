namespace _06_TryCatch;
class Program
{
    static void Main(string[] args)
    {
        //Exception Handling
        //Hatalar oluşma zamanına göre ikiye ayrılır:
        //Compile Time Errors: Kodu yazarken derleyicinin bize kızmasıdır.
        //RunTime Errors: Çalıştırdıktan sonraki hatalardır, bunlarla başa çıkmamız gerekmektedir (handle).

        //Hata oluşturabilecek bir senaryo oluşturalım:
        int sayi1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Girmis oldugunu sayi {0}", sayi1);

        //Bu üstteki yapıya biz string girdiğimizde, integer'a cast etmeye çalışacak.

        //try --> hataya sebebiyet verme ihtimali olan kod
        //catch --> hata ile karşılaşıldığında sebebi buraya yazılır
        //finally --> Hata olsun olmasın mutlaka yapılmasını istediğimiz işler varsa buraya yazarız.

        try
        {
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Girmis oldugunu sayi {0}", sayi2);
        }
        catch(Exception ex)
        {
            Console.WriteLine("Hata: " + ex.Message.ToString()); //ex, bir object.
        }
        finally //try catch bloğunda ne olursa olsun, çalıştıracağı bir blok. Zorunlu bir blok değildir.
        {
            Console.WriteLine("İşlem Tamamlandı.!");
        }


        //Hata Tipleri - ArgumentNullExpcetion
        try
        {
            //int a = int.Parse(null);
            int a1 = int.Parse("test");
            //int a2 = int.Parse(123124152231231);
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine("Boş değer girdiniz!");
            Console.WriteLine(ex);
        }
        catch(FormatException ex)
        {
            Console.WriteLine("Veri tipi uygun değil");
            Console.WriteLine(ex);
        }
        catch(OverflowException ex)
        {
            Console.WriteLine("Veri araliği disinda değer girdiniz.");
            Console.WriteLine(ex);
        }
        finally
        {
            Console.WriteLine("İşlem başarıyla tamamlandı");
        }


    }
}
