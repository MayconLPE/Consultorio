using Consultorio.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Consultorio.context
{
    public class ConsultorioContext : DbContext
    {
        public ConsultorioContext(DbContextOptions<ConsultorioContext> options) : base(options)
        {
            
        }

        public DbSet<Agendamento> Agendamentos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var agendamento = modelBuilder.Entity<Agendamento>();

            agendamento.ToTable("tb_agendamento");
            agendamento.HasKey(x => x.Id);
            agendamento.Property(x => x.Id).HasColumnName("id").ValueGeneratedOnAdd();
            agendamento.Property(x => x.NomePaciente).HasColumnName("nome_paciente").HasColumnType("varchar(100").IsRequired();
            agendamento.Property(x => x.Horario).HasColumnName("horario").IsRequired();
        }

    }
}
