using System;
using System.Collections.Generic;
using ChamadoPro.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace ChamadoPro.Infrastructure.Persistence.EntityConfigurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");

            builder.HasKey(u => u.Id);

            builder.Property(u => u.Name)
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(255);
            builder.HasIndex(u => u.Email).IsUnique();

            builder.Property(u => u.Password)
                .IsRequired()
                .HasMaxLength(500);

            builder.Property(u => u.Role)
                .HasConversion<string>()
                .IsRequired();

            builder.Property(u => u.Status)
                .HasConversion<string>()
                .IsRequired();
        }
    }
}
