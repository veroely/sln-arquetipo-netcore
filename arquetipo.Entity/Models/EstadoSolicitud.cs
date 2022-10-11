using System;
using System.Collections.Generic;

namespace arquetipo.Entity.Models
{
    public partial class EstadoSolicitud
    {
        public EstadoSolicitud()
        {
            Solicituds = new HashSet<Solicitud>();
        }

        public int IdEstadoSolicitud { get; set; }
        public string Descripcion { get; set; } = null!;
        public bool EsActivo { get; set; }

        public virtual ICollection<Solicitud> Solicituds { get; set; }
    }
}
