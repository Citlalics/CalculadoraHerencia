using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraHerencia
{
    class Division : operacion  
    {
        public double operar(double v1, double v2)
        {
            Valor1 = v1;
            Valor2 = v2;
            Resultado = Valor1 / Valor2;
            return Resultado;
        }
        
        public double operar()
        {
            return Resultado = Valor1 / Valor2;
        }
    }
}
