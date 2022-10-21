using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class UsuarioRol
    {

        public int IDUsuario { get; set; }
        public string Rol { get; set; }

        public DataTable Listar()
        {
            DataTable R = new DataTable();
            //darle funcionalidad

            //paso 2.1 y 2.2 de seq usuario rol listar
            Conexion MICnn = new Conexion();

            //paso 2.3 y 2.4
            R = MICnn.EjecutarSelect("SPUsuarioRolListar");


            return R;

        }
    }
}
