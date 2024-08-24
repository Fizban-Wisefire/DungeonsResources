using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class RaceDescriptionFeature
    {
        public required int Id {  get; set; }
        public required string Race { get; set; }
        public required string Name { get; set; }
        public required string Type { get; set; }
        public required string Text { get; set; }


        public RaceDescriptionFeature(string Race, string Name, string Type, string Text)
        {
            this.Race = Race;
            this.Name = Name;
            this.Type = Type;
            this.Text = Text;
        }
    }


}
