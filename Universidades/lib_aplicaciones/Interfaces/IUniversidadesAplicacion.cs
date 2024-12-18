﻿using lib_entidades.Modelos;

namespace lib_aplicaciones.Interfaces
{
    public interface IUniversidadesAplicacion
    {
        void Configurar(string string_conexion);
        List<Universidades> Listar();
        List<Universidades> Buscar(Universidades entidad, string tipo);
        Universidades Guardar(Universidades entidad);
        Universidades Modificar(Universidades entidad);
        Universidades Borrar(Universidades entidad);
    }
}