using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Class
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Resource { get; set; }
        public string Description { get; set; }
        public string HitDie { get; set; }
        public string PrimaryAbility { get; set; }
        public string Saves {  get; set; }
        public List<ClassDescriptionFeature> DescriptionFeatures { get; set; }
        public List<ClassMechanicFeature> MechanicFeatures { get; set; }

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
