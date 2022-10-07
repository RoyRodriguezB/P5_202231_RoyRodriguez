using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Usuario
    {

        //atributos
        public int IDUsuario { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasenna { get; set; }
        public string CodigoRecuperacion { get; set; }
        public string Email { get; set; }

        public bool Activo { get; set; }

        //atributo compuesto
        public Empresa MiEmpresa { get; set; }

        public UsuarioRol MiRol { get; set; }
        public Usuario()
        {
            //constructor de la clase
            MiEmpresa = new Empresa();
            MiRol = new UsuarioRol();
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
        public Usuario ConsultarPorID()
        {
            //consultarporid CLIENTE
            Usuario R = new Usuario();

            //select

            return R;
        }
        bool ConsultarPorCedula()
        {
            bool R = false;
            //SELECT

            return R;
        }
        bool ConsultarPorNombreUsuario()
        {
            bool R = false;
            //SELECT

            return R;
        }
        bool ConsultarPorEmail()
        {
            bool R = false;
            //SELECT

            return R;
        }
        public DataTable ListarActivos()
        {
            DataTable R = new DataTable();

            return R;
        }
        public DataTable ListarInactivos()
        {
            DataTable R = new DataTable();

            return R;
        }

        public bool ValidarLogin(string NombreUsuario, string contrasennia)
        {
            bool R = false;

            return R;
        }

        public bool EnviarCodigoRecuperacion(string Email)
        {
            bool R = false;

            return R;
        }
        public bool ResetearContraseña()
        {
            bool R = false;

            return R;
        }
    }
}
