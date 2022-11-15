using CVIServiceLibShared.Constants.Enums;
using System;

namespace CVIServiceLibShared.App.Response
{
    public class ContatoResponse : BaseResponse
    {
        public Guid? PerfilId { get; set; }

        public TipoContato TipoContato { get; set; }
        public string? Texto { get; set; }
    }
}
