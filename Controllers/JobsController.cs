using System.Collections.Generic;
using contract_manager.Models;
using contract_manager.Services;
using Microsoft.AspNetCore.Mvc;

namespace contract_manager.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class JobsController : ControllerBase
    {
        private readonly JobsService _serv;
        public JobsController(JobsService serv)
        {
            _serv = serv;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Job>> GetAll()
        {
            try
            {
                return Ok(_serv.GetAll());
            }
            catch (System.Exception err)
            {
                return BadRequest(err.Message);
            }
        }

        [HttpGet("{id}")]
        public ActionResult<Job> GetById(int id)
        {
            try
            {
                return Ok(_serv.GetById(id));
            }
            catch (System.Exception err)
            {
                return BadRequest(err.Message);
            }
        }

        [HttpPost]
        public ActionResult<Job> Create([FromBody] Job newJob)
        {
            try
            {
                return Ok(_serv.Create(newJob));
            }
            catch (System.Exception err)
            {
                return BadRequest(err.Message);
            }
        }

        [HttpDelete("{id}")]
        public ActionResult<Job> Delete(int id)
        {
            try
            {
                return Ok(_serv.Delete(id));
            }
            catch (System.Exception err)
            {
                return BadRequest(err.Message);
            }
        }
    }
}
