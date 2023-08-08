using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAGUAR_APP
{
    public class GrupoUser
    {
        /// <summary>
        /// Enumerador de los grupos disponibles para el usuario.
        /// </summary>
        public enum GrupoUsuario
        {
            Montacarga = 0,
            Logistica = 1,
            Calidad = 2,
            Administradores = 3,
            Produccion=4,
            ProduccionV2 = 5,
            Contabilidad = 6,
            RRHH=8,
            Forecasting=9,
            Bascula=10,
            Formulacion=11,
            Facturacion_Admin = 12,
            Facturacion_EndUser = 13
        }

        public GrupoUsuario GrupoUsuarioActivo;

        /// <summary>
        /// Constructor
        /// </summary>
        public GrupoUser()
        {
            GrupoUsuarioActivo = GrupoUsuario.Administradores;
        }
    }
}
