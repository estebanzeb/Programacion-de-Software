using lib_entidades.Modelos;
using lib_repositorios.Interfaces;
using System.Linq.Expressions;

namespace lib_repositorios.Implementaciones
{
    public class CasasRepositorio : ICasasRepositorio
    {
        private Conexion? conexion = null;

        public CasasRepositorio(Conexion conexion)
        {
            this.conexion = conexion;
        }

        public void Configurar(string string_conexion)
        {
            this.conexion!.StringConnection = string_conexion;
        }

        public List<Casas> Listar()
        {
            return conexion!.Listar<Casas>();
        }

        public List<Casas> Buscar(Expression<Func<Casas, bool>> condiciones)
        {
            return conexion!.Buscar(condiciones);
        }

        public Casas Guardar(Casas entidad)
        {
            conexion!.Guardar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }

        public Casas Modificar(Casas entidad)
        {
            conexion!.Modificar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }

        public Casas Borrar(Casas entidad)
        {
            conexion!.Borrar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }
    }
}