﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace TeCurso
{
    public class Coordenador : Pessoa

    {
        private int matricula;
        private float salario;
        private string curso;
        protected ArrayList coordenadores = new ArrayList();

        public int Matricula { get => matricula; set => matricula = value; }
        public float Salario { get => salario; set => salario = value; }
        public string Curso { get => curso; set => curso = value; }

        public Coordenador() { }

        public Coordenador(string nome, int idade, int matricula, string curso)
        {

            this.nome = nome;
            this.idade = idade;
            this.Matricula = matricula;
            this.Curso = curso;

        }


    }
}
