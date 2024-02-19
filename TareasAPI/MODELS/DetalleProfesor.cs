namespace TareasAPI.MODELS
{
    public class DetalleProfesor
    {
        public int ID { get; set; }
        public int ProfesorID { get; set; }
        public int TareaID { get; set; }
        //Propiedad de navegación
        public Profesor Profesor { get; set; }
        public Tarea Tarea { get; set; }
    }
}
