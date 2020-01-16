using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;  //BASE DE DATOS ///


namespace SistemaRestaurant
{
    // Conexíon a BD - José Z
    public static class BD
    {
        public static string connetionString = @"Data Source=DESKTOP-PRGRUST\SQLEXPRESS; Initial Catalog=Restaurante;User ID=sa;Password=admin";
        public static SqlConnection cnn = new SqlConnection(connetionString);

    }
    // ---------------------

    class DataBase
    {
    }
}
