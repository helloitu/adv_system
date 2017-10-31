using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//bd
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;

namespace TCC
{
    class secretariaBD
    {
        private MySqlConnection mCon;

        public secretariaBD()
        {
            mCon = new MySqlConnection("Persist Security Info = false; server = localhost; database = adv_sys;uid = root ; pwd =");
        }

        public DataTable getSecretaria()
        {
            MySqlCommand cmd = mCon.CreateCommand();
            MySqlDataAdapter da;
            cmd.CommandText = "SELECT * from tbl_secretaria order by sec_nome";
            try
            {
                mCon.Open();
                cmd = new MySqlCommand(cmd.CommandText, mCon);
                da = new MySqlDataAdapter(cmd);
                DataTable dtSecretaria = new DataTable();
                da.Fill(dtSecretaria);
                return dtSecretaria;
            }
            catch (MySqlException ex)
            {
                throw new ApplicationException(ex.ToString());
            }
            finally
            {
                mCon.Close();
            }
        }

        ////



        public void IncluirSecretaria(secretaria secretaria)
        {
            MySqlCommand Com = mCon.CreateCommand();
            Com.CommandText = "INSERT INTO tbl_secretaria(sec_nome,sec_rg,sec_cpf,sec_sexo,sec_endereco,sec_numero,sec_telefone,sec_celular) " +
                "values(?nome,?rg,?cpf,?sexo,?endereco,?numero,?telefone,?celular)";
            Com.Parameters.AddWithValue("?nome", secretaria.Nome);
            Com.Parameters.AddWithValue("?rg", secretaria.Rg);
            Com.Parameters.AddWithValue("?cpf", secretaria.Cpf);
            Com.Parameters.AddWithValue("?sexo", secretaria.Sexo);
            Com.Parameters.AddWithValue("?endereco", secretaria.Endereco);
            Com.Parameters.AddWithValue("?numero", secretaria.Numero);
            Com.Parameters.AddWithValue("?telefone", secretaria.Telefone);
            Com.Parameters.AddWithValue("?celular", secretaria.Celular);
            try
            {
                mCon.Open();
                int registrosAfetados = Com.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                throw new ApplicationException(ex.ToString());
            }
            finally
            {
                mCon.Close();
            }
        }

        public void alterarSecretaria(secretaria secretaria, int id)
        {
            MySqlCommand Com = mCon.CreateCommand();
            Com.CommandText = "UPDATE tbl_secretaria SET sec_nome=?nome, sec_rg = ?rg," +
                "sec_cpf = ?cpf, sec_sexo = ?sexo," +
                "sec_endereco = ?endereco,sec_cep=?cep,sec_cidade=?cidade," +
                " sec_estado = ?estado,sec_bairro=?bairro,sec_numero = ?numero , " +
                "sec_telefone = ?telefone , sec_celular = ?celular" +
                " WHERE sec_codigo=?codigo";
            Com.Parameters.AddWithValue("?nome", secretaria.Nome);
            Com.Parameters.AddWithValue("?rg", secretaria.Rg);
            Com.Parameters.AddWithValue("?cpf", secretaria.Cpf);
            Com.Parameters.AddWithValue("?sexo", secretaria.Sexo);
            Com.Parameters.AddWithValue("?endereco", secretaria.Endereco);
            Com.Parameters.AddWithValue("?cep", secretaria.CEP);
            Com.Parameters.AddWithValue("?cidade", secretaria.Cidade);
            Com.Parameters.AddWithValue("?estado", secretaria.Estado);
            Com.Parameters.AddWithValue("?bairro", secretaria.Bairro);
            Com.Parameters.AddWithValue("?numero", secretaria.Numero);
            Com.Parameters.AddWithValue("?telefone", secretaria.Telefone);
            Com.Parameters.AddWithValue("?celular", secretaria.Celular);
            Com.Parameters.AddWithValue("?codigo", id);
            try
            {
                mCon.Open();
                int registroAfetados = Com.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                throw new ApplicationException(ex.ToString());
            }
            finally
            {
                mCon.Close();
            }
        }

        public void excluirSecretaria(int id)
        {
            MySqlCommand Com = mCon.CreateCommand();
            Com.CommandText = "DELETE FROM tbl_secretaria WHERE sec_codigo=?codigo";
            Com.Parameters.AddWithValue("?codigo", id);
            try
            {
                mCon.Open();
                int registroAfetados = Com.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                throw new ApplicationException(ex.ToString());
            }
            finally
            {
                mCon.Close();
            }
        }


    }
}
