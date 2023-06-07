using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Word> Words { get; set; }
        DbSet<Translation> Translations { get; set; }
        DbSet<WordList> WordLists { get; set; }
        DbSet<Progress> Progress { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
