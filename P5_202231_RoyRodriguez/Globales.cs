using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5_202231_RoyRodriguez
{
    public static class Globales
    {
        //los objetos que definamos en esta clase seran accesibles desde la totalidad de la aplicaion.
        //ademas esta clase al ser static se auto instancia


        public static Form MiFormPrincipal = new Formularios.FrmPrincipalMDI();

        public static Formularios.FrmUsuariosGestion MiFormMantUsuarios = new Formularios.FrmUsuariosGestion();
    }
}
