namespace UMFG.ProgramacaoIV.Exc7
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Digite um nome: ");
            string nome = Console.ReadLine().ToLower();

            int quantidadeConsoantes = 0;
            //Lenght é utilizado para obter o numero maximo de elemento de uma strings 
            for (int i = 0; i < nome.Length; i++)
            {
                //IndexOf retorna posicao de string 
                if ("bcdfghjklmnpqrstvwxyz".IndexOf(nome[i]) != -1)
                {
                    quantidadeConsoantes++;
                }
            }

            Console.WriteLine($"O nome  digitado {nome} tem {quantidadeConsoantes} consoantes.");
        }
    }
}
    
