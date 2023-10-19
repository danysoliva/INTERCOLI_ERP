using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAGUAR_APP.Facturacion.Configuraciones.Models
{
  public  class ListaPrecioProductosAplicaPDV
    {
        public int IDListaPrecio { get; set; }
        public int PT_ID { get; set; }
        public int PDV_ID { get; set; }
        public decimal Precio { get; set; }
    }
}
