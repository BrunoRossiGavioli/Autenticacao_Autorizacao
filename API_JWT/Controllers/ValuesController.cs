using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API_JWT.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class ValuesController : ControllerBase
    {
        private readonly string[] _nomes = new string[] { "Bruno", "João", "Vinicius", "Ruan", "Alison", "Cristiano", "Luiz" };

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return _nomes;
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            if (id > _nomes.Length - 1)
                return BadRequest("Nome não encontrado");

            return Ok(_nomes[id]);
        }

    }
}
