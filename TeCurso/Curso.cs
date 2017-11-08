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
        private Coordenador coordenador; //Romulo

        public string Nome { get => nome; set => nome = value; }
        public int Id { get => id; set => id = value; }
        public ArrayList Turmas { get => turmas; set => turmas = value; }

        Curso() { }
    }
}
