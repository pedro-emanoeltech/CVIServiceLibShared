using System;

namespace CVIServiceLibShared.App.Response
{
    public class EstadoResponse : BaseResponse
    {
        public Guid? PaisId { get; set; }
        public string? Nome { get; set; }
        public string? UF { get; set; }

        //navegacao
        public PaisResponse? Pais { get; set; }
    }
}
