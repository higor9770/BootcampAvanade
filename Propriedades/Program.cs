using Propriedades.modulos; // importanto a classe Pessoa que está em modulos

Pessoa p1 = new Pessoa(nome: "Higor", sobrenome: "Cabral"); // instaciei a classe pessoa p1

// p1.Nome = "Higor"; //atribuindo valores para p1
// p1.Sobrenome = "Cabral";

Pessoa p2 = new Pessoa(nome: "Eduardo", sobrenome: "Neves Queiroz"); // instaciei a classe pessoa p2

//p2.Nome = "Eduardo"; //atribuindo valores para p2
// p2.Sobrenome = "Neves Queiroz";

Curso cursoDeIngles = new Curso(); //instanciando a classe curso
cursoDeIngles.Nome = "inglês"; //atribuindo valores para curso
cursoDeIngles.Alunos = new List<Pessoa>(); // criando uma lista vazia de Alunos

cursoDeIngles.AdicioanarAluno(p1); // adicionando p aluno p1 a lista de Alunos
cursoDeIngles.AdicioanarAluno(p2);// adicionando p aluno p2 a lista de Alunos
cursoDeIngles.ListarAlunos(); // listando os valores presentes na lista Alunos