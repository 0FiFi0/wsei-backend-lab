using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BackendLab01.Pages;

public class Summary : PageModel
{
    private readonly IQuizUserService _userService;
    
    public Summary(IQuizUserService userService)
    {
        _userService = userService;
    }

    public int CorrectAnswersCount { get; set; }


    public void OnGet(int userId, int quizId)
    {
        CorrectAnswersCount = _userService.CountCorrectAnswersForQuizFilledByUser(quizId, userId);
    }
}