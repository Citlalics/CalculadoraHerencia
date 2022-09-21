using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraHerencia
{
    class Resta : operacion  
    {
        public double operar(double v1, double v2)
        {
            Valor1 = v1;
            Valor2 = v2;
            Resultado = Valor1 - Valor2;
            return Resultado;
        }
        //OVERLOADING: sobrecarga. cuando tenemos dos metodos que se
        //llaman igual pero lo que tiene adentro es diferente 
        public double operar()
        {
            return Resultado = Valor1 - Valor2;
        }
    }
}
