using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace TeCurso
{
    public class Disciplina
    {

        private string nome;
        private int id;
        //private ArrayList disciplinas = new ArrayList();
        private List<Disciplina> disciplinas = new List<Disciplina>();
        private Professor professor = new Professor();
        private List<Professor> professores = new List<Professor>();
        private Aluno alunoMatiz = new Aluno();
        //private ArrayList alunos = new ArrayList();
        private List<Aluno> alunos = new List<Aluno>();
        private int geradorDeId = 0;

        public string Nome { get => nome; set => nome = value; }
        public int Id { get => id; set => id = value; }
        //public ArrayList Disciplinas { get => disciplinas; set => disciplinas = value; }
        public Professor Professor { get => professor; set => professor = value; }
        public Aluno AlunoMatiz { get => alunoMatiz; set => alunoMatiz = value; }
        public int GeradorDeId { get => geradorDeId; set => geradorDeId = value; }
        public List<Disciplina> Disciplinas { get => disciplinas; set => disciplinas = value; }
        public List<Professor> Professores { get => professores; set => professores = value; }
        public List<Aluno> Alunos { get => alunos; set => alunos = value; }

        public Disciplina() { }

        public int GerarId()
        {
            int valor = this.GeradorDeId;
            this.GeradorDeId++;
            return valor;
        }

        public void CriarDiciplina() 
        {
            Disciplina disciplina = new Disciplina();
            Console.Clear();
            Console.WriteLine("CRIANDO UMA NOVA DISCIPLINA NA INSTITUICAO\n\n");

            Console.WriteLine("Digite o nome da disciplina");
            disciplina.Nome = Console.ReadLine();

            disciplina.Id = GerarId();

            this.Disciplinas.Add(disciplina);


        }

        public void AdicionarAluno(List<Aluno> listaDeAlunos)
        {   //sei que posso fazer por matricula I CAN DO IT, YES I CAN BIRL!!!!!! i guess
            Console.Clear();
            int i = 0; //contador para a busca
            string nomeDoAluno;
            int matriculaDoAluno=0;
            bool achado = false;
            Console.WriteLine("ADICIONANDO ALUNO NA DISCIPLINA\n\n");
            Console.WriteLine("Deseja procurar o aluno por matricula ou pelo nome exato?\nM para matricula, N para nome");
            if (Console.ReadLine().ToUpper() == "N")
            {
                i = 0;
                Console.WriteLine("Digite o nome do aluno exatamente igual");
                nomeDoAluno = Console.ReadLine();
                foreach (Aluno alunoProcurado in listaDeAlunos)
                {
                    if (alunoProcurado.Nome.ToUpper() == nomeDoAluno.ToUpper())
                    {
                        Console.WriteLine("Localizamos o aluno:{0}", alunoProcurado.Nome);
                        Console.WriteLine("Sua matricula é:{0}", alunoProcurado.Matricula);
                        Console.WriteLine("Aluno adicionado");
                        Console.WriteLine("precione qualquer tecla para continuar...");
                        achado = true;
                        Console.ReadKey();

                    }

                    i++;
                }
                if (!achado) { Console.WriteLine("Aluno não encotrado"); }
                i=i - 1;
                this.alunos.Add(listaDeAlunos[i]);


            } else {
                i = 0;
                Console.WriteLine("Digite a matricula do aluno");
                matriculaDoAluno = int.Parse(Console.ReadLine());
                foreach (Aluno alunoProcurado in listaDeAlunos)
                {
                    if (alunoProcurado.Matricula == matriculaDoAluno)
                    {
                        Console.WriteLine("Localizamos o aluno:{0}", alunoProcurado.Nome);
                        Console.WriteLine("Sua matricula é:{0}", alunoProcurado.Matricula);
                        Console.WriteLine("Aluno adicionado");
                        Console.WriteLine("precione qualquer tecla para continuar...");
                        achado = true;
                        Console.ReadKey();

                    }

                    i++;
                }
                if (!achado) { Console.WriteLine("Aluno não encotrado"); }
                i = i - 1;
                this.alunos.Add(listaDeAlunos[i]);

            }


        }

        public void ConsultarAluno(List<Aluno> listaDeAlunos) //falta por para ver as disciplinas que ele tem
        {

            Console.Clear();
            int i = 0; //contador para a busca
            string nomeDoAluno;
            int matriculaDoAluno = 0;
            bool achado = false;
            Console.WriteLine("CONSULTANDO ALUNO\n\n");
            Console.WriteLine("Deseja procurar o aluno por matricula ou pelo nome exato?\nM para matricula, N para nome");
            if (Console.ReadLine().ToUpper() == "N")
            {
                i = 0;
                Console.WriteLine("Digite o nome do aluno exatamente igual");
                nomeDoAluno = Console.ReadLine();
                foreach (Aluno alunoProcurado in listaDeAlunos)
                {
                    if (alunoProcurado.Nome.ToUpper() == nomeDoAluno.ToUpper())
                    {
                        Console.WriteLine("Localizamos o aluno:{0}", alunoProcurado.Nome);
                        Console.WriteLine("Sua matricula é:{0}", alunoProcurado.Matricula);
                        Console.WriteLine("precione qualquer tecla para continuar...");
                        achado = true;
                        Console.ReadKey();

                    }

                    i++;
                }
                if (!achado) { Console.WriteLine("Aluno não encotrado"); }


            }
            else
            {
                i = 0;
                Console.WriteLine("Digite a matricula do aluno");
                matriculaDoAluno = int.Parse(Console.ReadLine());
                foreach (Aluno alunoProcurado in listaDeAlunos)
                {
                    if (alunoProcurado.Matricula == matriculaDoAluno)
                    {
                        Console.WriteLine("Localizamos o aluno:{0}", alunoProcurado.Nome);
                        Console.WriteLine("Sua matricula é:{0}", alunoProcurado.Matricula);
                        Console.WriteLine("precione qualquer tecla para continuar...");
                        achado = true;
                        Console.ReadKey();

                    }

                    i++;
                }
                if (!achado) { Console.WriteLine("Aluno não encotrado"); }
                i = i - 1;


            }



        }

        public int RemoverAluno(List<Aluno> listaDeAlunos)
        {

            Console.Clear();
            int i = 0; //contador para a busca
            string nomeDoAluno;
            int matriculaDoAluno = 0;
            bool achado = false;
            Console.WriteLine("INDO APAGAR UM ALUNO, UI UI UI, DAN DAN DAN\n\n");
            Console.WriteLine("Deseja procurar o aluno por matricula ou pelo nome exato?\nM para matricula, N para nome");
            if (Console.ReadLine().ToUpper() == "N")
            {
                i = 0;
                Console.WriteLine("Digite o nome do aluno exatamente igual");
                nomeDoAluno = Console.ReadLine();
                foreach (Aluno alunoProcurado in listaDeAlunos)
                {
                    if (alunoProcurado.Nome.ToUpper() == nomeDoAluno.ToUpper())
                    {
                        Console.WriteLine("Localizamos o aluno:{0}", alunoProcurado.Nome);
                        Console.WriteLine("Sua matricula é:{0}", alunoProcurado.Matricula);
                        Console.WriteLine("Este e' o aluno que deseja excluir?(s/n)");
                        if (Console.ReadLine().ToLower() == "s")

                        {
                            return i;
                        }else { return 007; }                       




                        achado = true;
                        Console.ReadKey();

                    }

                    i++;
                }
                if (!achado) { Console.WriteLine("Aluno não encotrado"); return 007; }
                return 007;

            }
            else
            {
                i = 0;
                Console.WriteLine("Digite a matricula do aluno");
                matriculaDoAluno = int.Parse(Console.ReadLine());
                foreach (Aluno alunoProcurado in listaDeAlunos)
                {
                    if (alunoProcurado.Matricula == matriculaDoAluno)
                    {
                        Console.WriteLine("Localizamos o aluno:{0}", alunoProcurado.Nome);
                        Console.WriteLine("Sua matricula é:{0}", alunoProcurado.Matricula);
                        Console.WriteLine("Este e' o aluno que deseja excluir?(s/n)");
                        if (Console.ReadLine().ToLower() == "s")

                        {
                            return i;
                        }
                        else { return 007; }

                    }

                    i++;
                }
                if (!achado) { Console.WriteLine("Aluno não encotrado"); return 007; }


                return 007;
            }



        }

        public int AlterarAluno(List<Aluno> listaDeAlunos)
        {

            Console.Clear();
            int i = 0; //contador para a busca
            string nomeDoAluno;
            int matriculaDoAluno = 0;
            bool achado = false;
            Console.WriteLine("INDO APAGAR UM ALUNO, UI UI UI, DAN DAN DAN\n\n");
            Console.WriteLine("Deseja procurar o aluno por matricula ou pelo nome exato?\nM para matricula, N para nome");
            if (Console.ReadLine().ToUpper() == "N")
            {
                i = 0;
                Console.WriteLine("Digite o nome do aluno exatamente igual");
                nomeDoAluno = Console.ReadLine();
                foreach (Aluno alunoProcurado in listaDeAlunos)
                {
                    if (alunoProcurado.Nome.ToUpper() == nomeDoAluno.ToUpper())
                    {
                        Console.WriteLine("Localizamos o aluno:{0}", alunoProcurado.Nome);
                        Console.WriteLine("Sua matricula é:{0}", alunoProcurado.Matricula);
                        Console.WriteLine("Este e' o aluno que deseja Alterar?(s/n)");
                        if (Console.ReadLine().ToLower() == "s")

                        {
                            return i;
                        }
                        else { return 007; }




                        achado = true;
                        Console.ReadKey();

                    }

                    i++;
                }
                if (!achado) { Console.WriteLine("Aluno não encotrado"); return 007; }
                return 007;

            }
            else
            {
                i = 0;
                Console.WriteLine("Digite a matricula do aluno");
                matriculaDoAluno = int.Parse(Console.ReadLine());
                foreach (Aluno alunoProcurado in listaDeAlunos)
                {
                    if (alunoProcurado.Matricula == matriculaDoAluno)
                    {
                        Console.WriteLine("Localizamos o aluno:{0}", alunoProcurado.Nome);
                        Console.WriteLine("Sua matricula é:{0}", alunoProcurado.Matricula);
                        Console.WriteLine("Este e' o aluno que deseja Alterar?(s/n)");
                        if (Console.ReadLine().ToLower() == "s")

                        {
                            return i;
                        }
                        else { return 007; }

                    }

                    i++;
                }
                if (!achado) { Console.WriteLine("Aluno não encotrado"); return 007; }


                return 007;
            }



        }


    }
}
