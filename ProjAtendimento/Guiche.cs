using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjAtendimento
{
    class Guiche
    {
        private int id;
        Queue<Senha> atendimentos;

        public int Id { get => id; set => id = value; }
        internal Queue<Senha> Atendimentos { get => atendimentos; set => atendimentos = value; }

        public Guiche()
        {
            Atendimentos = new Queue<Senha>();
            Id = 0;
        }

        public Guiche(int id)
        {
            Atendimentos = new Queue<Senha>();
            this.Id = id;
        }

        public bool chamar(Queue<Senha> filaSenhas)
        {
            if (filaSenhas.Count != 0)
            {
                Senha a = filaSenhas.Dequeue();
                a.DataAtend = DateTime.Now;
                a.HoraAtend = DateTime.Now;
                Atendimentos.Enqueue(a);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
