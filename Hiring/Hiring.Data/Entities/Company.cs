namespace Hiring.Data.Entities
{
    public class Company
    {
        public Company()
        {
            Vacants = new HashSet<Vacant>();
        }

        public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Vacant> Vacants { get; set; }
    }
}
