using GameStore.API.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Net.Http.Headers;
namespace GameStore.API.Data;

public class GameStoreContext(DbContextOptions<GameStoreContext> options)
         : DbContext(options)
{
    public DbSet<Game> Games => Set<Game>();

public DbSet<Genre> Genres => Set<Genre>();

}