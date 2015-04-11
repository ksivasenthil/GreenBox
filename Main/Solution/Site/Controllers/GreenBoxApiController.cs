using Model;
using Repository;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GreenBoxService.Controllers
{
    public class GreenBoxApiController : ApiController
    {
        private string CONNECTION_STRING = ConfigurationManager.AppSettings["ACTIVE_CONFIGURATION"];
        // GET api/<controller>
        public IEnumerable<VehicleType> GetAllVehicleTypes()
        {
            VehicleTypeRepository repo = new VehicleTypeRepository(CONNECTION_STRING);
            IEnumerable<VehicleType> vehicleTypes = default(IEnumerable<VehicleType>);
            vehicleTypes = repo.GetAll();
            return vehicleTypes;
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}