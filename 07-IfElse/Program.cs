namespace _07_IfElse;
class Program
{
    static void Main(string[] args)
    {
        //Saate göre bir selamlama programı yazalım.
        //DateTime kütüphanesinden yararlanalım

        int time = DateTime.Now.Hour;

        if(time >=6 && time < 11)
            Console.WriteLine("Günaydın!");
        else if(time <= 18)
            Console.WriteLine("İyi günler");
        else
            Console.WriteLine("İyi Geceler!");

        //Ternary IF
        
        string sonuc = time<=18 ? "İyi Günler" : "İyi Geceler";
        Console.WriteLine(sonuc);
        /*Soru işareti (?) ise anlamına gelmektedir, eğer ? öncesindeki ifade doğruysa
        * ? sonrasındaki ifade çalışır. Değilse, : , sonrasındaki ifade çalışmaktadır.
        */

        string sonuc2 = time>=6 && time < 11 ? "Günaydın" : time<=18 ? "İyi Günler" : "İyi Geceler";
        Console.WriteLine(sonuc);

    }
}
