namespace AvaliacaoLP3.ViewModels;

public class LojasViewModel
{
    public int Id {get; set;}
    public string Piso {get; set;}
    public string Nome {get; set;}
    public string Descricao {get; set;}
    public string Email {get; set;}


    public LojasViewModel(int id, string piso, string nome, string descricao, string email)
    {
    Id = id;
    Piso = piso;
    Nome = nome;
    Descricao = descricao; 
    Email = email;
    }

}