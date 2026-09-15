using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace DataAccess
{
    public abstract class ConnectionToSql
    {
        private readonly string connectionString;
         public ConnectionToSql()
        {
            if (File.Exists(@"D:\AzureRemote\DataAccess\Conexion.ini\Conexion.ini"))
            {
                ficheroINI = @"D:\AzureRemote\DataAccess\Conexion.ini\Conexion.ini";
                string conexion2 = LeerINI("ConexionINI", "");
                conexion2.Replace("\\\\", "\\");
                connectionString = conexion2;
            }
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
        public string LeerINI(string Seccion, string Clave)
        {
            StringBuilder temp = new StringBuilder(255);
            int i = GetPrivateProfileString(Seccion, Clave, "", temp, 255, this.ficheroINI);
            return temp.ToString();
        }
       
        public string ficheroINI { get; private set; }

        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section,
            string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section,
            string key, string def, StringBuilder retVal, int size, string filePath);
    }
}
