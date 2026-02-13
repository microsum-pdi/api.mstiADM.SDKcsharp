namespace api.mstiADM.SDK.csharp.ViewModels
{
    public class AcessosApiVM
    {
       // public bool AcessoApiADM { get; private set; }

        public bool AcessoApiDFE { get; private set; }

        public bool AcessoApiTAX { get; private set; }

        public bool AcessoApiHUB { get; private set; }
        
        public bool AcessoApiEFD { get; private set; }

        public bool AcessoApiPAY { get; private set; }

        public AcessosApiVM(bool AcessoApiDFE, bool AcessoApiTAX, bool AcessoApiHUB, bool AcessoApiEFD, bool AcessoApiPAY)
        {
           // this.AcessoApiADM = AcessoApiADM;
            this.AcessoApiDFE = AcessoApiDFE;
            this.AcessoApiTAX = AcessoApiTAX;
            this.AcessoApiHUB = AcessoApiHUB;
            this.AcessoApiEFD = AcessoApiEFD;
            this.AcessoApiPAY = AcessoApiPAY;
        }

        public bool IsTodosAcessosDesabilitados()
        {
            return AcessoApiDFE == false
                   && AcessoApiTAX == false
                   && AcessoApiHUB == false
                   && AcessoApiPAY == false;

        }
    }
}
