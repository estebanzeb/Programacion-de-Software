using asp_presentacion.Pages.Ventanas.Test;
using lib_utilidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace asp_presentacion.Pages.Ventanas.Test2
{
    public class TiposDatos
    {
        public int? Numero { get; set; }
        public string? Nombre { get; set; }
        public bool? Activo { get; set; }
        public Byte? Byte { get; set; }
        public decimal? Decimales { get; set; }
        public float? NumeroFloat { get; set; }
        public double? NumeroDouble { get; set; }
        public DateTime? Fecha { get; set; }
    }
    public class IndexModel : PageModel
    {
        [BindProperty] public TiposDatos? ObjtTpDat { get; set; }
        [BindProperty] public List<TiposDatos>? ListarHTML { get; set; }

        public void ListarElementos()
        {

            try{
                ListarHTML = ListarHTML ?? new List<TiposDatos>();

                ListarHTML!.Add(new TiposDatos()
                {
                    Numero=12423,
                    Nombre="",
                    Activo=false,
                    Byte=12,
                    Decimales=124123.12312m,
                    NumeroFloat=2234323f,
                    NumeroDouble=1231242f,
                    Fecha=new DateTime(200,01,01),
                });
            }
                catch (Exception ex)
            {
                LogConversor.Log(ex, ViewData!);
            }
        }

        public void OnGet()
        {
            try
            {
                ObjtTpDat = new TiposDatos();
                ListarElementos();
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
                ListarElementos();
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
                ListarElementos();
                ListarHTML!.Add(ObjtTpDat!);
                ObjtTpDat = new TiposDatos();
            }
            catch (Exception ex)
            {
                LogConversor.Log(ex, ViewData!);
            }
        }



    }
}
