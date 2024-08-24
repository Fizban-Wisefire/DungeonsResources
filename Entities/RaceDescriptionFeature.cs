using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class RaceDescriptionFeature
    {
        public string Race { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Text { get; set; }


        public RaceDescriptionFeature(string Race, string Name, string Type, string Text)
        {
            this.Race = Race;
            this.Name = Name;
            this.Type = Type;
            this.Text = Text;
        }
    }


}
