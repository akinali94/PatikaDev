namespace _15_AlgoritmaSorulari;
class Program
{
    static void Main(string[] args)
    {
        /* SORU 1:
        * Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan
        * n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanları konsola yazdırın.
        */

        Console.WriteLine("Girdiğiniz n adet pozitif sayılardan çift olanları ekrana yazdırılacaktır.");
        Console.Write("Lütfen pozitif bir tam sayı giriniz: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] dizi = new int[n];
        for(int i = 0; i < n; i++)
        {
            Console.Write($"{i+1}. sayı: ");
            dizi[i] = Convert.ToInt32(Console.ReadLine());
        }

        foreach(int item in dizi)
        {
            if(item % 2 == 0)
                Console.WriteLine(item);
        }

        Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");

        /* SORU 2:
        * Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n,m). Sonrasında kullanıcıdan n adet pozitf
        * sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılarıdan m'e eşit yada tam bölünenleri konsola yazdırın.
        */

        Console.WriteLine("Girdiğiniz 'n' adet sayılar arasında, girdiğiniz 'm' pozitif tam sayısına tam bölünenler ekrana yazdırılacaktır.");
        Console.Write("Kaç adet sayı girmek istiyorsunuz (n): ");
        int n2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Tam bölen sayı (m): ");
        int m2 = Int32.Parse(Console.ReadLine());

        int[] dizi2 = new int[n2];

        for(int i = 0; i<n2; i++)
        {
            Console.Write($"{i+1}. sayı: ");
            dizi2[i] = Convert.ToInt32(Console.ReadLine());
        }
        
        foreach(int item in dizi2)
        {
            if(item % m2 == 0)
                Console.WriteLine(item);
        }

        Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");

        /* SORU 3:
        * Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime
        * girmesini isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru konsola yazıdırn.
        */

        Console.WriteLine("Girdiğiniz 'n' adet kelime, sondan başa ekrana yazdırılacaktır.");
        Console.Write("Kaç adet kelime girmek istiyorsunuz (n): ");
        int n3 = Convert.ToInt32(Console.ReadLine());
        
        string[] dizi3 = new string[n3];

        for(int i = 0; i < n3; i++)
        {
            Console.Write($"{i+1}. kelime: ");
            dizi3[i] = Console.ReadLine();
        }

        for(int i=n3-1; i>=0 ; i--)
        {
            Console.WriteLine(dizi3[i]);
        }

         Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");

        /* SORU 4:
        * Bir konsol uygulamasında kullanıcıdan bir cümle yazmasını isteyin. Cümledeki toplam kelime ve harf sayısını konsola
        * yazdırın.
        */

        Console.WriteLine("Yazdığınız cümledeki kelime ve harf sayısı ekrana yazıdırılacaktır.");
        Console.Write("Lütfen cümle giriniz: ");
        string cumle = Console.ReadLine();
        string[] kelime = cumle.Split(" ");
        Console.WriteLine("Cumledeki kelime sayisi: " + kelime.Length);
        
        int sayac = 0;
        for(int i = 0; i<cumle.Length; i++)
            sayac++;

        Console.WriteLine("Cumledeki harf sayisi: " + (sayac - (kelime.Length-1)));

        Console.ReadLine();
    }
}
