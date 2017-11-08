using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeCurso
{
    public class Pessoa
    {
        protected string nome;
        protected int idade;
        protected string endereco;


        public string Nome { get => nome; set => nome = value; }
        public int Idade { get => idade; set => idade = value; }
        public string Endereco { get => endereco; set => endereco = value; }


        public Pessoa()
        {


        }

    }
}
