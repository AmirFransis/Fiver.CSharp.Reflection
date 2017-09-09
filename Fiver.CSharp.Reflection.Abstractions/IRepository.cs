using System.Collections.Generic;

namespace Fiver.CSharp.Reflection.Abstractions
{
    public interface IRepository
    {
        List<Movie> GetMovies();
    }
}
