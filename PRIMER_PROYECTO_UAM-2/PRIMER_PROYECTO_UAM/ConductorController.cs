using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PRIMER_PROYECTO_UAM
{
    public class ConductorController
    {
        public bool AgregaConductor(ConductorBE ConductorBk)
        {
            bool result = false;
            try
            {
                Conexion myConnection = new Conexion();
                SqlConnection conexion = myConnection.CreateConnection();
                SqlCommand comando = myConnection.CreateCommand(conexion);



                comando.CommandText = "REGISTRAR_CONDUCTOR";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@PLACA", ConductorBk.Placa);
                comando.Parameters.AddWithValue("@AñO", ConductorBk.Año);
                comando.Parameters.AddWithValue("@COLOR", ConductorBk.Color);
                comando.Parameters.AddWithValue("@NOMBRES", ConductorBk.Nombres);
                comando.Parameters.AddWithValue("@APELLIDOS", ConductorBk.Apellidos);
                comando.Parameters.AddWithValue("@DNI", ConductorBk.DNI);
                comando.Parameters.AddWithValue("@EDAD", ConductorBk.Edad);
                comando.Parameters.AddWithValue("@DIRECCION", ConductorBk.Direccion);
                comando.Parameters.AddWithValue("@PROVINCIA", ConductorBk.Provincia);



                conexion.Open();
                comando.ExecuteNonQuery();
                conexion.Close();
                result = true;
            }
            catch (SqlException e)
            {
                //insert error in a log
                result = false;
            }
            return result;
        }
        public List<ConductorBE> Agregaconduct()
        {
            ConductorBE conductorBE;
            List<ConductorBE> listaResult = new List<ConductorBE>();

            Conexion myConnection = new Conexion();
            SqlConnection conexion = myConnection.CreateConnection();
            SqlCommand comando = myConnection.CreateCommand(conexion);
            SqlDataReader cconduct;

            comando.CommandText = "REGISTRAR_CONDUCTOR";
            comando.CommandType = CommandType.StoredProcedure;

            conexion.Open();

            cconduct = comando.ExecuteReader();
            while (cconduct.Read())
            {
                conductorBE = new ConductorBE();

                conductorBE.Placa = Convert.ToInt32(cconduct["PLACA"]);
                conductorBE.Año = Convert.ToInt16(cconduct["AñO"]);
                conductorBE.Color = cconduct["COLOR"].ToString();
                conductorBE.Nombres = cconduct["NOMBRES"].ToString();
                conductorBE.Apellidos = cconduct["APELLIDOS"].ToString();
                conductorBE.DNI = Convert.ToInt16(cconduct["DNI"]);
                conductorBE.Edad = Convert.ToInt16(cconduct["EDAD"]);
                conductorBE.Direccion = cconduct["DIRECCION"].ToString();
                conductorBE.Provincia = cconduct["PROVINCIA"].ToString();


                listaResult.Add(conductorBE);

            }

            conexion.Close();

            return listaResult;
        }
    }

}
