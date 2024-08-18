using Microsoft.AspNetCore.Mvc;
using PrometheusGrafanaDotnetCore.Application.Services;
using PrometheusGrafanaDotNetCore.Domain;

namespace PrometheusGrafanaDotNetCore.Controllers;

[Route("[controller]")]
public class UsersController(UserService userService) : Controller
{
    [HttpGet]
    public IActionResult GetUsers()
    {
        return Ok(userService.GetUsers());
    }
    
    [HttpGet("{userId:double}")]
    public IActionResult GetUser(double userId)
    {
        return Ok(userService.GetUser(userId));
    }

    [HttpPost]
    public IActionResult CreateUser([FromBody] User user)
    {
        userService.AddUser(user);
        return Ok();
    }
}
