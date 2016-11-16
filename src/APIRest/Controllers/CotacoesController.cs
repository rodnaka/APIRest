using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using APIRest.Data;

namespace APIRest.Controllers
{
    [Route("api/[controller]")]
    public class CotacoesController : Controller
    {        
        [HttpGet("{id}")]
        public Cotacao Get([FromServices]CotacaoContext context, string id)
        {
            return context.Cotacoes.Where(c => c.Sigla == id).FirstOrDefault();
        }
    }
}
