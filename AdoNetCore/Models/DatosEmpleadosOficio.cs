using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetCore.Models
{
    public class DatosEmpleadosOficio
    {
        //modelo para devolver a partir de nuestra consulta
        public int SumaSalarial { get; set; }
        public int Mediasalarial { get; set; }
        public int MaximoSalarial { get; set; }
    }
}
