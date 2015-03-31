﻿using GreenStore;
using Model;
using Repository;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;
using System.Web.Script.Serialization;

namespace GreenBoxService
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
    public class GreenBox : IGreenBox
    {
        public decimal[] GetEmission(GetEmissionRequest request)
        {

            Context store = new Context();
            VehicleTypeRepository repo = new VehicleTypeRepository(store);

            /*Dictionary<string, object> routeData = new JavaScriptSerializer().Deserialize<Dictionary<string, object>>(routeDetails);
            Dictionary<string, object> legs = (routeData["routes"] as Dictionary<string, object>)["legs"] as Dictionary<string, object>;
            ArrayList steps = legs["steps"] as ArrayList;
            foreach (var step in steps)
            {
                Dictionary<string, object> distanceData = (step as Dictionary<string, object>)["distance"] as Dictionary<string, object>;
                decimal distance = Decimal.Parse(distanceData["value"] as string);
                Guid subTypeId = Guid.Parse(vehicleSubType);
                VehicleSubType details = repo.GetSubTypeDetails(subTypeId);
                decimal emissionFactor = details.FuelType.CO2Emissions;
                decimal mileage = details.Mileage;
                decimal CO2Emissions = emissionFactor * (distance / mileage);
                StringBuilder instructions = new StringBuilder((step as Dictionary<string, object>)["instructions"] as string);
                instructions.Insert(0, CO2Emissions.ToString());
                (step as Dictionary<string, object>)["instructions"] = instructions.ToString();
            }
            return (new JavaScriptSerializer()).Serialize(routeData);
             */
            Guid subTypeId = Guid.Parse(request.VehicleSubTypeId);
            VehicleSubType details = repo.GetSubTypeDetails(subTypeId);
            decimal emissionFactor = details.FuelType.CO2Emissions;
            decimal mileage = details.Mileage;
            //converting the entire leg distance to an array and then performing actions and conveting to an array and then passing this back to client
            List<decimal> _legDistance = new List<decimal>();
            for (int i = 0; i < request.Distance.Length; i++)
            {
                _legDistance.Add((request.Distance[i] / mileage) * emissionFactor);
            }
            return _legDistance.ToArray();

            //decimal CO2Emissions = emissionFactor * (request.Distance / mileage);
            //return CO2Emissions;
        }

        public List<VehicleType> GetVehicleType()
        {
            Context store = new Context();
            VehicleTypeRepository RepositoryObj = new VehicleTypeRepository(store);
            return RepositoryObj.GetAll().ToList<VehicleType>();
        }



        public List<VehicleSubType> GetVehicleSubType(VehicleSubTypeRequest VehicleType)
        {
            Context store = new Context();
            VehicleTypeRepository RepositoryObj = new VehicleTypeRepository(store);
            return RepositoryObj.GetSubTypesForAType(VehicleType.VehicleTypeID).ToList<VehicleSubType>();
        }
    }
}
