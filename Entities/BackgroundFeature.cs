using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class BackgroundFeature
    {
        public required int Id { get; set; }
        public required string Name { get; set; }
        public string Description { get; set; }
        public string Personality { get; set; }
        public string Idea { get; set; }
        public string Bond {  get; set; }
        public string Flaw { get; set; }

    }
}
