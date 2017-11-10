using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeCurso
{
    class Program
    {
        // procurar meio melhor para fazer isso, sei que posso usar os metodos com Return, mas né :\
        #region objetos Matrizes
        static Aluno alunoMatriz = new Aluno();
        static Turma turmaMatriz = new Turma();
        static Disciplina disciplinaMatriz = new Disciplina();
        static Curso cursoMatriz = new Curso();
        static Professor professorMatriz = new Professor();
        static Coordenador coordenadorMatriz = new Coordenador();
        #endregion

        static void Main(string[] args)
        {

            #region Andamento do codigo e suas caracteristicas
            /*      TODO 37%
             * 
             *      MENU 35%
             *  Metodo do Menu               ( )
             *  
             *      CLASSE CURSO 20%
             *  Metodo Criar Curso           (X)
             *  Metodo Cadrastrar Turmas     ( )
             *  Metodo Consultar Turmas      ( )
             *  Metodo Remover Turmas        ( )
             *  Metodo Atualizar Turmas      ( )
             *  
             *      CLASSE TURMA 20% 
             *  Metodo Criar Turma           (X)
             *  Metodo Cadrastar Disciplicas ( )
             *  Metodo Consultar Disciplicas ( )
             *  Metodo Remover Disciplicas   ( )
             *  Metodo Atualizar Disciplicas ( )
             *  
             *      CLASSE DISCIPLINA 90%         FALTA POR NO MAIN!
             *  Metodo Criar Disciplina      (X) Metodo Feito, falta fazer sistema para armazenar a disciplina feita
             *  Metodo Cadastrar Alunos      (X) 
             *  Metodo Consultar Alunos      (X)
             *  Metodo Remover Alunos        (X)
             *  Metodo Atualizar Alunos      (X)
             *  
             *      CLASSE MAIN 4%
             *  Metodo criador ddados feitos ( )
             *  SwtichCases                  ( )
             *  
             *      PESSOAS E SEUS FILHOS 50%
             *  Metodo Criador de Professor  (X)
             *  Metodo Criador de Coordenador(X)
             *  Metodo Criador de Aluno      (X)
             *  
             *  
             *  METODO LOGICO: cada quebra de linha sou eu em um tempo diferente \/
             *  Irei usar os ArrayList's como um deposito de dados "lixo"
             *  Onde irei fazer um Foreach para localizar dentro desse array o indice do objeto dejesado
             *  Sem se importar com o index dele, pois sempre irei fazer que o programa faça uma busca ruim no array
             *  Já que não sei como posso organizar de uma forma mais "limpa"
             *  
             *  Sei que poderia usar os Id's como "chave primaria" para evitar de criar mais arrays por ai, mas irei fazer dessa forma mesmo
             *  
             *  Converti TUDO PARA LIST!
             *  
             *  Ultimo update antes de enviar o trabalho, Bem eu terminei de fazer os Metodos para Aluno, basicamente o resto iria seguir a mesma logica
             *  Mas eu não fiz pq já são 21:27 aqui, sei que tive tempo para fazer, mas só fui realmente fazer no dia 09/11, antes disso fiquei planejando(em vão)
             *  Dica, nao deixe para ultima hora, vocÊ vai perceber que poderia ter feito mais nesse trabalho.... VIVA PENSANDO QUE O TRAB É PARA O DIA SEGUINTE
             *  VIVA SEMPRE COMO SE FOSSE O ULTIMO DIA PARA FAZER!
             *  Desculpa guys, well se der vontade outro dia termino(promessa de politico)
            */
            #endregion



            Menu();

        }

        static public void Menu()
        {
            bool loop = true;
            Console.Clear();
            int resposta = 0;
            

            do
            {
                Console.WriteLine("Final Fantasy Cursos\n\n");//será que alguem pega a referencia? A REAL REFERENCIA!

                Console.WriteLine("1 - Criar Aluno");
                Console.WriteLine("2 - Criar Professor");
                Console.WriteLine("3 - Criar Coordenador");
                Console.WriteLine("4 - Criar Disciplina");
                Console.WriteLine("5 - Criar Turma");
                Console.WriteLine("6 - Criar Curso");
                Console.WriteLine("7 - Consultar aluno ");
                Console.WriteLine("8 - Remover aluno ");
                Console.WriteLine("9 - Editar aluno ");
                Console.WriteLine("10 - Listar alunos ");//nao fiz ainda, mas é de boa fazer
                Console.WriteLine("11 - Konami Code");
                Console.WriteLine("12 - Sair\n\n");
                Console.WriteLine("choose your destiny:");
                resposta = int.Parse(Console.ReadLine());

                switch (resposta)
                {
                    case 1: // criar aluno
                        alunoMatriz.CriarAluno();
                        break;

                    case 2:// criar professor
                        professorMatriz.CriarProfessor();
                        break;

                    case 3://criar coordenador
                        coordenadorMatriz.CriarCoordenador();
                        break;

                    case 4://criar disciplina
                        disciplinaMatriz.CriarDiciplina();
                        break;

                    case 5://criar turma
                        turmaMatriz.CriarTurma();
                        break;

                    case 6://criar curso
                        cursoMatriz.CriarCurso();
                        break;

                    case 7://consultar aluno
                        disciplinaMatriz.ConsultarAluno(alunoMatriz.Alunos);
                        break;

                    case 8:// remover aluno
                        disciplinaMatriz.RemoverAluno(alunoMatriz.Alunos);
                        break;

                    case 9://Editar aluno
                        disciplinaMatriz.AlterarAluno(alunoMatriz.Alunos);
                        break;

                    case 10://Listar aluno | mesmo sistema para listar prof/coord
                        Console.Clear();
                        Console.WriteLine("LISTANDO ALUNOS CRIADOS!");
                        foreach(Aluno luno in alunoMatriz.Alunos)
                        {
                            Console.WriteLine("Nome:{0}    Matricula:{1}", luno.Nome, luno.Matricula);

                        }
                        break;

                    case 11://konami
                        Console.Clear();
                        string konami;
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("WHY YOU CHOOSE THE KONAMI CODE?");
                        Console.ResetColor();
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("ENTAO DIGITE THE CODE FOR US MUAH MUAH MUAH HAHA!");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        konami = Console.ReadLine();
                        Console.ResetColor();
                        if (konami == "tetris") { alunoMatriz.Tetris(); }
                        if (konami == "mario") { alunoMatriz.Mario(); }
                        break;

                    case 12://sair
                        loop = false;
                        break;




                }


            } while (loop);


        }

    }
}
