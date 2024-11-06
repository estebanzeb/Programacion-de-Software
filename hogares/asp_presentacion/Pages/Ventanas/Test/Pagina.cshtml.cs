using lib_utilidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace asp_presentacion.Pages.Ventanas.Test
{
    public class PaginaModel : PageModel
    {
        public void OnGet()
        {
            try
            {
                Actual = new Dias();
                Listar();
            }
            catch (Exception ex)
            {
                LogConversor.Log(ex, ViewData!);
            }
        }

        [BindProperty] public Dias? Actual { get; set; }
        [BindProperty] public List<Dias>? Lista { get; set; }

        private void Listar()
        {
            try
            {
                Lista = Lista ?? new List<Dias>();
                Lista!.Add(new Dias()
                {
                    Numero = 1,
                    Nombre = "Lunes",
                    Descripcion = "Volvemos a lo mismo"
                });
                Lista!.Add(new Dias()
                {
                    Numero = 2,
                    Nombre = "Martes",
                    Descripcion = "Vemos al canson de programacion"
                });
                Lista!.Add(new Dias()
                {
                    Numero = 3,
                    Nombre = "Miercoles",
                    Descripcion = "Casi se acaba la semana"
                });
                Lista!.Add(new Dias()
                {
                    Numero = 4,
                    Nombre = "Jueves",
                    Descripcion = "Ultimo dia de programacion"
                });
                Lista!.Add(new Dias()
                {
                    Numero = 5,
                    Nombre = "Viernes",
                    Descripcion = "Por fin"
                });
                Lista!.Add(new Dias()
                {
                    Numero = 6,
                    Nombre = "Sabado",
                    Descripcion = "Parranda, Fiesta!"
                });
                Lista!.Add(new Dias()
                {
                    Numero = 7,
                    Nombre = "Domingo",
                    Descripcion = "Descanso"
                });
            }
            catch (Exception ex)
            {
                LogConversor.Log(ex, ViewData!);
            }
        }

        public void OnPostBtCerrar()
        {
            try
            {
                Listar();
            }
            catch (Exception ex)
            {
                LogConversor.Log(ex, ViewData!);
            }
        }

        public void OnPostBtGuardar()
        {
            try
            {
                Listar();
                Lista!.Add(Actual!);
                Actual = new Dias();
            }
            catch (Exception ex)
            {
                LogConversor.Log(ex, ViewData!);
            }
        }
    }

    public class Dias
    {
        public int Numero { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
    }
}
