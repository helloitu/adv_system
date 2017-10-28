using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC
{
    class cliente
    {
        public cliente()
        {
        }
        public cliente(string nome, string sexo, string email, string rg,
            string cpf, string datanascimento,string cidade, string endereco, string numero,
            string telefone,string celular)
        {
            this.Nome = nome;
            this.Sexo = sexo;
            this.Email = email;
            this.Rg = rg;
            this.Cpf = cpf;
            this.Datanascimento = datanascimento;
            this.Cidade = cidade;
            this.Endereco = endereco;
            this.Numero = numero;
            this.Telefone = telefone;
            this.Celular = celular;
        }

        private int _clienteCOD;
        public int ClienteCOD
        {
            get { return _clienteCOD; }
            set { _clienteCOD = value; }
        }

        private string nome;
        public string Nome
        {
            get {return nome ;}
            set { nome = value;}
        }

        private string sexo;
        public string Sexo
        {
            get {return sexo;}
            set {sexo = value;}
        }

        private string email;
        public string Email
        {
            get {return email;}
            set {email = value;}
        }

        private string rg;
        public string Rg
        {
            get {return rg;}
            set {rg = value;}
        }

        private string cpf;
        public string Cpf
        {
            get {return cpf;}
            set {cpf = value;}
        }

        private string datanascimento;
        public string Datanascimento
        {
            get {return datanascimento;}
            set {datanascimento = value;}
        }

        private string cidade;
        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }

        private string endereco;
        public string Endereco
        {
            get {return endereco;}
            set {endereco = value;}
        }

        private string numero;
        public string Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        private string telefone;
        public string Telefone
        {
            get {return telefone;}
            set {telefone = value;}
        }

        private string celular;
        public string Celular
        {
            get {return celular;}
            set {celular = value;}
        }
    }
}
