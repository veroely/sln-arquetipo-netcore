using arquetipo.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arquetipo.Domain.IRepository
{
    public interface IEstadoSolicitudRepository
    {
        Task<EstadoSolicitud> GetByDescripcion(string descripcion);
    }
}
