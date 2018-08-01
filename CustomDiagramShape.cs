using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.Windows.Controls;

namespace Project_Telerik
{
    public class CustomDiagramShape : RadDiagramShape
    {
        public CustomDiagramShape(CustomElementViewModel viewModel)
        {
            DataContext = viewModel;
            //Test = "123";
            //Parameters = new List<Parameter>
            //{
            //    new Parameter{Name="A"},
            //    new Parameter{Name="B"},
            //    new Parameter{Name="C"},
            //    new Parameter{Name="D"},
            //    new Parameter{Name="E"},
            //    new Parameter{Name="F"},
            //    new Parameter{Name="G"},
            //    new Parameter{Name="H"}
            //};
        }

        //private List<Parameter> parameters;

        //public List<Parameter> Parameters
        //{
        //    get { return parameters; }
        //    set { parameters = value; }
        //}
        //public string Test { get; set; }
    }
}
