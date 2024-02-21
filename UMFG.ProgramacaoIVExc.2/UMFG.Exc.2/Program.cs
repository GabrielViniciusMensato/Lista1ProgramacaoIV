namespace UMFG.Exc._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inisira um valor em USD: ");
            double valorEmUSD = Convert.ToDouble(Console.ReadLine());
          
            double taxaDeConversao = 5.22;

            //conversao 
            double valorEmBRL = valorEmUSD * taxaDeConversao;

            Console.WriteLine($"{valorEmUSD} USD é equivalente a {valorEmBRL} BRL");
        }
    }
}

