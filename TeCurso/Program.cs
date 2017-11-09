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
             *  Metodo Cadrastar Disciplicas ( )
             *  Metodo Consultar Disciplicas ( )
             *  Metodo Remover Disciplicas   ( )
             *  Metodo Atualizar Disciplicas ( )
             *  
             *      CLASSE DISCIPLINA 4%
             *  Metodo Cadastrar Alunos      ( ) COLOCAR MATRICULA NO MAIN, ACHAR MEIO DE MELHORAR ISSO DPS ( )
             *  Metodo Consultar Alunos      ( )
             *  Metodo Remover Alunos        ( )
             *  Metodo Atualizar Alunos      ( )
             *  
             *  
             *  METODO LOGICO:
             *  Irei usar os ArrayList's como um deposito de dados "lixo"
             *  Onde irei fazer um Foreach para localizar dentro desse array o indice do objeto dejesado
             *  Sem se importar com o index dele, pois sempre irei fazer que o programa faça uma busca ruim no array
             *  Já que não sei como posso organizar de uma forma mais "limpa"
            */
            #endregion

            #region objetos Matrizes
            Aluno alunoMatriz = new Aluno();
            #endregion

            alunoMatriz.CriarAluno();
            alunoMatriz.CriarAluno();
            alunoMatriz.CriarAluno();
            foreach (Aluno alunosProcurados in alunoMatriz.Alunos)
            {
                Console.WriteLine("Nome:{0} Matricula:{1}",alunosProcurados.Nome,alunosProcurados.Matricula);

            }



        }
    }
}
