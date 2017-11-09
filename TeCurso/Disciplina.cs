using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace TeCurso
{
    public class Disciplina
    {

        private string nome;
        private int id;
        private ArrayList diciplinas = new ArrayList();
        private Professor professor = new Professor();
        private Aluno alunoMatiz = new Aluno();
        //private Aluno aluno;


        public string Nome { get => nome; set => nome = value; }
        public int Id { get => id; set => id = value; }
        public ArrayList Diciplinas { get => diciplinas; set => diciplinas = value; }
        public Aluno AlunoMatiz { get => alunoMatiz; set => alunoMatiz = value; }

        //CRIAR MEIO DE COLOCAR MATRICULA NO MAIN PARA O ALUNO - APAGAR AVISO AO FAZER
        public Aluno CadastrarAluno()
        {   //colocar color aqui \/ EXTRA
            Console.Clear();
            Console.WriteLine("CADASTRAMENTO DE NOVO ALUNO NA DISCIPLINA\n\n");
            Console.WriteLine("Digite o nome do aluno");
            Aluno aluno = new Aluno();
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("");

            //TALVEZ APAGUE TUDO

            return aluno;
        }


    }
}
