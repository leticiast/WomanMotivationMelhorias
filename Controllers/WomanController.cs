// Async representa métodos assíncronos baseados em tarefas.

using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using WomanMotivation_.Models;
using System;
using WomanMotivation_.Data;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WomanMotivation_.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WomanController : ControllerBase
    {   
        //Método Get 
        //Dentro do Get tem um parametro DataContext para acessar o dados. 
        //static int count = 1; 
        [EnableCors("Policy1")]
        [HttpGet]
        public async Task<ActionResult<FraseMotivacional>> Get([FromServices] DataContext context)
        {
            
            var frasesMotivacionais = await context.FrasesMotivacionais.ToListAsync();
            var diaAtual = DateTime.Now.Day;        
            //count++;
                   
            return frasesMotivacionais[diaAtual-1];
        }    
        //Método Post
        [HttpPost]
        [Route("[controller]")]

        public async Task<ActionResult<FraseMotivacional>> Post([FromServices] DataContext context, [FromBody]FraseMotivacional model)
        {
            context.FrasesMotivacionais.Add(model);
            await context.SaveChangesAsync(); 
            return model; 
        }
    }
}
