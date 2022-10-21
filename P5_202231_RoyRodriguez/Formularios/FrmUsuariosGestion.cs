using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5_202231_RoyRodriguez.Formularios
{
    public partial class FrmUsuariosGestion : Form
    {
        public Logica.Models.Usuario MIUsuarioLocal { get; set; }

        public FrmUsuariosGestion()
        {
            InitializeComponent();

            MIUsuarioLocal = new Logica.Models.Usuario();
        }

        private void FrmUsuariosGestion_Load(object sender, EventArgs e)
        {
            //establecer el form principal
            MdiParent = Globales.MiFormPrincipal;

            CargarRolesDeUsuario();
            CargarEmpresas();
        }


        private void CargarRolesDeUsuario()
        {
            //Paso 1 y 1.1 de seq usuario rol listar
            Logica.Models.UsuarioRol MiRolUsuario = new Logica.Models.UsuarioRol();


            DataTable dt = new DataTable();
            dt = MiRolUsuario.Listar();

            if(dt != null && dt.Rows.Count > 0)
            {
                //combo box tipo usuario
                CboxRolUsuario.ValueMember = "IDUsuarioRol";
                CboxRolUsuario.DisplayMember = "Rol";

                CboxRolUsuario.DataSource = dt;

                CboxRolUsuario.SelectedIndex = -1;
            }
        }

        private void CargarEmpresas()
        {
            //Paso 1 y 1.1 de seq usuario rol listar
            Logica.Models.Empresa MiEmpresa = new Logica.Models.Empresa();


            DataTable dt = new DataTable();
            dt = MiEmpresa.Listar();

            if (dt != null && dt.Rows.Count > 0)
            {
                //combo box tipo usuario
                CboxEmpresa.ValueMember = "ID";
                CboxEmpresa.DisplayMember = "D";

                CboxEmpresa.DataSource = dt;

                CboxEmpresa.SelectedIndex = -1;
            }
        }




        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void CboxRolUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
