﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Cliente
    {
        //atributos
        public int IDCliente { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string CorreoElectronico { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public bool Activo { get; set; }

        //atributo compuesto
        public Empresa MiEmpresa { get; set; }
        public Cliente()
        {
            //constructor de la clase
            MiEmpresa = new Empresa();
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
        public Cliente ConsultarPorID()
        {
            //consultarporid CLIENTE
            Cliente R = new Cliente();

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
