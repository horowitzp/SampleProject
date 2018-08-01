using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Telerik
{
    public class CustomElementViewModel
    {
        public CustomElementViewModel()
        {
            Test = "123";
            Parameters = new List<Parameter>
            {
                new Parameter{Name="ItemA"},
                new Parameter{Name="ItemB"},
                new Parameter{Name="ItemC"},
                new Parameter{Name="ItemD"},
                new Parameter{Name="ItemE"},
                new Parameter{Name="ItemF"},
                new Parameter{Name="ItemG"},
                new Parameter{Name="ItemH"}
            };
        }

        #region properties
        //AutomationID generation
        private static int unique_identifier = 1;
        public string AutomationID => $"CustomElement_{unique_identifier++}";

        public string Test { get; set; }

        private List<Parameter> parameters;

        public List<Parameter> Parameters
        {
            get { return parameters; }
            set { parameters = value; }
        }
        #endregion
    }
}
