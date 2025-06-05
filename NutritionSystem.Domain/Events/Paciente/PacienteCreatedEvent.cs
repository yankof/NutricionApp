// NutritionSystem.Domain/Events/Paciente/PacienteCreatedEvent.cs
using NutritionSystem.Domain.Common;
using System;

namespace NutritionSystem.Domain.Events.Paciente
{
    public class PacienteCreatedEvent : DomainEventBase
    {
        public Guid PacienteId { get; }
        //public string Ocupacion { get; }

        public PacienteCreatedEvent(Guid pacienteId)
        {
            PacienteId = pacienteId;
          //  Ocupacion = ocupacion;
        }
    }
}