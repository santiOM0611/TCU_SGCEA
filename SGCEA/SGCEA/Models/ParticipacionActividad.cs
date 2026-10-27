namespace SGCEA.Models
{
    public class ParticipacionActividad
    {
        public int Id { get; set; }

        public int AdultoMayorId { get; set; }
        public AdultoMayor AdultoMayor { get; set; }

        public int ActividadId { get; set; }
        public Actividad Actividad { get; set; }
    }
}