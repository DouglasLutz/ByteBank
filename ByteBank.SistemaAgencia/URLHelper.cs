using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    public class URLHelper
    {
        public String URL { get; }
        public String StringParametros { get; }

        public URLHelper(String url)
        {
            if (String.IsNullOrEmpty(url)) 
                throw new ArgumentException("O argumento url não pode ser nulo ou vazio.", nameof(url));

            URL = url;
            StringParametros = GetStringParametros(url);
        }

        private string GetStringParametros(string url)
        {
            int idxInterrogacao = url.IndexOf('?');

            if (idxInterrogacao == -1) 
                return "";

            return url.Substring(idxInterrogacao + 1);
        }

        //private void GetListParametros(string stringParametros)
        //{
        //    String[] parametros = stringParametros.Split('&');
        //    foreach(String parametro in parametros)
        //    {
        //        String[] nomeValor = parametro.Split('=');
        //        Console.WriteLine("Parametro " + nomeValor[0] + " tem o valor de " + nomeValor[1]);    
        //    }
        //}
    }
}
