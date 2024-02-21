namespace UMFG.ProgramacaoIV.Exc4
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Digite o ano de nascimento: ");
            int anoDeNascimento = int.Parse(Console.ReadLine());

            int idade = DateTime.Now.Year - anoDeNascimento;

            Console.WriteLine($"Sua idade é: {idade} anos");
        }
    }
}




