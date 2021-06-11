using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorNumerosRomanos.Consoleapp
{
    public class ConverteNumerosRomanos
    {
        private Dictionary<char, int> NumerosRomanos = new Dictionary<char, int>();

        public int valorTotal;
        public int valorLetraAnterior;
        public int valorLetraAtual;
        public int DireitaMenor;
        public ConverteNumerosRomanos()
        {
            NumerosRomanosParaMontarCenariosPossiveis();
        }
        public string ConverteParaDecimal(string EntradaEmRomano)
        {
            EntradaEmRomano.Trim();
            valorTotal = 0;
            valorLetraAnterior = 0;
            ConstruindoNumerosRomanos(EntradaEmRomano);
            return valorTotal.ToString();
        }
        internal string NumerosEmRomanosMaior4Mil(int numero)
        {
            string resultado = "";
            resultado = MetodoNumerosRomanosAcimade4Mil(numero, resultado);
            return resultado.ToString();
        } 
        public string ConverterMais4Mil(string romano)
        {
            ConverteNumerosRomanos numeros = new ConverteNumerosRomanos();
            int resultado = 0;
            romano = FazReplaceLetrasComMacron(romano);
            return RetornaNumerosRomanos4milMaior(romano, numeros, ref resultado);
        }
        internal int NumerosRomanosMaior4mil(char letras)
        {
            switch (letras)
            {
                case 'I': return 1;
                case 'V': return 5;
                case 'X': return 10;
                case 'L': return 50;
                case 'C': return 100;
                case 'D': return 500;
                case 'M': return 1000;
                case 'R': return 4000;
                case 'S': return 5000;
                case 'T': return 6000;
                case 'U': return 7000;
                case 'F': return 8000;
                case 'G': return 9000;
                case 'B': return 10000;
                default: return 0;
            }
        }
        #region MetodosPrivados
        private static string FazReplaceLetrasComMacron(string romano)
        {
            romano = romano.Replace("V̄ĪĪĪ", "F");
            romano = romano.Replace("V̄ĪĪ", "U");
            romano = romano.Replace("ĪV̄", "R");
            romano = romano.Replace("V̄Ī", "T");
            romano = romano.Replace("V̄", "S");
            romano = romano.Replace("ĪX̄", "G");
            romano = romano.Replace("X̄", "B");
            return romano;
        }
        private static string MetodoNumerosRomanosAcimade4Mil(int numero, string resultado)
        {
            switch (numero)
            {
                case 4000: resultado += "ĪV̄"; break;
                case 5000: resultado += "V̄"; break;
                case 6000: resultado += "V̄Ī"; break;
                case 7000: resultado += "V̄ĪĪ"; break;
                case 8000: resultado += "V̄ĪĪĪ"; break;
                case 9000: resultado += "ĪX̄"; break;
                case 10000: resultado += "X̄"; break;
                default: break;
            }

            return resultado;
        }
        private void ConstruindoNumerosRomanos(string EntradaEmRomano)
        {
            for (int Posicao = EntradaEmRomano.Length - 1; Posicao >= 0; Posicao--)
            {
                valorLetraAtual = NumerosRomanos[EntradaEmRomano.ToString()[Posicao]];

                DireitaMenor = 1;
                if (valorLetraAtual < valorLetraAnterior)
                {
                    DireitaMenor = -1;
                }
                valorTotal += NumerosRomanos[EntradaEmRomano.ToUpper()[Posicao]] * DireitaMenor;

                valorLetraAnterior = valorLetraAtual;
            }
        }
        private void NumerosRomanosParaMontarCenariosPossiveis()
        {
            NumerosRomanos.Add('I', 1);
            NumerosRomanos.Add('V', 5);
            NumerosRomanos.Add('X', 10);
            NumerosRomanos.Add('L', 50);
            NumerosRomanos.Add('C', 100);
            NumerosRomanos.Add('D', 500);
            NumerosRomanos.Add('M', 1000);
        }
        private static string RetornaNumerosRomanos4milMaior(string romano, ConverteNumerosRomanos numeros, ref int resultado)
        {
            foreach (char letras in romano)
            {
                resultado += numeros.NumerosRomanosMaior4mil(letras);
            }

            return resultado.ToString();
        }
        #endregion
    }
}