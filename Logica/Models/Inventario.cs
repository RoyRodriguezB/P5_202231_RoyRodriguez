using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    
    public class Inventario
    {
        public int IDInventario { get; set; }
        public string NombreItem { get; set; }

        public string CodigoBarras { get; set; }

        public decimal Costo { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal CantidadEnStock { get; set; }
        public bool Activo { get; set; }

        //atributo compuesto
        public Empresa MiEmpresa { get; set; }

        public Categoria MiCategoria { get; set; }
        public Impuesto MiImpuesto { get; set; }

        //relacion muchos a muchos
        ////copiar factura
        public List<InventarioProveedor> ListadoProveedores { get; set; }

        public Inventario()
        {
            //constructor de la clase
            MiEmpresa = new Empresa();
            MiCategoria = new Categoria();
            MiImpuesto = new Impuesto();
            ListadoProveedores = new List<InventarioProveedor>();
            Activo = true;
        }

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
        public Inventario ConsultarPorID()
        {
            //consultarporid CLIENTE
            Inventario R = new Inventario();

            //select

            return R;
        }

        public bool ConsultarPorCodigoBarras(int IDEmpresa)
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
        public DataTable ListarProveedores()
        {
            DataTable R = new DataTable();

            return R;
        }
        public bool AgregarProveedor()
        {
            bool R = false;

            //Acá va el código que permite agregar un proveedor
            //en la base de datos

            return R;
        }

        public bool ModificarPrecioProveedor()
        {
            bool R = false;

            //Acá va el código que permite agregar un proveedor
            //en la base de datos

            return R;
        }
        public bool EliminaProveedor()
        {
            //en las eliminaciones logicas lo que haremos sera cambiar el valor
            //
            bool R = false;

            //Acá va el código que permite agregar un proveedor
            //UPDATE en la base de datos

            return R;
        }



    }
}
