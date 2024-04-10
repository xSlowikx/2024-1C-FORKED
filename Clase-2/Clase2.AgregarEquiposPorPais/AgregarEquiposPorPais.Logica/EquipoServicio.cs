using AgregarEquiposPorPais.Entidades;

namespace AgregarEquiposPorPais.Logica;

public interface IEquipoService
{
    void agregarEquipo(Equipo equipo);
    List<Equipo> obtenerEquipos();
    void eliminarEquipo(Equipo equipo);
}
public class EquipoServicio : IEquipoService
{
    private static List<Equipo> teams { get; set; } = new List<Equipo>();
    public void agregarEquipo(Equipo equipo)
    {
        teams.Add(equipo);
    }

    public void eliminarEquipo(Equipo equipo)
    {
        teams.Remove(equipo);
    }

    public List<Equipo> obtenerEquipos()
    {
        return teams;
    }
}

