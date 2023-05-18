using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchedulingSystem.Models;

namespace SchedulingSystem.Data.Mapping
{
    public class ProfessionalMap : IEntityTypeConfiguration<Professional>
    {
        public void Configure(EntityTypeBuilder<Professional> builder)
        {
            builder.ToTable("Professional");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            builder.Property(x => x.Name)
                .IsRequired()
                .HasColumnType("VARCHAR")
                .HasMaxLength(50);

            builder.Property(x => x.Speciality)
                .IsRequired()
                .HasColumnType("VARCHAR")
                .HasMaxLength(50);

            builder.Property(x => x.Email)
                .IsRequired()
                .HasColumnType("VARCHAR")
                .HasMaxLength(100);

            builder.Property(x => x.Phone)
                .IsRequired()
                .HasColumnType("VARCHAR")
                .HasMaxLength(20);

            builder.Property(x => x.PasswordHash)
                .IsRequired()
                .HasColumnType("VARCHAR")
                .HasMaxLength(100);
        }
    }
}