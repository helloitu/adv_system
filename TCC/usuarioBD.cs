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
    class usuarioBD
    {
        private MySqlConnection mCon;

        public usuarioBD()
        {
            mCon = new MySqlConnection("Persist Security Info = false; server = localhost; database = adv_sys;uid = root ; pwd =");
        }


        public usuario selecionaUser(string login, string senha)
        {
            try
            {
                mCon.Open();
                MySqlCommand cmd = mCon.CreateCommand();
                cmd.CommandText = "SELECT * from tbl_usuario WHERE usu_login=?login and usu_senha=?senha";
                cmd.Parameters.AddWithValue("?login", login);
                cmd.Parameters.AddWithValue("?senha", senha);

                MySqlDataReader dr;
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                usuario usuLogin = new usuario();
                while (dr.Read())
                {
                    usuLogin.Nome = dr["usu_nome"].ToString();
                    usuLogin.Funcao = dr["usu_funcao"].ToString();
                    usuLogin.Login = dr["usu_login"].ToString();
                    usuLogin.Senha = dr["usu_senha"].ToString();

                    
                }
                return usuLogin;
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.ToString());
            }
            finally
            {
                mCon.Close();
            }
        }


        public DataTable getUsuario()
        {
            MySqlCommand cmd = mCon.CreateCommand();
            MySqlDataAdapter da;
            cmd.CommandText = "SELECT * from tbl_usuario order by usu_nome";
            try
            {
                mCon.Open();
                cmd = new MySqlCommand(cmd.CommandText, mCon);
                da = new MySqlDataAdapter(cmd);
                DataTable dtUsuario = new DataTable();
                da.Fill(dtUsuario);
                return dtUsuario;
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



        public void IncluirUsuario(usuario usuario)
        {
            MySqlCommand Com = mCon.CreateCommand();
            Com.CommandText = "INSERT INTO tbl_usuario(usu_nome,usu_funcao,usu_login,usu_senha) " +
                "values(?nome,?funcao,?login,?senha)";
            Com.Parameters.AddWithValue("?nome", usuario.Nome);
            Com.Parameters.AddWithValue("?funcao", usuario.Funcao);
            Com.Parameters.AddWithValue("?login", usuario.Login);
            Com.Parameters.AddWithValue("?senha", usuario.Senha);
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

        public void alterarUsuario(usuario usuario, int id)
        {
            MySqlCommand Com = mCon.CreateCommand();
            Com.CommandText = "UPDATE tbl_usuario SET usu_nome=?nome, usu_funcao = ?funcao,usu_login = ?login," +
                "usu_senha = ?senha WHERE usu_id=?codigo";
            Com.Parameters.AddWithValue("?nome", usuario.Nome);
            Com.Parameters.AddWithValue("?funcao", usuario.Funcao);
            Com.Parameters.AddWithValue("?login", usuario.Login);
            Com.Parameters.AddWithValue("?senha", usuario.Senha);
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

        public void excluirUsuario(int id)
        {
            MySqlCommand Com = mCon.CreateCommand();
            Com.CommandText = "DELETE FROM tbl_usuario WHERE usu_id=?codigo";
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

