using Hiring.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hiring.Data.Configurations
{
    public class ApplicationConfig
    {
        public void Configure(EntityTypeBuilder<Application> entity)
        {
            entity.ToTable("Application");

            entity.HasOne(d => d.Applicant)
                .WithMany(p => p.Applications)
                .HasForeignKey(d => d.ApplicantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__application_applicant_id");

            entity.HasOne(d => d.Vacant)
                .WithMany(p => p.Applications)
                .HasForeignKey(d => d.VacantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__application_vacant_id");
        }
    }
}
