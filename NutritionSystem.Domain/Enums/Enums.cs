namespace NutritionSystem.Domain.Enums
{
    public enum EstadoActivo
    {
        Activo = 1, // Mapeará a '1' en la BD
        Inactivo = 0 // Mapeará a '0' en la BD
    }

    public enum TipoEvaluacion
    {
        Inicial,
        Seguimiento,
        Final
    }

    public enum TipoStatus
    {
        Inicial,
        Seguimiento,
        Final
    }

    public enum TipoDiagnostico
    {
        Nutricional,
        Medico,
        General
    }

    public enum TipoPlan
    {
        Dieta,
        Adelgazamiento,
        MasaMuscular,
        Ejercicio,
        Mixto
    }

    public enum EstatusConsulta
    {
        Activa,
        Finalizada,
        Cancelada
    }
}