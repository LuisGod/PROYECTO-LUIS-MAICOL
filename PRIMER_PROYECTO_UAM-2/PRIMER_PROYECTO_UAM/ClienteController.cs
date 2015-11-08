using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace PRIMER_PROYECTO_UAM
{
    public class ClienteController
    {



        private string buscar;
        public string Buscar
        {
            get { return buscar; }
            set { buscar = value; }
        }



        public void listarclientes(DataGridView data)
        {
            Conexion myconexion = new Conexion();
            SqlConnection conexion = myconexion.CreateConnection();

            conexion.Open();
            SqlCommand comando = new SqlCommand("VER_CLIENTE", conexion);
            comando.Connection = conexion;
            comando.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(dt);
            data.DataSource = dt;
            data.Columns[0].Width = 60;
            data.Columns[1].Width = 165;
            data.Columns[2].Width = 165;
            data.Columns[3].Width = 90;
            data.Columns[4].Width = 50;
            data.Columns[5].Width = 165;
            data.Columns[6].Width = 100;
            data.Columns[7].Width = 125;

            conexion.Close();
        }

        //METODOS PARA BUSCAR  POR CEDULA
        public void buscarcedula(DataGridView data)
        {
            Conexion myconexion = new Conexion();
            SqlConnection conexion = myconexion.CreateConnection();
            conexion.Open();
            SqlCommand comando = new SqlCommand("SELECT * FROM CLIENTE where DNI like ('" + buscar + "%')", conexion);
            comando.Connection = conexion;
            comando.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(dt);
            data.DataSource = dt;
            conexion.Close();

           

        }

        //METODOS PARA BUSCAR POR APELLIDO
        public void buscarapellido(DataGridView data)
        {
            Conexion myconexion = new Conexion();
            SqlConnection conexion = myconexion.CreateConnection();
            conexion.Open();
            SqlCommand comando = new SqlCommand("SELECT * FROM CLIENTE where APELLIDOS like ('" + buscar + "%')", conexion);
            comando.Connection = conexion;
            comando.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(dt);
            data.DataSource = dt;
            conexion.Close();
        }
        public void eliminar(DataGridView dataelimina)
        {
            Conexion myconexion = new Conexion();
            SqlConnection conexion = myconexion.CreateConnection();
            DialogResult resultado = MessageBox.Show("¿Estas Seguro de Eliminar al cliente?");
            if (resultado == DialogResult.No)
            {
                return;
            }

            {
                SqlCommand comando = new SqlCommand("BORRAR_CLIENTE", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("ID", dataelimina.CurrentRow.Cells["ID"].Value);
                conexion.Open();
                comando.ExecuteNonQuery();
                conexion.Close();

                MessageBox.Show("El cliente ha sido eliminado");
            }

        }



    }
}
