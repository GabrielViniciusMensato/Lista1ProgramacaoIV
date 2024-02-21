namespace UMFGProgramacaoIVExc1
{
    internal class Program
    {
       private static Exc2Programacao ex2 = new Exc2Programacao();  

        
        static void Main(string[] args)
        {
            var opcao = 10;
            do
            {

                Console.WriteLine("Exercicio1");
                Console.WriteLine("Exercicio2");
                Console.WriteLine("Exercicio3");
                Console.WriteLine("Exercicio3");
                Console.WriteLine("Exercicio4");
                Console.WriteLine("Exercicio5");
                Console.WriteLine("Exercicio6");
                Console.WriteLine("Exercicio7");
                int.TryParse(Console.ReadLine(), out opcao);    

                switch(opcao){
                    case 1: 

                        break;

                    case 2:
                        Console.WriteLine("Qual o número desejado: "); 
                        var valor = Console.ReadLine(); 
                        double valorTransferido = Convert.ToDouble(valor);
                        ex2.ConverterRealParaDolar(valorTransferido); 
                        break;

                    case 3:
                        break;

                    case 4:
                        break;

                       case 5:
                        break;

                    case 6:
                        break;

                    case 7:
                        break;

                    default:
                        
                        break; 

                }


            } while (opcao != 10); 

            
            


            Console.Write("Insira um valor em BRL: ");
            double valorEmBRL = Convert.ToDouble(Console.ReadLine());

            
            double taxaDeConversao = 0.193259;

            //conversao
           double valorEmUSD = valorEmBRL * taxaDeConversao;

            Console.WriteLine($"{valorEmBRL} A quantidade em BRL é equivalente a {valorEmUSD} USD");
        }
    }
}
