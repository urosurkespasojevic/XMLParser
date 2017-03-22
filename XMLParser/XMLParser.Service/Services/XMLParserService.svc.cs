using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace XMLParser.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "XMLParserService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select XMLParserService.svc or XMLParserService.svc.cs at the Solution Explorer and start debugging.
    public class XMLParserService : IXMLParserService
    {
        [WebGet(UriTemplate = "GetStartForm")]
        public string GetStartForm()
        {
            return "prc";
        }
    }
}
