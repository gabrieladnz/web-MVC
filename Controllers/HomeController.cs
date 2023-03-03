using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LhPet.Models;

namespace LhPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Cliente cliente1 = new Cliente(01, "Gabriela D", 234.234.234.23, "testando123@hotmail.com", "User teste");
        Cliente cliente2 = new Cliente(02, "Iris R.", 224.234.234.23, "testando132@hotmail.com", "User teste 2");
        Cliente cliente3 = new Cliente(03, "Marcos F.", 214.234.234.23, "testando321@hotmail.com", "User teste 3");
       
       //lista clientes
       List<Cliente> listaClientes = new List<Cliente>();
       listaClientes.Add(cliente1);
       listaClientes.Add(cliente2);
       listaClientes.Add(cliente3);

       ViewBag.listaClientes = listaClientes;
       
       // fornecedores 
       Fornecedor fornecedor1 = new Fornecedor(01, "A", "B", "C");
       Fornecedor fornecedor2 = new Fornecedor(02, "A", "B", "C");

        List<Fornecedor> listaFornecedores = new List<Fornecedor>();
        listaFornecedores.Add(fornecedor1);
        listaFornecedores.Add(fornecedor2);

        ViewBag.listaFornecedores = listaFornecedores;

        return View();
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
