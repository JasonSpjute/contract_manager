using System;
using System.Collections.Generic;
using System.Data;
using contract_manager.Models;
using Dapper;

namespace contract_manager.Repositories
{
    public class JobsRepository
    {
        private readonly IDbConnection _db;

        public JobsRepository(IDbConnection db)
        {
            _db = db;
        }
        internal IEnumerable<Job> Get()
        {
            string sql = "SELECT * FROM jobs;";
            return _db.Query<Job>(sql);
        }

        internal Job Get(int id)
        {
            string sql = "SELECT * FROM jobs Where id = @id;";
            return _db.QueryFirstOrDefault<Job>(sql, new { id });
        }

        internal int Create(Job newJob)
        {
            string sql = @"
            INSERT INTO jobs
            (name, description, estimate)
            VALUES
            (@Name, @Description, @Estimate);
            SELECT LAST_INSERT_ID();";
            return _db.ExecuteScalar<int>(sql, newJob);
        }

        internal void Delete(int id)
        {
            string sql = "DELETE FROM jobs WHERE id = @id;";
            _db.Execute(sql, new { id });
        }
        internal IEnumerable<Job> GetJobsByContractorId(int contractorId)
        {
            string sql = @"
      SELECT j.*,
      co.id as ContractId 
      FROM contracts co
      JOIN jobs j ON j.id = co.jobId
      WHERE contractorId = @ContractorId";

            return _db.Query<ContractViewModel>(sql, new { contractorId });
        }
    }
}