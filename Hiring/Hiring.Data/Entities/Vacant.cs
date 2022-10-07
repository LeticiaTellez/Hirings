
namespace Hiring.Data.Entities
{
    public class Vacant
    {
        public Vacant()
        {
            Applications = new HashSet<Application>();
        }

        public int Id { get; set; }
        public int CompanyId { get; set; }
        public int PositionId { get; set; }
        public string SalaryRange { get; set; }
        public int Quantity { get; set; }
        public string ExpirienceYears { get; set; }
        public string HiringType { get; set; }

        public virtual Company Company { get; set; }
        public virtual Position Position { get; set; }
        public virtual ICollection<Application> Applications { get; set; }
    }
}
