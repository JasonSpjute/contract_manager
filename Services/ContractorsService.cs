using System;
using System.Collections;
using System.Collections.Generic;
using contract_manager.Models;
using contract_manager.Repositories;

namespace contract_manager.Services
{
    public class ContractorsService
    {
        private readonly ContractorsRepository _repo;
        public ContractorsService(ContractorsRepository repo)
        {
            _repo = repo;
        }
        internal IEnumerable<Contractor> GetAll()
        {
            return _repo.Get();
        }

        internal Contractor GetById(int id)
        {
            Contractor exists = _repo.Get(id);
            if (exists == null)
            {
                throw new Exception("Invalid Id");
            }
            return exists;
        }

        internal Contractor Create(Contractor newContractor)
        {
            int id = _repo.Create(newContractor);
            newContractor.Id = id;
            return newContractor;
        }

        internal string Delete(int id)
        {
            GetById(id);
            _repo.Delete(id);
            return "Successfully Deleted";
        }
    }
}