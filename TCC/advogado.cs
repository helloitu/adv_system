using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC
{
    class advogado
    {
        public advogado() {
        }
        public advogado(string nome, string rg, string cpf,string sexo , string email,string endereco,string numero , string telefone,
            string celular,string especialidade,string registro, string data_emissao,string status)
        {
            this.Nome = nome;
            this.Rg = rg;
            this.Cpf = cpf;
            this.Sexo = sexo;
            this.Email = email;
            this.Endereco = endereco;
            this.Numero = numero;
            this.Telefone = telefone;
            this.Celular = celular;
            this.Especialidade = especialidade;
            this.Registro = registro;
            this.Data_emissao = data_emissao;
            this.Status = status;
        }

                ///
                private int _advogadoCOD;
                public int advogadoCOD
                {
                    get { return _advogadoCOD; }
                    set { _advogadoCOD = value; }
                }

                ///
                private string nome;
                public string Nome
                {
                    get{ return nome;}
                    set { nome = value;}
                }

                ///
                private string rg;
                public string Rg
                {
                    get{ return rg;}
                    set {rg = value;}
                }

                ///
                private string cpf;
                public string Cpf
                {
                    get{ return cpf;}
                    set { cpf = value;}
                }

                
                private string sexo;
                public string Sexo
                {
                    get{ return sexo;}
                    set { sexo = value;}
                }


                private string email;
                public string Email
                {
                    get { return email; }
                    set { email = value; }
                }

        ///
        private string endereco;
                public string Endereco
                {
                    get{ return endereco;}
                    set {endereco = value;}
                }

                ///
                private string numero;
                public string Numero
                {
                    get { return numero; }
                    set { numero = value; }
                }


        ///
                private string telefone;
                public string Telefone
                {
                    get{ return telefone;}
                    set {telefone = value;}
                }

                ///
                private string celular;
                public string Celular
                {
                    get{ return celular ;}
                    set {celular = value;}
                }

                ///
                private string registro;
                public string Registro
                {
                    get{ return registro;}
                    set { registro = value;}
                }

                ///
                private string especialidade;
                public string Especialidade
                {
                    get { return especialidade; }
                    set { especialidade = value; }
                }

        ///
        private string data_emissao;
                public string Data_emissao
                {
                    get{ return data_emissao;}
                    set {data_emissao = value;}
                }
   
                /// 
                private string status;
                public string Status
                {
                    get{ return status;}
                    set {status = value;}
                }
                
                ///


        }
    }
