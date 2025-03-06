using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ChamadoPro.Domain.Entities;

namespace ChamadoPro.Infrastructure.Persistence.EntityConfigurations
{
    public class AttachmentConfiguration : IEntityTypeConfiguration<Attachment>
    {
        public void Configure(EntityTypeBuilder<Attachment> builder)
        {
            builder.ToTable("Attachments");

            builder.HasKey(a => a.Id);

            builder.Property(a => a.Name)
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(a => a.FileUrl)
                .IsRequired()
                .HasColumnType("TEXT");

            builder.Property(a => a.DateCreated)
                .IsRequired()
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            builder.HasOne(a => a.Ticket)
                .WithMany() 
                .HasForeignKey(a => a.TicketId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
