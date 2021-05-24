using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace JokesWebApp.Models
{
    public class Joke
    {
        public int Id { get; set; }
        [DisplayName("Joke Question")]
        public string JokeQuestion { get; set; }
        public string JokeAnswer { get; set; }
        public Joke()
        {

        }
    }
}
