using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace JukeBox.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    
    private string ConnectionString = "server=localhost;port=3306;database=JukeBoxData;user=root;password=;";

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        Console.WriteLine("Fakka");
   
        // var optionsBuilder = new DbContextOptionsBuilder<DbdContextClass>();
        // optionsBuilder.UseSqlServer(ConnectionString);
        // var dbContextOptions = optionsBuilder.Options;
    
        using (var context = new DbdContextClass())
        {
            var genres = context.Genres.ToList();
            // // Console.WriteLine(genres);
            // foreach (var genre in genres)
            // {
            //     Console.WriteLine(genre.Genre);
            // }
            ViewData["Genres"] = genres;
        }
        
        
    }

}