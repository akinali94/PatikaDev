using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
namespace WebApi.DBOperations{

    public class DataGenerator{

        //initilize metodumuz olsun, verileri insert eden.
        //IServiceProvider, In-memory ile alakalı. Program.cs kendi içerisindeki ServiceProvider ile burayı çağırarak
        //uygulama ilk çalıştığında hep ayağa kalkan bir yapı kuruyoruz, bu da ServiceProvider ile oluyor.
        public static void Initialize(IServiceProvider serviceProvider){

            //Az önce oluşturmuş olduğumuz context'in instance'ına ihtiyacımız var. Çünkü, birazdan database'e kaydeceğim o bilgileri
            //bunu da context aracılığıyla yapacağız.
            //alttaki getrequiredService, injection ile alakalı. Buna sonra geleceğiz.
            using (var context = new BookStoreDbContext(serviceProvider.GetRequiredService<DbContextOptions<BookStoreDbContext>>())){

                if(context.Books.Any()){
                    return;
                }

                //Controller'daki verilerin aynısını buraya ekledik, onları silicez.
                context.Books.AddRange(
                new Book{
                    //Id = 1,
                    Title = "Lea Startup",
                    GenreId = 1, //Personal Growth
                    PageCount = 200,
                    PublishDate = new DateTime(2001,06,12)
                },

                new Book{
                    //Id = 2,
                    Title = "HerLand",
                    GenreId = 2, //Science Fiction
                    PageCount = 250,
                    PublishDate = new DateTime(2010,03,23)
                },

                new Book{
                    //Id = 3,
                    Title = "Dune",
                    GenreId = 2, //Science Fiction
                    PageCount = 540,
                    PublishDate = new DateTime(2002,05,23)
                }
                );

                context.SaveChanges();
            }
        } 
    }
}