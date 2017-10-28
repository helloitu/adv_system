using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC
{
    class agenda
    {
        public agenda()
        {
        }

        public agenda(string nome, string data, string horario, string situacao, string assunto, string telefone, string celular)
        {
            this.Nome = nome;
            this.Data = data;
            this.Horario = horario;
            this.Situacao = situacao;
            this.Assunto = assunto;
            this.Telefone = telefone;
            this.Celular = celular;
        }

        private int _agendaID;
        public int AgendaID
        {
            get { return _agendaID; }
            set { _agendaID = value; }
        }

        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private string data;
        public string Data
        {
            get { return data; }
            set { data = value; }
        }

        private string horario;
        public string Horario
        {
            get { return horario; }
            set { horario = value; }
        }

        private string situacao;
        public string Situacao
        {
            get { return situacao; }
            set { situacao = value; }
        }


        private string assunto;
        public string Assunto
        {
            get { return assunto; }
            set { assunto = value; }
        }

        private string telefone;
        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        private string celular;
        public string Celular
        {
            get { return celular; }
            set { celular = value; }
        }
    }
}
