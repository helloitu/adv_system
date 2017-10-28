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
        public secretaria(string nome,string rg,string cpf, string sexo,string endereco,
            string numero,string telefone, string celular)
        {
            this.Nome = nome;
            this.Rg = rg;
            this.Cpf = cpf;
            this.Sexo = sexo;
            this.Endereco = endereco;
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
