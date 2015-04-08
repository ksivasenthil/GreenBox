using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GreenBoxService
{
    [DataContract]
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