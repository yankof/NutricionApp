namespace NutritionSystem.Application.Features.Plan.Commands
{
    public class CreatePlanCommand : IRequest<Guid>
    {
        public Guid ConsultaId { get; set; }
        public string Descripcion { get; set; }
        public TipoPlan TipoPlan { get; set; }
        public TipoStatus TipoStatus { get; set; }
        public int DiasTratamiento { get; set; }    

    }

    public class CreatePlanCommandHandler : IRequestHandler<CreatePlanCommand, Guid>
    {
        private readonly IUnitOfWork _unitOfWork;

        public CreatePlanCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Guid> Handle(CreatePlanCommand request, CancellationToken cancellationToken)
        {
            // Opcional: Validar que la ConsultaId exista
            var consulta = await _unitOfWork.Consultas.GetByIdAsync(request.ConsultaId);
            if (consulta == null)
            {
                throw new ArgumentException($"La Consulta con ID {request.ConsultaId} no existe.");
            }

            var plan = new Domain.Entities.Plan(
                Guid.NewGuid(), // Generar un nuevo ID
                request.ConsultaId,
                request.Descripcion,
                request.TipoPlan,
                request.TipoStatus,
                request.DiasTratamiento
                
            );

            await _unitOfWork.Planes.AddAsync(plan);
            await _unitOfWork.CompleteAsync(); // Esto disparará el evento de dominio

            return plan.Id;
        }
    }
}