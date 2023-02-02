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
        byte b1 = 5; // 0 ile 255 arası değer. 1 byte'tır.
        sbyte b2 = 5; // -128 ile 128 arası değer alır. 1 byte'tır.

        short s1 = 5;   //2 byte değer kaplar
        ushort s2 = 5;  //2 byte

        int i16 = 2;  //2 byte
        int i = 2;      //4 byte
        int i32 = 2;    //4 byte
        int i64 = 2;  //8 byte

        uint ui = 2;    //unsigned int, 4 byte
        long l = 4;     //8 byte
        ulong ul = 4;   //8 byte

        float f = 5;     //4 byte
        double d = 5;    //8 byte
        decimal dec = 5; //16 byte

        char c = 'c';    //2 byte
        string str = "Bu bir diğer stringtir";

        bool b1 = true;

        DateTime dt = DateTime.Now;
        Console.WriteLine(dt);

        Console.WriteLine("dt"); 
    }
}
