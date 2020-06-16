using System;

namespace Aula18Dojo
{
    public class Jogador
    {
        public string Nome { get; set; }
        public string Posicao { get; set; }
        public DateTime Nascimento { get; set; }
        public float Altura { get; set; }
        public float Peso { get; set; }
        public string Nacionalidade { get; set; }
        public string MostrarDados(){
            return $"Nome: {Nome}, Posiçao do jogador: {Posicao}, Data de nascimento: {Nascimento}, Altura: {Altura}, Peso: {Peso}, Nascionalidade: {Nacionalidade}";
        }
        public int Idade { get; set; }

        public int CalcularIdade(){
            // 0    1    2
            // 05 / 02 / 1985 data do cr7
            int anoNasct = Int32.Parse(Nascimento.ToString().Split('/' ,' ')[2]);
            int anoAtual = Int32.Parse(DateTime.Now.ToString().Split('/' ,' ')[2]);

            Idade = anoAtual - anoNasct;
            return Idade;

        }
        public string CalcularAposentadoria(){

            string aposentadoria = "";

            if(Posicao == "Atacante" && Idade >= 35){

                aposentadoria = "Voce pode se aposentar";

            }else if(Posicao == "Meio Campo" && Idade >= 38){

                aposentadoria = "Voce pode se aposentar";

            }else if(Posicao == "Defesa" && Idade >= 40){

                aposentadoria = "Voce pode se aposentar";

            }else{

                aposentadoria = "Voce nao pode se aposentar";

            }
            return aposentadoria;
        }
    }
}