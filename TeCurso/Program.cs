using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeCurso
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Andamento do codigo e suas caracteristicas
            /*      TODO 0%
             * 
             *      MENU 0%
             *  Metodo do Menu               ( )
             *  
             *      CLASSE CURSO 20%
             *  Metodo Criar Curso           (X)
             *  Metodo Cadrastrar Turmas     ( )
             *  Metodo Consultar Turmas      ( )
             *  Metodo Remover Turmas        ( )
             *  Metodo Atualizar Turmas      ( )
             *  
             *      CLASSE TURMA 0% 
             *  Metodo Criar Turma           (X)
             *  Metodo Cadrastar Disciplicas ( )
             *  Metodo Consultar Disciplicas ( )
             *  Metodo Remover Disciplicas   ( )
             *  Metodo Atualizar Disciplicas ( )
             *  
             *      CLASSE DISCIPLINA 40%
             *  Metodo Criar Disciplina      (X)
             *  Metodo Cadastrar Alunos      (X) 
             *  Metodo Consultar Alunos      (X)
             *  Metodo Remover Alunos        (X)
             *  Metodo Atualizar Alunos      ( )
             *  
             *      CLASSE MAIN 1%
             *  Metodo criador ddados feitos ( )
             *  
             *      PESSOAS E SEUS FILHOS 50%
             *  Metodo Criador de Professor   (X)
             *  Metodo Criador de Coordenador (X)
             *  Metodo Criador de Aluno       (X)
             *  
             *  
             *  METODO LOGICO:
             *  Irei usar os ArrayList's como um deposito de dados "lixo"
             *  Onde irei fazer um Foreach para localizar dentro desse array o indice do objeto dejesado
             *  Sem se importar com o index dele, pois sempre irei fazer que o programa faça uma busca ruim no array
             *  Já que não sei como posso organizar de uma forma mais "limpa"
             *  
             *  Sei que poderia usar os Id's como "chave primaria" para evitar de criar mais arrays por ai, mas irei fazer dessa forma mesmo
             *  
             *  Converti TUDO PARA LIST!
            */
            #endregion

            #region objetos Matrizes
            Aluno alunoMatriz = new Aluno();
            Aluno a1 = new Aluno();
            Turma turmaMatriz = new Turma();
            Disciplina disciplinaMatriz = new Disciplina();
            #endregion
            alunoMatriz.CriarAluno();
            alunoMatriz.CriarAluno();
            disciplinaMatriz.CriarDiciplina();
            disciplinaMatriz.CriarDiciplina();
            disciplinaMatriz.AdicionarAluno(alunoMatriz.Alunos);
            


            //disciplinaMatriz.CriarDiciplina();
            //disciplinaMatriz.CriarDiciplina();
            //foreach (Disciplina alunosProcurados in disciplinaMatriz.Disciplinas)
            //{
            //    Console.WriteLine("Nome:{0} Matricula:{1}", alunosProcurados.Nome, alunosProcurados.Id);
            //}

            //turmaMatriz.CriarTurma();
            //turmaMatriz.CriarTurma();

            //foreach (Turma alunosProcurados in turmaMatriz.Turmas)
            //{
            //    Console.WriteLine("Nome:{0} Matricula:{1}", alunosProcurados.Nome, alunosProcurados.Id);
            //}

            //alunoMatriz.CriarAluno();
            //alunoMatriz.CriarAluno();
            //alunoMatriz.CriarAluno();
            //foreach (Aluno alunosProcurados in alunoMatriz.Alunos)
            //{
            //    Console.WriteLine("Nome:{0} Matricula:{1}", alunosProcurados.Nome, alunosProcurados.Matricula);
            //}



        }
    }
}
