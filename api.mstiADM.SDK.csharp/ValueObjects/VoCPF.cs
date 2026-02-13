using api.mstiADM.SDK.csharp.Entidade;
using api.mstiADM.SDK.csharp.Resources;
using System;
using System.Text.RegularExpressions;

namespace api.mstiADM.SDK.csharp.ValueObjects
{
    public class VoCPF : Notificavel
    {
        private string strCPF { get; set; }

        public VoCPF(string CPF)
        {
            if (CPF != null)
            {

                this.strCPF = CPF;

                if (string.IsNullOrEmpty(CPF) || !isValid(CPF))
                    AddNotification("CPF", Resource.CPFInvalido);
            }
            else
            {
                AddNotification("CPF", Resource.CPFInvalido);
            }

        }

        public string getNumbers()
        {
            return String.Join("", System.Text.RegularExpressions.Regex.Split(this.strCPF, @"[^\d]"));
        }

        public bool isValid(string documento)
        {
            var valido = ValidaCPF.Instance.isValid(documento);
            return valido;
        }
    }

    public class ValidaCPF
    {
        public static readonly ValidaCPF _instance = new ValidaCPF();

        public static ValidaCPF Instance
        {
            get
            {
                return _instance;
            }
        }

        public bool isValid(string cpf)
        {
            return IsCpf(cpf);
        }

        private bool IsCpf(string vrCPF)
        {
            if (vrCPF == null)
                return false;

            bool result = true;

            string valor = String.Join("", Regex.Split(vrCPF, @"[^\d]"));

            switch (valor)
            {
                case "00000000000":
                    result = false;
                    break;
                case "11111111111":
                    result = false;
                    break;
                case "22222222222":
                    result = false;
                    break;
                case "33333333333":
                    result = false;
                    break;
                case "44444444444":
                    result = false;
                    break;
                case "55555555555":
                    result = false;
                    break;
                case "66666666666":
                    result = false;
                    break;
                case "77777777777":
                    result = false;
                    break;
                case "88888888888":
                    result = false;
                    break;
                case "99999999999":
                    result = false;
                    break;
            }

            if (result == false)
                return false;

            if (valor.Length != 11)
                return false;

            bool igual = true;
            for (int i = 1; i < 11 && igual; i++)
                if (valor[i] != valor[0])
                    igual = false;

            if (igual || valor == "12345678909")
                return false;

            int[] numeros = new int[11];
            for (int i = 0; i < 11; i++)
                numeros[i] = int.Parse(
                valor[i].ToString());

            int soma = 0;
            for (int i = 0; i < 9; i++)
                soma += (10 - i) * numeros[i];

            int resultado = soma % 11;
            if (resultado == 1 || resultado == 0)
            {
                if (numeros[9] != 0)
                    return false;
            }
            else if (numeros[9] != 11 - resultado)
                return false;

            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += (11 - i) * numeros[i];

            resultado = soma % 11;

            if (resultado == 1 || resultado == 0)
            {
                if (numeros[10] != 0)
                    return false;

            }
            else
                if (numeros[10] != 11 - resultado)
                return false;
            return true;

        }
    }
}
