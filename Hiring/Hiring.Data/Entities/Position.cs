
namespace Hiring.Data.Entities
{
    public class Position
    {
        public Position()
        {
            Vacants = new HashSet<Vacant>();
        }

        public Position (int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Vacant> Vacants { get; set; }
    }
}
