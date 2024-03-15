using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RadarFit.BLL;
using RadarFit.MODEL.Entities;
using System.Net;

namespace RadarFit.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ObjetoController : ControllerBase
    {
        private readonly ObjetoBLL _objetoBLL;
        public ObjetoController(ObjetoBLL objetoBLL) {
            _objetoBLL = objetoBLL;
        }

        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Object>>> GetAll(int page, int limit)
        {
            try
            {
                var Objetos = await _objetoBLL.GetAll(page, limit).ConfigureAwait(false);
                return Ok(Objetos);
            }
            catch (Exception e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e);
            }
        }

        [HttpGet]
        [Route("id")]
        public async Task<ActionResult<List<Object>>> GetById(int Id)
        {
            try
            {
                var objeto = await _objetoBLL.GetById(Id).ConfigureAwait(false);
                return Ok(objeto);
            }
            catch (Exception e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e);
            }
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<List<Object>>> Create(Objeto objeto)
        {
            try
            {
                var obj = await _objetoBLL.Create(objeto).ConfigureAwait(false);
                return Ok(obj);
            }
            catch (Exception e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e);
            }
        }

        [HttpPut]
        [Route("")]
        public async Task<ActionResult<List<Object>>> Update(Objeto objeto)
        {
            try
            {
                var obj = await _objetoBLL.Update(objeto).ConfigureAwait(false);
                return Ok(obj);
            }
            catch (Exception e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e);
            }
        }

        [HttpDelete]
        [Route("")]
        public async Task<ActionResult<List<Object>>> Delete(int Id)
        {
            try
            {
                var obj = await _objetoBLL.Delete(Id).ConfigureAwait(false);
                return Ok(obj);
            }
            catch (Exception e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e);
            }
        }
    }
}
