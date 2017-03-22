using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XMLParser.Models.Interfaces;
using System.ServiceModel;
using System.Runtime.Serialization.Json;

namespace XMLParser.Models
{
    [DataContractFormat]
    public class LoginFormModel:IFormModel
    {
        [MessageBodyMember]
        public string Username { get; set; }

        [MessageBodyMember]
        public string Password{ get; set; }
    }
}
