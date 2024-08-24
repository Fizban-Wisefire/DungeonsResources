
namespace Entities
{
    public interface IDataAccess
    {
        public List<Race> GetRaces();

        Race GetRace(int id);
        List<Class> GetClasses();

        Class GetClass(int id);
    }
}
