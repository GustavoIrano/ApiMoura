using CrudMoura.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CrudMoura.Data.Mappings
{
    public class TarefaMapping : IEntityTypeConfiguration<Tarefa>
    {
        public void Configure(EntityTypeBuilder<Tarefa> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Nome)
                .IsRequired()
                .HasColumnType("varchar(100)");
            builder.Property(t => t.Realizada)
                .IsRequired();

            builder.ToTable("Tarefas");
        }
    }
}
