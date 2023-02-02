namespace _03_VariablesandDataTypes;
class Program
{
    static void Main(string[] args)
    {
        int deger = 2;
        string degisken = null;
        string Degisken = null;

        //Değişken tipleri nelerdir?
        string string1 = "bu bir stringtir"; //stringlere null atama yapılabilir.
        byte byt1 = 5; // 0 ile 255 arası değer. 1 byte'tır.
        sbyte b2 = 5; // -128 ile 128 arası değer alır. 1 byte'tır.

        short s1 = 5;   //2 byte değer kaplar
        ushort s2 = 5;  //2 byte

        Int16 i16 = 2;  //2 byte
        int i = 2;      //4 byte
        Int32 i32 = 2;    //4 byte
        Int64 i64 = 2;  //8 byte

        uint ui = 2;    //unsigned int, 4 byte
        long l = 4;     //8 byte
        ulong ul = 4;   //8 byte

        float f = 5;     //4 byte
        double d = 5;    //8 byte
        decimal dec = 5; //16 byte

        char c = 'c';    //2 byte
        string str = "Bu bir diğer stringtir";

        bool b1 = true;
        Console.WriteLine(b1);

        DateTime dt = DateTime.Now;
        Console.WriteLine(dt);

        Console.WriteLine("dt"); 

        //Tüm değişlen türleri aslında objedir.
        object o1 = "x";
        object o2 = 'c';
        object o3 = 123;

        //String ifadeler
        string str1 = string.Empty;
        string ad = "Zikriye";
        string soyad = "Ürkmez";
        string adSoyad = ad + " " + soyad;
        Console.WriteLine(adSoyad);

        //integer tanımlama şekilleri
        int integer1 = 20;
        int integer2 = 30;
        int integer3 = integer1 * integer2;
        Console.WriteLine(integer3);

        //boolean
        bool bool1 = 10>2;
        Console.WriteLine(bool1);

        //Değişken dönüşümleri
        string str20 = "20";
        int int20 = 20;
        string stringyeni = str20 + int20.ToString();
        Console.WriteLine(stringyeni); //Cıktısı 2020

        int intyeni = int20 + Convert.ToInt32(str20);
        Console.WriteLine(intyeni); //Çıktısı 40

        int int21 = int20 + int.Parse(str20);
        Console.WriteLine(int21);

        //DateTime

        string dt1 = DateTime.Now.ToString("dd.MM.yyyy");
        string dt2 = DateTime.Now.ToString("dd/MM/yyyy");
        string dt3 = DateTime.Now.ToString("HH:mm"); //Saati aldık. Küçük m, minutes; M ise month.

        /*DateTime Kütüphanesi
        * https://docs.microsoft.com/tr-tr/dotnet/api/system.datetime?view=netcore-3.1
        */

        /*String Kütüphanesi
        * https://docs.microsoft.com/tr-tr/dotnet/api/system.string?view=netcore-3.1
        */




    }
}
