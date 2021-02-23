using System;
using System.Collections.Generic;
using System.Data;
using contract_manager.Models;
using Dapper;

namespace contract_manager.Repositories
{
    public class ContractsRepository
    {
        private readonly IDbConnection _db;

        public ContractsRepository(IDbConnection db)
        {
            _db = db;
        }
        internal int Create(Contract newContract)
        {
            string sql = @"
            INSERT INTO contracts
            (contractorId, jobId, finalPrice, completed)
            VALUES
            (@ContractorId, @JobId, @FinalPrice, @Completed);
            SELECT LAST_INSERT_ID();";
            return _db.ExecuteScalar<int>(sql, newContract);
        }
        internal void Delete(int id)
        {
            string sql = "DELETE FROM contracts WHERE id = @id;";
            _db.Execute(sql, new { id });
        }
    }
}