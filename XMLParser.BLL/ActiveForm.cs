using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLParser.BLL
{
    public enum FormType
    {
        LoginForm,
        TestForm
    }

    public class ActiveForm
    {
        private static ActiveForm instance;
        private string activeFormPath = null;
        private Dictionary<FormType, string> forms;

        private ActiveForm()
        {
            forms = new Dictionary<FormType, string>();

            //inserting all forms
            Forms[FormType.LoginForm] = "~/Forms/LoginForm.xml";
            Forms[FormType.TestForm] = "~/Forms/TestForm.xml";
        }

        public static ActiveForm Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ActiveForm();
                }

                return instance;
            }
        }

        public Dictionary<FormType, string> Forms
        {
            get
            {
                return forms;
            }
        }

        public string ActiveFormPath
        {
            get
            {
                if(activeFormPath == null)
                {
                    activeFormPath = Forms[FormType.LoginForm];
                }
                return activeFormPath;
            }

            set
            {
                activeFormPath = value;
            }
        }

        public static string GetXsltPath(string clientType)
        {
            switch (clientType)
            {
                case "web":
                    return "~/XSLT/FormParseFile.xslt";
                default:
                    return "~/XSLT/FormParseFile.xslt";
            }
        }
    }
}
