namespace TareaToDo
{
    public class TareaToDo
    {
        public enum TareaEstado
        {
            pendiente,
            completado
        }

        public int TareaID {get ; set;}
        public string Descripcion {get ; set;}
        public int Duracion {get ; set;}

    }

}


