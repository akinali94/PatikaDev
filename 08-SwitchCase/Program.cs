namespace _08_SwitchCase;
class Program
{
    static void Main(string[] args)
    {
        int month = DateTime.Now.Month;
        
        //Expression
        switch (month)
        {
            case 1:
            Console.WriteLine("Ocak Ayındasınız");
            break;
            case 4:
            Console.WriteLine("Nisan Ayındasınız");
            break;
            case 2:
            Console.WriteLine("Subat Ayındasınız");
            break;
            case 3:
            Console.WriteLine("Mart Ayındasınız");
            break;
            default: // Hiçbir koşul olmaz ise default çalışıyor.
                Console.WriteLine("Yanlış veri girişi");
            break; 
        } 

        //Birden fazla koşulu aynı anda görmek için
        switch (month)
        {
            case 12:
            case 1:
            case 2:
                Console.WriteLine("Kış ayındasınız");
            break;
            case 3:
            case 4:
            case 5:
                Console.WriteLine("Bahar Ayındasınız");
            break;
            default:
                Console.WriteLine("Öyle bir ay yok!");
            break;
        }
    }
}
