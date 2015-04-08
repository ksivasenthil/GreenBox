using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;


namespace GreenBoxService
{
    [ServiceContract]
    public interface IGreenBox
    {
        [OperationContract]
        [WebInvoke
           (UriTemplate = "GetEmission",
            Method = "POST",
            RequestFormat = WebMessageFormat.Xml,
            BodyStyle = WebMessageBodyStyle.Bare)]
        double[] GetEmission(GetEmissionRequest request);

        [OperationContract]
        [WebGet(UriTemplate = "GetVehicleType",
            ResponseFormat = WebMessageFormat.Xml,
            BodyStyle = WebMessageBodyStyle.Bare)]
        List<VehicleType> GetVehicleType();

        [OperationContract]
        [WebInvoke(UriTemplate = "GetVehicleSubType",
            Method = "POST",
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare)]
        List<VehicleSubType> GetVehicleSubType(VehicleSubTypeRequest VehicleTypeId);

    }
}
