namespace _04_Operators;
class Program
{
    static void Main(string[] args)
    {
        //Atama ve işlemli atama

        int x = 3;
        int y = 2;
        //y = y+2; yerine
        y += 2; // işlemli atama
        Console.WriteLine(y);
        y /= 2;
        Console.WriteLine(y);
        x *= 2;
        Console.WriteLine(x);

        //Mantıksal Operatörler
        //&&, ||, ! 

        bool isSuccess = true;
        bool isCompleted = false;

        if(isSuccess && isCompleted)
            Console.WriteLine("Perfect");
        
        if(isSuccess || isCompleted)
            Console.WriteLine("Great");
        
        if(isSuccess && !isCompleted)
            Console.WriteLine("Fine");

        //İlişkisel Operatörler
        //<, > , <=, >=, ==, !=

        int a = 3;
        int b = 4;
        bool sonuc = a<b;
        Console.WriteLine(sonuc);
        sonuc = a>b;
        Console.WriteLine(sonuc);
        sonuc = a>=b;
        Console.WriteLine(sonuc);
        sonuc = a<=b;
        Console.WriteLine(sonuc);
        sonuc = a==b;
        Console.WriteLine(sonuc);
        sonuc = a!=b;
        Console.WriteLine(sonuc);

        //Aritmetik Operatörler
        // +, -, *, /

        int sayi1 = 10;
        int sayi2 = 5;
        Console.WriteLine(sayi1 / sayi2);
        Console.WriteLine(sayi1 * sayi2);
        Console.WriteLine(sayi1 + sayi2);
        Console.WriteLine(sayi1 - sayi2);
        Console.WriteLine(sayi1 += sayi1);

        //Mod: %
        int sonucmod = sayi1 % sayi2;
        Console.WriteLine(sonucmod);



    }
}
