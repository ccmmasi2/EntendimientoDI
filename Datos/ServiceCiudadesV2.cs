using PracticaInyeccionDependencias.Datos.Interfaces;

namespace PracticaInyeccionDependencias.Datos
{
    public class ServiceCiudadesV2 : IServiceCiudades
    {
        private List<string> _ciudades;

        private Guid idServicio;

        public Guid IdServicio
        {
            get { return idServicio; }
        }

        public ServiceCiudadesV2()
        {
            idServicio = Guid.NewGuid();

            _ciudades = new List<string>
            {
                "Zúrich",
                "Los Ángeles",
                "Shanghai",
                "París",
                "Madrid",
                "Ciudad de México",
                "Rio de Janeiro"
            };


        }

        public List<string> GetCiudades()
        {
            return _ciudades;
        }

        public void Dispose()
        {

        }
    }
}
