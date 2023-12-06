using GTY.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GTY.Controllers;

public class OxeController : Controller
{
    private readonly ILogger<OxeController> _logger;
    public OxeController(ILogger<OxeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Cidades()
    {
        return View();
    }
    public IActionResult CadastroPessoa()
    {
        return View();
    }
    public IActionResult EditarPessoa()
    {
        return View();
    }
    public IActionResult ConfirmarExcluirPessoa()
    {
        return View();
    }
}
