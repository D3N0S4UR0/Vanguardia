using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormLogin
{
    public class usuario
    {
        String nome;
        String senha;
        String dif;
        int progresso;

        public usuario(string nome, string senha, string dif, int progresso)
        {
            this.nome = nome;
            this.senha = senha;
            this.dif = dif;
            this.progresso = progresso;
        }

        public string Nome { get => nome; set => nome = value; }
        public string Senha { get => senha; set => senha = value; }
        public string Dif { get => dif; set => dif = value; }
        public int Progresso { get => progresso; set => progresso = value; }
    }
}
