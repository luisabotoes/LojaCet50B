using LojaCet50B.Dados.Entidades;
using Microsoft.EntityFrameworkCore;

namespace LojaCet50B.Dados
{
    public class DataContext : DbContext
    {

        public DbSet<Produto> Produtos { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

    }
}
