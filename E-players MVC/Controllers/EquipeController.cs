using System;
using System.IO;
using E_players_MVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_players_MVC.Controllers
{
    [Route("Equipe")]

    public class EquipeController : Controller
    {
        Equipe equipemodel = new Equipe();
        [Route("Listar")]
        public IActionResult Index()
        {
            ViewBag.Equipes = equipemodel.LerTodas();
            return View();
        }

        [Route("Cadastrar")]
        public IActionResult Cadastrar(IFormCollection form)
        {
            Equipe novaEquipe = new Equipe();
            novaEquipe.IdEquipe = Int32.Parse(form["IdEquipe"]);
            novaEquipe.Nome = form["Nome"];

            if (form.Files.Count > 0)
            {
                //Upload Início
                var file = form.Files[0];
                var folder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/Equipes");

                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }

                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/", folder, file.FileName);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(stream);
                }

                novaEquipe.Imagem = file.FileName;
            }

            else
            {
                novaEquipe.Imagem = "padrao.png";
            }

            //Upload Final
            equipemodel.Criar(novaEquipe);

            ViewBag.Equipes = equipemodel.LerTodas();

            return LocalRedirect("~/Equipe/Listar");
        }

        [Route("{id}")]
        public IActionResult Excluir(int id)
        {
            equipemodel.Deletar(id);
            ViewBag.Equipes = equipemodel.LerTodas();
            return LocalRedirect("~/Equipe/Listar");
        }
    }
}