using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PRIMER_PROYECTO_UAM
{
    public class ProvinciaController
    {
        public List<ProvinciaBE> CONSULTAPROVINCIA()
        {

            ProvinciaBE provinciaBE;
            List<ProvinciaBE> listaResulta = new List<ProvinciaBE>();

            Conexion myConnection = new Conexion();
            SqlConnection conexion = myConnection.CreateConnection();
            SqlCommand comando = myConnection.CreateCommand(conexion);
            SqlDataReader provincias;

            comando.CommandText = "CONSULTAPROVINCIA";
            comando.CommandType = CommandType.StoredProcedure;


            conexion.Open();

            provincias = comando.ExecuteReader();
            while (provincias.Read())
            {
                provinciaBE = new ProvinciaBE();


                provinciaBE.IDPROVINCIAS = int.Parse(provincias["IDPROVINCIAS"].ToString());
                provinciaBE.PROVINCIA = provincias["PROVINCIA"].ToString();


                listaResulta.Add(provinciaBE);

            }

            conexion.Close();

            return listaResulta;

        }

    }
}
