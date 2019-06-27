using Supermarket.API.Persistence.Contexts;

namespace Supermarket.API.Persistence.Repositories
{
  public abstract class BaseRepository
  {
    protected readonly AppDbContext _context;

    public BaseRepository(AppDbContext conext)
    {
      _context = conext;
    }
  }
}