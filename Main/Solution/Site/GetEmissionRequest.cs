using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Web.Http.ModelBinding;

namespace GreenBoxService
{
    [DataContract]
    [ModelBinder(typeof(EmissionRequestModelBinder))]
    public class GetEmissionRequest
    {
        [DataMember]
        public string VehicleSubTypeId { get; set; }

        [DataMember]
        public double[] Distance { get; set; }

        [DataMember]
        public string MapXml { get; set; }
    }
}