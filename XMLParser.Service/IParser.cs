using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Web;
using System.Text;
using XMLParser.Models.Interfaces;

namespace XMLParser.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IParser" in both code and config file together.
    [ServiceContract]
    public interface IParser
    {
        [OperationContract]
        [WebInvoke(UriTemplate = "/getview/{clientType}", Method = "GET", BodyStyle = WebMessageBodyStyle.Bare,
            RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string GetView(string clientType);

        [OperationContract]
        [WebInvoke(UriTemplate = "/submitform/{formType}", Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped,
            RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string SubmitForm(string formType, Stream data);
    }
}
