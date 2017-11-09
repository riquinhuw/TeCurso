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
        private ArrayList disciplinas = new ArrayList();
        private Professor professor = new Professor();
        private Aluno alunoMatiz = new Aluno();
        private ArrayList alunos = new ArrayList();
        private int geradorDeId = 0;

        public string Nome { get => nome; set => nome = value; }
        public int Id { get => id; set => id = value; }
        public ArrayList Disciplinas { get => disciplinas; set => disciplinas = value; }
        public Professor Professor { get => professor; set => professor = value; }
        public Aluno AlunoMatiz { get => alunoMatiz; set => alunoMatiz = value; }
        public int GeradorDeId { get => geradorDeId; set => geradorDeId = value; }

        public Disciplina() { }

        public int GerarId()
        {
            int valor = this.GeradorDeId;
            this.GeradorDeId++;
            return valor;
        }

        public void CriarDiciplina() 
        {
            Disciplina disciplina = new Disciplina();
            Console.Clear();
            Console.WriteLine("CRIANDO UMA NOVA DISCIPLINA NA INSTITUICAO\n\n");

            Console.WriteLine("Digite o nome da disciplina");
            disciplina.Nome = Console.ReadLine();

            disciplina.Id = GerarId();

            this.Disciplinas.Add(disciplina);


        }


    }
}
