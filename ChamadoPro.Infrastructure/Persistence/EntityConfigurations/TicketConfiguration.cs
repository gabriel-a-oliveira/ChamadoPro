using ChamadoPro.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace ChamadoPro.Infrastructure.Persistence.EntityConfigurations
{
    public class TicketConfiguration : IEntityTypeConfiguration<Ticket>
    {
        public void Configure(EntityTypeBuilder<Ticket> builder)
        {
            builder.ToTable("Tickets");

            builder.HasKey(t => t.Id);

            builder.Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(1000);

            builder.Property(t => t.Status)
                .HasConversion<string>()
                .IsRequired();

            builder.Property(t => t.Priority)
                .HasConversion<string>()
                .IsRequired();

            builder.Property(t => t.CategoryId)
                .IsRequired(false);

            builder.Property(t => t.ResponsibleId)
                .IsRequired(false);

            builder.HasOne(t => t.Category)
                .WithMany()
                .HasForeignKey(t => t.CategoryId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.HasOne(t => t.Requester)
                .WithMany()
                .HasForeignKey(t => t.RequesterId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(t => t.Responsible)
                .WithMany()
                .HasForeignKey(t => t.ResponsibleId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.Property(t => t.Date_created)
                .IsRequired()
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            builder.Property(t => t.ConcludedAt)
                .IsRequired(false);

        }
    }
}
