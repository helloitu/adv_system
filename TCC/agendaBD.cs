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
    class agendaBD
    {
        private MySqlConnection mCon;

        public agendaBD()
        {
            mCon = new MySqlConnection("Persist Security Info = false; server = localhost; database = adv_sys;uid = root ; pwd =");
        }

        public DataTable getAgenda()
        {
            MySqlCommand cmd = mCon.CreateCommand();
            MySqlDataAdapter da;
            cmd.CommandText = "SELECT * from tbl_agenda order by age_data";
            try
            {
                mCon.Open();
                cmd = new MySqlCommand(cmd.CommandText, mCon);
                da = new MySqlDataAdapter(cmd);
                DataTable dtAgenda = new DataTable();
                da.Fill(dtAgenda);
                return dtAgenda;
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

        public void IncluirAgenda(agenda agenda)
        {
            MySqlCommand Com = mCon.CreateCommand();
            Com.CommandText = "INSERT INTO tbl_agenda(age_nome,age_data,age_horario,age_situacao,age_assunto," +
                "age_telefone,age_celular) values(?nome,?data,?horario,?situacao,?assunto,?telefone,?celular)";
            Com.Parameters.AddWithValue("?nome", agenda.Nome);
            Com.Parameters.AddWithValue("?data", agenda.Data);
            Com.Parameters.AddWithValue("?horario", agenda.Horario);
            Com.Parameters.AddWithValue("?situacao", agenda.Situacao);
            Com.Parameters.AddWithValue("?assunto", agenda.Assunto);
            Com.Parameters.AddWithValue("?telefone", agenda.Telefone);
            Com.Parameters.AddWithValue("?celular", agenda.Celular);

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


        public agenda selecionaAgenda(string dia)
        {
            try
            {
                mCon.Open();
                MySqlCommand cmd = mCon.CreateCommand();
                cmd.CommandText = "SELECT * from tbl_agenda WHERE age_data = ?data";
                cmd.Parameters.AddWithValue("?data", dia);

                MySqlDataReader dr;

                agenda agdSelect = new agenda();
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                while (dr.Read())
                {
                    agdSelect.AgendaID = Convert.ToInt32(dr["age_id"]);
                    agdSelect.Nome = dr["age_nome"].ToString();
                    agdSelect.Data = dr["age_data"].ToString();
                    agdSelect.Horario = dr["age_horario"].ToString();
                    agdSelect.Situacao = dr["age_situacao"].ToString();
                    agdSelect.Assunto = dr["age_assunto"].ToString();
                    agdSelect.Telefone = dr["age_telefone"].ToString();
                    agdSelect.Celular = dr["age_celular"].ToString();
                }
                return agdSelect;
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


        public void alterarAgenda(agenda agenda, int id)
        {
            MySqlCommand Com = mCon.CreateCommand();
            Com.CommandText = "UPDATE tbl_agenda SET age_nome = ?nome, age_data = ?data, age_horario = ?horario, age_situacao = ?situacao," +
                "age_assunto = ?assunto, age_telefone = ?telefone,age_celular= ?celular " +
                " WHERE age_id=?codigo";
            Com.Parameters.AddWithValue("?nome", agenda.Nome);
            Com.Parameters.AddWithValue("?data", agenda.Data);
            Com.Parameters.AddWithValue("??horario", agenda.Horario);
            Com.Parameters.AddWithValue("?situacao", agenda.Situacao);
            Com.Parameters.AddWithValue("?assunto", agenda.Assunto);
            Com.Parameters.AddWithValue("?telefone", agenda.Telefone);
            Com.Parameters.AddWithValue("?celular", agenda.Celular);
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


        public void excluirAgenda(int id)
        {
            MySqlCommand Com = mCon.CreateCommand();
            Com.CommandText = "DELETE FROM tbl_agenda WHERE age_id=?codigo";
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
