using CVIServiceLibShared.App.Response;
using CVIServiceLibShared.Constants.Enums;
using System;

namespace CVIServiceLibShared.App.Response
{
    public class EscolaridadeResponse : BaseResponse
    {
        public Guid? PerfilId { get; set; }
        public NivelAcademico? NivelAcademico { get; set; }

    }
}
