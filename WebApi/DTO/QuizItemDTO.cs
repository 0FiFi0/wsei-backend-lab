using BackendLab01;

namespace WebApi.DTO;

public class QuizItemDTO
{
    public int Id { get; set; }
    public string Question { get; set; }
    public List<string> Options { get; set; }

    public static QuizItemDTO Of(QuizItem item)
    {
        return new QuizItemDTO()
        {
            Id = item.Id,
            Question = item.Question,
            Options = new List<string>(item.IncorrectAnswers)
            {
                item.CorrectAnswer
            }
        };
    }
}