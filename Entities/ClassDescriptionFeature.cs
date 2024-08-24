using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ClassDescriptionFeature
    {
        public string Class { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Text { get; set; }


        public ClassDescriptionFeature(string Class, string Name, string Type, string Text)
        {
            this.Class = Class;
            this.Name = Name;
            this.Type = Type;
            this.Text = Text;
        }
    }


}
