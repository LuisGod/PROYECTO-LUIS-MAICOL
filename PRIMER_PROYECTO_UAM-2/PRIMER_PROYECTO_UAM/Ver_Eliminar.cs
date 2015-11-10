using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace PRIMER_PROYECTO_UAM
{
    public partial class Ver_Eliminar : Form
    {
      
        ClienteController ManipularDatos = new ClienteController();
        private string buscar;
        public string Buscar
        {
            get { return buscar; }
            set { buscar = value; }
        }
        public Ver_Eliminar()
        {
            InitializeComponent();
        }

        Conexion myconexion = new Conexion();
        ClienteController ver = new ClienteController();
        private void Ver_Eliminar_Load(object sender, EventArgs e)
        {
            r_ced.Checked = true;
            ver.listarclientes(dataeliminar);

        }



        private void txtcedula_TextChanged(object sender, EventArgs e)
        {

            if (r_ced.Checked == true)
            {
                ver.Buscar = txtcedula.Text;
                ver.buscarcedula(dataeliminar);
            }
            else if (r_apellido.Checked == true)
            {
                ver.Buscar = txtcedula.Text;
                ver.buscarapellido(dataeliminar);
            }
        }

        private void txtbuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (r_ced.Checked == true)
            {
                txtcedula.MaxLength = 8;
                if (Char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            else if (r_apellido.Checked == true)
            {
                txtcedula.MaxLength = 43556;
                if (Char.IsLetter(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }




        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void r_ced_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            ver.eliminar(dataeliminar);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {



        }

        private void r_apellido_CheckedChanged(object sender, EventArgs e)
        {
            ver.buscarapellido(dataeliminar);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnactualizar_Click_1(object sender, EventArgs e)
        {

        }



        private void button2_Click(object sender, EventArgs e)
        {





        }

        private void btnact_Click(object sender, EventArgs e)
        {

        }








    }
}


