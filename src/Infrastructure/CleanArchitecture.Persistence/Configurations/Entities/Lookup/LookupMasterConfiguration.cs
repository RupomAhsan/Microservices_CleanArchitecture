using CleanArchitecture.Domain.Entity.Lookup;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArchitecture.Persistence.Configurations.Entities.Lookup;

public class LookupMasterConfiguration : IEntityTypeConfiguration<LookupMasterEntity>
{
    public void Configure(EntityTypeBuilder<LookupMasterEntity> builder)
    {
        builder.Property(t => t.Type)
                         .IsRequired()
                         .HasMaxLength(100);

        builder.Property(t => t.Description)
                         .HasMaxLength(150);

        #region Audit Fileds
        builder.Property(t => t.DateCreated)
                      .IsRequired()
                      .HasColumnType("date")
                      .HasDefaultValueSql("NOW()");

        builder.Property(t => t.CreatedBy)
                      .IsRequired()
                      .HasColumnType("TEXT")
                      .HasMaxLength(50)
                      .HasDefaultValue("SystemUser");

        builder.Property(t => t.IsDeleted)
                      .HasColumnType("boolean").HasDefaultValue(false);

        builder.Property(t => t.LastModifiedDate)
                      .HasColumnType("date");

        builder.Property(t => t.LastModifiedBy)
                      .HasColumnType("TEXT")
                      .HasMaxLength(50);

        builder.Property(t => t.IsActive)
                      .HasColumnType("boolean").HasDefaultValue(true);
        #endregion
    }
}
