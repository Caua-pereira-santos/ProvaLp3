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

    public IActionResult Cadastrar[fromForm] string nome, [FromForm] string email, [FromForm] string descricao)
        {
            foreach(var loja in lojas)
            {if(nome == loja.Nome){
                ViewData["Nome"]= nome; 

            return View();
            }
        }

        LojasViewModel  loja = new LojasViewModel(lojas.count(), nome, email, descricao);
        lojas.Add(loja);

        return view("Cadastrar");

        }

        public IActionResult Detalhar()
        {
            return View();
        }

        public IActionResult Deletar(int id)
        {
            if(lojas.Count() == 1)
            {
                lojas.Clear();
            }
            else
            
                lojas.RemoveAt(id);

                foreach (var loja in lojas)
                {
                    lojas.Id = lojas.IndexOf(loja);
                }

                return View();

            
        }
    
}