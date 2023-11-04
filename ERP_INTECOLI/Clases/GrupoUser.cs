using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_INTECOLI
{
    public class GrupoUser
    {
        /// <summary>
        /// Enumerador de los grupos disponibles para el usuario.
        /// </summary>
        public enum GrupoUsuario
        {
            Manager = 1,
            Facturacion = 2,
            Atencion_al_cliente = 3,
            Cajero=4,
            Supervisor = 5,
            //Contabilidad = 6,
            //RRHH=8,
            //Forecasting=9,
            //Bascula=10,
            //Formulacion=11,
            //Facturacion_Admin = 12,
            //Facturacion_EndUser = 13
        }

        public GrupoUsuario GrupoUsuarioActivo;

        /// <summary>
        /// Constructor
        /// </summary>
        public GrupoUser()
        {
            GrupoUsuarioActivo = GrupoUsuario.Manager;
        }
    }
}
