namespace _17_DateTimeandMathMethods;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(DateTime.Now); //şu anın tarihini getirir
        Console.WriteLine(DateTime.Now.Date); //şu anın sadece tarihini getiriyor, saati 00:00:00 olarak getirir.
        Console.WriteLine(DateTime.Now.Day); //günü getirir
        Console.WriteLine(DateTime.Now.Month); //Ayı getirir
        Console.WriteLine(DateTime.Now.Year); //.....
        Console.WriteLine(DateTime.Now.Hour);
        Console.WriteLine(DateTime.Now.Minute);
        Console.WriteLine(DateTime.Now.Second);

        Console.WriteLine(DateTime.Now.DayOfWeek); // Yılın kaçıncı haftasındayız
        Console.WriteLine(DateTime.Now.DayOfYear); // Yılın hangi günü

        Console.WriteLine(DateTime.Now.ToLongDateString()); //Saturday, April 24, 2021
        Console.WriteLine(DateTime.Now.ToShortDateString()); // 4/24/21
        Console.WriteLine(DateTime.Now.ToShortTimeString());
        Console.WriteLine(DateTime.Now.ToShortTimeString());

        Console.WriteLine(DateTime.Now.AddDays(2));
        Console.WriteLine(DateTime.Now.AddHours(3));
        Console.WriteLine(DateTime.Now.AddSeconds(3));
        Console.WriteLine(DateTime.Now.AddMonths(5));
        Console.WriteLine(DateTime.Now.AddYears(15));

        //DateTime Format
        Console.WriteLine(DateTime.Now.ToString("dd")); //sadece günü getirir
        Console.WriteLine(DateTime.Now.ToString("ddd")); //günün kısaltması, örneğin Sat
        Console.WriteLine(DateTime.Now.ToString("dddd")); //Saturday
        
        Console.WriteLine(DateTime.Now.ToString("MM")); //ayın gösterimi, örneğin 04
        Console.WriteLine(DateTime.Now.ToString("MMM")); //Apr
        Console.WriteLine(DateTime.Now.ToString("MMMM")); //April

        Console.WriteLine(DateTime.Now.ToString("yy")); //2023'ün 23'ünü gösterir
        Console.WriteLine(DateTime.Now.ToString("yyyy")); //2023


        //MATH Kütüphanesi
        Console.WriteLine(Math.Abs(-25)); //Mutlak değer
        Console.WriteLine(Math.Sin(10));
        Console.WriteLine(Math.Cos(10));
        Console.WriteLine(Math.Tan(10));

        Console.WriteLine(Math.Ceiling(22.3)); // Ceiling, 22.3'ten büyük, en küçük sayıyı getirir.
        Console.WriteLine(Math.Round(22.3)); //En yakın tam sayıya yuvarlar, çıktı: 22
        Console.WriteLine(Math.Round(22.7)); // Çıktı: 23
        Console.WriteLine(Math.Floor(22.7)); //Tabana yuvarlar. Çıktı: 22

        Console.WriteLine(Math.Max(2,6)); //İki sayının max'ını verir. 6
        Console.WriteLine(Math.Min(2,6)); //İki sayının min'ini verir. 2

        Console.WriteLine(Math.Pow(3,4)); //3'ün 4. kuvvetini alır
        Console.WriteLine(Math.Sqrt(9)); //Karekök alır
        Console.WriteLine(Math.Log(9)); //9'un e tabanındaki logaritmik karşılığını verir.
        Console.WriteLine(Math.Exp(3)); //e üzeri 3'ü verir
        Console.WriteLine(Math.Log10(10)); //10 sayısının logaritma 10 tabanındaki karşılığını verir.

        Console.WriteLine("--------");




        
    }
}
