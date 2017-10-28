using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC
{
    class caso
    {
        public caso()
        {

        }
        public caso(string causa, string vara, string cartorio, string pasta,string tipo, 
            string numero ,string valor, string pagamento, string cliente, string posicao,
            string advogado, string parte_nome,string parte_endereco,string parte_numero,
            string parte_telefone, string parte_celular, string data, string andamento, string data_andamento)
        {
            this.Causa = causa;
            this.Vara = vara;
            this.Cartorio = cartorio;
            this.Pasta = pasta;
            this.Valor = valor;
            this.Pagamento = pagamento;
            this.Cliente = cliente;
            this.Posicao = posicao;
            this.Advogado = advogado;
            this.ParteNome = parte_nome;
            this.ParteEndereco = parte_endereco;
            this.ParteNumero = parte_numero;
            this.ParteTelefone = parte_telefone;
            this.ParteCelular = parte_celular;
            this.Data = data;
            this.Tipo = tipo;
            this.Andamento = andamento;
            this.DataAndamento = data_andamento;
            this.Numero = numero;
        }

        private int _casoID;
        public int CasoID
        {
            get { return _casoID; }
            set { _casoID = value; }
        }

        private string numero;
        public string Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        private string causa;
        public string Causa
        {
            get { return causa; }
            set { causa = value; }
        }

        private string vara;
        public string Vara
        {
            get { return vara; }
            set { vara = value; }
        }

        private string cartorio;
        public string Cartorio
        {
            get { return cartorio; }
            set { cartorio = value; }
        }

        private string pasta;
        public string Pasta
        {
            get { return pasta; }
            set { pasta = value; }
        }

        private string tipo ;
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }


        private string valor;
        public string Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        private string pagamento;
        public string Pagamento
        {
            get { return pagamento; }
            set { pagamento = value; }
        }

        private string cliente;
        public string Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }

        private string posicao;
        public string Posicao
        {
            get { return posicao; }
            set { posicao = value; }
        }

        private string advogado;
        public string Advogado
        {
            get { return advogado; }
            set { advogado = value; }
        }

        private string parte_nome;
        public string ParteNome
        {
            get { return parte_nome; }
            set { parte_nome = value; }
        }

        private string parte_endereco;
        public string ParteEndereco
        {
            get { return parte_endereco; }
            set { parte_endereco = value; }
        }

        private string parte_numero;
        public string ParteNumero
        {
            get { return parte_numero; }
            set { parte_numero = value; }
        }

        private string parte_telefone;
        public string ParteTelefone
        {
            get { return parte_telefone; }
            set { parte_telefone = value; }
        }

        private string parte_celular;
        public string ParteCelular
        {
            get { return parte_celular; }
            set { parte_celular = value; }
        }

        private string data;
        public string Data
        {
            get { return data; }
            set { data = value; }
        }

        private string andamento;
        public string Andamento
        {
            get { return andamento; }
            set { andamento = value; }
        }

        private string data_andamento;
        public string DataAndamento
        {
            get { return data_andamento; }
            set { data_andamento = value; }
        }
    }
}
