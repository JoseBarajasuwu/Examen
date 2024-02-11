using AgregarUsuarios.Dato;
using AgregarUsuarios.Modelo;
using Microsoft.AspNetCore.Mvc;

namespace webService.Controllers
{
    [ApiController]
    [Route("api/VerExamenes")]
    public class ExamenController
    {
        [HttpGet]
        public async Task<ActionResult<List<ExamenModel>>> Get()
        {
            var funcion = new Examen();
            var lista = await funcion.MostrarExamen();
            return lista;

        }
        

    }
}
