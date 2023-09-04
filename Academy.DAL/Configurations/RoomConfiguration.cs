using Academy.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Academy.DAL.Configurations;

public class RoomConfiguration : IEntityTypeConfiguration<Room>
{
    public void Configure(EntityTypeBuilder<Room> builder)
    {
        builder.Property(r => r.Order).IsRequired();
        builder.Property(r=>r.Name).IsRequired().HasMaxLength(50);
        builder.Property(r => r.ImageUrl).IsRequired();
        builder.Property(r=>r.Capacity).IsRequired();
    }
}
