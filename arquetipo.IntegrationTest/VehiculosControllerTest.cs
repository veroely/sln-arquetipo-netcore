using Microsoft.AspNetCore.Mvc.Testing;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace arquetipo.IntegrationTest
{
    public class VehiculosControllerTest
    {
        private readonly HttpClient _client;
        public VehiculosControllerTest()
        {
            var aplication = new WebApplicationFactory<Program>()
                            .WithWebHostBuilder(builder =>
                            {
                                builder.ConfigureServices(services =>
                                {
                                });
                            });
            _client = aplication.CreateClient(); 
        }

        [Fact]
        public async Task GetVehiculos_DaddUnNombreModelo_RetornarNoNull() 
        {
            var respuesta = await _client.GetAsync("/api/Vehiculos/Chevrolet/Cavalier");
            
            Assert.True((int)respuesta.StatusCode ==200);
        }
    }
}
