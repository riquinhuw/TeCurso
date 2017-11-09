using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeCurso
{
    public class Pessoa
    {

        //Poderia usar polimorfismo, todos herdariam matricula, e eu iria fazer os metodos:
        //Criar,AdiconarAoArray,GerarMatricula, mas... estou sem tempo e não domino ainda, dps vejo( ou não)

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
