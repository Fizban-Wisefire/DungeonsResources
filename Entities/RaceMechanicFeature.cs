using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class RaceMechanicFeature
    {
        public string Race { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public string CharacterSheetText { get; set; }


        public RaceMechanicFeature(string Race, string Name, string Text, string CharacterSheetText)
        {
            this.Race = Race;
            this.Name = Name;
            this.Text = Text;
            this.CharacterSheetText = CharacterSheetText;
        }

    }
}
