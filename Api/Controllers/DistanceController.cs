using System.Drawing;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("[controller]")]
public class DistanceController : ControllerBase
{

    private readonly ILogger<DistanceController> _logger;
    private readonly DistanceService _service;

    public DistanceController(ILogger<DistanceController> logger, DistanceService service)
    {
        _logger = logger;
        _service = service;
    }

    [HttpGet(Name = "GetDistance")]
    public int GetDistance(float startLatitude, float startLongitude, float endLatitude, float endLongitude)
    {
        return _service.GetDistance(
            new PointF(startLatitude, startLongitude),
            new PointF(endLatitude, endLongitude));
    }
}
