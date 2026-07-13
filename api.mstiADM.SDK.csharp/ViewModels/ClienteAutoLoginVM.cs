using System;
using Newtonsoft.Json;

namespace api.mstiADM.SDK.csharp.ViewModels
{
    public class ClienteAutoLoginVM
    {
        public string Token {get; set; }
        public string Email {get; set; }

        public string ToChaveVM()
        {
            var obj = new ClienteAutoLoginChaveVM()
            {
                Token = Token, 
                Email = Email,
                Expiration = DateTime.Now.AddMinutes(5)
            };
            return JsonConvert.SerializeObject(obj);
        }
    }

    public class ClienteAutoLoginChaveVM
    {
        public string Token {get; set; }
        public string Email {get; set; }
        public DateTime Expiration {get; set; }
    }
}