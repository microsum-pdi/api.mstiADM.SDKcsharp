using api.mstiADM.SDK.csharp.Enums;
using api.mstiADM.SDK.csharp.Interfaces.Adm;
using api.mstiADM.SDK.csharp.Services.TabelasPadroes;
using api.mstiADM.SDK.csharp.ViewModels.Config;
using api.mstiADM.SDK.csharp.ViewModels.TabelasAuxiliares;

namespace api.mstiADM.SDK.csharp.Tests
{
    public class TabelasPadroesTest
    {
        private ITabelasPadroesServices tabpdService;

        public TabelasPadroesTest()
        {
            var configAmbienteSDK = new ConfigAmbienteSDK()
            {
                Token = "B8EA89DCC565E2A87957243E04CD7F68C4345F45B30F82C6C535B58FFE3582B9",
                URL = "https://server.ad.microsum.net:9443/Gateway/api.mstiGateway",
                URLFrontend = "https://server.ad.microsum.net:9443/ADM/api.msti.ADMUI"
            };
            tabpdService = new TabelasPadroesServices(configAmbienteSDK);
        }

        [Fact]
        public async Task TesteMultiplasRequisicoes()
        {
            try
            {
                const int TOP = 100;
                int page = 0;

                var qtdRegistrosLidos = 0;
                var qtdRegistrosEsperado = 10451;

                while(true)
                {
                    int skip = page * TOP;
                    var resultVM = await tabpdService.GetAtualizacoes<TABPDBaseVM>(ENomeTabela.TABPDNCMs, 0, TOP, skip);
                    
                    if(resultVM == null || resultVM.Data.Count <= 0) break;

                    qtdRegistrosLidos += resultVM.Data.Count;
                    page++;
                }
                
                Assert.Equal(qtdRegistrosEsperado, qtdRegistrosLidos);
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}