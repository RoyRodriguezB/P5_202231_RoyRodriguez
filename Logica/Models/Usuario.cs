using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Logica.Models
{
    public class Usuario
    {

        //atributos
        public int IDUsuario { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasennia { get; set; }
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
            Conexion MICnn = new Conexion();
            //lista de parametros para insert
            MICnn.ListaParametros.Add(new SqlParameter("@Nombre", this.Nombre));

            MICnn.ListaParametros.Add(new SqlParameter("@Cedula", this.Cedula));
            MICnn.ListaParametros.Add(new SqlParameter("@NombreUsuario", this.NombreUsuario));
            //debe incriptar la contraseña
            MICnn.ListaParametros.Add(new SqlParameter("@Contrasennia", this.Contrasennia));

            MICnn.ListaParametros.Add(new SqlParameter("@Email", this.Email));

            MICnn.ListaParametros.Add(new SqlParameter("@IDRol", this.MiRol.IDUsuario));
            MICnn.ListaParametros.Add(new SqlParameter("@IDEmpresa", this.MiEmpresa.IDEmpresa));

            int Resultado = MICnn.EjecutarUpdateDeleteInsert("SPUsuarioAgregar");

            if(Resultado > 0)
            {
                R = true;
            }

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

            Conexion MICnn = new Conexion();

            MICnn.ListaParametros.Add(new SqlParameter("@Cedula", this.Cedula));

            DataTable Consulta = MICnn.EjecutarSelect("SPUsuarioConsultarPorCedula");

            if(Consulta != null && Consulta.Rows.Count > 0)
            {
                
               R = true;
            }

            return R;
        }
        bool ConsultarPorNombreUsuario()
        {
            bool R = false;
            //SELECT
            Conexion MICnn = new Conexion();

            MICnn.ListaParametros.Add(new SqlParameter("@NombreUsuario", this.NombreUsuario));

            DataTable Consulta = MICnn.EjecutarSelect("SPUsuarioConsultarPorNombreUsuario");

            if (Consulta != null && Consulta.Rows.Count > 0)
            {

                R = true;
            }

            return R;
        }
        bool ConsultarPorEmail()
        {
            bool R = false;
            //SELECT
            Conexion MICnn = new Conexion();

            MICnn.ListaParametros.Add(new SqlParameter("@Email", this.Email));

            DataTable Consulta = MICnn.EjecutarSelect("SPUsuarioConsultarPorEmail");

            if (Consulta != null && Consulta.Rows.Count > 0)
            {

                R = true;
            }

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
