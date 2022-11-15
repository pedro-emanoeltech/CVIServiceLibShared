using CVIServiceLibShared.Constants.Enums;
using System;

namespace CVIServiceLibShared.App.Response
{
    public class IdiomaResponse : BaseResponse
    {
        public Guid? PerfilId { get; set; }
        public string? Nome { get; set; }
        public NivelLinguagem? NivelLeitura { get; set; }
        public NivelLinguagem? NivelEscrita { get; set; }
        public NivelLinguagem? NivelConversacao { get; set; }

    }
}
