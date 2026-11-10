using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heranca
{
    public class Desenvolvedor : Funcionario
    {
        public override decimal CalcularBonus()
        {
            // throw new NotImplementedException(); //* Mostra que o método não havia sido definido ainda.
            return 500m;
        }

        public override void Trabalhar()
        {
            Console.WriteLine("Desenvolvedor está trabalhando.");
        }
    }
}