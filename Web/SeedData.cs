using ApplicationCore.Interfaces.Repository;
using BackendLab01;

namespace Infrastructure.Memory;
public static class SeedData
{
    public static void Seed(this WebApplication app)
    {
        using (var scope = app.Services.CreateScope())
        {
            var provider = scope.ServiceProvider;
            var quizRepo = provider.GetService<IGenericRepository<Quiz, int>>();
            var quizItemRepo = provider.GetService<IGenericRepository<QuizItem, int>>();


            var quiz1Items = new List<QuizItem>
            {
                new QuizItem(1, "Pytanie 1", new List<string> { "A", "B", "C" }, "D"),
                new QuizItem(2, "Pytanie 2", new List<string> { "A", "B", "C" }, "D"),
                new QuizItem(3, "Pytanie 3", new List<string> { "A", "B", "C" }, "D")
            };

            var quiz1 = new Quiz(1, quiz1Items, "Quiz 1");
            quizRepo.Add(quiz1);

            var quiz2Items = new List<QuizItem>
            {
                new QuizItem(4, "Pytanie 1", new List<string> { "A", "B", "C" }, "D"),
                new QuizItem(5, "Pytanie 2", new List<string> { "A", "B", "C" }, "D"),
                new QuizItem(6, "Pytanie 3", new List<string> { "A", "B", "C" }, "D")
            };

            var quiz2 = new Quiz(2, quiz2Items, "Quiz 2");
            quizRepo.Add(quiz2);
            
            
        }
    }
}