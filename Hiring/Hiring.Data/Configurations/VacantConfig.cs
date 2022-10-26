using Hiring.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hiring.Data.Configurations
{
    public class VacantConfig
    {
        public void Configure(EntityTypeBuilder<Vacant> entity)
        {
            entity.ToTable("Vacant");

            entity.HasOne(d => d.Company)
                .WithMany(p => p.Vacants)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__vacant_company_id");

            entity.HasOne(d => d.Position)
                .WithMany(p => p.Vacants)
                .HasForeignKey(d => d.PositionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__vacant_position_id");
        }
    }
}
