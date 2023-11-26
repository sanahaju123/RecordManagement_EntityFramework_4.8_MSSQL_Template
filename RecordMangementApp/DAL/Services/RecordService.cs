using RecordManagementApp.DAL.Interrfaces;
using RecordManagementApp.DAL.Services.Repository;
using RecordManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace RecordManagementApp.DAL.Services
{
    public class RecordService : IRecordService
    {
        private readonly IRecordRepository _repository;

        public RecordService(IRecordRepository repository)
        {
            _repository = repository;
        }

        public Task<Record> CreateRecord(Record expense)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public Task<bool> DeleteRecordById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public List<Record> GetAllRecords()
        {
            //write your code here
            throw new NotImplementedException();
        }

        public Task<Record> GetRecordById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public Task<Record> UpdateRecord(Record model)
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}