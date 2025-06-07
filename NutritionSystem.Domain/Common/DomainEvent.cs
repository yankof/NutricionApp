namespace NutritionSystem.Domain.Common
{
    // Clase base abstracta para todos los eventos de dominio
    // Ahora implementa INotification de MediatR
    public abstract class DomainEvent : INotification // <-- Modifica esta línea
    {
        public Guid Id { get; set; }
        public DateTime DateOccurred { get; protected set; } = DateTime.UtcNow;

        protected DomainEvent(Guid id, DateTime dateOccurred)
        {
            Id = Guid.NewGuid();
            DateOccurred = dateOccurred;
        }
        protected DomainEvent()
        {
                
        }
    }
}