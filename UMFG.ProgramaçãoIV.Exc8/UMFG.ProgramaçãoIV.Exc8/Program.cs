namespace UMFG.ProgramaçãoIV.Exc8
{
    internal class Program
    {            static void Main()
            {
                Console.Write("Insira seu nome: ");
                string nome = Console.ReadLine();
                

                Console.WriteLine(nome);    
                Console.Write("Data de nascimento: (no formato dd/mm/aaaa): ");
                DateTime dataNascimento = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

                int idade = CalcularIdade(dataNascimento);

              
                string faixaEtaria = DeterminarFaixaEtaria(idade);

                
                Console.WriteLine($"{nome}, você tem {idade} anos e sua faixa etária é: {faixaEtaria}");
            }

            static int CalcularIdade(DateTime dataNascimento)
            {
                DateTime dataAtual = DateTime.Now;
                int idade = dataAtual.Year - dataNascimento.Year;

                if (dataNascimento > dataAtual.AddYears(-idade))
                {
                    idade--;
                }

                return idade;
            }

            static string DeterminarFaixaEtaria(int idade)
            {
                if (idade >= 0 && idade <= 19)
                {
                    return "Jovem";
                }
                else if (idade >= 20 && idade <= 59)
                {
                    return "Adulto";
                }
                elses
                {
                    return "Idoso";
                }
            }
        }
    }


