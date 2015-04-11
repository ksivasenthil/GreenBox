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

        public IEnumerable<VehicleType> GetAllVehicleTypes()
        {
            VehicleTypeRepository repo = new VehicleTypeRepository(CONNECTION_STRING);
            IEnumerable<VehicleType> vehicleTypes = default(IEnumerable<VehicleType>);
            vehicleTypes = repo.GetAll();
            return vehicleTypes;
        }

        public List<VehicleSubType> GetVehicleSubTypeById(string id)
        {
            VehicleTypeRepository repo = new VehicleTypeRepository(CONNECTION_STRING);
            List<VehicleSubType> vehicleSubTypes = default(List<VehicleSubType>);
            Guid vehicleTypeId = Guid.Parse(id);
            vehicleSubTypes = repo.GetSubTypesForAType(vehicleTypeId);
            return vehicleSubTypes;
        }

        public IEnumerable<double> GetEmissionFactors(GetEmissionRequest data)
        {
            VehicleTypeRepository repo = new VehicleTypeRepository(CONNECTION_STRING);

            Guid subTypeId = Guid.Parse(data.VehicleSubTypeId);
            VehicleSubType details = repo.GetSubTypeDetails(subTypeId);
            double emissionFactor = details.FuelType.CO2EmissionFactor;
            double mileage = details.Mileage;
            //converting the entire leg distance to an array and then performing actions and conveting to an array and then passing this back to client
            List<double> _legDistance = new List<double>();
            for (int i = 0; i < data.Distance.Length; i++)
            {
                _legDistance.Add((data.Distance[i] / mileage) * emissionFactor);
            }
            return _legDistance;
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