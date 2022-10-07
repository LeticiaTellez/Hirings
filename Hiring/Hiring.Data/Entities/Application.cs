
namespace Hiring.Data.Entities
{
    public class Application
    {
        public int Id { get; set; }
        public int ApplicantId { get; set; }
        public int VacantId { get; set; }
        public DateTime CreationDate { get; set; }

        public virtual Applicant Applicant { get; set; }
        public virtual Vacant Vacant { get; set; }
    }
}
