namespace AgregarEquiposPorPais.Entidades
{
    public class Equipo
    {
        private static int id = 0;
        public String Nombre { get; set; }
        public String Pais { get; set; }

        public int Id { get; private set; }

        public Equipo(String nombre, String pais)
        {
            id += 1;
            Id = id;
            Nombre = nombre;
            Pais = pais;
        }
    }

    
}
