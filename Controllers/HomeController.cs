using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SistemaVendas.DAL;
using SistemaVendas.Entidades;
using SistemaVendas.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVendas.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}
        protected ApplicationDbContext Repositorio;

        public HomeController(ApplicationDbContext repositorio)
        {
            Repositorio = repositorio;

        }

        public IActionResult Index()
        {
            return View();

            /*
                * Removendo um Objeto do banco
                Categoria objCategoria = Repositorio.Categoria.Where(x => x.Codigo == 1).FirstOrDefault();
                Repositorio.Attach(objCategoria);
                Repositorio.Remove(objCategoria);
                Repositorio.SaveChanges();
                return View();
            */


            /*
             * Fazendo a alteração de um registro da base de dados
                //nao podemos jogar uma lista para um objeto simples, temos que transformar a lista em objeto simples, conseguimos no nosso caso usando FirstOrDefault
                Categoria objCategoria = Repositorio.Categoria.Where(x => x.Codigo == 1).FirstOrDefault();
                objCategoria.Descricao = "Bebidas";
                Repositorio.Entry(objCategoria).State = Microsoft.EntityFrameworkCore.EntityState.Modified; //modificando um objeto
                Repositorio.SaveChanges();
            */

            /*
             adicionando um registro em categorias
            Categoria categoria = new Categoria()
            {
                Descricao = "Teste"
            };
            Repositorio.Categoria.Add(categoria);//esta adicionando um objeto do tipo categoria

            Repositorio.SaveChanges();
            */

            /*
             *Listando na nossa view Home 
             
            //trabalhar com tipo generico e mais flexibilidade
            IEnumerable<Categoria> lista = Repositorio.Categoria.ToList();
           
            */
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
