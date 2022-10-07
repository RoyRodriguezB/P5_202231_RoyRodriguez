using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class FacturaInventario
    {
        public decimal Costo { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal Cantidad { get; set; }
        public decimal PorcentajeImpuesto { get; set; }
        public decimal PorcentajeDescuento { get; set; }
        public decimal SubTotal { get; set; }//suma cantidad * precio venta

        public decimal DescuentoTotal { get; set; }

        public decimal SubTotal2 { get; set; }//subtotal - descuentototal

        public decimal ImpuestoTotal { get; set; }
        public decimal TotalLinea { get; set; }//subtotal2 + impuestototal

        //funciones
        public decimal TotalizarLinea()
        {
            //decimal R = 0;

            SubTotal = Cantidad * PrecioVenta;
            //momto del descuento
            DescuentoTotal = (SubTotal * PorcentajeDescuento) / 100;

            //subtital2
            SubTotal2 = SubTotal - DescuentoTotal;

            ImpuestoTotal = (SubTotal * PorcentajeImpuesto) / 100;

            TotalLinea = SubTotal2 + ImpuestoTotal;



            //Acá va el código que permite agregar un proveedor
            //en la base de datos

            return TotalLinea;
        }

        public Inventario MiInventario { get; set; }

        public FacturaInventario()
        {
            MiInventario = new Inventario()

        }


    }
}
