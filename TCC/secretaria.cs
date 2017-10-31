using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC
{
    class secretaria
    {
        public secretaria()
        {
        }
        public secretaria(string nome,string rg,string cpf, string sexo,string endereco,string cep,string cidade,string estado,string bairro,
            string numero,string telefone, string celular)
        {
            this.Nome = nome;
            this.Rg = rg;
            this.Cpf = cpf;
            this.Sexo = sexo;
            this.Endereco = endereco;
            this.CEP = cep;
            this.Cidade = cidade;
            this.Estado = estado;
            this.Bairro = bairro;
            this.Numero = numero;
            this.Telefone = telefone;
            this.Celular = celular;
        }

        ///
        private int _secretariaCOD;
        public int SecretariaCOD
        {
            get { return _secretariaCOD; }
            set { _secretariaCOD = value; }
        }

        ///
        private string nome;
        public string Nome
        {
            get { return nome; }
            set {nome = value; }
        }

        ///
        private string rg;
        public string Rg
        {
            get { return rg ; }
            set {rg = value; }
        }

        ///
        private string cpf;
        public string Cpf
        {
            get { return cpf; }
            set {cpf = value; }
        }

        ///
        private string sexo;
        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        ///
        private string endereco;
        public string Endereco
        {
            get { return endereco; }
            set {endereco = value; }
        }

        private string cidade;
        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }
        private string bairro;
        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }
        private string estado;
        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        private string cep;
        public string CEP
        {
            get { return cep; }
            set { cep = value; }
        }


        ///
        private string numero;
        public string Numero
        {
            get { return numero; }
            set {numero = value; }
        }

        ///
        private string telefone;
        public string Telefone
        {
            get { return telefone; }
            set {telefone = value; }
        }

        ///
        private string celular;
        public string Celular
        {
            get { return celular; }
            set {celular = value; }
        }

        ///
       
    }
}
