using lib_entidades.Modelos;
using System.Linq.Expressions;

namespace lib_repositorios.Interfaces
{
    public interface ICasasRepositorio
    {
        void Configurar(string string_conexion);
        List<Casas> Listar();
        List<Casas> Buscar(Expression<Func<Casas, bool>> condiciones);
        Casas Guardar(Casas entidad);
        Casas Modificar(Casas entidad);
        Casas Borrar(Casas entidad);
    }
}