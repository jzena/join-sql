using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JoinSQL
{
    public class Routines
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public string Definition { get; set; }
        public List<DefitionItem> ListDefinitionItem { get; set; }
    }

    public class DefitionItem
    {
        public string Text { get; set; }
    }
}
