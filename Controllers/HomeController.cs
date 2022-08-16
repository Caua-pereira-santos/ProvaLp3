using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using exemploaspnet.Models;

namespace exemploaspnet.Controllers;

public class UserRequest
{
    public string Nome { get; set; }
    public string Email { get; set; }
}

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

//interface que devolve resposta para quem está solicitando
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

     public IActionResult PrimeiraAction()
     {
        return View();
     }

    //  public string TesteFormData(string nome, string email)
    //  {
    //     return $"Nome: {nome}, E-mail: {email}";
    //  }


      public IActionResult Formulario()
      {
        return View();
      }
       public string TesteFormData([FromForm] UserRequest userRequest, [FromHeader] string x)
     {
        return $"Nome: {userRequest.Nome}, E-mail: {userRequest.Email}, x: {x}";
     }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

   
}
