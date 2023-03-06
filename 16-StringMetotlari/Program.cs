namespace _16_StringMetotlari;
class Program
{
    static void Main(string[] args)
    {
        //String kütüphanesinin metotlarını kullanacağız.

        string degisken = "Dersimiz CSharp, Hoşgeldiniz!";
        string degisken2 = "Dersimiz CSharp";

        //Length - Karakter sayısını öğreniyoruz
        Console.WriteLine(degisken.Length);
        
        //ToUpper, ToLower - Karakterleri büyütür ve küçültür
        Console.WriteLine(degisken.ToLower());
        Console.WriteLine(degisken.ToUpper());

        //Concat - birleştirme, iki argüman alır
        Console.WriteLine(String.Concat(degisken," Merhaba"));

        /*Compare, CompareTo - birinci değişkene eşit olursa 0 döndürür, 1. değişken 2. değişkenden büyükse 1;
         * 2. değişken birinci değişkenden büyükse -1 geri döndürür.
         */
        Console.WriteLine(degisken.CompareTo(degisken2)); // 0,1,-1
        Console.WriteLine(String.Compare(degisken,degisken2,true)); //üçüncü argüman, ignorecase durumu, yani büyük küçük harf duyarsız hale gelir.
        Console.WriteLine(String.Compare(degisken,degisken2,false)); //üçüncü argüman, false, yani büyük küçük harf duyarsızlığı kapalı.

        //Contains - ilk yazılan string içinde, değisken2 var mı diye kontrol ediyor.
        Console.WriteLine(degisken.Contains(degisken2));
        Console.WriteLine(degisken.EndsWith("Hoşgeldiniz!")); //Hosgeldiniz! ile bitip bitmediğini sorguluyor, true dönecek
        Console.WriteLine(degisken.StartsWith("Merhaba!")); //Merhaba ile başlayıp başlamadığını sorguluyor, false dönecek

        //IndexOf
        Console.WriteLine(degisken.IndexOf("CSharp")); //ilk bulduğu yerde, ilk char'ın indeksini verir, bulamazsa -1 verir.


    }
}
