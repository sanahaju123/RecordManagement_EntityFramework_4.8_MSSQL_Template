using RecordManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace RecordManagementApp.DAL.Services.Repository
{
    public class RecordRepository : IRecordRepository
    {
        private readonly DatabaseContext _dbContext;
        public RecordRepository(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }


        public async Task<Record> CreateRecord(Record record)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteRecordById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public List<Record> GetAllRecords()
        {
            //write your code here
            throw new NotImplementedException();
        }

        public async Task<Record> GetRecordById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }

      
        

        public async Task<Record> UpdateRecord(Record model)
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}