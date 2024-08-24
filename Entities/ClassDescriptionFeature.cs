using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ClassDescriptionFeature
    {
        public required int Id { get; set; }
        public required string Class { get; set; }
        public required string Name { get; set; }
        public required string Type { get; set; }
        public required string Text { get; set; }


        public ClassDescriptionFeature(string Class, string Name, string Type, string Text)
        {
            this.Class = Class;
            this.Name = Name;
            this.Type = Type;
            this.Text = Text;
        }
    }


}
