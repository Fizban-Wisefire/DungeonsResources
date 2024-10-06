using Entities;
using WebAPI.Data;

namespace WebAPI
{
    public class DbAccess : IDataAccess
    {
        public DbAccess() { }

        public List<Race> GetRaces() 
        {
            using (var context = new DungeonResourceContext())
            {
                List<Race> races = context.Races.ToList();
                return races;
            }
        }

        public Race GetRace(int id) 
        {
            using (var context = new DungeonResourceContext()) 
            {
                Race race = context.Races.Single(race => race.Id == id);
                return race;
            }
        }

        public List<Class> GetClasses()
        {
            using (var context = new DungeonResourceContext())
            {
                List<Class> classes = context.Classes.ToList();
                return classes;
            }
        }

        public Class GetClass(int id) 
        {
            using (var context = new DungeonResourceContext())
            {
                Class newclass = context.Classes.Single(newclass => newclass.Id == id);
                return newclass;
            }
        }

/// ADD A REMOVE RACE METHOD AND A ADD RACE METHOD TO REPLACE THE DIFFERENT TASKS IN ADD RACES

        public void AddRaces(List<Race> races) 
        {
            using (var context = new DungeonResourceContext())
            {
                Console.WriteLine("Begin Add");
                foreach (var race in races)
                {
/// REMOVE THIS AND FIX THE JSON FILE!! NO ID CAN BE 0
                    race.Id += 1;
                    if (context.Races.Contains(race))
                    {
                        context.Races.Remove(race);
                        context.SaveChanges();
                    }
                    Console.WriteLine($"Add {race.Name}");
                    Console.WriteLine($"Add {race.Id}");
                    context.Races.Add(race);
                    Console.WriteLine("Save Changes");
                    context.SaveChanges();
                }

            }
        }
    }
}
