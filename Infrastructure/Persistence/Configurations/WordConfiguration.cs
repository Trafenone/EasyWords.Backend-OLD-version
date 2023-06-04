using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Configurations
{
    internal class WordConfiguration : IEntityTypeConfiguration<Word>
    {
        public void Configure(EntityTypeBuilder<Word> builder)
        {
            builder.ToTable(nameof(Word));

            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd();

            builder.Property(x => x.Name)
                .HasMaxLength(255)
                .IsRequired();

            builder.Property(x => x.Transcription)
                .HasMaxLength(255)
                .IsRequired(false);

            builder.Property(x => x.Image)
                .IsRequired(false);

            builder
                .HasOne(w => w.Progress)
                .WithOne(p => p.Word)
                .HasForeignKey<Progress>(p => p.Id)
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();

            builder
                .HasMany(w => w.Translations)
                .WithOne(t => t.Word)
                .HasForeignKey(t => t.WordId)
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();
        }
    }
}
