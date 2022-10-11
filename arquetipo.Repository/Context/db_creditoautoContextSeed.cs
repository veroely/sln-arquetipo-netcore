using arquetipo.Entity.Models;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace arquetipo.Repository.Context
{
    public class db_creditoautoContextSeed
    {
        public static async Task CargarInformacion(db_creditoautoContext context, ILoggerFactory loggerFactory)
        {
            try
            {
                //carga de catálogos
                if (!context.EstadoCivils.Any())
                {
                    List<EstadoCivil> listaEstadoCivil = new List<EstadoCivil>()
                    {
                        new EstadoCivil(){ Descripcion="Soltero", EsActivo =true },
                        new EstadoCivil(){ Descripcion="Casado", EsActivo =true },
                        new EstadoCivil(){ Descripcion="Divorciado", EsActivo =true },
                        new EstadoCivil(){ Descripcion="Viudo", EsActivo =true }
                    };

                    await context.AddRangeAsync(listaEstadoCivil);
                    await context.SaveChangesAsync();
                }

                if (!context.PatioVehiculars.Any())
                {
                    List<PatioVehicular> listaEstadoCivil = new List<PatioVehicular>()
                    {
                        new PatioVehicular(){ Nombre="Ambacar", Direccion ="Quicentro Norte", Telefono="02123456",NumeroPuntoVenta=1},
                        new PatioVehicular(){ Nombre="Astumotors", Direccion ="La Argelia", Telefono="022785634",NumeroPuntoVenta=2},
                        new PatioVehicular(){ Nombre="AutoComercio", Direccion ="Quitumbe", Telefono="02789321",NumeroPuntoVenta=3 },
                        new PatioVehicular(){ Nombre="AutoPremium", Direccion ="Carapungo", Telefono="02543456",NumeroPuntoVenta=4 }
                    };

                    await context.AddRangeAsync(listaEstadoCivil);
                    await context.SaveChangesAsync();
                }

                if (!context.EstadoSolicituds.Any())
                {
                    List<EstadoSolicitud> listaEstadoSolicitud = new List<EstadoSolicitud>()
                    {
                        new EstadoSolicitud(){ Descripcion="Registrada", EsActivo =true },
                        new EstadoSolicitud(){ Descripcion="Despachada", EsActivo =true },
                        new EstadoSolicitud(){ Descripcion="Cancelada", EsActivo =true },
                    };

                    await context.AddRangeAsync(listaEstadoSolicitud);
                    await context.SaveChangesAsync();
                }

                string pathFolder = "../arquetipo.Repository/DataCSV/";
                //carga de archivos CSV
                if (!context.Clientes.Any()) 
                {
                    List<Dictionary<string, string>> clientesCSV = LeerArchivo($"{pathFolder}Clientes.csv");
                    var clientesJson = JsonConvert.SerializeObject(clientesCSV);

                    List<Cliente> clientes = JsonConvert.DeserializeObject<List<Cliente>>(clientesJson);
                    if (clientes.Count > 0) 
                    {
                        var verificarduplicados = clientes.GroupBy(g => g.Identificacion)
                                                                   .Where(w => w.Count() > 1).ToList();
                        if (verificarduplicados.Count > 0)
                        {
                            List<string> duplicados = verificarduplicados.Select(s => s.Key).ToList();
                            throw new Exception("Existen datos duplicados en el archivo Clientes "+ string.Join(";",duplicados));
                        }

                        await context.AddRangeAsync(clientes);
                        await context.SaveChangesAsync();
                    }
                }

                if (!context.Ejecutivos.Any())
                {
                    List<Dictionary<string, string>> ejecutivosCSV = LeerArchivo($"{pathFolder}Ejecutivos.csv");
                    var ejecutivosJson = JsonConvert.SerializeObject(ejecutivosCSV);

                    List<Ejecutivo> ejecutivos = JsonConvert.DeserializeObject<List<Ejecutivo>>(ejecutivosJson);
                    if (ejecutivos.Count > 0)
                    {
                        var verificarduplicados = ejecutivos.GroupBy(g => g.Identificacion)
                                           .Where(w => w.Count() > 1).ToList();
                        if (verificarduplicados.Count > 0)
                        {
                            List<string> duplicados = verificarduplicados.Select(s => s.Key).ToList();
                            throw new Exception("Existen datos duplicados en el archivo Ejecutivos " + string.Join(";", duplicados));
                        }

                        await context.AddRangeAsync(ejecutivos);
                        await context.SaveChangesAsync();
                    }
                }

                if (!context.MarcaVehiculars.Any())
                {
                    List<Dictionary<string, string>> marcasCSV = LeerArchivo($"{pathFolder}Marcas.csv");
                    var marcasJson = JsonConvert.SerializeObject(marcasCSV);

                    List<MarcaVehicular> marcas = JsonConvert.DeserializeObject<List<MarcaVehicular>>(marcasJson);

                    if (marcas.Count > 0)
                    {
                        var verificarduplicados = marcas.GroupBy(g => g.Descripcion)
                                           .Where(w => w.Count() > 1).ToList();
                        if (verificarduplicados.Count > 0)
                        {
                            List<string> duplicados = verificarduplicados.Select(s => s.Key).ToList();
                            throw new Exception("Existen datos duplicados en el archivo Marcas " + string.Join(";", duplicados));
                        }

                        marcas.Select(s => { s.EsActivo = true; return s; }).ToList();
                        await context.AddRangeAsync(marcas);
                        await context.SaveChangesAsync();
                    }
                }

            }
            catch (Exception ex)
            {
                var logger = loggerFactory.CreateLogger<db_creditoautoContext>();
                logger.LogError(ex.Message);
            }
        }

        private static List<Dictionary<string, string>> LeerArchivo(string path)
        {
            List<string[]> datosPorFila = new List<string[]>();
            var filas = new StreamReader(path);
            var encabezado = string.Empty;
            int k = 0;
            while (!filas.EndOfStream)
            {
                var fila = filas.ReadLine();
                var datos = fila.Split(";");

                if (k == 0)
                    encabezado = fila;

                datosPorFila.Add(datos);
                k++;
            }

            var properties = encabezado.Split(";");

            List<Dictionary<string, string>> listObjResult = new List<Dictionary<string, string>>();

            for (int i = 1; i < datosPorFila.Count; i++)
            {
                var objResult = new Dictionary<string, string>();
                for (int j = 0; j < properties.Length; j++)
                    objResult.Add(properties[j], datosPorFila[i][j]);

                listObjResult.Add(objResult);
            }

            return listObjResult;
        }
    }
}
