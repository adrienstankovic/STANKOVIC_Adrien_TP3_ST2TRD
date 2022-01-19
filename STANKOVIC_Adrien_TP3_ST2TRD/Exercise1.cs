using System;
using System.Collections.Generic;
using System.Linq;


namespace STANKOVIC_Adrien_TP3_ST2TRD
{
    public class Exercise1
    {
        public static void workOnMovie()
        {
            var movies = new MovieCollection().Movies;

            var query1 = movies
                .OrderBy(c => c.ReleaseDate)
                .First()
                .Title;
            Console.WriteLine($"Q1: Oldest movie title: {query1}");

            var query2 = movies
                .Count();
            Console.WriteLine($"Q2: Count all movies: {query2}");
            
            var query3 = movies
                .Count(c => c.Title.Contains('e'));
            Console.WriteLine($"Q3: Count all movies with the letter e in the title: {query3}");

            var query41 = movies
                .Where(x => x.Title.Contains("f"))
                .Select(x => x.Title);
            var query4 = string
                .Join(" ,", query41)
                .Count(x => x == 'f');
            Console.WriteLine($"Q4: Count the letter f in title: {query4}");

            var query5 = movies
                .OrderByDescending(c => c.Budget)
                .First()
                .Title;
            Console.WriteLine($"Q5: Movie with higher budget: {query5}");

            var query6 = movies
                .OrderBy(c => c.BoxOffice)
                .First()
                .Title;
            Console.WriteLine($"Q6: Movie with the lowest box office: {query6}");
            Console.WriteLine();

            var query7 = movies
                .OrderByDescending(c => c.Title)
                .Take(11);
            Console.WriteLine("Q7: First 11 movies ordered by reversed alphabetical order: ");
            foreach (var q7 in query7)
            {
                Console.WriteLine(q7.Title);
            }
            Console.WriteLine();

            var query8 = movies
                .Count(x => x.ReleaseDate.Year < 1980);
            Console.WriteLine($"Q8: Count all movies made before 1980: {query8}");
            
            var query9 = movies
                .Where(t => t.Title.StartsWith("A") || t.Title.StartsWith("E") || t.Title.StartsWith("I") || t.Title.StartsWith("O") || t.Title.StartsWith("U") || t.Title.StartsWith("Y"))
                .Average(r => r.RunningTime);
            Console.WriteLine($"Q9: Average time of movies with title started by a vowel: {query9}");
            Console.WriteLine();

            var query10 = movies.Where(m =>
                    (m.Title.Contains("h") || m.Title.Contains("w") || m.Title.Contains("H") || m.Title.Contains("W")) &
                    (!m.Title.Contains("i") & !m.Title.Contains("t") & !m.Title.Contains("I") & !m.Title.Contains("T")))
                .Select(m => m.Title);
            Console.WriteLine($"Q10: Movies with H or W and without I or T in the title: ");
            foreach (var title in query10)
            {
                Console.WriteLine(title);
            }
            Console.WriteLine();
            
            var query11 = movies
                .Average(x => x.Budget/x.BoxOffice);
            Console.WriteLine($"Q11: Mean of Budget / Box office of all movies: {query11}");
        }
    }
}
