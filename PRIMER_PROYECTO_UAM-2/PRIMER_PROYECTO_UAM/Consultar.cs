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
    public partial class Consultar : Form
    {
        //Conexion myConnection = new Conexion();
        //SqlConnection sqlConnection = myConnection.CreateConnection();
        //SqlCommand comando = myConnection.CreateCommand(sqlConnection);
        public Consultar()
        {
            InitializeComponent();
        }

        private void Consultar_Load(object sender, EventArgs e)
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
        }

        private void btneditar_Click(object sender, EventArgs e)
        {

        }
    }
}
