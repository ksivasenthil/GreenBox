using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.ModelBinding;

namespace GreenBoxService
{
    public class EmissionRequestModelBinder : IModelBinder
    {
        public bool BindModel(HttpActionContext actionContext, ModelBindingContext bindingContext)
        {
            var key = bindingContext.ModelName;
            var val = bindingContext.ValueProvider.GetValue(key);
            if (val != null)
            {
                var s = val.AttemptedValue;
                if (s != null)
                {
                    string[] rawData = s.Split(new[] { ',' });
                    bool validDataIsAvaialble = null != rawData && 3 == rawData.Length;
                    if (validDataIsAvaialble)
                    {
                        GetEmissionRequest model = new GetEmissionRequest()
                        {
                            VehicleSubTypeId = rawData[0],
                            MapXml = rawData[1]
                        };
                        string[] distanceArrays = rawData[2].Split('~');
                        bool validDistancePoint = null != distanceArrays && 0 < distanceArrays.Length;
                        if (validDistancePoint)
                        {
                            List<double> distances = new List<double>();
                            foreach (string points in distanceArrays)
                            {
                                distances.Add(Double.Parse(points));
                            }
                            model.Distance = distances.ToArray<double>();
                        }
                        bindingContext.Model = model;
                    }
                }
                else
                {
                    // change this line to null if you prefer nulls to empty arrays 
                    bindingContext.Model = default(GetEmissionRequest);
                }
                return true;
            }
            return false;
        }
    }
}