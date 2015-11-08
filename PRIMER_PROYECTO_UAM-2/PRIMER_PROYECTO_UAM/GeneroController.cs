using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PRIMER_PROYECTO_UAM
{
   public  class GeneroController
    {

       public List<GeneroBE> CONSULTAGENERO()
       {

           GeneroBE generoBE;
           List<GeneroBE> listaResult = new List<GeneroBE>();

           Conexion myConnection = new Conexion();
           SqlConnection conexion = myConnection.CreateConnection();
           SqlCommand comando = myConnection.CreateCommand(conexion);
           SqlDataReader generos;

           comando.CommandText = "CONSULTAGENERO";
           comando.CommandType = CommandType.StoredProcedure;
           

           conexion.Open();

           generos = comando.ExecuteReader();
           while (generos.Read())
           {
               generoBE = new GeneroBE();

               generoBE.IDGENERO = int.Parse(generos["IDGENERO"].ToString());
               generoBE.GENERO = generos["GENERO"].ToString();


               listaResult.Add(generoBE);

           }

           conexion.Close();

           return listaResult;

       }
    }
}
