using E_players_MVC.Interfaces;

namespace E_players_MVC.Models
{
    public class Noticia: EPlayersBase, INoticia
    {
        public int IdNoticia { get; set; }
        public string Titulo { get; set; }
        public string Texto { get; set; }
        public string Imagem { get; set; }
        public int Propriedade { get; set; }
    }
}