using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using JJOO.Models;


namespace JJOO.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
   
    public IActionResult Deportes()
    {
        viewBag.Deporte=BD.ListarDeportes();
        return view();
    }
    
    public IActionResult Paises()
    {
        viewBag.Pais=BD.ListarPaises();
        return view();
    }
    public IActionResult VerDetalleDeporte()
    {
        viewBag.Deporte=BD.VerInfoDeporte(id_deporte);
        return view();
    }
    public IActionResult VerDetallePais()
    {
        viewBag.Pais=BD.VerInfoPais();
        return view();
    }
    public IActionResult VerDetalleDeportista()
    {
        
        return view();
    }
    public IActionResult AgregarDeportista()
    {
        return view();
    }
    public IActionResult GuardarDeportista()
    {
        return view();
    }
    public IActionResult EliminarDeportista()
    {
        return view();
    }
    public IActionResult Creditos()
    {
        return view();
    }
}
