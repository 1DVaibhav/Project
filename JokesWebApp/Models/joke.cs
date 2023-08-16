using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace JokesWebApp.Models
{
    public class joke
    {
        public int id { get; set; }

        public string JokeQuestion { get; set; }
        public string JokeAnswer { get; set; }

        public joke()
        {
                
        }
    }
}
