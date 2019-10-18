using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjAtendimento
{
    class Senhas
    {
        private int proximoAtendimento;
        private Queue<Senha> filaSenhas;

       internal Queue<Senha> FilaSenhas { get => filaSenhas; set => filaSenhas = value; }        

        public Senhas()
        {
            this.FilaSenhas = new Queue<Senha>();
            this.proximoAtendimento = 1;
        }

        public void gerar()
        {
            this.FilaSenhas.Enqueue(new Senha(this.proximoAtendimento++));
        }
    }
}
