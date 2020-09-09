using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace teste1.CLASSES
{
    class CONEXAO
    {

        public SqlConnection conexao_bd_abrir()
        {
            SqlConnection con = new SqlConnection(@"Data Source=den1.mssql7.gear.host; Password=Lm57?uj?E61K; User ID=jiora12; Initial Catalog=jiora12;");

            con.Open();
            return con;
        }

        public SqlConnection conexao_bd_fechar()
        {
            SqlConnection con = new SqlConnection(@"Data Source=den1.mssql7.gear.host; Password=Lm57?uj?E61K; User ID=jiora12; Initial Catalog=jiora12;");

            con.Close();
            return con;
        }

    }
}
