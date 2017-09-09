using Fiver.CSharp.Reflection.Abstractions;
using System.Collections.Generic;

namespace Fiver.CSharp.Reflection.Impl2
{
    public class RepositoryB : IRepository
    {
        public List<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie { Id = 2, Title = "Diamonds Are Forever ", ReleaseYear = 1971, Summary = "A diamond smuggling investigation leads James Bond to Las Vegas, where he uncovers an evil plot involving a rich business tycoon." },
            };
        }
    }
}
