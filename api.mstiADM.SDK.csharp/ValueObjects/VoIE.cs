using api.mstiADM.SDK.csharp.Entidade;
using api.mstiADM.SDK.csharp.Resources;
using System;
using System.Runtime.InteropServices;

namespace api.mstiADM.SDK.csharp.ValueObjects
{
    [ClassInterface(ClassInterfaceType.None)]
    public class VoIE : Notificavel
    {
        private string strIE { get; set; }


        public VoIE(string IE, string UF)
        {
            if (IE != null)
            {

                this.strIE = IE;

                if (string.IsNullOrEmpty(IE) || !isValid(IE, UF))
                    AddNotification("IE", Resource.IEInvalida);
            }
            else
            {
                AddNotification("IE", Resource.IEInvalida);
            }

        }

        public string getNumbers()
        {
            return String.Join("", System.Text.RegularExpressions.Regex.Split(this.strIE, @"[^\d]"));
        }

        public bool isValid(string documento, string uF)
        {
            return true;
        }
    }
}

