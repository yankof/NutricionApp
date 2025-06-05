namespace NutritionSystem.Domain.Common
{
    public abstract class EntityBase<TId>
    {
        public TId Id { get; protected set; }

        // Lista de eventos de dominio generados por esta entidad
        private List<DomainEventBase> _domainEvents = new List<DomainEventBase>();
        public IReadOnlyCollection<DomainEventBase> DomainEvents => _domainEvents.AsReadOnly();

        protected void AddDomainEvent(DomainEventBase domainEvent)
        {
            _domainEvents.Add(domainEvent);
        }

        public void ClearDomainEvents()
        {
            _domainEvents.Clear();
        }
    }
}