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
    class advogadoBD
    {
        private MySqlConnection mCon;

        public advogadoBD()
        {
            mCon = new MySqlConnection("Persist Security Info = false; server = localhost; database = adv_sys;uid = root ; pwd =");
        }

        public DataTable getAdvogado()
        {
            MySqlCommand cmd = mCon.CreateCommand();
            MySqlDataAdapter da;
            cmd.CommandText = "SELECT * from tbl_advogado order by adv_nome";
            try
            {
                mCon.Open();
                cmd = new MySqlCommand(cmd.CommandText, mCon);
                da = new MySqlDataAdapter(cmd);
                DataTable dtAdvogado = new DataTable();
                da.Fill(dtAdvogado);
                return dtAdvogado;
            }
            catch (MySqlException ex)
            {
                throw new ApplicationException(ex.ToString());
            }
            finally {
                mCon.Close();
            }
        }

        ////////////////////

        public void IncluirAdvogado(advogado advogado)
        {
            MySqlCommand Com = mCon.CreateCommand();
            Com.CommandText = "INSERT INTO tbl_advogado(adv_nome,adv_rg,adv_cpf,"+
                "adv_sexo,adv_email,adv_endereco,adv_bairro,adv_estado,"+
                "adv_cep,adv_cidade,adv_numero,adv_telefone,adv_celular,"+
                "adv_especialidade, " +
                "adv_registro,adv_data_emissao,adv_status) values(?nome,?rg,?cpf,"+
                "?sexo,?email,?endereco,?bairro,?estado,?cep,?cidade,?numero,"+
                "?telefone,?celular,?especialidade, " +
                "?registro,?data_emissao,?status)";
            Com.Parameters.AddWithValue("?nome", advogado.Nome);
            Com.Parameters.AddWithValue("?rg", advogado.Rg);
            Com.Parameters.AddWithValue("?cpf", advogado.Cpf);
            Com.Parameters.AddWithValue("?sexo", advogado.Sexo);
            Com.Parameters.AddWithValue("?email", advogado.Email);
            Com.Parameters.AddWithValue("?endereco", advogado.Endereco);
            Com.Parameters.AddWithValue("?bairro", advogado.Bairro);
            Com.Parameters.AddWithValue("?estado", advogado.Estado);
            Com.Parameters.AddWithValue("?cep", advogado.CEP);
            Com.Parameters.AddWithValue("?cidade", advogado.Cidade);
            Com.Parameters.AddWithValue("?numero", advogado.Numero);
            Com.Parameters.AddWithValue("?telefone", advogado.Telefone);
            Com.Parameters.AddWithValue("?celular", advogado.Celular);
            Com.Parameters.AddWithValue("?especialidade", advogado.Especialidade);
            Com.Parameters.AddWithValue("?registro", advogado.Registro);
            Com.Parameters.AddWithValue("?data_emissao", advogado.Data_emissao);
            Com.Parameters.AddWithValue("?status", advogado.Status);
            
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


       

        /////////////////
        public advogado selecionaAdvogado(string nome)
        {
            try
            {
                mCon.Open();
                MySqlCommand cmd = mCon.CreateCommand();
                cmd.CommandText = "SELECT * from tbl_advogado WHERE adv_nome = ?nome";
                cmd.Parameters.AddWithValue("?nome", nome);

                MySqlDataReader dr;

                advogado advSelect = new advogado();
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                while (dr.Read())
                {
                    advSelect.advogadoCOD = Convert.ToInt32(dr["Cod."]);
                    advSelect.Nome = dr["Nome"].ToString();
                    advSelect.Rg = dr["RG"].ToString();
                    advSelect.Cpf = dr["CPF"].ToString();
                    advSelect.Sexo = dr["Sexo"].ToString();
                    advSelect.Endereco = dr["Endereço"].ToString();
                    advSelect.Telefone = dr["Telefone"].ToString();
                    advSelect.Celular = dr["Celular"].ToString();
                    advSelect.Registro = dr["Registro OAB"].ToString();
                    advSelect.Data_emissao = dr["Data de admissão"].ToString();
                    advSelect.Status = dr["Status"].ToString();
                }
                return advSelect;
            }
            catch(Exception ex)
            {
                throw new ApplicationException(ex.ToString());
            }
            finally
            {
                mCon.Close();
            }
        }

        /*
                public advogado selecionaUserAdvogado(string login,string senha)
                {
                    try
                    {
                        mCon.Open();
                        MySqlCommand cmd = mCon.CreateCommand();
                        cmd.CommandText = "SELECT * from tbl_advogado WHERE adv_login =?login and adv_senha =?senha";
                        cmd.Parameters.AddWithValue("?login", login);
                        cmd.Parameters.AddWithValue("?senha", senha);

                        MySqlDataReader dr;
                        dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                        advogado advogado = new advogado();
                        while (dr.Read())
                        {
                            advogado.Login = dr["adv_login"].ToString();
                            advogado.Senha = dr["adv_senha"].ToString();
                        }
                        return advogado;
                    }
                    catch(Exception ex)
                    {
                        throw new ApplicationException(ex.ToString());
                    }
                    finally
                    {
                        mCon.Close();
                    }
                }

            */




        public void alterarAdvogado(advogado advogado, int id)
        {
            MySqlCommand Com = mCon.CreateCommand();
            Com.CommandText = "UPDATE tbl_advogado SET adv_nome=?nome, adv_rg=?rg," +
                " adv_cpf=?cpf,adv_sexo=?sexo,adv_email=?email,adv_endereco = ?endereco," +
                "adv_bairro =?bairro,adv_estado=?estado,adv_cep=?cep," +
                "adv_cidade=?cidade, adv_numero = ?numero," +
                "adv_telefone = ?telefone , adv_celular = ?celular," +
                "adv_especialidade = ?especialidade,adv_registro = ?registro," +
                "adv_data_emissao = ?data_emissao,adv_status = ?status" +
                " WHERE adv_codigo=?codigo";
            Com.Parameters.AddWithValue("?nome", advogado.Nome);
            Com.Parameters.AddWithValue("?rg", advogado.Rg);
            Com.Parameters.AddWithValue("?cpf", advogado.Cpf);
            Com.Parameters.AddWithValue("?sexo", advogado.Sexo);
            Com.Parameters.AddWithValue("?email", advogado.Email);
            Com.Parameters.AddWithValue("?endereco", advogado.Endereco);
            Com.Parameters.AddWithValue("?bairro", advogado.Bairro);
            Com.Parameters.AddWithValue("?estado", advogado.Estado);
            Com.Parameters.AddWithValue("?cep", advogado.CEP);
            Com.Parameters.AddWithValue("?cidade", advogado.Cidade);
            Com.Parameters.AddWithValue("?numero", advogado.Numero);
            Com.Parameters.AddWithValue("?telefone", advogado.Telefone);
            Com.Parameters.AddWithValue("?celular", advogado.Celular);
            Com.Parameters.AddWithValue("?especialidade", advogado.Especialidade);
            Com.Parameters.AddWithValue("?registro", advogado.Registro);
            Com.Parameters.AddWithValue("?data_emissao", advogado.Data_emissao);
            Com.Parameters.AddWithValue("?status", advogado.Status);
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


        public void excluirAdvogado(int id)
        {
            MySqlCommand Com = mCon.CreateCommand();
            Com.CommandText = "DELETE FROM tbl_advogado WHERE adv_codigo=?codigo";
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
