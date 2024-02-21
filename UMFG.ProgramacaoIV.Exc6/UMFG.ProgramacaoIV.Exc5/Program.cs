namespace UMFG.ProgramacaoIV.Exc5
{
    internal class Program
    {

        static void Main()
        {
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine().ToLower();

            int quantidadeVogais = 0;

            for (int i = 0; i < nome.Length; i++)
            {
                //especificando vogais 
                if ("aeiou".IndexOf(nome[i]) != -1)
                {
                    //++ utilizado para acrescentar valor à uma variavel numerica 
                    quantidadeVogais++;
                }
            }

            Console.WriteLine($"O nome {nome} possui {quantidadeVogais} vogais.");
        }
    }
}
