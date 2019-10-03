using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using apphw2.NewFolder;

namespace apphw2.Pages
{
    public class IndexModel : PageModel
    {
        public List<movies> movie { get; set; } = new List<movies>();
        public string maintitle { get; set; }
        public string[] movies1 { get; set; }

        public void OnGet()
        {
            movie.Add(new movies
            {
                movieid = "52341hi",
                title = "Hangover",
                director = "Tod Phillips",
                rating = 10.5
            });
        }
    }
}
