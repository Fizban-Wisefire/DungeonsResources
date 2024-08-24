using Entities;
using System.Text.Json;

namespace DungeonsResources
{
    public class JsonAccess : IDataAccess
    {
        public List<Race> GetRaces()
        {
            string fileName = "wwwroot/sampleData/races.json";
            using FileStream openStream = File.OpenRead(fileName);
            List<Race>? races = JsonSerializer.Deserialize<List<Race>>(openStream);
            Console.WriteLine(races[1]);
            return races;
        }

        public List<RaceDescriptionFeature> GetRaceDescriptionFeatures(string raceName)
        {
            Console.WriteLine("Starting D Features");
            string fileName = "wwwroot/sampleData/raceDescriptionFeatures.json";
            using FileStream openStream = File.OpenRead(fileName);
            List<RaceDescriptionFeature>? featureList = JsonSerializer.Deserialize<List<RaceDescriptionFeature>>(openStream);
            List<RaceDescriptionFeature> newList = new List<RaceDescriptionFeature>();
            foreach (RaceDescriptionFeature feature in featureList)
            {
                if (feature.Race == raceName)
                {
                    newList.Add(feature);
                }
            }
            Console.WriteLine("Finished D Features");
            return newList;
        }
        public List<RaceMechanicFeature> GetRaceMechanicFeatures(string raceName)
        {
            Console.WriteLine("Starting M Features");
            string fileName = "wwwroot/sampleData/raceMechanicFeatures.json";
            using FileStream openStream = File.OpenRead(fileName);
            List<RaceMechanicFeature>? featureList = JsonSerializer.Deserialize<List<RaceMechanicFeature>>(openStream);
            List<RaceMechanicFeature> newList = new List<RaceMechanicFeature>();
            foreach (RaceMechanicFeature feature in featureList)
            {
                Console.WriteLine($"{feature.Race} vs {raceName}");
                if (feature.Race == raceName)
                {
                    Console.WriteLine("True");
                    newList.Add(feature);
                }
            }
            Console.WriteLine(newList.Count);
            return newList;
        }
        public Race GetRace(int id)
        {
            List<Race> races = GetRaces();
            Race newRace = races[id];
            List<RaceDescriptionFeature> descriptionFeatures = GetRaceDescriptionFeatures(newRace.Name);
            newRace.DescriptionFeatures = descriptionFeatures;
            List<RaceMechanicFeature> mechanicFeatures = GetRaceMechanicFeatures(newRace.Name);
            newRace.MechanicFeatures = mechanicFeatures;
            return newRace;
        }

        public List<Class> GetClasses()
        {
            string fileName = "wwwroot/sampleData/classes.json";
            using FileStream openStream = File.OpenRead(fileName);
            List<Class>? classes = JsonSerializer.Deserialize<List<Class>>(openStream);
            Console.WriteLine(classes[0]);
            return classes;
        }


        public List<ClassDescriptionFeature> GetClassDescriptionFeatures(string className)
        {
            Console.WriteLine("Starting D Features");
            string fileName = "wwwroot/sampleData/classDescriptionFeatures.json";
            using FileStream openStream = File.OpenRead(fileName);
            List<ClassDescriptionFeature>? featureList = JsonSerializer.Deserialize<List<ClassDescriptionFeature>>(openStream);
            List<ClassDescriptionFeature> newList = new List<ClassDescriptionFeature>();
            foreach (ClassDescriptionFeature feature in featureList)
            {
                if (feature.Class == className)
                {
                    newList.Add(feature);
                }
            }
            Console.WriteLine("Finished D Features");
            return newList;
        }
        public List<ClassMechanicFeature> GetClassMechanicFeatures(string className)
        {
            Console.WriteLine("Starting M Features");
            string fileName = "wwwroot/sampleData/classMechanicFeatures.json";
            using FileStream openStream = File.OpenRead(fileName);
            List<ClassMechanicFeature>? featureList = JsonSerializer.Deserialize<List<ClassMechanicFeature>>(openStream);
            List<ClassMechanicFeature> newList = new List<ClassMechanicFeature>();
            foreach (ClassMechanicFeature feature in featureList)
            {
                Console.WriteLine($"{feature.Class} vs {className}");
                if (feature.Class == className)
                {
                    Console.WriteLine("True");
                    newList.Add(feature);
                }
            }
            Console.WriteLine(newList.Count);
            return newList;
        }
        public Class GetClass(int id)
        {
            List<Class> classes = GetClasses();
            Class newClass = classes[id];
            List<ClassDescriptionFeature> descriptionFeatures = GetClassDescriptionFeatures(newClass.Name);
            newClass.DescriptionFeatures = descriptionFeatures;
            List<ClassMechanicFeature> mechanicFeatures = GetClassMechanicFeatures(newClass.Name);
            newClass.MechanicFeatures = mechanicFeatures;
            return newClass;
        }
    }
}