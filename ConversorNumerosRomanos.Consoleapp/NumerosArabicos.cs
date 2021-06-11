using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorNumerosRomanos.Consoleapp
{
    public class NumerosArabicos
    {
        #region String's numeros Romanos
        private string[] unidadesRomanos =
            new string[] { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };

        private string[] dezenasRomanos =
            new string[] { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };

        private string[] centenasRomanos =
            new string[] { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };

        private string[] milharesRomanos =
            new string[] { "", "M", "MM", "MMM" };
        #endregion

        public string ConverterParaRomano(string EntradaEmDecimal)
        {
            ConverteNumerosRomanos numeroArabico = new ConverteNumerosRomanos();           
            string resultado = "";
            int RetornoInteiro = Convert.ToInt32(EntradaEmDecimal.Trim());
            if (RetornoInteiro < 4000 && RetornoInteiro > 0)
                resultado = TransformandoOsNumerosRomanos(RetornoInteiro);
            else if (RetornoInteiro >= 4000)
                resultado = TransformandoNumerosAcimade4mil(numeroArabico, resultado, RetornoInteiro);
            
            return resultado;
        }

        #region MetodosPrivados
        private string MontandoResultado(int Unidade, int Dezena, int Centena, int Milhar)
        {
            return milharesRomanos[Milhar] + centenasRomanos[Centena] +
                dezenasRomanos[Dezena] + unidadesRomanos[Unidade];
        }
        private string TransformandoOsNumerosRomanos(int RetornoInteiro)
        {
            string resultado;
            int Unidade = RetornoInteiro % 10;
            int Dezena = (RetornoInteiro / 10) % 10;
            int Centena = (RetornoInteiro / 100) % 10;
            int Milhar = (RetornoInteiro / 1000) % 10;
            resultado = MontandoResultado(Unidade, Dezena, Centena, Milhar);
            return resultado;
        }
        private static string TransformandoNumerosAcimade4mil(ConverteNumerosRomanos numeroArabico, string resultado, int RetornoInteiro)
        {
            resultado += numeroArabico.NumerosEmRomanosMaior4Mil(RetornoInteiro);
            return resultado;
        }
        #endregion
    }
}
