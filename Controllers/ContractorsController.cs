using System;
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
        private readonly JobsService _jserv;
        public ContractorsController(ContractorsService serv, JobsService jserv)
        {
            _serv = serv;
            _jserv = jserv;
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
        [HttpGet("{contractorId}/contractorjobs")]
        public ActionResult<IEnumerable<Job>> GetContracts(int contractorId)
        {
            try
            {
                return Ok(_jserv.GetJobsByContractorId(contractorId));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}