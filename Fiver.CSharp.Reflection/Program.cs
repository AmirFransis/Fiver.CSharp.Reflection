using Fiver.CSharp.Reflection.Abstractions;
using System;
using System.Linq;
using System.Runtime.Loader;

namespace Fiver.CSharp.Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var assemblyPath = GetImplementationPath();
                var assembly = AssemblyLoadContext.Default.LoadFromAssemblyPath(assemblyPath);

                var repositories = assembly.ExportedTypes
                                    .Where(t => typeof(IRepository).IsAssignableFrom(t))
                                    .Select(t => Activator.CreateInstance(t) as IRepository)
                                    .ToList();

                repositories.ForEach(
                    repo =>
                    {
                        //Console.WriteLine($"Discovered: {repo.GetType().AssemblyQualifiedName}");
                        Console.WriteLine("Movies Count: {0}", repo.GetMovies().Count);
                    });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("");
                Console.WriteLine("Done!");
                Console.ReadLine();
            }
        }

        private static string GetImplementationPath()
        {
            Console.Write("Select Implementation (A or B): ");
            var option = Console.ReadLine();

            if (option.ToLower() == "a")
                return @"C:\DATA\Work\_Fiver\Source Code\Fiver.CSharp.Reflection\Fiver.CSharp.Reflection.Impl1\bin\Debug\netcoreapp2.0\Fiver.CSharp.Reflection.Impl1.dll";
            else
                return @"C:\DATA\Work\_Fiver\Source Code\Fiver.CSharp.Reflection\Fiver.CSharp.Reflection.Impl2\bin\Debug\netcoreapp2.0\Fiver.CSharp.Reflection.Impl2.dll";
        }
    }
}
