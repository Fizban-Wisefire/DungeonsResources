using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class RaceMechanicFeature
    {
        public required int Id { get; set; }
        public required string Race { get; set; }
        public required string Name { get; set; }
        public required string Text { get; set; }
        public required string CharacterSheetText { get; set; }


        public RaceMechanicFeature(string Race, string Name, string Text, string CharacterSheetText)
        {
            this.Race = Race;
            this.Name = Name;
            this.Text = Text;
            this.CharacterSheetText = CharacterSheetText;
        }

    }
}
