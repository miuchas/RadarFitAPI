using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RadarFit.MODEL.Entities;

namespace RadarFit.DAO.Configurations
{
    internal class ObjetoConfiguration : IEntityTypeConfiguration<Objeto>
    {
        public void Configure(EntityTypeBuilder<Objeto> builder)
        {
            builder.ToTable("Objeto");

            builder.Property(x => x.Id)
                .HasColumnName("id")
                .ValueGeneratedOnAdd()
                .IsRequired();

            builder.Property(x => x.Titulo)
                .HasColumnName("titulo")
                .IsRequired();

            builder.Property(x => x.Descricao)
                .HasColumnName("descricao")
                .IsRequired();
        }
    }
}
