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
        //private Aluno aluno;


        public string Nome { get => nome; set => nome = value; }
        public int Id { get => id; set => id = value; }
        public ArrayList Diciplinas { get => diciplinas; set => diciplinas = value; }

        //Esse cadastrar aluno poderia ter sido feito na classe ALuno mesmo.
        public void CadastrarAluno()
        {   //colocar color aqui \/ EXTRA
            Console.WriteLine("CADASTRAMENTO DE NOVO ALUNO NA DISCIPLINA\n\n");
            Console.WriteLine("Digite o nome do aluno");
            Aluno aluno = new Aluno();
            aluno.Nome = Console.ReadLine();
            //Criar sistema criador de curso


        }


    }
}
