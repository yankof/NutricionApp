namespace NutritionSystem.Domain.Common
{
    // Clase base abstracta para todos los eventos de dominio
    // Ahora implementa INotification de MediatR
    public abstract class DomainEventBase : INotification // <-- Modifica esta línea
    {
        public DateTime DateOccurred { get; protected set; } = DateTime.UtcNow;
    }
}