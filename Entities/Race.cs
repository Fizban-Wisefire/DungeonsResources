using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Race
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Resource { get; set; }
        public string Description { get; set; }
        public int Str {  get; set; }
        public int Dex { get; set; }
        public int Con {  get; set; }
        public int Wis { get; set; }
        public int Int { get; set; }
        public int Cha { get; set; }
        public string Age { get; set; }
        public string Size { get; set; }
        public int Speed { get; set; }
        public List<RaceDescriptionFeature> DescriptionFeatures { get; set; }
        public List<RaceMechanicFeature> MechanicFeatures { get; set; }
        


        public Race(int Id, string Name, string Resource, string Description, int Str, int Dex, int Con, int Wis, int Int, int Cha, string Age, string Size, int Speed, List<RaceDescriptionFeature> DescriptionFeatures, List<RaceMechanicFeature> MechanicFeatures) 
        {
            this.Id = Id;
            this.Name = Name;
            this.Resource = Resource;
            this.Description = Description;
            this.Str = Str;
            this.Dex = Dex;
            this.Con = Con;
            this.Wis = Wis;
            this.Int = Int;
            this.Cha = Cha;
            this.Age = Age;
            this.Size = Size;
            this.Speed = Speed;
            this.DescriptionFeatures = DescriptionFeatures;
            this.MechanicFeatures = MechanicFeatures;
        }
    }
}
