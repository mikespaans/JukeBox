// using Microsoft.EntityFrameworkCore;
// using Microsoft.EntityFrameworkCore.SqlServer;
//
//
// namespace JukeBox;
//
// public class DataBaseAcces
// {
//     private string ConnectionString = "server=localhost;port=3306;database=JukeBoxData;user=root;password=;";
//
//
//     public DataBaseAcces()
//     {
//         
//     }
//
//     public void GetGenres()
//     {
//         var optionsBuilder = new DbContextOptionsBuilder<DbdContextClass>();
//         optionsBuilder.UseSqlServer(ConnectionString);
//         var dbContextOptions = optionsBuilder.Options;
//         
//         using (var context = new DbdContextClass(dbContextOptions))
//         {
//             var genres = context.Genre.ToList();
//             foreach (var genre in genres)
//             {
//                 Console.WriteLine(genre.Genre);
//             }
//         }
//         
//     }
// }