using BackendLab01;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;
[ApiController]
[Route("/api/v1/user/quizzes")]

public class ApiUserQuizController
{
    private IQuizUserService _userService;

    public ApiUserQuizController(IQuizUserService userService)
    {
        _userService = userService;
    }

    [HttpGet]
    [Route("{id}")]
    public Quiz? GetQuizById(int id)
    {
        return _userService.FindQuizById(id);
    }
}