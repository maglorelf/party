using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace party
{
    [System.AttributeUsage(System.AttributeTargets.Property, AllowMultiple = false)]
    public class VisibleGrid : System.Attribute
    {
        public bool IsVisible { get; set; }
        public string Header { get; set; }
        public int Order { get; set; }
        public VisibleGrid(string header,int order)
        {
            IsVisible = true;
            Header = header;
            Order = order;
        }
    }
}

