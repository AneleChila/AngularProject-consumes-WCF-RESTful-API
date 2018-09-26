using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ImperialToMetric
{
    
    [ServiceContract]
    public interface IImperialMetric
    {
        [OperationContract]
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,

        BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "/InchToMetre/{value}")]
        double InchToMetre(string value);


        [OperationContract]
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,

        BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "/MetreToInch/{value}")]
        double MetreToInch(string value);


        [OperationContract]
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,

        BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "/FootToMetre/{value}")]
        double FootToMetre(string value);


        [OperationContract]
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,

        BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "/MetreToFoot/{value}")]
        double MetreToFoot(string value);


        [OperationContract]
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,

        BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "/YardToMetre/{value}")]
        double YardToMetre(string value);


        [OperationContract]
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,

        BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "/MetreToYard/{value}")]
        double MetreToYard(string value);


        [OperationContract]
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,

        BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "/MilesToMetre/{value}")]
        double MilesToMetre(string value);


        [OperationContract]
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,

        BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "/MetreToMiles/{value}")]
        double MetreToMiles(string value);
    }
}
