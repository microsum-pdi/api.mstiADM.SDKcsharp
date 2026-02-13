using System.Collections.Generic;
using System.Linq;

namespace api.mstiADM.SDK.csharp.ViewModels.ClientPackVM._Base
{
    public static class IEnumerableExtensions
    {
        public static List<ClienteTokenVM> ToListTokenVM(this ICollection<ClienteTokenVMPack> clienteTokenVMPacksCollection)
        {
            List<ClienteTokenVM> clienteTokenVMs = new List<ClienteTokenVM>();

            var clienteTokenVMPacks = clienteTokenVMPacksCollection.ToList();

            for (int i = 0; i < clienteTokenVMPacks.Count; i++)
            {
                clienteTokenVMs.Add(new ClienteTokenVM
                {
                    HashToken = clienteTokenVMPacks[i].HashToken,
                    AesToken = clienteTokenVMPacks[i].AesToken,
                    Geracao = clienteTokenVMPacks[i].Geracao,
                    Revogacao = clienteTokenVMPacks[i].Revogacao
                });
            }

            return clienteTokenVMs;
        }


        public static List<ClienteTokenVMPack> ToListTokenVMPack(this ICollection<ClienteTokenVM> clienteTokenVMCollection)
        {
            List<ClienteTokenVMPack> clienteTokenVMsPack = new List<ClienteTokenVMPack>();

            var clienteTokenVMPacks = clienteTokenVMCollection.ToList();

            for (int i = 0; i < clienteTokenVMPacks.Count; i++)
            {
                clienteTokenVMsPack.Add(new ClienteTokenVMPack
                {
                    HashToken = clienteTokenVMPacks[i].HashToken,
                    AesToken = clienteTokenVMPacks[i].AesToken,
                    Geracao = clienteTokenVMPacks[i].Geracao,
                    Revogacao = clienteTokenVMPacks[i].Revogacao
                });
            }

            return clienteTokenVMsPack;
        }

        public static List<ClienteWebHookVM> ToListWebHookVM(this ICollection<ClienteWebHookVMPack> clienteWebHooksVMPackCollection)
        {
            List<ClienteWebHookVM> webHooksVMs = new List<ClienteWebHookVM>();

            var clienteWebHooksVMPacks = clienteWebHooksVMPackCollection.ToList();

            for (int i = 0; i < clienteWebHooksVMPacks.Count; i++)
            {
                webHooksVMs.Add(new ClienteWebHookVM
                {
                    API = clienteWebHooksVMPacks[i].API,
                    SISTEMA = clienteWebHooksVMPacks[i].SISTEMA,
                    SERVICO = clienteWebHooksVMPacks[i].SERVICO,
                    ACAO = clienteWebHooksVMPacks[i].ACAO,
                    URL = clienteWebHooksVMPacks[i].URL,
                    Token = clienteWebHooksVMPacks[i].Token,
                    Identificador = clienteWebHooksVMPacks[i].Identificador
                });
            }

            return webHooksVMs;
        }

        public static List<ClienteWebHookVMPack> ToListWebHookVMPack(this ICollection<ClienteWebHookVM> clienteWebHooksVMCollection)
        {
            List<ClienteWebHookVMPack> webHooksPack = new List<ClienteWebHookVMPack>();

            var clienteWebHooksVMPacks = clienteWebHooksVMCollection.ToList();

            for (int i = 0; i < clienteWebHooksVMPacks.Count; i++)
            {
                webHooksPack.Add(new ClienteWebHookVMPack
                {
                    API = clienteWebHooksVMPacks[i].API,
                    SISTEMA = clienteWebHooksVMPacks[i].SISTEMA,
                    SERVICO = clienteWebHooksVMPacks[i].SERVICO,
                    ACAO = clienteWebHooksVMPacks[i].ACAO,
                    URL = clienteWebHooksVMPacks[i].URL,
                    Token = clienteWebHooksVMPacks[i].Token,
                    Identificador = clienteWebHooksVMPacks[i].Identificador
                });
            }

            return webHooksPack;
        }
    }
}
