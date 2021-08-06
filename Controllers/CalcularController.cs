using DevSoftPlayerApi2.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace DevSoftPlayerApi2.Controllers
{
    [ApiController]
    [Route("Index")]
    public class CalcularController : Controller
    {
        ApiExterna _api;
        public CalcularController(ApiExterna api)
        {
            _api = api;
        }
        [HttpPost]
        [Route("JurosApiExterna")]
        public IActionResult CalcularJurosExterno(double valorInicial, int tempoDecorrido)
        {
            double juros = _api.ReturnGet();
            double valorJuros = Math.Pow((1 + juros), tempoDecorrido);
            double valorFinal = valorInicial * valorJuros;

            return Ok(valorFinal);
        }
        [HttpGet]
        [Route("Git")]
        public IActionResult ShowMeTheCode()
        {

            return Ok();
        }
    }
}
