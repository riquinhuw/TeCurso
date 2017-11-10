using System;
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
        private ArrayList coordenadores = new ArrayList();
        private int geradorDeMatricula = 0;

        public int Matricula { get => matricula; set => matricula = value; }
        public float Salario { get => salario; set => salario = value; }
        public string Curso { get => curso; set => curso = value; }
        protected ArrayList Coordenadores { get => coordenadores; set => coordenadores = value; }
        public int GeradorDeMatricula { get => geradorDeMatricula; set => geradorDeMatricula = value; }

        public Coordenador() { }

        public int GerarMatricula()
        {
            int valor = this.GeradorDeMatricula;
            this.GeradorDeMatricula++;
            return valor;

        }

        public void AdicionarCoordenador(Coordenador coordenador) { this.coordenadores.Add(coordenador); }

        public void CriarCoordenador()
        {
            Console.Clear();
            Console.WriteLine("CADASTRAMENTO DE NOVO COORDENADOR NA INSTITUICAO\n\n");
            Console.WriteLine("Digite o nome do aluno");
            Coordenador coordenador = new Coordenador();
            coordenador.Nome = Console.ReadLine();
            coordenador.matricula = GerarMatricula();
            AdicionarCoordenador(coordenador);

        }





    }
}
