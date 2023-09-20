namespace PracticaInyeccionDependencias.Datos.Interfaces
{
    public interface IServiceCiudades
    {
        Guid IdServicio { get; }
        List<string> GetCiudades();
    }
}