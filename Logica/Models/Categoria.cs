using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Categoria
    {
        //primero escribimos las prropiedads simples
        public int IDCategoria { get; set; }

        public string NombreCategoria { get; set; }

        //escribimos las funciones y metodos
        public DataTable Listar()
        {
             DataTable R = new DataTable();
            //hay que prrogramar la SP

            return R;

        }

    }
}
