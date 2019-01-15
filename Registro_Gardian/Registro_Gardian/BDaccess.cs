using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro_Gardian
{
    class BDaccess
    {
        string CC;        
        OleDbConnection cn;
        //ComboBox cmbdata;
        //result set
        OleDbDataAdapter da;
        //preparedstatement
        OleDbCommandBuilder Constructor;
        //DataTable Tabla;
        //BindingSource Fuente;
        //lector de datos 
        OleDbDataReader dr;
        public BDaccess(string s)
        {
            CC = @"Provider=Microsoft.ACE.OLEDB.12.0;" + s;
            cn = new OleDbConnection();
            cn.ConnectionString = CC;
            cn.Open();
        }

        
        public void CrearConexion()
        {
            cn = new OleDbConnection(CC);
            cn.Open();
        }

        public void CerrarConexion()
        {
            cn.Close();
        }

        public int Comandosinresultado(string command)
        {
            //devuelve un entero que indica cuantas filas se modificaron
            OleDbCommand com = new OleDbCommand(command, cn);
            return com.ExecuteNonQuery();
        }

        public string Comandounvalor(string query)
        {
            //ejecuta un query que regresa un solo dato, si no hay resultado regresa cadena vacia
            OleDbCommand cmd = new OleDbCommand(query, cn);
            dr = cmd.ExecuteReader();
            bool haydatos = dr.Read();
            string res;
            if (haydatos)
                res = dr[0].ToString();
            else
                res = "";
            dr.Close();
            return res;
        }
        //ejecuta un query que regresa una tabla de datos
        //metodo que ejecuta una consulta con resultado, el resultado lo devuelve en un datatable 
        public DataTable ConandoconResultados(string query)
        {
            da = new OleDbDataAdapter(query, cn);
            DataTable tabla = new DataTable();
            da.Fill(tabla);
            return tabla;
        }

        public bool Estado()
        {
            if (cn.State == ConnectionState.Open)
                return true;
            else
                return false;
        }
    }
}
