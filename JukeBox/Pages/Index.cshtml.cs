using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace JukeBox.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    
    // private string ConnectionString = "server=localhost;port=3306;database=JukeBoxData;user=root;password=;";

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet([FromQuery] string genre)
    {
        Console.WriteLine("Fakka");
        Console.WriteLine(genre);
     
    
        using (var context = new DbdContextClass())
        {
            var genres = context.Genres.ToList();
            var songs = context.Songs.Where(s => s.Genre == genre).ToList();

            
          
            ViewData["Genres"] = genres;
            ViewData["Songs"] = songs;
            
        }
        
        
    }

}