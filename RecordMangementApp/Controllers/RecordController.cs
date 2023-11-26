using RecordManagement.Models;
using RecordManagementApp.DAL.Interrfaces;
using RecordManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace RecordManagementApp.Controllers
{
    public class RecordController : ApiController
    {
        private readonly IRecordService _service;
        public RecordController(IRecordService service)
        {
            _service = service;
        }
        public RecordController()
        {
            // Constructor logic, if needed
        }
        [HttpPost]
        [Route("api/Record/CreateRecord")]
        [AllowAnonymous]
        public async Task<IHttpActionResult> CreateRecord([FromBody] Record model)
        {
            //write your code here
            throw new NotImplementedException();
        }


        [HttpPut]
        [Route("api/Record/UpdateRecord")]
        public async Task<IHttpActionResult> UpdateRecord([FromBody] Record model)
        {
            //write your code here
            throw new NotImplementedException();
        }


        [HttpDelete]
        [Route("api/Record/DeleteRecord")]
        public async Task<IHttpActionResult> DeleteRecord(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }


        [HttpGet]
        [Route("api/Record/GetRecordById")]
        public async Task<IHttpActionResult> GetRecordById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }


        [HttpGet]
        [Route("api/Record/GetAllRecords")]
        public async Task<IEnumerable<Record>> GetAllRecords()
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}
