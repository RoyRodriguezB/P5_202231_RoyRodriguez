using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Proveedor
    {
        public int IDProveedor { get; set; }
        public string Nombre { get; set; }

        public string Cedula { get; set; }

        public string Direccion { get; set; }
        public string Notas { get; set; }
        public bool Activo { get; set; }


        //funciones y metodos

        public bool Agregar()
        {
            bool R = false;

            //Acá va el código que permite agregar un proveedor
            //en la base de datos

            return R;
        }

        public bool Modificar()
        {
            bool R = false;

            //Acá va el código que permite agregar un proveedor
            //en la base de datos

            return R;
        }
        public bool Eliminar()
        {
            //en las eliminaciones logicas lo que haremos sera cambiar el valor
            //
            bool R = false;

            //Acá va el código que permite agregar un proveedor
            //UPDATE en la base de datos

            return R;
        }
        bool ConsultarPorID()
        {
            bool R = false;

            //select

            return R;
        }
        bool ConsultarPorCedula()
        {
            bool R = false;
            //SELECT

            return R;
        }
        public DataTable Listar(bool VerActivos = true)
        {
            DataTable R = new DataTable();

            return R;
        }
    }
}
