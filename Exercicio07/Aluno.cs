using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio07
{
    public class Aluno
    {
        string[] valor = new string[10];

        public string this[int numero]
        {
            get
            {
                if (numero >= 0 && numero < valor.Length)
                {
                    return valor[numero];
                }
                return "Erro";
            }
            set
            {
                if (numero >= 0 && numero < valor.Length)
                {
                    valor[numero] = value;
                }
            }
        }
    }
}
