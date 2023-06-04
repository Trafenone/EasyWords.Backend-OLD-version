using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Configurations
{
    public class WordListConfiguration : IEntityTypeConfiguration<WordList>
    {
        public void Configure(EntityTypeBuilder<WordList> builder)
        {
            builder.ToTable(nameof(WordList));
            
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd();
            
            builder.Property(x => x.Title)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(x => x.IsActive)
                .HasDefaultValue(true);
            
            builder
                .HasMany(x => x.Words)
                .WithOne(x => x.WordList)
                .HasForeignKey(x => x.WordListId)
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();
        }
    }
}
