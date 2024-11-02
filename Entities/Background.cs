using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Background
    {
        public required int Id {  get; set; }
        public required string Name { get; set; }
        public string Description { get; set; }
        public string Skills { get; set; }
        public string Languages { get; set; }
        public string Instruments { get; set; }
        public string Equipment { get; set; }
        public int Features { get; set; }
        public List<BackgroundFeature> BackgroundFeatures { get; set; }

        public Background(int Id, string Name, string Description, string Skills, string Languages, string Instruments, string Equipment, int Features)
        {
            this.Id = Id;
            this.Name = Name;
            this.Description = Description;
            this.Skills = Skills;
            this.Languages = Languages;
            this.Instruments = Instruments;
            this.Equipment = Equipment;
            this.Features = Features;
        }

/* CHANGE SKILLS LANGUAGES INSTRUMENTS EQUIPMENT AND FEATURES TO LISTS OF */
    }
}
