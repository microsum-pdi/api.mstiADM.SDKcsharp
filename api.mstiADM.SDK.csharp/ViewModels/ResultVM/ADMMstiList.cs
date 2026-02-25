using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace api.mstiADM.SDK.csharp.ViewModels.ResultVM
{
    [ClassInterface(ClassInterfaceType.None)]
    public class ADMMstiList<T> : List<T>
    {
        /// <summary> 
        /// Quantidade total de registros que a lista poderá obter
        /// 
        /// <para>Utilizado para controles de paginação</para> 
        /// </summary> 
        public int Capacidade { get; set; }

        public void WithElements(IEnumerable<T> elements)
        {
            AddRange(elements);
        }
    }
}