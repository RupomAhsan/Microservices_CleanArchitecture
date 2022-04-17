using CleanArchitecture.Domain.Entity.Lookup;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArchitecture.Persistence.Configurations.Entities.Lookup;

public class LookupDetailConfiguration : IEntityTypeConfiguration<LookupDetailEntity>
{
    public void Configure(EntityTypeBuilder<LookupDetailEntity> builder)
    {
        builder.HasOne(b => b.LookupMaster).WithMany(c => c.LookupDetails)
                .OnDelete(DeleteBehavior.Restrict);

        builder.Property(t => t.Name)
                         .IsRequired()
                         .HasMaxLength(100);

        builder.Property(t => t.DisplayName)
                         .IsRequired()
                         .HasMaxLength(50);

        builder.Property(t => t.Description)
                         .HasMaxLength(150);

        builder.Property(t => t.GroupName)
                         .HasMaxLength(50);

        builder.Property(t => t.SortOrder)
                         .HasDefaultValue(0);

        builder.Property(t => t.Miscellaneous)
                         .HasMaxLength(20);

        builder.Property(t => t.IsDefault)
                      .HasColumnType("BIT").HasDefaultValue(false);

        #region Audit Fileds
        builder.Property(t => t.DateCreated)
                      .IsRequired()
                      .HasColumnType("Datetime")
                      .HasDefaultValueSql("GetDate()");

        builder.Property(t => t.CreatedBy)
                      .IsRequired()
                      .HasColumnType("NVARCHAR")
                      .HasMaxLength(50)
                      .HasDefaultValue("SystemUser");

        builder.Property(t => t.IsDeleted)
                      .HasColumnType("BIT").HasDefaultValue(false);

        builder.Property(t => t.LastModifiedDate)
                      .HasColumnType("Datetime");

        builder.Property(t => t.LastModifiedBy)
                      .HasColumnType("NVARCHAR")
                      .HasMaxLength(50);

        builder.Property(t => t.IsActive)
                      .HasColumnType("BIT").HasDefaultValue(true);
        #endregion
    }
}
