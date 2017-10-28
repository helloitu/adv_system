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
    class casoBD
    {
        private MySqlConnection mCon;

        public casoBD()
        {
            mCon = new MySqlConnection("Persist Security Info = false; server = localhost; database = adv_sys;uid = root ; pwd =");
        }

        public DataTable getCaso()
        {
            MySqlCommand cmd = mCon.CreateCommand();
            MySqlDataAdapter da;
            cmd.CommandText = "SELECT * from tbl_caso order by caso_cliente";
            try
            {
                mCon.Open();
                cmd = new MySqlCommand(cmd.CommandText, mCon);
                da = new MySqlDataAdapter(cmd);
                DataTable dtCaso = new DataTable();
                da.Fill(dtCaso);
                return dtCaso;
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
        //////////  ////////////////
        ////////////////
 



        public void IncluirCaso(caso caso)
        {
            MySqlCommand Com = mCon.CreateCommand();
            Com.CommandText = "INSERT INTO tbl_caso(caso_causa,caso_vara,caso_cartorio,caso_pasta,caso_numero,caso_tipo,caso_valor,caso_pagamento,caso_cliente," +
                "caso_posicao,caso_advogado,caso_parte_nome,caso_parte_endereco,caso_parte_numero,caso_parte_telefone,"+
                "caso_parte_celular,caso_data,caso_andamento,caso_data_andamento) " +
                "Values (?causa,?vara,?cartorio,?pasta,?numero,?tipo,?valor,?pagamento,?cliente,?posicao," +
                "?advogado,?parte_nome,?parte_endereco,?parte_numero," +
                "?parte_telefone,?parte_celular,?data,?andamento,?data_andamento)";
            Com.Parameters.AddWithValue("?causa", caso.Causa);
            Com.Parameters.AddWithValue("?vara", caso.Vara);
            Com.Parameters.AddWithValue("?cartorio", caso.Cartorio);
            Com.Parameters.AddWithValue("?pasta", caso.Pasta);
            Com.Parameters.AddWithValue("?numero", caso.Numero);
            Com.Parameters.AddWithValue("?tipo", caso.Tipo);
            Com.Parameters.AddWithValue("?valor", caso.Valor);
            Com.Parameters.AddWithValue("?pagamento", caso.Pagamento);
            Com.Parameters.AddWithValue("?cliente", caso.Cliente);
            Com.Parameters.AddWithValue("?posicao", caso.Posicao);
            Com.Parameters.AddWithValue("?advogado", caso.Advogado);
            Com.Parameters.AddWithValue("?parte_nome", caso.ParteNome);
            Com.Parameters.AddWithValue("?parte_endereco", caso.ParteEndereco);
            Com.Parameters.AddWithValue("?parte_numero", caso.ParteNumero);
            Com.Parameters.AddWithValue("?parte_telefone", caso.ParteTelefone);
            Com.Parameters.AddWithValue("?parte_celular", caso.ParteCelular);
            Com.Parameters.AddWithValue("?data", caso.Data);
            Com.Parameters.AddWithValue("?andamento", caso.Andamento);
            Com.Parameters.AddWithValue("?data_andamento", caso.DataAndamento);

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

        public caso selecionaCaso(string cliente)
        {
            try
            {
                mCon.Open();
                MySqlCommand cmd = mCon.CreateCommand();
                cmd.CommandText = "SELECT * from tbl_agenda WHERE caso_cliente = ?cliente";
                cmd.Parameters.AddWithValue("?cliente", cliente);

                MySqlDataReader dr;

                caso casoSelect = new caso();
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                while (dr.Read())
                {
                    casoSelect.CasoID = Convert.ToInt32(dr["caso_codigo"]);
                    casoSelect.Causa = dr["caso_causa"].ToString();
                    casoSelect.Vara = dr["caso_vara"].ToString();
                    casoSelect.Cartorio = dr["caso_cartorio"].ToString();
                    casoSelect.Pasta = dr["caso_pasta"].ToString();
                    casoSelect.Numero = dr["caso_numero"].ToString();
                    casoSelect.Pagamento = dr["caso_tipo"].ToString();
                    casoSelect.Valor = dr["caso_valor"].ToString();
                    casoSelect.Pagamento = dr["caso_pagamento"].ToString();
                    casoSelect.Cliente = dr["caso_cliente"].ToString();
                    casoSelect.Posicao = dr["caso_posicao"].ToString();
                    casoSelect.Advogado = dr["caso_advogado"].ToString();
                    casoSelect.ParteNome = dr["caso_parte_nome"].ToString();
                    casoSelect.ParteEndereco = dr["caso_parte_endereco"].ToString();
                    casoSelect.ParteNumero = dr["caso_parte_numero"].ToString();
                    casoSelect.ParteTelefone = dr["caso_parte_telefone"].ToString();
                    casoSelect.ParteCelular = dr["caso_parte_celular"].ToString();
                    casoSelect.Data = dr["caso_data"].ToString();
                    casoSelect.Andamento = dr["caso_andamento"].ToString();
                    casoSelect.DataAndamento = dr["caso_data_andamento"].ToString();
                }
                return casoSelect;
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

        public void alterarCaso(caso caso, int codigo)
        {
            MySqlCommand Com = mCon.CreateCommand();
            Com.CommandText = "UPDATE tbl_caso SET caso_causa = ?causa,caso_vara = ?vara,caso_cartorio = ?cartorio,caso_pasta = ?pasta,caso_numero = ?numero,caso_tipo = ?tipo," +
                "caso_valor = ?valor,caso_pagamento = ?pagamento ,caso_cliente = ?cliente,caso_posicao = ?posicao,caso_advogado = ?advogado,"+
                "caso_parte_nome = ?parte_nome,caso_parte_endereco = ?parte_endereco,caso_parte_numero = ?parte_numero,caso_parte_telefone = ?parte_telefone,"+
                "caso_parte_celular = ?parte_celular,caso_data = ?data,caso_andamento = ?andamento,caso_data_andamento = ?data_andamento" +
                " WHERE caso_codigo=?codigo";
            Com.Parameters.AddWithValue("?causa", caso.Causa);
            Com.Parameters.AddWithValue("?vara", caso.Vara);
            Com.Parameters.AddWithValue("?cartorio", caso.Cartorio);
            Com.Parameters.AddWithValue("?pasta", caso.Pasta);
            Com.Parameters.AddWithValue("?numero", caso.Numero);
            Com.Parameters.AddWithValue("?tipo", caso.Tipo);
            Com.Parameters.AddWithValue("?valor", caso.Valor);
            Com.Parameters.AddWithValue("?pagamento", caso.Pagamento);
            Com.Parameters.AddWithValue("?cliente", caso.Cliente);
            Com.Parameters.AddWithValue("?posicao", caso.Posicao);
            Com.Parameters.AddWithValue("?advogado", caso.Advogado);
            Com.Parameters.AddWithValue("?parte_nome", caso.ParteNome);
            Com.Parameters.AddWithValue("?parte_endereco", caso.ParteEndereco);
            Com.Parameters.AddWithValue("?parte_numero", caso.ParteNumero);
            Com.Parameters.AddWithValue("?parte_telefone", caso.ParteTelefone);
            Com.Parameters.AddWithValue("?parte_celular", caso.ParteCelular);
            Com.Parameters.AddWithValue("?data", caso.Data);
            Com.Parameters.AddWithValue("?andamento", caso.Andamento);
            Com.Parameters.AddWithValue("?data_andamento", caso.DataAndamento);
            Com.Parameters.AddWithValue("?codigo", codigo);
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

        public void excluirCaso(int codigo)
        {
            MySqlCommand Com = mCon.CreateCommand();
            Com.CommandText = "DELETE FROM tbl_caso WHERE caso_codigo=?codigo";
            Com.Parameters.AddWithValue("?codigo", codigo);
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
