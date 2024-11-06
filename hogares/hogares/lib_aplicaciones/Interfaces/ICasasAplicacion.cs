using lib_entidades.Modelos;

namespace lib_aplicaciones.Interfaces
{
    public interface ICasasAplicacion
    {
        void Configurar(string string_conexion);
        List<Casas> Buscar(Casas entidad, string tipo);
        List<Casas> Listar();
        Casas Guardar(Casas entidad);
        Casas Modificar(Casas entidad);
        Casas Borrar(Casas entidad);
    }
}