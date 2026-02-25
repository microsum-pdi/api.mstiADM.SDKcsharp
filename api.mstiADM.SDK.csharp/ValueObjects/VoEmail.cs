using api.mstiADM.SDK.csharp.Entidade;
using api.mstiADM.SDK.csharp.Resources;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace api.mstiADM.SDK.csharp.ValueObjects
{
    [ClassInterface(ClassInterfaceType.None)]
    public class VoEmail : Notificavel
    {
        private string strEmail { get; set; }

        public VoEmail(string email)
        {
            if (email != null)
            {
                this.strEmail = email;

                if (string.IsNullOrEmpty(email) || !IsValid(email))
                    AddNotification("Email", Resource.EmailInvalido);
            }
            else
            {
                AddNotification("Email", Resource.EmailInvalido);
            }
        }

        public bool IsValid(string email)
        {
            string pattern = @"^[a-zA-Z0-9.!#$%&'*+-/=?^_`{|}~]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$";
            return Regex.IsMatch(email, pattern);
        }
    }
}
