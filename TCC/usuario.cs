using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC
{
    class usuario
    {
        
    
        private int _usuarioID;
        public int UsuarioID
        {
            get { return _usuarioID; }
            set { _usuarioID = value; }
        }

        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private string funcao;
        public string Funcao
        {
            get { return funcao; }
            set { funcao = value; }
        }
        



        private string login;
        public string Login
        {
            get { return login; }
            set { login = value; }
        }


        private string senha;
        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }

        public usuario()
        {

        }

        public usuario(string nome, string funcao, string login, string senha)
        {
            this.Nome = nome;
            this.Funcao = funcao;
            this.Login = login;
            this.Senha = senha;

        }
    }
}
