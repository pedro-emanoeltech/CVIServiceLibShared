using CVIServiceLibShared.App.Request;
using CVIServiceLibShared.Constants.Enums;
using System;

namespace CVIServiceLibShared.App.Request
{
    public class EscolaridadeRequest : BaseRequest
    {
        public Guid? PerfilId { get; set; }
        public NivelAcademico? NivelAcademico { get; set; }

    }
}
