using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XMLParser.Models.Interfaces;

namespace XMLParser.BLL.Interface
{
    public interface IFormSubmitter
    {
        string Submit(IFormModel model);
    }
}
