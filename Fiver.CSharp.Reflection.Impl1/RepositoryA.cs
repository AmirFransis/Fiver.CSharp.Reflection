using Fiver.CSharp.Reflection.Abstractions;
using System.Collections.Generic;

namespace Fiver.CSharp.Reflection.Impl1
{
    public class RepositoryA : IRepository
    {
        public List<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie { Id = 1, Title = "Never Say Never Again", ReleaseYear = 1983, Summary = "A SPECTRE agent has stolen two American nuclear warheads, and James Bond must find their targets before they are detonated." },
                new Movie { Id = 2, Title = "Diamonds Are Forever ", ReleaseYear = 1971, Summary = "A diamond smuggling investigation leads James Bond to Las Vegas, where he uncovers an evil plot involving a rich business tycoon." },
            };
        }
    }
}
