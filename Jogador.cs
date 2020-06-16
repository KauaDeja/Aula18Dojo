using System;

namespace Aula18Dojo
{
    public class Jogador
    {
        public string nome { get; set; }
        public string posicao { get; set; }
        public DateTime dataNascimento { get; set; }
        public string nacionalidade { get; set; }
        public float altura { get; set; }
        public float peso { get; set; }

        // atributo idade adicionado
        public int idade { get; set; }

        // atributo aposentado adicionado
        public string Retorno { get; set; }


        public string MostrarDados(){

            System.Console.WriteLine("Digite o nome do jogador:");
            nome = Console.ReadLine();

            System.Console.WriteLine("Digite a idade do jogador:");
            idade = Int32.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite a posição do jogador:");
            posicao = Console.ReadLine();

            System.Console.WriteLine("Digite a Data de nascimento:");
            dataNascimento = DateTime.Parse(Console.ReadLine( ));

            System.Console.WriteLine("Digite a nacionalidade:");
            nacionalidade = Console.ReadLine();

            System.Console.WriteLine("Digite a altura do jogador:");
            altura = float.Parse(Console.ReadLine( ));

            System.Console.WriteLine("Digite o peso do jogador:");
            peso = float.Parse(Console.ReadLine( ));

            return " Dados do Jogador informado com sucesso!";

        }   // converter DateTime em String com cplit
            // Foi usado DateTime Now visto tbm no desafio do Uber
            public int CalcularIdade(){
                int Nascimento  = Int32.Parse(dataNascimento.ToString().Split("/")[2].Split(" ")[0]);
                int AnoAtualizado = Int32.Parse(DateTime.Now.ToString().Split("/")[2].Split(" ")[0]);

                // retornando o calculo da idade
                idade = AnoAtualizado - Nascimento;

                return idade;
            }

            public string VerificarAposentadoria(){

                CalcularIdade();
                string Retorno = "";
                if(idade >= 35 && posicao == "Atacante"){
                    Retorno = "O atacante pode se aposentar";
                }else if(idade >= 38 && posicao == "Meio Campo"){
                    Retorno = "O meio campista pode se aposentar";
                }else if(idade >= 40 && posicao == "Defensor"){
                    Retorno = "O Defensor pode se aposentar";
                }else{
                    Retorno = "O jogador não tem idade sulficiente para se aposentar";
                }
                return Retorno;
            }

            
           
            
    }
}