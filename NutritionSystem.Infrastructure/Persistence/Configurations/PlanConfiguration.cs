namespace NutritionSystem.Infrastructure.Persistence.Configurations
{
    public class PlanConfiguration : IEntityTypeConfiguration<Plan>
    {
        public void Configure(EntityTypeBuilder<Plan> builder)
        {
            builder.ToTable("Plan");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .HasColumnName("Id")
                .IsRequired();

            builder.Property(p => p.TipoPlan)
                .HasColumnName("TipoPlan")
                .HasConversion<string>()
                .HasMaxLength(100);

            builder.Property(p => p.Descripcion)
                .HasColumnName("Descripcion")
                .HasMaxLength(200);

            builder.Property(p => p.DiasTratamiento)
                .HasColumnName("DiasTratamiento");

            builder.Property(p => p.ConsultaId)
                .HasColumnName("IdConsulta")
                .IsRequired();

            builder.Property(p => p.TipoStatus)
                .HasColumnName("tipoStatus")
                .HasConversion<string>()
                .HasMaxLength(10);

            // Relación de FK
            builder.HasOne(p => p.Consulta)
                .WithMany(c => c.Planes)
                .HasForeignKey(p => p.ConsultaId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}