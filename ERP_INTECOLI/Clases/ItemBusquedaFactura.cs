using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_INTECOLI.Clases
{
    public class ItemBusquedaFactura
    {
        public int id;
        public int lote;
        public int tipo;//1=Cliente. 2=Punto Venta
        public string ItemCode;
        public string ItemName;
        public int PresenacionID;
        public string Presentacion;

        public ItemBusquedaFactura()
        {
            id = 0;
            lote = 0;
            ItemCode = "";
            ItemName = "";
            tipo = 0;
        }

    }
}
