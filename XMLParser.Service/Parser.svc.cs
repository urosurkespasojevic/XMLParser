using System.Xml;
using System.Xml.XPath;
using System.Xml.Xsl;
using System.Web;
using System.IO;
using XMLParser.BLL;
using XMLParser.BLL.Interface;
using XMLParser.Models.Interfaces;
using XMLParser.Models;

namespace XMLParser.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Parser" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Parser.svc or Parser.svc.cs at the Solution Explorer and start debugging.
    public class Parser : IParser
    {
        public string GetView(string clientType)
        {
            //var reqestHeader = WebOperationContext.Current.IncomingRequest;
            //var useragent = reqestHeader.UserAgent;           


            StringWriter result = new StringWriter();
            XslCompiledTransform transformXML = new XslCompiledTransform();
            transformXML.Load(HttpContext.Current.Server.MapPath(ActiveForm.GetXsltPath(clientType)));
            XPathDocument xpathdocument = new XPathDocument(HttpContext.Current.Server.MapPath(ActiveForm.Instance.ActiveFormPath));
            XmlTextWriter writer = new XmlTextWriter(result);
            writer.Formatting = Formatting.Indented;
            transformXML.Transform(xpathdocument, null, writer, null);
            return result.ToString();
        }

        public string SubmitForm(string formType,Stream data)
        {
            StreamReader reader = new StreamReader(data);
            string body = reader.ReadLine();            
            ActiveForm.Instance.ActiveFormPath = ActiveForm.Instance.Forms[FormType.TestForm];
            //GetView();
            return "ok";
        }

    }
}
