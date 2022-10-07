

namespace Hiring.Data.Entities
{
    public class Applicant
    {
        public Applicant()
        {
            Applications = new HashSet<Application>();
        }

        public int Id { get; set; }
        public int UserId { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public string Cellphone { get; set; }
        public string ResumeUrl { get; set; }

        public virtual ICollection<Application> Applications { get; set; }
    }
}
