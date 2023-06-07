using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations
{
    public class ProgressConfiguration : IEntityTypeConfiguration<Progress>
    {
        public void Configure(EntityTypeBuilder<Progress> builder)
        {
            builder.ToTable(nameof(Progress));

            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd();

            builder.Property(x => x.CreationDate)
                .HasDefaultValue(DateTime.Now);

            builder.Property(x => x.LastTrainingDate)
                .IsRequired(false);

            builder.Property(x => x.IsLearned)
                .HasDefaultValue(false);
        }
    }
}
