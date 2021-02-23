using System.Collections.Generic;
using contract_manager.Models;
using contract_manager.Services;
using Microsoft.AspNetCore.Mvc;

namespace contract_manager.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class ContractsController : ControllerBase
    {
        private readonly ContractsService _serv;
        public ContractsController(ContractsService serv)
        {
            _serv = serv;
        }

        [HttpPost]
        public ActionResult<Contract> Create([FromBody] Contract newContract)
        {
            try
            {
                return Ok(_serv.Create(newContract));
            }
            catch (System.Exception err)
            {
                return BadRequest(err.Message);
            }
        }
        [HttpDelete("{id}")]
        public ActionResult<Contract> Delete(int id)
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