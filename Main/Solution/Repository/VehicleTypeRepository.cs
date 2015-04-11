using GreenStore;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Repository
{
    public class VehicleTypeRepository
    {
        private Battery storage;

        public VehicleTypeRepository(string connectionString)
        {
            storage = new Battery(connectionString);
        }

        public VehicleSubType GetSubTypeDetails(Guid vehicleSubTypeId)
        {
            bool searchCriteriaProvided = null != vehicleSubTypeId && !Guid.Empty.Equals(vehicleSubTypeId);
            if (searchCriteriaProvided)
            {
                VehicleSubType returnValue;
                Expression<Func<VehicleSubType, bool>> criteria = d => d.Id.Equals(vehicleSubTypeId);
                returnValue = storage.Where(criteria).FirstOrDefault<VehicleSubType>();
                return returnValue;
            }
            else
            {
                return default(VehicleSubType);
            }
        }

        public List<VehicleType> GetAll()
        {
            List<VehicleType> returnValue;
            Expression<Func<VehicleType, bool>> criteria = d => 1 == 1;
            returnValue = storage.Where(criteria).ToList<VehicleType>();
            return returnValue;
        }

        public List<VehicleSubType> GetSubTypesForAType(Guid vehicleTypeId)
        {
            bool searchCriteriaProvided = null != vehicleTypeId && !Guid.Empty.Equals(vehicleTypeId);
            if (searchCriteriaProvided)
            {
                List<VehicleSubType> returnValue;
                Expression<Func<VehicleSubType, bool>> criteria = d => d.VehicleTypeId.Equals(vehicleTypeId);
                returnValue = storage.Where(criteria).ToList<VehicleSubType>();
                return returnValue;
            }
            else
            {
                return default(List<VehicleSubType>);
            }
        }
    }
}
