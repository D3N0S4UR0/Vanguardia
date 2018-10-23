using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormLogin
{
    public class perguntas
    {
        private String modo;
        private pergunta perguntaFase1;
        private pergunta perguntaFase2;
        private pergunta[] perguntasFaseFinal;
        public perguntas(String modo)
        {
            this.modo = modo;
            perguntasFaseFinal = new pergunta[5];
            switch (this.modo)
            {
                case "facil":
                    {
                        this.perguntaFase1 =new pergunta("Existe algum erro na frase: 'O assacino matou a vítima' ?", "sim");
                        this.perguntaFase2 = new pergunta("Qual a capital do Brasil?","Brasília");
                        perguntasFaseFinal[0] = new pergunta("Quanto é 50 - 22?", "28");
                        perguntasFaseFinal[1] = new pergunta("Quanto é 33 + 57?", "90");
                        perguntasFaseFinal[2] = new pergunta("Meia hora tem quantos minutos?", "30");
                        perguntasFaseFinal[3] = new pergunta("Saul vai para a escola às 7 horas e volta às 11, quantas horas Saul fica na escola?", "4");
                        perguntasFaseFinal[4] = new pergunta("Qual número tem 2 centenas, 2 dezenas e 6 unidades?","226");
                        break;
                    }
                case "medio":
                    {
                        this.perguntaFase1= new pergunta("Classifique a palavra lâmpada como proparoxítona, paroxítona ou oxítona", "proparoxítona");
                        this.perguntaFase2 = new pergunta("Como se chama o movimento que a terra faz em torno do próprio eixo?", "Rotação");
                        perguntasFaseFinal[0] = new pergunta("Quanto é 32 : 4?", "8");
                        perguntasFaseFinal[1] = new pergunta("Quanto é 14 * 5","70");
                        perguntasFaseFinal[2] = new pergunta("Se eu tenho que pagar 12 parcelas de R$200,00 . Quanto eu pagarei no total?(apenas o número)", "2400");
                        perguntasFaseFinal[3] = new pergunta("Qual é a diferença entre o maior número e o menor número que podem ser escritos com os algarismos 2, 4, 7 e 8 sem usar o mesmo algarismo duas vezes?", "6264");
                        perguntasFaseFinal[4] = new pergunta("Nas férias de julho, os 36 alunos do 4º ano foram fazer um passeio de trem. O custo total das passagens foi de 4.572 reais. Qual o preço de cada passagem?", "127");
                        break;
                    }

                case "dificil":
                    {
                        this.perguntaFase1 = new pergunta("Complete a palavra: __lhotina", "guilhotina");
                        this.perguntaFase2 = new pergunta("Qual a capital de roraima?", "Boa Vista");
                        perguntasFaseFinal[0] = new pergunta("Se uma caixa de sabão em pó custa R$6,00.Quanto custarão 6 caixas?(apenas o número)", "36");
                        perguntasFaseFinal[1] = new pergunta("Em um táxi, cabem no máximo 4 pessoas além do motorista. Quantos passageiros no máximo 5 táxis podem levar?", "20");
                        perguntasFaseFinal[2] = new pergunta("Uma caixa de bombons contém 10 unidades. Se joão comprar 11 caixas, quantos bombons estará comprando?", "110");
                        perguntasFaseFinal[3] = new pergunta("É correto dizer que 9,07 e 9,7 representam o mesmo número decimal?", "não");
                        perguntasFaseFinal[4] = new pergunta("Adicionando 11,72 ao número 3,28 e subtraindo 7,223 do resultado, você obtém que número decimal?", "7,777");
                        break;
                    }
            }
        }

        public pergunta getPerguntaFase1()
        {
            return this.perguntaFase1;
        }

        public pergunta getPerguntaFase2()
        {
            return this.perguntaFase2;
        }

        public pergunta[] getPerguntaFaseFinal()
        {
            return this.perguntasFaseFinal;
        }
    }
}
