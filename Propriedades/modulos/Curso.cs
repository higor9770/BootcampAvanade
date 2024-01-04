using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Propriedades.modulos
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicioanarAluno(Pessoa aluno){ //o void é apenas para retornar alguma informação

            Alunos.Add(aluno);

        }

        public int ObterQuantidadeDeAlunosMatriculados(){

            int quantidade = Alunos.Count;
            return quantidade;

        }

        public bool RemoverAluno(Pessoa aluno){

            return Alunos.Remove(aluno);

        }

        public void ListarAlunos(){ // método para retornar os nomes dos alunos


            Console.WriteLine($"Alunos do curso de: {Nome} ");
            foreach (Pessoa aluno in Alunos){ // para cada aluno na lista de alunos print o nome completo dos alunos
                Console.WriteLine(aluno.NomeCompleto);
            }
        }

    }
}