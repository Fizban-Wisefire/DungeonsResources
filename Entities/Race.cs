using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Race
    {
        public required int Id { get; set; }
        public required string Name { get; set; }
        public required string Resource { get; set; }
        public string Description { get; set; }
        public required int Str {  get; set; }
        public required int Dex { get; set; }
        public required int Con {  get; set; }
        public required int Wis { get; set; }
        public  required int Int { get; set; }
        public required int Cha { get; set; }
        public required string Age { get; set; }
        public required string Size { get; set; }
        public required int Speed { get; set; }
        public List<RaceDescriptionFeature> DescriptionFeatures { get; set; }
        public List<RaceMechanicFeature> MechanicFeatures { get; set; }
        
        public Race() { }

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
