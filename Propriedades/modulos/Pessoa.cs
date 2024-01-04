using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Propriedades.modulos
{
    public class Pessoa
    {

        public Pessoa(){

        }

        public Pessoa(string nome, string sobrenome){// criando um construtor

            Nome = nome;
            Sobrenome = sobrenome;

        }

        private string _Nome; // criando uma nova variavel _nome como private para proteger o dado
        private int _Idade; // criando uma nova variavel chamada Idade como private para proteger o dado
        public string Nome { // variavel nome para receber do usuário o valor que será inserido nessa variável
            
            get{

                return _Nome.ToUpper(); //trazendo os valores da variavél _nome tudo maiúscula

            }
        
            set{

                if (value == ""){ // fazendo uma excessão no método set para não deixar valores nulos serem inseridos

                    throw new ArgumentException ("O nome não pode ser vazio");
                }

                _Nome = value; // se o valor não for nulo, o valor vai ser inserido na variável _nome e protegido
            }
        
        } 

        public string Sobrenome {get; set;}

        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper(); //nova variavel para juntar nome e sobrenome 
        // (é apenas get, pois o set já foi feito nas outras variaveis)



        public int Idade { // variavel Idade para receber do usuário o valor que será inserido nessa variável

            get => _Idade; //traz o valor da variavel _Idade (private) 
            
            set{
 
                if (value < 0){ // fazendo uma excessão no método set para não deixar valores nulos serem inseridos

                    throw new ArgumentException ("A idade não pode ser menor que zero");
                }

                _Idade = value;  // se o valor não for nulo, o valor vai ser inserido na variável _Idade e protegido

            } 

        }

        public void apresentar(){ // função apresentar

            Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");

        }

    }
}