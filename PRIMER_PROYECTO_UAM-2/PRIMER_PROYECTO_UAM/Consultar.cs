using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace PRIMER_PROYECTO_UAM
{
    public partial class Consultar : Form
    {
        public OpenFileDialog examinar = new OpenFileDialog();
        public Consultar()
        {
            InitializeComponent();
        }

        private void Consultar_Load(object sender, EventArgs e)
        {


            //cmbcedula.SelectedIndex = 0;
            //txtbuscarcliente.Focus();
            //txtbuscarcliente.Enabled = true;
            //txtnombre.Enabled = false;
            //txtapellido.Enabled = false;
            //txtdireccion.Enabled = false;
            //cmbprovincia.Enabled = false;
            //btnedit.Enabled = false;

            ////////////////////////////////////////////////////////////////////////////////


            List<ProvinciaBE> listaP = new List<ProvinciaBE>();
            ProvinciaController provinciacontrola = new ProvinciaController();
            listaP = provinciacontrola.CONSULTAPROVINCIA();

            BindingSource provinciasourse = new BindingSource();
            provinciasourse.DataSource = listaP;
            cmbprovincia.DataSource = provinciasourse;
            cmbprovincia.DisplayMember = "PROVINCIA";
            cmbprovincia.ValueMember = "IDPROVINCIAS";


        }
        private void EditarClient()
        {
            Conexion myconexion = new Conexion();
            SqlConnection conexion = myconexion.CreateConnection();
            conexion.Open();
            string sql = @"UPDATE CLIENTE SET
                                         [NOMBRES] = @NOMBRES, [APELLIDOS] = @APELLIDOS ,[DIRECCION] = @DIRECCION ,[PROVINCIA] = @PROVINCIA WHERE [ID] = @ID";

            SqlCommand command = new SqlCommand(sql, conexion);

            command.Parameters.AddWithValue("ID", label7.Text);

            command.Parameters.AddWithValue("NOMBRES", txtnombre.Text);
            command.Parameters.AddWithValue("APELLIDOS", txtapellido.Text);
            command.Parameters.AddWithValue("DIRECCION", txtdireccion.Text);
            command.Parameters.AddWithValue("PROVINCIA", cmbprovincia.Text);
            command.ExecuteNonQuery();
            MessageBox.Show("Datos Actualizados Satisfactoriamente");
            conexion.Close();
        }

        private void txtdirección_TextChanged(object sender, EventArgs e)
        {

        }

    
        private void txtbuscarcliente_KeyDown(object sender, KeyEventArgs e)////////
        {
        }
        
        public void ver()
        {

            //BUSQUEDA POR CEDULA
            if (cmbcedula.Text == "Cedula")
            {
                Conexion myconexion = new Conexion();
                SqlConnection conexion = myconexion.CreateConnection();
               
                conexion.Open();
                SqlCommand cmd = new SqlCommand("select * from CLIENTE where DNI= @Clav", conexion);
                cmd.Parameters.AddWithValue("@Clav", txtbuscarcliente.Text);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                //Representa un set de comandos que es utilizado para llenar un DataSet
                SqlDataAdapter dp = new SqlDataAdapter(cmd);
                //Representa un caché (un espacio) en memoria de los datos.
                DataSet ds = new DataSet("CLIENTE");

                //Arreglo de byte en donde se almacenara la foto en bytes
                byte[] MyData = new byte[0];


                //Llenamosel DataSet con la tabla. ESTUDIANTE es nombre de la tabla
                dp.Fill(ds, "CLIENTE");

                //Si dni existe ejecutara la consulta
                if (ds.Tables["CLIENTE"].Rows.Count > 0)
                {
                    //Inicializamos una fila de datos en la cual se almacenaran todos los datos de la fila seleccionada
                    DataRow myRow = ds.Tables["CLIENTE"].Rows[0];

                    //Se almacena el campo foto de la tabla en el arreglo de bytes
                    MyData = (byte[])myRow["FOTO"];
                    //Se inicializa un flujo en memoria del arreglo de bytes
                    MemoryStream stream = new MemoryStream(MyData);
                    //En el picture box se muestra la imagen que esta almacenada en el flujo en memoria 
                    //el cual contiene el arreglo de bytes
                    picfoto3.Image = Image.FromStream(stream);

                    txtnombre.Text = myRow["NOMBRES"].ToString();
                    txtapellido.Text = myRow["APELLIDOS"].ToString();
                    txtdireccion.Text = myRow["DIRECCION"].ToString();
                    cmbprovincia.Text = myRow["PROVINCIA"].ToString();
                    label4.Text = myRow["ID"].ToString();

                    txtbuscarcliente.Enabled = false;
                    cmbcedula.Enabled = false;
                    txtnombre.Enabled = true;
                    txtnombre.Focus();
                    txtapellido.Enabled = true;
                    txtdireccion.Enabled = true;
                    cmbprovincia.Enabled = true;

                }

                else
                {
                    MessageBox.Show("La Cedula ingresada NO EXISTE - Digite nuevamente");

                    txtbuscarcliente.Enabled = true;
                    cmbcedula.Enabled = true;
                    txtnombre.Enabled = false;
                    txtbuscarcliente.Focus();
                    txtbuscarcliente.Clear();
                    txtapellido.Enabled = false;
                    txtdireccion.Enabled = false;
                    cmbprovincia.Enabled = false;

                }

            }

            //BUSQUEDA POR APELLIDO
            if (cmbcedula.Text == "Apellido")
            {
                Conexion myconexion = new Conexion();
                SqlConnection conexion = myconexion.CreateConnection();

                conexion.Open();
                SqlCommand cmd = new SqlCommand("select * from CLIENTE where DNI= @Clav", conexion);
                cmd.Parameters.AddWithValue("@Clav", txtbuscarcliente.Text);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                //Representa un set de comandos que es utilizado para llenar un DataSet
                SqlDataAdapter dp = new SqlDataAdapter(cmd);
                //Representa un caché (un espacio) en memoria de los datos.
                DataSet ds = new DataSet("CLIENTE");

                //Arreglo de byte en donde se almacenara la foto en bytes
                byte[] MyData = new byte[0];


                //Llenamosel DataSet con la tabla. ESTUDIANTE es nombre de la tabla
                dp.Fill(ds, "CLIENTE");

                //Si dni existe ejecutara la consulta
                if (ds.Tables["CLIENTE"].Rows.Count > 0)
                {
                    //Inicializamos una fila de datos en la cual se almacenaran todos los datos de la fila seleccionada
                    DataRow myRow = ds.Tables["CLIENTE"].Rows[0];

                    //Se almacena el campo foto de la tabla en el arreglo de bytes
                    MyData = (byte[])myRow["FOTO"];
                    //Se inicializa un flujo en memoria del arreglo de bytes
                    MemoryStream stream = new MemoryStream(MyData);
                    //En el picture box se muestra la imagen que esta almacenada en el flujo en memoria 
                    //el cual contiene el arreglo de bytes
                    picfoto3.Image = Image.FromStream(stream);

                    txtnombre.Text = myRow["NOMBRES"].ToString();
                    txtapellido.Text = myRow["APELLIDOS"].ToString();
                    txtdireccion.Text = myRow["DIRECCION"].ToString();
                    cmbprovincia.Text = myRow["PROVINCIA"].ToString();
                    label4.Text = myRow["ID"].ToString();

                    txtbuscarcliente.Enabled = false;
                    cmbcedula.Enabled = false;
                    txtnombre.Enabled = true;
                    txtnombre.Focus();
                    txtapellido.Enabled = true;
                    txtdireccion.Enabled = true;
                    cmbprovincia.Enabled = true;

                }

                else
                {
                    MessageBox.Show("El Apellido  NO EXISTE - Digite nuevamente");

                    txtbuscarcliente.Enabled = true;
                    cmbcedula.Enabled = true;
                    txtnombre.Enabled = false;
                    txtbuscarcliente.Focus();
                    txtbuscarcliente.Clear();
                    txtapellido.Enabled = false;
                    txtdireccion.Enabled = false;
                    cmbprovincia.Enabled = false;

                }

            }


        }



        private void txtbuscarcliente_Enter(object sender, EventArgs e)
        {
            txtbuscarcliente.BackColor = Color.PeachPuff;
        }

        private void txtbuscarcliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbuscarcliente_KeyPress(object sender, KeyPressEventArgs e)
        {

          

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            ver();

        }
        private void btneditar_Click(object sender, EventArgs e)
        {
            EditarClient();


            txtnombre.Enabled = false;
            txtapellido.Enabled = false;
            txtdireccion.Enabled = false;
            cmbprovincia.Enabled = false;

        }

        private void cmbcedula_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            //EditarClient();


            //txtnombre.Enabled = false;
            //txtapellido.Enabled = false;
            //txtdireccion.Enabled = false;
            //cmbprovincia.Enabled = false;

        }
    }
}
