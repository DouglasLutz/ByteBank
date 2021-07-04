using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    public class CursoStrings
    {

        public static void Teste()
        {
            URLHelper url = new URLHelper("https://bytebank.com.br/cambio/cotacao?moedaOrigem=real&moedaDestino=dolar&valor=1500");

            Console.WriteLine("String parametros: " + url.StringParametros);
        }

    }
}
