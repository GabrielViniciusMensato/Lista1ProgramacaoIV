using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMFGProgramacaoIVExc1
{
    internal class Exc2Programacao
    {

        public double ValorEmReal {  get; set; }
        public double ValorDolar{ get; set; }
        public double ValorUsuario { get; set; }
        public double ValorConvertido { get; set; }


    public void ConverterRealParaDolar(double valorUsuario)
        {
            ValorEmReal = 5.22;
            ValorUsuario = valorUsuario;
            ValorConvertido = valorUsuario * ValorDolar; 
            ValorConvertido = Math.Round(ValorConvertido, 2);

            Console.WriteLine("O valor em real " + ValorConvertido);
            

        }

    }
}
