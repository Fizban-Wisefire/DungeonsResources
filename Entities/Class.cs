using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Class
    {
        public required int Id { get; set; }
        public required string Name { get; set; }
        public required string Resource { get; set; }
        public required string Description { get; set; }
        public required string HitDie { get; set; }
        public required string PrimaryAbility { get; set; }
        public required string Saves {  get; set; }
        public List<ClassDescriptionFeature> DescriptionFeatures { get; set; }
        public List<ClassMechanicFeature> MechanicFeatures { get; set; }

        public Class() { }

        public Class(int Id, string Name, string Resource , string Description, string HitDie, string PrimaryAbility, string Saves, List<ClassDescriptionFeature> DescriptionFeatures, List<ClassMechanicFeature> MechanicFeatures) 
        {
            this.Id = Id;
            this.Name = Name;   
            this.Resource = Resource;
            this.Description = Description; 
            this.HitDie = HitDie;
            this.PrimaryAbility = PrimaryAbility;
            this.Saves = Saves;
            this.DescriptionFeatures = DescriptionFeatures;
            this.MechanicFeatures = MechanicFeatures;
        }
    }
}
