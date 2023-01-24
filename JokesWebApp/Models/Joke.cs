using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JokesWebApp.Models
{
    public class Joke
    {

        // properties of the joke --> prop + TabTab generates the code autamatically
        public int Id { get; set; }
        public string JokeQuestion { get; set; }
        public string JokeAnswer { get; set; }

        // constructor
        public Joke() 
        {
        }
    }
}