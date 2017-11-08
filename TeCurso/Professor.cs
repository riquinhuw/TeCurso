using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeCurso
{
    public class Professor :Pessoa
    {
        private int matricula;
        private float salario;
        private string turma;

        public int Matricula { get => matricula; set => matricula = value; }
        public float Salario { get => salario; set => salario = value; }
        public string Turma { get => turma; set => turma = value; }


        public Professor(string nome, int idade, int matricula, string curso)
        {
            this.nome = nome;
            this.idade = idade;
            this.Matricula = matricula;
            this.Turma = curso;
        }


    }
}
