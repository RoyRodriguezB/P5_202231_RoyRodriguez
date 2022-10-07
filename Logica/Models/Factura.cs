using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Factura
    {
        public int IDFactura { get; set; }
        public int Numero { get; set; }
        public DateTime Fecha { get; set; }
        public string Notas { get; set; }

        //atributo compuesto
        public Cliente MiCliente { get; set; }

        public Usuario MiUsuario { get; set; }
        public FacturaTipo MiFacturaTipo { get; set; }

        //relacion muchos a muchos
        public List<FacturaInventario> Detalle { get; set; }

        public Factura()
        {
            //constructor de la clase
            MiCliente = new Cliente();
            MiUsuario = new Usuario();
            MiFacturaTipo = new FacturaTipo();
            Detalle = new List<FacturaInventario>();

            Fecha = DateTime.Now;
            
        }

        public int Agregar()
        {
            int R = 0;

            //Acá va el código que permite agregar un proveedor
            //en la base de datos

            return R;
        }

        public bool Imprimir()
        {
            bool R = false;

            //Acá va el código que permite agregar un proveedor
            //en la base de datos

            return R;
        }
        public DataTable ListarPorFechas(DateTime FechaInicial, DateTime FechaFinall)
        {
            DataTable R = new DataTable();

            return R;
        }



    }
}
