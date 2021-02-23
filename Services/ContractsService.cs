using System;
using System.Collections;
using System.Collections.Generic;
using contract_manager.Models;
using contract_manager.Repositories;

namespace contract_manager.Services
{
    public class ContractsService
    {
        private readonly ContractsRepository _repo;
        public ContractsService(ContractsRepository repo)
        {
            _repo = repo;
        }
        internal Contract Create(Contract newContract)
        {
            int id = _repo.Create(newContract);
            newContract.Id = id;
            return newContract;
        }
        internal string Delete(int id)
        {
            GetById(id);
            _repo.Delete(id);
            return "Successfully Deleted";
        }
    }
}