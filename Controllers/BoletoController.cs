using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using MVCApp;
namespace MVCWebApp.Controllers
{
    [Route("[controller]")]
    public class BoletoController : Controller
    {

        public IActionResult GerarBoleto()
        {
            string nomeArquivo = "boleto.pdf";
            PagamentoBoleto.GerarBoletoPDF(nomeArquivo);
            return File(nomeArquivo, "application/pdf", nomeArquivo);
        }
    }
}