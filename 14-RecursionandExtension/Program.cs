namespace _14_RecursionandExtension;
class Program
{
    static void Main(string[] args)
    {
        //Recursion (Özyinelemeli) - Kendi kendini çağıran fonksiyonlar

        //3 üzeri 4'ü önce for döngüsüyle ardından, recursion ile yapalım.

        int result = 1;
        for(int i = 1; i<5; i++)
        {
            result = result * 3;
        }
        Console.WriteLine("For döngüsü sonucu: {0} ", + result);

        //Şimdi bunu recursion ile yazalım //bir class tanımlayalım altta.

        Islemler instance1 = new Islemler();
        int result2 = instance1.Expo(3,4);
        Console.WriteLine("Recursion sonucu: {0} ", + result2);

        //------------------------------------------------------------------------------------------------------------------------

        //Extension Metotlar

        /*Mevcut olan fonksiyonu daha kolay veya rahat elde edebilmek için, tekrar yazabilmek için 
        * extension metota dönüştürebiliyoruz.
        */

        //Şimdi verdiğimiz cümle içerisinde boşluk olup olmadığını kontrol eden bir metot yazalım.
        /*Extension class'lar ve extension metotlar, static olmak zorundadır. Yoksa nesnesi olmadan
        * üretemiyorsunuz, erişemiyorsunuz.
        */

        string ifade = "Burada bosluk var midir?";
        bool sonuc = ifade.CheckSpaces();
        Console.WriteLine(sonuc);
        if(sonuc)
            Console.WriteLine(ifade.RemoveWhiteSpaces());
        Console.WriteLine(ifade.MakeUpperCase());
        Console.WriteLine(ifade.MakeLowerCase());


        //Integer diziyi kullanan extension metot yazalım
        int[] dizi =  {3,1,6,4,9,8,7,5};
        dizi.SortArray();
        dizi.EkranaYazdir();

        int sayi = 5;
        Console.WriteLine(sayi.IsEven());
        Console.WriteLine(ifade.GetFirstCharacter());

    }


}

class Islemler
{
    public int Expo(int sayi, int üs)
    {
        if(üs < 2)
            return sayi;
        return sayi*Expo(sayi, üs-1);
    }
}

public static class MyExtensions //Extension Metotlar static olmalıdır.
{
    public static bool CheckSpaces(this string param)
    {
        return param.Contains(" ");
    }

    public static string RemoveWhiteSpaces(this string param)
    {
        string [] dizi = param.Split(" ");
        return string.Join("", dizi);
    }

    public static string MakeUpperCase(this string param)
    {
        return param.ToUpper();
    }

    public static string MakeLowerCase(this string param)
    {
        return param.ToLower();
    }

    public static int[] SortArray(this int[] param)
    {
        Array.Sort(param);
        return param;
    }

    public static void EkranaYazdir(this int[] param)
    {
        foreach(int item in param)
            Console.WriteLine(item);
    }

    public static bool IsEven(this int param)
    {
        return param % 2 == 0;
    }

    public static string GetFirstCharacter(this string param)
    {
        return param.Substring(0,1); //(startindex, lenght)
    }
}