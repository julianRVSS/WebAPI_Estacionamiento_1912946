using Microsoft.AspNetCore.Mvc;
using WebApiEstacionamiento.Entidades;

namespace WebApiEstacionamiento.Controllers
{
    [ApiController]
    [Route("api/estacionamiento")]
    public class EstacionamientoController : ControllerBase
    {
        [HttpGet]

        public ActionResult<List<Estacionamiento>> Get() 
       {
            return new List<Estacionamiento>()
            {
                new Estacionamiento() { id = 1 , ocupado = true},
                new Estacionamiento() { id = 2 , ocupado = true}
            };
       }
    }  
}
