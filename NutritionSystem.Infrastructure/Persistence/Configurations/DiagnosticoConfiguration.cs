namespace NutritionSystem.Infrastructure.Persistence.Configurations
{
    public class DiagnosticoConfiguration : IEntityTypeConfiguration<Diagnostico>
    {
        public void Configure(EntityTypeBuilder<Diagnostico> builder)
        {
            builder.ToTable("Diagnostico");

            // Como la tabla SQL no tiene PK, EF Core necesita una.
            // Le damos una PK Guid en el modelo de dominio.
            builder.HasKey(d => d.Id);

            builder.Property(d => d.Id)
                .ValueGeneratedOnAdd(); // EF Core generará este GUID

            builder.Property(d => d.ConsultaId)
                .HasColumnName("IdConsulta")
                .IsRequired();

            builder.Property(d => d.TipoDiagnostico)
                .HasColumnName("TipoDiagnostico")
                .HasConversion<string>()
                .HasMaxLength(50);

            builder.Property(d => d.Descripcion)
                .HasColumnName("Valor")
                .HasMaxLength(200);

            builder.Property(d => d.TipoStatus)
                .HasColumnName("TipoStatus")
                .HasConversion<string>()
                .HasMaxLength(10);

            // Si la combinación (IdConsulta, TipoDiagnostico) debe ser única:
            // builder.HasIndex(d => new { d.IdConsulta, d.TipoDiagnostico }).IsUnique();

            // Relación de FK
            builder.HasOne(d => d.Consulta)
                .WithMany(c => c.Diagnosticos)
                .HasForeignKey(d => d.ConsultaId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}