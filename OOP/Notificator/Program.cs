
using Notificator.ContentContext;

namespace Notificator
{
    public class Program
    {
         static void Main(string[] args)
        {
           //var articles = new List<Article>();
           // articles.Add(new Article("Artigo sobre EF", "EF"));

           // foreach(var article in articles)
           // {
           //     Console.WriteLine(article.Id);
           //     Console.WriteLine(article.Title);
           //     Console.WriteLine(article.Url);
           // }

            //var courses = new List<Course>();

            //courses.Add(new Course("Fundamentos ASP NET", "fundamentos-aspnet"));
            //courses.Add(new Course("Fundamentos SqlServer", "fundamentos-sqlserver"));
            //courses.Add(new Course("Fundamentos EF", "fundamentos-entityframework"));


            var careers = new List<Career>();

            var careerDotnet = new Career("Especialista ASPNET", "especialista-aspnet");
            var careerSql = new Career("Especialista SQLSERVER", "especialista-sqlserver");

            careers.Add(careerDotnet);
            careers.Add(careerSql);

            careerDotnet.Items.Add(new CareerItem(1, "Declaração de variaveis", "", null));
            careerDotnet.Items.Add(new CareerItem(2, "Declaração de classes", "", null));
            careerDotnet.Items.Add(new CareerItem(3, "Criando endpoints", "", null));
            careerDotnet.Items.Add(new CareerItem(4, "Filtrando requisições", "", null)); 
            careerDotnet.Items.Add(new CareerItem(5, "Refatorando", "", null));

            careerSql.Items.Add(new CareerItem(1, "Instalando Azure Data Studio", "", null));
            careerSql.Items.Add(new CareerItem(2, "Criando o banco de dados", "", null));
            careerSql.Items.Add(new CareerItem(3, "Fazendo querys", "", null));
            careerSql.Items.Add(new CareerItem(4, "Otimizando consultas", "", null));
            careerSql.Items.Add(new CareerItem(5, "Refatorando", "", null));

            foreach (var career in careers)
            {
                Console.WriteLine(career.Title);

                foreach(var item in career.Items.OrderBy(x => x.Order))
                {

                    Console.WriteLine($"{item.Order} - {item.Title}");
                }
                Console.WriteLine(" ");
            }
        }
    }
}