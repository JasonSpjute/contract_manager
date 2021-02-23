using System.Collections.Generic;
using contract_manager.Models;
using contract_manager.Services;
using Microsoft.AspNetCore.Mvc;

namespace contract_manager.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class ContractorsController : ControllerBase
    {
        private readonly ContractorsService _serv;
        public ContractorsController(ContractorsService serv)
        {
            _serv = serv;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Contractor>> GetAll()
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
        public ActionResult<Contractor> GetById(int id)
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
        public ActionResult<Contractor> Create([FromBody] Contractor newContractor)
        {
            try
            {
                return Ok(_serv.Create(newContractor));
            }
            catch (System.Exception err)
            {
                return BadRequest(err.Message);
            }
        }

        [HttpDelete("{id}")]
        public ActionResult<Contractor> Delete(int id)
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