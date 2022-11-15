using System;

namespace CVIServiceLibShared.App.Response
{
    public class CandidaturaResponse : BaseResponse
    {
        public Guid? PerfilId { get; set; }
        public Guid? VagaId { get; set; }

        //navegaçao
        public virtual PerfilResponse? Perfil { get; set; }
        public virtual VagaResponse? Vaga { get; set; }
    }
}
