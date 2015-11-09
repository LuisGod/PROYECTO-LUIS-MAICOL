using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;//libreria para imagen

using System.Data.SqlClient;

namespace PRIMER_PROYECTO_UAM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public OpenFileDialog examinar = new OpenFileDialog();
        private void Form1_Load(object sender, EventArgs e)
        {

            ////////////////////////////////////////////////////////////////////////////////
            List<ProvinciaBE> listaP = new List<ProvinciaBE>();
            ProvinciaController provinciacontrola = new ProvinciaController();
            listaP = provinciacontrola.CONSULTAPROVINCIA();

            BindingSource provinciasourse = new BindingSource();
            provinciasourse.DataSource = listaP;
            cmbprovincia.DataSource = provinciasourse;
            cmbprovincia.DisplayMember = "PROVINCIA";
            cmbprovincia.ValueMember = "IDPROVINCIAS";
           
            ///////////////////////////////////////////////////////////////////////////////

            List<GeneroBE> lista = new List<GeneroBE>();

            GeneroController generocontrola = new GeneroController();
            lista = generocontrola.CONSULTAGENERO();


            BindingSource generosourse = new BindingSource();
            generosourse.DataSource = lista;
            cmbgenero.DataSource = generosourse;
            cmbgenero.DisplayMember = "GENERO";
            cmbgenero.ValueMember = "IDGENERO";

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtnombre.Text == "")
            {
                MessageBox.Show("Digite un Nombre para Continuar");
                txtnombre.Focus();
            }
            else if (txtapellido.Text == "")
            {
                MessageBox.Show("Digite un Apellido para Continuar");
                txtapellido.Focus();
            }
            else if (txtcedula.Text == "")
            {
                MessageBox.Show("Digite la Cédula para Continuar");
                txtcedula.Focus();
            }
            else if (txtdireccion.Text == "")
            {
                MessageBox.Show("Digite Direccion para Continuar");
                txtdireccion.Focus();
            }

            else if (txtexaminar.Text == "")
            {
                MessageBox.Show("Cargue una fotografia para Continuar");
                btnbuscarfoto.Focus();

            }

            else
            {
                REGISTRARCLIENTE();

            }
        }

                //almacenar////////////////////////////////////////////////////////7
        public bool  REGISTRARCLIENTE()
        {
           ClienteBE  REGISTRAR_CLIENTE = new ClienteBE();

            bool resulta = false;
            try
            {
                    Conexion myconexion = new Conexion();
                    SqlConnection conexion = myconexion.CreateConnection();
                    SqlCommand comando = myconexion.CreateCommand(conexion);

                    //pasos
                    FileStream stream = new FileStream(txtexaminar.Text, FileMode.Open, FileAccess.Read);
                    //Se inicailiza un flujo de archivo con la imagen seleccionada desde el disco.
                    BinaryReader br = new BinaryReader(stream);
                    FileInfo fi = new FileInfo(txtexaminar.Text);

                    //Se inicializa un arreglo de Bytes del tamaño de la imagen
                    byte[] binData = new byte[stream.Length];
                    //Se almacena en el arreglo de bytes la informacion que se obtiene del flujo de archivos(foto)
                    //Lee el bloque de bytes del flujo y escribe los datos en un búfer dado.
                    stream.Read(binData, 0, Convert.ToInt32(stream.Length));

                    ////Se muetra la imagen obtenida desde el flujo de datos
                    ClienteBE cliente = new ClienteBE();


                    picfoto.Image = Image.FromStream(stream);
                    conexion.Open();
                    comando.CommandText = "REGISTRAR_CLIENTE";
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@NOMBRES",txtnombre.Text.ToString());    //;
                    comando.Parameters.AddWithValue("@APELLIDOS", txtapellido.Text.ToString());
                    comando.Parameters.AddWithValue("@DNI", txtcedula.Text.ToString());
                    comando.Parameters.AddWithValue("@EDAD", numedad.Text.ToString());
                    comando.Parameters.AddWithValue("@DIRECCION", txtdireccion.Text);
                    comando.Parameters.AddWithValue("@PROVINCIA", cmbprovincia.Text);
                    comando.Parameters.AddWithValue("@GENERO", cmbgenero.Text);
                    comando.Parameters.AddWithValue("@FOTO", binData);

                    int result = comando.ExecuteNonQuery();
                    if (result > 0)
                        MessageBox.Show("!!!!!DATOS ALMACENADOS CORRECTAMENTE¡¡¡¡¡");
                    else
                        MessageBox.Show("INSERCIÓN FALLO");
                    conexion.Close();

                    txtnombre.Clear();

                    txtapellido.Clear();
                    txtdireccion.Clear();
                    picfoto.Image = null;
                    txtcedula.Clear();
                    txtnombre.Focus();
                }
            catch (SqlException e)
            {
                //insert error in a log
                resulta = false;
            }
            return resulta;
            
        }
            
        

        private void btnbuscarfoto_Click(object sender, EventArgs e)
        {
            examinar.Filter = "image files|*.jpg;*.png;*.gif;*.ico;.*;";
            DialogResult dres1 = examinar.ShowDialog();
            if (dres1 == DialogResult.Abort)
                return;
            if (dres1 == DialogResult.Cancel)
                return;
            txtexaminar.Text = examinar.FileName;
            picfoto.Image = Image.FromFile(examinar.FileName);
        }

       
    }
}

