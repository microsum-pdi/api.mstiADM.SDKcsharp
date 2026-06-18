using api.mstiADM.SDK.csharp.Entidade;
using System;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace api.mstiADM.SDK.csharp.ValueObjects
{
    [ClassInterface(ClassInterfaceType.None)]
    public class VoCNPJ : Notificavel
    {
        private string strCNPJ { get; set; }

        private const int TamanhoCnpJSemDV = 12;
        private static readonly Regex RegexCnpJSemDV = new Regex(@"^([A-Z\d]){12}$", RegexOptions.Compiled);
        private static readonly Regex RegexCnpj = new Regex(@"^([A-Z\d]){12}(\d){2}$", RegexOptions.Compiled);
        private static readonly Regex RegexCaracteresNaoPermitidos = new Regex(@"[^A-Z\d./-]", RegexOptions.Compiled | RegexOptions.IgnoreCase);
        private const int ValorBase = '0';
        private static readonly int[] PesosDV = { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
        private const string CnpjZerado = "00000000000000";

        public VoCNPJ() { }

        public VoCNPJ(string CNPJ) 
        { 
            strCNPJ = CNPJ; 
            if(!Check(CNPJ)) AddNotification("CNPJ", "CNPJ inválido");
        }

        public bool IsValid()
        {
            return Check(strCNPJ);
        }

        public bool Check()
        {
            return Check(strCNPJ);
        }

        public static bool Check(string cnpj)
        {
            if (string.IsNullOrWhiteSpace(cnpj) || RegexCaracteresNaoPermitidos.IsMatch(cnpj))
                return false;

            string cnpjSemMascara = ClearFormat(cnpj);

            if (RegexCnpj.IsMatch(cnpjSemMascara) && cnpjSemMascara != CnpjZerado)
            {
                string dvInformado = cnpjSemMascara.Substring(TamanhoCnpJSemDV);
                string dvCalculado = CalculaDV(cnpjSemMascara.Substring(0, TamanhoCnpJSemDV));
                return dvInformado == dvCalculado;
            }

            return false;
        }

        public string CalculaDV()
        {
            return CalculaDV(strCNPJ);
        }

        public static string CalculaDV(string cnpj)
        {
            if (string.IsNullOrWhiteSpace(cnpj) || RegexCaracteresNaoPermitidos.IsMatch(cnpj))
                throw new ArgumentException("CNPJ inválido.");

            string cnpjSemMascara = ClearFormat(cnpj);

            if (RegexCnpJSemDV.IsMatch(cnpjSemMascara) && cnpjSemMascara != CnpjZerado.Substring(0, TamanhoCnpJSemDV))
            {
                int somatorioDV1 = 0;
                int somatorioDV2 = 0;

                for (int i = 0; i < TamanhoCnpJSemDV; i++)
                {
                    int asciiDigito = cnpjSemMascara[i] - ValorBase;
                    somatorioDV1 += asciiDigito * PesosDV[i + 1];
                    somatorioDV2 += asciiDigito * PesosDV[i];
                }

                int dv1 = (somatorioDV1 % 11 < 2) ? 0 : 11 - (somatorioDV1 % 11);
                somatorioDV2 += dv1 * PesosDV[TamanhoCnpJSemDV];
                int dv2 = (somatorioDV2 % 11 < 2) ? 0 : 11 - (somatorioDV2 % 11);

                return $"{dv1}{dv2}";
            }

            throw new ArgumentException("Não é possível calcular o DV pois o CNPJ fornecido é inválido");
        }

        public string ClearFormat()
        {
            return ClearFormat(strCNPJ);
        }

        public static string ClearFormat(string cnpj)
        {
            return Regex.Replace(cnpj, @"[^a-zA-Z0-9]", "");
        }
    
        public static bool IsCNPJ(string cnpj)
        {
            var value = ClearFormat(cnpj);
            return value.Length == 14;
        }

        /// <summary>
        /// Formata o CNPJ da própria instância adicionando a máscara (XX.XXX.XXX/XXXX-XX).
        /// </summary>
        public string Format()
        {
            return Format(strCNPJ);
        }

        /// <summary>
        /// Método estático que recebe uma string de CNPJ (com ou sem máscara) e retorna formatado corretamente.
        /// </summary>
        public static string Format(string cnpj)
        {
            if (string.IsNullOrWhiteSpace(cnpj)) return string.Empty;

            string cnpjSemMascara = ClearFormat(cnpj);

            // Garante que o CNPJ tem o tamanho padrão de 14 caracteres antes de aplicar a máscara
            if (cnpjSemMascara.Length != 14)
                return cnpj; // Retorna o valor original caso não possua tamanho correto para formatação

            return $"{cnpjSemMascara.Substring(0, 2)}.{cnpjSemMascara.Substring(2, 3)}.{cnpjSemMascara.Substring(5, 3)}/{cnpjSemMascara.Substring(8, 4)}-{cnpjSemMascara.Substring(12, 2)}";
        }
    }
}