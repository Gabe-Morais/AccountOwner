using Contracts;
using Microsoft.AspNetCore.Mvc;

namespace AccountOwnerServer.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{

    private readonly ILoggerManager _logger;

    public WeatherForecastController(ILoggerManager logger)
    {
        _logger = logger;
    }

    [
    HttpGet]
    public IEnumerable<string> Get()
    {
        _logger.LogInfo("Testando um log de informação a partir de um Controller.");
        _logger.LogDebug("Testando um log de debug a partir de um Controller.");
        _logger.LogWarn("Testando um log de aviso a partir de um Controller.");
        _logger.LogError("Testando um log de erro a partir de um Controller.");
        return new string[] { "value1", "value2" };
    }
}
