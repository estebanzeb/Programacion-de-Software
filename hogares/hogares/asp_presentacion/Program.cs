using lib_comunicaciones.Implementaciones;
using lib_comunicaciones.Interfaces;

var builder = WebApplication.CreateBuilder(args);

var datos = new Dictionary<string, object>();
ICasasComunicacion iCasasComunicacion = new CasasComunicacion();
var hilo = iCasasComunicacion.Listar(datos);
hilo.Wait();
var respuesta = hilo.Result;

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();