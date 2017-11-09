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

        public string Nome { get => nome; set => nome = value; }
        public int Id { get => id; set => id = value; }
        public ArrayList Diciplinas { get => diciplinas; set => diciplinas = value; }
        public ArrayList Alunos { get => alunos; set => alunos = value; }

        public Turma() { }

        public void CriarTurma()
        {
            Console.Clear();


        }
    }
}
