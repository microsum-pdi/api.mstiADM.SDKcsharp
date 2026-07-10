using System;

namespace api.mstiADM.SDK.csharp.ViewModels
{
    public class ClienteAutoLoginVM
    {
        public string Token {get; set; }
        public string Email {get; set; }
        public DateTime Expiration {get; set; }
    }
}