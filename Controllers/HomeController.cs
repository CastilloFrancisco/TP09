using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP09.Models;

namespace TP09.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Juego p = Objeto.StringToObject<Juego>(HttpContext.Session.GetString("partida"));

        if (p == null)
        {
            p = new Juego();
            ViewBag.otrosJugadores = null;
        }
        else
        {

            ViewBag.otrosJugadores = p.DevolverListaUsuarios();
        }

        HttpContext.Session.SetString("partida", Objeto.ObjectToString(p));

        return View();
    }


    [HttpPost]
    public IActionResult Comenzar(string username, int dificultad)
    {
        Juego p = Objeto.StringToObject<Juego>(HttpContext.Session.GetString("partida"));

        p.inicializarJuego(username, dificultad);
        ViewBag.Palabra = p.Palabra;

        return View("Juego");
    }

    [HttpPost]
    public IActionResult FinJuego(int intentos)
    {
        Juego p = Objeto.StringToObject<Juego>(HttpContext.Session.GetString("partida"));

        p.FinJuego(intentos);


        HttpContext.Session.SetString("partida", Objeto.ObjectToString(p));

        return View("Index");

    }
}