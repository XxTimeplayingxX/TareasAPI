namespace TareasAPI.MODELS
{
    public class DetalleTarea
    {
        public int ID { get; set; }
        //Clave Foránea
        public int EstudianteID { get; set; }
        public int TareaID { get; set; }
        //Propiedad de navegación
        public Estudiante Estudiante { get; set; }
        public Tarea Tarea { get; set; }

    }
}
