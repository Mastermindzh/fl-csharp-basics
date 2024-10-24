using ApiWithControllers.services;
using Microsoft.AspNetCore.Mvc;

namespace ApiWithControllers.Controllers;

[ApiController]
[Route("[controller]")]
public class Problem13Controller : ControllerBase
{

    private readonly ILogger<Problem13Controller> _logger;
    private readonly Problem13Service problem13Service;

    public Problem13Controller(ILogger<Problem13Controller> logger, Problem13Service problem13Service)
    {
        this.problem13Service = problem13Service;
        _logger = logger;
    }

    [HttpGet("problem13")]
    public string GetProblem13()
    {
        return problem13Service.Solve();
    }
}
