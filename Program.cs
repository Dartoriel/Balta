using System;
using Balta.ContentContext;

namespace Balta
{
    class Program
    {
        static void Main(string[] args)
        {
            var articles = new List<Article>();
            articles.Add(new Article("Artigo sobre OOP", "orientacao-objetos"));
            articles.Add(new Article("Artigo sobre C#", "orientacao-csharp"));
            articles.Add(new Article("Artigo sobre dotnet", "orientacao-dotnet"));

            foreach (var article in articles)
            {
                Console.WriteLine(article.Id);
                Console.WriteLine(article.Title);
                Console.WriteLine(article.Url);
            }

            var courses = new List<Course>();
            var courseOOP = new Course("Fundamentos OOP", "fundamentos-oop");
            var courseCsharp = new Course("Fundamentos C#", "fundamentos-csharp");
            var courseDotnet = new Course("Fundamentos dotnet", "fundamentos-dotnet");

            courses.Add(courseOOP);
            courses.Add(courseCsharp);
            courses.Add(courseDotnet);

            var careers = new List<Career>();
            var careerDotnet = new Career("Especialista .NET", "especialista=dotnet");
            var careerItem = new CareerItem(1, "Comece por aqui", "", null);
            careerDotnet.Items.Add(careerItem);
            careers.Add(careerDotnet);

            foreach (var career in careers)
            {
                Console.WriteLine(career.Title);
                foreach (var item in career.Items)
                {
                    Console.WriteLine($"{item.Order} - {item.Title}");
                }
            }
        }
    }
}