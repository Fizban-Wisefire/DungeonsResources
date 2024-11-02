using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    internal class Subrace
    {
        public required int Id { get; set; }
        public required string Name { get; set; }
        public required string Race { get; set; }
        public string Resource { get; set; }
        public string Description { get; set; }
        public int Str {  get; set; }
        public int Dex {  get; set; }
        public int Con {  get; set; }
        public int Int {  get; set; }
        public int Wis {  get; set; }
        public int Cha {  get; set; }
    }
}
