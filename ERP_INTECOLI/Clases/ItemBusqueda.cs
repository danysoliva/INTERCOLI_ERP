using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_INTECOLI.Clases
{
    public class ItemBusqueda
    {
        public Int64 id_estudiantes;
        public string Identidad;
        public string Nombres;
        public string Apellidos;

        public ItemBusqueda()
        {
            id_estudiantes = 0;
            Identidad = "";
            Nombres = "";
            Apellidos = "";
        }

    }
}
