using System;

namespace CVIServiceLibShared.App.Request
{
    public class CandidaturaRequest : BaseRequest
    {
        public Guid? PerfilId { get; set; }
        public Guid? VagaId { get; set; }

 
    }
}
