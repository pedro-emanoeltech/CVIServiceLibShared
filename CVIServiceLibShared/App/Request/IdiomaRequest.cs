using CVIServiceLibShared.App.Request;
using CVIServiceLibShared.Constants.Enums;
using System;

namespace CVIServiceLibShared.App.Request
{
    public class IdiomaRequest : BaseRequest
    {
        public Guid? PerfilId { get; set; }
        public string? Nome { get; set; }
        public NivelLinguagem? NivelLeitura { get; set; }
        public NivelLinguagem? NivelEscrita { get; set; }
        public NivelLinguagem? NivelConversacao { get; set; }


    }
}
