using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace TeCurso
{
    public class Turma
    {

        private string nome;
        private int id;
        private ArrayList diciplinas = new ArrayList();
        private ArrayList alunos = new ArrayList();
        private ArrayList turmas = new ArrayList();
        private int geradorDeId = 0;

        public string Nome { get => nome; set => nome = value; }
        public int Id { get => id; set => id = value; }
        public ArrayList Diciplinas { get => diciplinas; set => diciplinas = value; }
        public ArrayList Alunos { get => alunos; set => alunos = value; }
        public int GeradorDeId { get => geradorDeId; set => geradorDeId = value; }
        public ArrayList Turmas { get => turmas; set => turmas = value; }

        public Turma() { }

        public int GerarId()
        {
            int valor = this.geradorDeId;
            this.geradorDeId++;
            return valor;
        }

        public void CriarTurma()
        {
            Turma turma = new Turma();
            Console.Clear();
            Console.WriteLine("CRIANDO UMA NOVA TURMA NA INSTITUICAO \n\n");

            Console.WriteLine("Digite o nome da turma");
            turma.Nome = Console.ReadLine();

            turma.id = GerarId();

            this.Turmas.Add(turma);



        }
    }
}
