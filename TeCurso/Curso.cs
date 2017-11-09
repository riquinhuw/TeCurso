using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace TeCurso
{
    public class Curso
    {
        private string nome; //Ciencia da Computacao
        private int id;
        private ArrayList turmas = new ArrayList(); // 2MA2017
        private Coordenador coordenador = new Coordenador(); //Romulo
        private ArrayList Cursos = new ArrayList(); // arrayzão para os cursos marotos!
        private int geradorDeId = 0;

        public string Nome { get => nome; set => nome = value; }
        public int Id { get => id; set => id = value; }
        public ArrayList Turmas { get => turmas; set => turmas = value; }

        public Curso() { }

        public void AdicionarCurso(Curso curso)
        {
            this.Cursos.Add(curso);
        }

        public int GerarId()
        {
            int valor = this.geradorDeId;
            this.geradorDeId++;
            return valor;
        }

        public void CriarCurso()
        {
            Curso curso = new Curso();
            Console.WriteLine("!!! CRIANDO CURSO !!!\n\n");

            Console.WriteLine("Digite o nome do curso");
            curso.Nome = Console.ReadLine();




        }


    }
}
