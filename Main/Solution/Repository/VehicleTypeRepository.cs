using GreenStore;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class VehicleTypeRepository
    {
        private Battery storage;

        public VehicleTypeRepository(Battery store)
        {
            storage = store;
        }

        public VehicleSubType GetSubTypeDetails(Guid vehicleSubTypeId)
        {
            throw new NotImplementedException();
        }

        public List<VehicleType> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<VehicleSubType> GetSubTypesForAType(Guid vehicleTypeId)
        {
            throw new NotImplementedException();
        }
    }
}
