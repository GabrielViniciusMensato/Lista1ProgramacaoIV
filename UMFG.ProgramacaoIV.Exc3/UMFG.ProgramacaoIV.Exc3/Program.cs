namespace UMFG.ProgramacaoIV.Exc3
{
    internal class Program
    {
        static void Main()
        {
            
            Console.Write("Distância percorrida em KM: ");
            double distanciaEmKM = Convert.ToDouble(Console.ReadLine());

            
            Console.Write("Gasto de combustível em litros: ");
            double gastoEmLitros = Convert.ToDouble(Console.ReadLine());

            //calculo 
            double mediaDeGasto = gastoEmLitros / distanciaEmKM;

            Console.WriteLine($"A média de gasto do automóvel é de {mediaDeGasto} litros por quilômetro.");
        }
    }
}

