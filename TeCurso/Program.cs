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
             *      CLASSE CURSO 0%
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
             *  Metodo Cadastrar Alunos      ( ) FALTA METODO DE CRIAR CURSO, PARA PODER MATRICULAR OS ALUNOS HU3
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

            Aluno paulo = new Aluno();
            Aluno paulo2 = new Aluno();
            Aluno paulo3 = new Aluno();
            Aluno paulo4 = new Aluno();
            paulo.Matricula = alunoMatriz.GerarMatricula();
            paulo2.Matricula = alunoMatriz.GerarMatricula();
            paulo3.Matricula = alunoMatriz.GerarMatricula();
            paulo4.Matricula = alunoMatriz.GerarMatricula();
            Console.WriteLine(paulo.Matricula);
            Console.WriteLine(paulo2.Matricula);
            Console.WriteLine(paulo3.Matricula);
            Console.WriteLine(paulo4.Matricula);



        }
    }
}
