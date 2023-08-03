using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RoleBased.Data.Configurations;

public class ProfileConfig : IEntityTypeConfiguration<Profile>
{
    public void Configure(EntityTypeBuilder<Profile> builder)
    {
        builder.HasKey(x => x.IdProfile);        

        builder.Property(x => x.Description)
            .IsRequired(true)
            .HasMaxLength(100)
            .IsUnicode(false);

        builder.Property(x => x.LogUserCreation)
            .IsRequired(true)
            .HasMaxLength(100)
            .IsUnicode(false);

        builder.Property(x => x.LogUserModification)
            .IsRequired(false)
            .HasMaxLength(100)
            .IsUnicode(false);

        builder.Property(x => x.LogDateCreation)
            .IsRequired(true)
            .HasColumnType("datetime");

        builder.Property(x => x.LogDateModification)
            .IsRequired(false)
            .HasColumnType("datetime");
    }
}
