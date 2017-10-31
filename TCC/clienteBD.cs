using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;

namespace TCC
{
    class clienteBD
    {
        private MySqlConnection mCon;
        public clienteBD()
        {
            mCon = new MySqlConnection("Persist Security Info = false ;" + 
                "server = localhost;database = adv_sys;uid=root;pwd=");
        }

        public DataTable getCliente()
        {
            MySqlCommand cmd = mCon.CreateCommand();
            MySqlDataAdapter da;
            cmd.CommandText = "SELECT * from tbl_cliente order by cli_nome";
            try
            {
                mCon.Open();
                cmd = new MySqlCommand(cmd.CommandText, mCon);
                da = new MySqlDataAdapter(cmd);
                DataTable dtCliente = new DataTable();
                da.Fill(dtCliente);
                return dtCliente;
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



        public void IncluirCliente(cliente cliente)
        {
            MySqlCommand Com = mCon.CreateCommand();
            Com.CommandText = "INSERT INTO tbl_cliente(cli_nome,cli_sexo,cli_email,cli_rg,cli_cpf,cli_data_nascimento,cli_cidade,"+
                "cli_endereco,cli_numero,cli_telefone,cli_celular) "+
                "Values (?nome,?sexo,?email,?rg,?cpf,?datanascimento,?cidade,?endereco,?numero,?telefone,?celular)";
            Com.Parameters.AddWithValue("?nome", cliente.Nome);
            Com.Parameters.AddWithValue("?sexo", cliente.Sexo);
            Com.Parameters.AddWithValue("?email", cliente.Email);
            Com.Parameters.AddWithValue("?rg", cliente.Rg);
            Com.Parameters.AddWithValue("?cpf", cliente.Cpf);
            Com.Parameters.AddWithValue("?datanascimento", cliente.Datanascimento);
            Com.Parameters.AddWithValue("?cidade", cliente.Cidade);
            Com.Parameters.AddWithValue("?endereco", cliente.Endereco);
            Com.Parameters.AddWithValue("?numero", cliente.Numero);
            Com.Parameters.AddWithValue("?telefone", cliente.Telefone);
            Com.Parameters.AddWithValue("?celular", cliente.Celular);
            try
            {
                mCon.Open();
                int registrosAfetados = Com.ExecuteNonQuery();
            }
            catch(MySqlException ex)
            {
                throw new ApplicationException(ex.ToString());
            }
            finally
            {
                mCon.Close();
            }
        }
        /*
        public void alterarCliente(cliente cliente, int id)
        {
            MySqlCommand Com = mCon.CreateCommand();
            Com.CommandText = "UPDATE tbl_cliente SET cli_nome=?nome, cli_sexo = ?sexo," +
                " cli_email = ?email, cli_rg = ?rg," +
                "cli_cpf = ?cpf, cli_data_nascimento = ?data_nascimento," +
                "cli_cidade = ?cidade, cli_cep=?cep,cli_bairro=?bairro," +
                "cli_estado=?estado,cli_endereco = ?endereco, cli_numero = ?numero , " +
                "cli_telefone = ?telefone , cli_celular = ?celular" +
                " WHERE cli_cod=?cod";
            Com.Parameters.AddWithValue("?nome", cliente.Nome);
            Com.Parameters.AddWithValue("?sexo", cliente.Sexo);
            Com.Parameters.AddWithValue("?email", cliente.Email);
            Com.Parameters.AddWithValue("?rg", cliente.Rg);
            Com.Parameters.AddWithValue("?cpf", cliente.Cpf);
            Com.Parameters.AddWithValue("?data_nascimento", cliente.Datanascimento);
            Com.Parameters.AddWithValue("?cidade", cliente.Cidade);
            Com.Parameters.AddWithValue("?cep", cliente.CEP);
            Com.Parameters.AddWithValue("?bairro", cliente.Bairro);
            Com.Parameters.AddWithValue("?estado", cliente.Estado);
            Com.Parameters.AddWithValue("?endereco", cliente.Endereco);
            Com.Parameters.AddWithValue("?numero", cliente.Numero);
            Com.Parameters.AddWithValue("?telefone", cliente.Telefone);
            Com.Parameters.AddWithValue("?celular", cliente.Celular);
            Com.Parameters.AddWithValue("?cod", id);
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
    
     */
        public void alterarCliente(cliente cliente, int id)
        {
            MySqlCommand Com = mCon.CreateCommand();
            Com.CommandText = "UPDATE tbl_cliente SET cli_nome=?nome, cli_sexo = ?sexo,"+
                " cli_email = ?email, cli_rg = ?rg,"+
                "cli_cpf = ?cpf, cli_data_nascimento = ?data_nascimento," +
                "cli_cidade = ?cidade, cli_cep=?cep,adv_bairro=?bairro"+
                "cli_estado=?estado,cli_endereco = ?endereco, cli_numero = ?numero , " +
                "cli_telefone = ?telefone , cli_celular = ?celular" +
                " WHERE cli_cod=?cod";
            Com.Parameters.AddWithValue("?nome", cliente.Nome);
            Com.Parameters.AddWithValue("?sexo", cliente.Sexo);
            Com.Parameters.AddWithValue("?email", cliente.Email);
            Com.Parameters.AddWithValue("?rg", cliente.Rg);
            Com.Parameters.AddWithValue("?cpf", cliente.Cpf);
            Com.Parameters.AddWithValue("?data_nascimento", cliente.Datanascimento);
            Com.Parameters.AddWithValue("?cidade", cliente.Cidade);
            Com.Parameters.AddWithValue("?cep", cliente.CEP);
            Com.Parameters.AddWithValue("?bairro", cliente.Bairro);
            Com.Parameters.AddWithValue("?estado", cliente.Estado);
            Com.Parameters.AddWithValue("?endereco", cliente.Endereco);
            Com.Parameters.AddWithValue("?numero", cliente.Numero);
            Com.Parameters.AddWithValue("?telefone", cliente.Telefone);
            Com.Parameters.AddWithValue("?celular", cliente.Celular);
            Com.Parameters.AddWithValue("?cod", id);
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
        

        public void excluirCliente(int id)
        {
            MySqlCommand Com = mCon.CreateCommand();
            Com.CommandText = "DELETE FROM tbl_cliente WHERE cli_cod=?codigo";
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
