using System.ComponentModel.DataAnnotations;

namespace lib_entidades.Modelos
{
    public class Universidades
    {
        [Key] public int Id { get; set; }
        public string? Codigo { get; set; }
        public string? Nombre { get; set; }
        public string? Direccion { get; set; }
        public string? Telefono { get; set; }
        public DateTime? Fecha { get; set; }
        public int Cant_carreres { get; set; }
        public bool Activa { get; set; }
        public string? Descripcion { get; set; }

        public bool Validar()
        {
            if (string.IsNullOrEmpty(Codigo) ||
                string.IsNullOrEmpty(Nombre) ||
                string.IsNullOrEmpty(Direccion) ||
                string.IsNullOrEmpty(Telefono) ||
                Fecha == null ||
                string.IsNullOrEmpty(Descripcion))
                return false;
            return true;
        }
    }
}
