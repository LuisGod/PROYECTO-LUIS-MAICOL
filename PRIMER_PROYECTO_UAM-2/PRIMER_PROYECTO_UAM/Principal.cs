using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRIMER_PROYECTO_UAM
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void bTNCONSULTAR_Click(object sender, EventArgs e)
        {
            Consultar frmconsulta = new Consultar();
             frmconsulta.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ver_Eliminar frmver = new Ver_Eliminar();
            frmver.Show();

        }

        }
    }

