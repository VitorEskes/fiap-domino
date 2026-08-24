using DominoPontaDeQuina.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DominoPontaDeQuina.Repository.Context;

public class DominoDbContext : DbContext
{
    private const string ConnectionString = "Data Source=domino.db";

    public DbSet<Usuario> Usuarios { get; set; } = null!;

    public DbSet<Jogador> Jogadores { get; set; } = null!;

    public DbSet<Jogo> Jogos { get; set; } = null!;

    public DbSet<ParticipacaoJogo> ParticipacoesJogo { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlite(ConnectionString);
        }
    }
}
