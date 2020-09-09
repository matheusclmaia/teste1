using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace teste1.CLASSES
{
    class CRUD:CONEXAO
    {
        string resultado;
        public string select(string nome)
        {
            SqlCommand comando = new SqlCommand("select " +  nome + " from magias", conexao_bd_abrir());
            //comando.Parameters.Add(new SqlParameter("nome", nome));
            resultado = comando.ExecuteScalar().ToString();
            conexao_bd_fechar();

            return resultado;
        }

        public void insert_magia(string NOME, string DESCRICAO, string TIPO_DA_MAGIA, string CUSTO_DE_MANA, string CALCULO_DO_DADO, string ATRIBUTO, string ELEMENTO, string EFEITO, string CHANCE_DO_EFEITO, string AREA_DE_ALVO)
        {
            SqlCommand comando = new SqlCommand("INSERT INTO [dbo].[MAGIAS] ([NOME] ,[DESCRICAO] ,[TIPO_DA_MAGIA] ,[CUSTO_DE_MANA],[CALCULO_DO_DADO] ,[ATRIBUTO] ,[ELEMENTO] ,[EFEITO] ,[CHANCE_DO_EFEITO] ,[AREA_DE_ALVO]) values (@NOME , @DESCRICAO, @TIPO_DA_MAGIA  , @CUSTO_DE_MANA , @CALCULO_DO_DADO , @ATRIBUTO , @ELEMENTO , @EFEITO , @CHANCE_DO_EFEITO , @AREA_DE_ALVO)", conexao_bd_abrir());
            comando.Parameters.Add(new SqlParameter("NOME", NOME));
            comando.Parameters.Add(new SqlParameter("DESCRICAO", DESCRICAO));
            comando.Parameters.Add(new SqlParameter("TIPO_DA_MAGIA", TIPO_DA_MAGIA));
            comando.Parameters.Add(new SqlParameter("CUSTO_DE_MANA", CUSTO_DE_MANA));
            comando.Parameters.Add(new SqlParameter("CALCULO_DO_DADO", CALCULO_DO_DADO));
            comando.Parameters.Add(new SqlParameter("ATRIBUTO", ATRIBUTO));
            comando.Parameters.Add(new SqlParameter("ELEMENTO", ELEMENTO));
            comando.Parameters.Add(new SqlParameter("EFEITO", EFEITO));
            comando.Parameters.Add(new SqlParameter("CHANCE_DO_EFEITO", CHANCE_DO_EFEITO));
            comando.Parameters.Add(new SqlParameter("AREA_DE_ALVO", AREA_DE_ALVO));
            comando.ExecuteNonQuery();
            conexao_bd_fechar();            
        }

    }
}
