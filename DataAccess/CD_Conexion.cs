using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace DataAccess
{
    class CD_Conexion
    {
              
        private SqlConnection Conexion = new SqlConnection(LeerINI("ConexionINI", ""));

        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }
        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }

        public static string LeerINI(string Seccion, string Clave)
        {
            StringBuilder temp = new StringBuilder(255);
            int i = GetPrivateProfileString(Seccion, Clave, "", temp, 255, @"D:\AzureRemote\DataAccess\Conexion.ini\Conexion.ini");
            return temp.ToString();
        }

        public string ficheroINI { get; private set; }
        public static string connectionString { get; private set; }

        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section,
            string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section,
            string key, string def, StringBuilder retVal, int size, string filePath);

    }
}
