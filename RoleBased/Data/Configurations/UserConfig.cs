using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RoleBased.Data.Configurations
{
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.IdUser);

            builder.HasMany(x => x.Profiles)
                .WithMany(x => x.Users);

            builder.Property(x => x.Name)
                .IsRequired(true)
                .HasMaxLength(100)
                .IsUnicode(false);
            
            builder.Property(x => x.LastName)
                .IsRequired(true)
                .HasMaxLength(100)
                .IsUnicode(false);
            
            builder.Property(x => x.Gender)
                .IsRequired(true)
                .HasMaxLength(25)
                .IsUnicode(false);
            
            builder.Property(x => x.Mail)
                .IsRequired(true)
                .HasMaxLength(50)
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
}
