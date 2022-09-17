using Microsoft.AspNetCore.Mvc;
using ProvaLp3.ViewModels;

namespacw ProvaLp3.Controllers;

public class LojasController : Controllers{
    private static List<LojaViewModel> lojas = new List<LojaViewModel>
    {
        new LojasViewModel(32, "piso 3", "Tênis Brasil", "Aqui você encontra os têni", true, "tenis@email.com"),
        new LojasViewModel(33, "Lembranças já", "Vem comprar sua lembrança", true, "lemb@email.com"),
        new LojasViewModel(12, "Sorvetinho gelado", "Sorvetinho Gelado", false, "sorvetinho@email.com"),
    };

    public IActionResult Index(int id)
    {
        return View(lojas[id-1]);
    }

    public IActionResult Cadastrar()
        {
            return View();
        }

        public IActionResult Detalhar()
        {
            return View();
        }
    
}