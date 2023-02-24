namespace _12_MetotTanimlama;
class Program
{
    static void Main(string[] args)
    {
        //Metotların genel syntaksı

        /*erisim_belirteci geri_donustipi metot_adi(parametreListesi/arguman)
         * {
         *      komutlar;
         * }
         */

        
        int a = 2;
        int b = 3;

        Console.WriteLine(a+b);

        //Üsttekini metot olarak yazalım.

        //Topla(2,3); //şimdi alttaki metot, statik olmadığı için, instance'ını alıp yapmamız gerekiyor, bu şekilde birazcık zor.

        Program inst1 = new Program();

        Console.WriteLine(inst1.Topla(3,2));

        //Şimdi statik yaptık, o metodu doğrudan çağırabiliyoruz.

        Console.WriteLine(ToplaStatic(3,5));


        //Farklı bir sınıf içerisinde olduğumuz için instance alıp, diğer sınıfımıza ulaşalım.
        Metotlar metot1 = new Metotlar();
        metot1.EkranaYazdir(Convert.ToString(a+b));

        //Call by value & Call by reference

        int sonuc = ToplaStatic(a,b);
        Console.WriteLine(sonuc);

        /* Bizim yaptığımız call by value, a ve b'nin değerlerini Topla metotunda çağırdık ve 
        * buraya atadığı anda, a ve b'yi bit bit karşılığını atıyor. Yani, Metot gidip bellekten
        * yer alıyor ve bu yerlere tek tek a ve b değerlerini yazıyor. Metot kendi içinden işlemler
        * yaparken buradan kendi ayırdığı a ve b değerini okuyup çekiyor. 
        * Fonksiyon başladığında yaratılır, yerler ayırılır, metot işlemini yapar ve ardından bellekten
        * silinir. İşlem biter. Yani metot'un deger1 ve deger2'sine bir sonraki satırda ulaşamam.
        * Bu anlattığımız call bu value'dur.
        * Bir de call by reference' bakalım.
        */

        //Metotlar sınıfındaki ArttırveTopla Metoduna bakalım.

        /*Bu metotta deger1 ve deger2'yi birer arttırıp toplamını istiyoruz.
        * Alttaki işlemlerde,
        * a+b = 5;
        * sonuc2 = 7;
        * a+b = 5;
        * bu şekilde sonuç alacağımızı biliyoruz. çünkü ne demiştik, ArttırveTopla metodunda
        * a ve b metot içinde arttıtılacak ve sonra arttırılması silinecek.
        */
        Console.WriteLine("************************");
        metot1.EkranaYazdir(Convert.ToString(a+b));
        int sonuc2 = metot1.ArttirVeTopla(a,b);
        metot1.EkranaYazdir(Convert.ToString(sonuc2));
        metot1.EkranaYazdir(Convert.ToString(a+b));
        
        /* Bu value' yerine reference'larını çağırsak nasıl olur? Metot'a ref kelimesini ekleyeceğiz.
        * Ne demek bu? a ve b'nin değerlerini değil de, a ve b'nin referanslarındaki değerleri yani
        * bellekteki karşılıklarını/adresteki yerleri üzerinde işlem yapıyor. Ve referanstaki değerlerini
        * değiştiriyor.
        */
        Console.WriteLine("************************");
        metot1.EkranaYazdir(Convert.ToString(a+b));
        int sonuc3 = metot1.ArttirveToplaRef(ref a, ref b); //ref keyword'lerini eklemek önemli
        metot1.EkranaYazdir(Convert.ToString(sonuc3));
        metot1.EkranaYazdir(Convert.ToString(a+b));

        //En son işlemde sonucumuz 5 olarak beklerken, referans'ı üzerinden işlediğimiz için 7 olarak çıkacak.
    }

    int Topla(int deger1, int deger2)
    {
        return deger1 + deger2;
    }

    static int ToplaStatic(int deger1, int deger2)
    {
        return deger1 + deger2;
    }

}

class Metotlar
{
    public void EkranaYazdir(string veri)
    {
        Console.WriteLine(veri);
    }

    public int ArttirVeTopla(int deger1, int deger2)
    {
        deger1 += 1;
        deger2 += 1;
        return deger1 + deger2;
    }

    public int ArttirveToplaRef(ref int deger1, ref int deger2)
    {
        deger1 += 1;
        deger2 += 1;
        return deger1 + deger2;
    }
}
