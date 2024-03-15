using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using RadarFit.DAO.Configurations;
using RadarFit.MODEL.Entities;

namespace RadarFit.DAO
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        public DbSet<Objeto> Objeto { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Configurations
            modelBuilder.ApplyConfiguration(new ObjetoConfiguration());
            #endregion

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Carrega as configurações do arquivo appsettings.json
                IConfigurationRoot configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .Build();

                // Configura a conexão com o banco de dados PostgreSQL
                string connectionString = configuration.GetConnectionString("DefaultConnection");
                optionsBuilder.UseNpgsql(connectionString);
                base.OnConfiguring(optionsBuilder);
            }
        }
    }
}
