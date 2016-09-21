using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyclomatic
{
    class StartRace
    {

        public int Resultado_15(int? primerNumero, int segundoNumero)
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
        public int Resultado_7(int? primerNumero, int segundoNumero)
        {
            int result = 0;
            try
            {
                if (primerNumero.Value == 1)
                    result = primerNumero.Value + segundoNumero;
                if (primerNumero.Value == 12)
                    result =  primerNumero.Value + segundoNumero;
                if (primerNumero.Value == 2)
                    result =  primerNumero.Value + segundoNumero;
                if (primerNumero.Value == 3)
                    result =  primerNumero.Value + segundoNumero;
                if (primerNumero.Value == 4)
                    result =  primerNumero.Value + segundoNumero;
                if (primerNumero.Value == 5)
                    result =  primerNumero.Value + segundoNumero;
                result =  0;
            }
            catch (Exception e)
            {
                result =  e.GetHashCode();
            }

            return result;
        }

        public int Resultado_4(int? primerNumero, int segundoNumero)
        {
            try
            {
                return primerNumero.Value + segundoNumero;
            }
            catch (Exception e)
            {
                return e.GetHashCode();
            }
        }

        public int Resultado_3(int? primerNumero, int segundoNumero)
        {
            int result = 0;
            try
            {
                result = primerNumero.Value + segundoNumero;
                return result;
            }
            catch (Exception e)
            {
                result = e.GetHashCode();
            }
            return result;
        }

        public int Resultado_2(int? primerNumero, int segundoNumero)
        {
            int result = 0;
            try
            {
                result = primerNumero.Value + segundoNumero;
            }
            catch (Exception e)
            {
                result = e.GetHashCode();
            }
            return result;
        }
    }
}
