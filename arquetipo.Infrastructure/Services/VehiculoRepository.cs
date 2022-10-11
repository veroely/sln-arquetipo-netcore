using arquetipo.Domain.IRepository;
using arquetipo.Entity.Models;
using arquetipo.Repository.Context;
using Microsoft.EntityFrameworkCore;

namespace arquetipo.Infrastructure.Services
{
    public class VehiculoRepository : IVehiculoRepository
    {
        private readonly db_creditoautoContext _context;
        public VehiculoRepository(db_creditoautoContext context)
        {
            _context = context;
        }

        public async Task<Vehiculo> GetByPlaca(string placa)
        {
            Vehiculo vehiculo = await _context.Vehiculos.Where(x => x.Placa == placa).FirstOrDefaultAsync();
            return vehiculo;
        }
        public async Task<List<Vehiculo>> GetByMarcaModelo(string marca, string modelo, string anio)
        {
            IQueryable<MarcaVehicular> marcasIQuery = _context.MarcaVehiculars;

            if (!string.IsNullOrEmpty(marca)) 
            {
                marcasIQuery = marcasIQuery.Where(w => w.Descripcion == marca);
            }

            IQueryable<Vehiculo> vehiculosIQuery = _context.Vehiculos;

            if (!string.IsNullOrEmpty(modelo))
            {
                vehiculosIQuery = vehiculosIQuery.Where(w => w.Modelo == modelo);
            }


            List<Vehiculo> lista = await (from vehiculos in vehiculosIQuery.AsQueryable()
                                          join marcas in marcasIQuery.AsQueryable() on vehiculos.IdMarcaVehicular equals marcas.IdMarcaVehicular
                                          select vehiculos).ToListAsync();

            return lista;
        }

    }
}
