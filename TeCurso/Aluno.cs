using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeCurso
{
    public class Aluno : Pessoa
    {
        private int matricula;
        private string curso; //CCO
        private string turma; // CCO 2017-1 MA

        public int Matricula { get => matricula; set => matricula = value; }
        public string Curso { get => curso; set => curso = value; }
        public string Turma { get => turma; set => turma = value; }

        public Aluno() //Construtor Vazio
        { }

        public Aluno(string nome,int idade,int matricula,string curso,string turma )
        {
            this.nome = nome;
            this.idade = idade;
            this.matricula = matricula;
            this.curso = curso;
        }


    }
}
