namespace _05_TypeConversions;
class Program
{
    static void Main(string[] args)
    {
        //Implicit Conversion (Bilinçsiz Dönüşüm)
        //Düşük kapasiteli bir değişkenin, kendinden daha büyük kapasiteli bir değişkene atanması durumudur. Makina bunu kendi kendine yapar.
        Console.WriteLine("***** Implicit Conversion *****");

        byte a = 5;
        sbyte b = 30;
        short c = 10;

        int d = a+b+c; //int, diğerlerinden daha büyük olduğu için hatasız, otomatik dönüşüm yapıyor.
        Console.WriteLine("d:" +d);

        long h = d; 
        Console.WriteLine("h:" +h);

        float i = h;
        Console.WriteLine("i:" + i);

        string e = "Ali";
        char f = 'A';
        object g = e + f + d; //object string ve char'dan daha kapasiteli bir veri tipidir



        //Explicit Conversion (Bilinçli Dönüşüm)
        //C#'ın kendi kendine yapamadığı dönüşümlerdir, Convert ve Parse metotları kullanılarak yapılmaktadır.
        Console.WriteLine("***** Explicit Conversion *****");

        int x = 4;
        //byte y = x; //Hata verecektir. byte, int'e göre daha düşük kapasiteli bir tiptir.
        byte y =(byte)x;
        Console.WriteLine("y:" +y);

        int z = 100;
        byte t = (byte)z;
        Console.WriteLine("t:" +t);

        float w = 10.3f;
        byte v = (byte)w;
        Console.WriteLine("v:" +v);

        


    }
}
