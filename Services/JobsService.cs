using System;
using System.Collections;
using System.Collections.Generic;
using contract_manager.Models;
using contract_manager.Repositories;

namespace contract_manager.Services
{
    public class JobsService
    {
        private readonly JobsRepository _repo;
        public JobsService(JobsRepository repo)
        {
            _repo = repo;
        }
        internal IEnumerable<Job> GetAll()
        {
            return _repo.Get();
        }

        internal Job GetById(int id)
        {
            Job exists = _repo.Get(id);
            if (exists == null)
            {
                throw new Exception("Invalid Id");
            }
            return exists;
        }

        internal Job Create(Job newJob)
        {
            int id = _repo.Create(newJob);
            newJob.Id = id;
            return newJob;
        }

        internal string Delete(int id)
        {
            GetById(id);
            _repo.Delete(id);
            return "Successfully Deleted";
        }
    }
}