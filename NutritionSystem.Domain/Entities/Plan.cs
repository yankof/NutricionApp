namespace NutritionSystem.Domain.Entities
{
    public class Plan : EntityBase<Guid>
    {
        public Guid ConsultaId { get; private set; } // FK a Consulta
        public Consulta Consulta { get; private set; }

        public string Descripcion { get; private set; }
        public TipoPlan TipoPlan { get; private set; } // Ejemplo: Nutricional, de Ejercicio, etc.
        public DateOnly FechaCreacion { get; private set; }
        public TipoStatus TipoStatus { get; private set; }
        public int DiasTratamiento { get; private set; }

        private Plan() { }

        public Plan(Guid id, Guid consultaId, string descripcion, TipoPlan tipoPlan, TipoStatus tipoStatus, int diasTratamiento)
        {
            Id = id; // Asigna el ID proporcionado o genera uno si es necesario
            ConsultaId = consultaId;
            Descripcion = descripcion;
            TipoPlan = tipoPlan;
            FechaCreacion = DateOnly.FromDateTime(DateTime.UtcNow);
            DiasTratamiento = diasTratamiento;
            TipoStatus = tipoStatus;

            // REGISTRAR EL EVENTO DE DOMINIO:
            AddDomainEvent(new PlanCreatedEvent(this.Id, this.ConsultaId, this.TipoPlan, this.Descripcion, this.TipoStatus, this.DiasTratamiento));
        }

        public void UpdateDetails(string newDescripcion, TipoPlan newTipoPlan)
        {
            Descripcion = newDescripcion;
            TipoPlan = newTipoPlan;
            // Podrías añadir un PlanUpdatedEvent aquí
        }
    }
}