using ApiAula.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiAula.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutosController : ControllerBase
    {
        
        [HttpGet()]
        public IEnumerable<Produto> Get()
        {
            return null;
        }

        [HttpPost()]
        public IEnumerable<Produto> Post( Produto produto)
        {
            return null;
        }
    }
}
