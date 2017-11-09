using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace TeCurso
{
    public class Professor :Pessoa
    {
        private int matricula;
        private float salario;
        private string turma;
        private ArrayList professores = new ArrayList();
        private int geradorDeMatricula = 0;

        public int Matricula { get => matricula; set => matricula = value; }
        public float Salario { get => salario; set => salario = value; }
        public string Turma { get => turma; set => turma = value; }

        public Professor() { }

        public int GerarMatricula()
        {
            int valor = this.geradorDeMatricula;
            this.geradorDeMatricula++;
            return valor;

        }

        public void AdicionarProfessor(Professor professor) { this.professores.Add(professor); }

        public void CriarProfessor()
        {
            Console.Clear();
            Console.WriteLine("CADASTRAMENTO DE NOVO PROFESSOR NA INSTITUICAO\n\n");
            Console.WriteLine("Digite o nome do Professor");
            Professor professor = new Professor();
            professor.Nome = Console.ReadLine();
            professor.matricula = GerarMatricula();
            AdicionarProfessor(professor);

        }


    }
}
