using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ClassMechanicFeature
    {
        public required int Id { get; set; }
        public required string Class { get; set; }
        public required string Name { get; set; }
        public required int Level { get; set; }
        public string Type { get; set; }
        public required string Text { get; set; }
        public required string CharacterSheetText { get; set; }


        public ClassMechanicFeature(int Id, string Class, string Name, int Level, string Type, string Text, string CharacterSheetText)
        {
            this.Id = Id;
            this.Class = Class;
            this.Name = Name;
            this.Level = Level;
            this.Type = Type;
            this.Text = Text;
            this.CharacterSheetText = CharacterSheetText;
        }

    }
}
