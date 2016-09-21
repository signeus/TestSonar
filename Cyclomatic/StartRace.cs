using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyclomatic
{
    class StartRace
    {

        public int Resultado(int? primerNumero, int segundoNumero)
        {
            try
            {
                if(primerNumero.Value == 1)
                    return primerNumero.Value + segundoNumero;
                if (primerNumero.Value == 12)
                    return primerNumero.Value + segundoNumero;
                if (primerNumero.Value == 2)
                    return primerNumero.Value + segundoNumero;
                if (primerNumero.Value == 3)
                    return primerNumero.Value + segundoNumero;
                if (primerNumero.Value == 4)
                    return primerNumero.Value + segundoNumero;
                if (primerNumero.Value == 5)
                    return primerNumero.Value + segundoNumero;
                return 0;
            }
            catch(Exception e)
            {
                return e.GetHashCode();
            }
        }
    }
}
