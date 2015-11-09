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
    public partial class Agrega_Conductor : Form
    {
        public Agrega_Conductor()
        {
            InitializeComponent();
        }

        private void Agrega_Conductor_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonagrega_Click(object sender, EventArgs e)
        {
            bool result;

            ConductorBE conductorbe = new ConductorBE();
            conductorbe.Placa = Convert.ToInt32(textboxplaca.Text);
            conductorbe.Año = Convert.ToInt16(textboxyear.Text);
            conductorbe.Color = textboxcolor.Text;
            conductorbe.Nombres = textboxnombr.Text;
            conductorbe.Apellidos = textboxapell.Text;
            conductorbe.DNI = Convert.ToInt32(textboxcedul.Text);
            conductorbe.Edad = Convert.ToInt16(textboxage.Text);
            conductorbe.Direccion = textdirec.Text;
            conductorbe.Provincia = textboxprovincia.Text;
            
            


            ConductorController controler = new ConductorController();
            if (result = controler.AgregaConductor(conductorbe))
            {
                MessageBox.Show("Conductor Almacenado con Exito");
            }
            else
            {
                MessageBox.Show("La Insercion ha Fallado");
            }
        }

        

        
    }
}
