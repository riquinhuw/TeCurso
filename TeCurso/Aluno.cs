using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace TeCurso
{
    public class Aluno : Pessoa
    {
        private int matricula;
        private Curso curso; //CCO //MUDEI DO TIPO STRING PARA CURSO
        private string turma; // CCO 2017-1 MA
        private double nota1;
        private double nota2;
        private double nota3;
        private string diciplina;
        private ArrayList alunos = new ArrayList();
        protected int geradorDeMatricula = 0;


        public int Matricula { get => matricula; set => matricula = value; }
        public string Turma { get => turma; set => turma = value; }
        public double Nota1 { get => nota1; set => nota1 = value; }
        public double Nota2 { get => nota2; set => nota2 = value; }
        public double Nota3 { get => nota3; set => nota3 = value; }
        public string Diciplina { get => diciplina; set => diciplina = value; }
        public ArrayList Alunos { get => alunos; set => alunos = value; }
        public Curso Curso { get => curso; set => curso = value; }

        public Aluno() //Construtor Vazio
        { }

        public Aluno(string nome,int idade,int matricula,Curso curso,string turma,string diciplina)
        {
            this.nome = nome;
            this.idade = idade;
            this.matricula = matricula;
            this.Curso = curso;
            this.diciplina = diciplina;

        }

        public void AdicionarAluno(Aluno aluno)
        {
            
            this.alunos.Add(aluno);

        }

        public int GerarMatricula()
        {
            int valor = this.geradorDeMatricula;
            this.geradorDeMatricula++;
            return valor;

        }

        public void CriarAluno()
        {
            Console.Clear();
            Console.WriteLine("CADASTRAMENTO DE NOVO ALUNO NA INSTITUICAO\n\n");
            Console.WriteLine("Digite o nome do aluno");
            Aluno aluno = new Aluno();
            aluno.Nome = Console.ReadLine();
            aluno.matricula = GerarMatricula();
            AdicionarAluno(aluno);

        }


    }
}
