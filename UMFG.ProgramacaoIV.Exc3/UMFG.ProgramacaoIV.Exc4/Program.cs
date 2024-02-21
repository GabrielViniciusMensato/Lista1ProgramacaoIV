namespace UMFG.ProgramacaoIV.Exc4
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Digite a data de nascimento: ");
            int anoNascimento = int.Parse(Console.ReadLine());

            int idade = DateTime.Now.Year - anoNascimento;

            Console.WriteLine($"Sua idade é: {idade} anos");
        }
    }
}
    
