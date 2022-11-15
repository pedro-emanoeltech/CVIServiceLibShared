using CVIServiceLibShared.Constants.Enums;
using System;

namespace CVIServiceLibShared.App.Request
{
    public class ContatoRequest : BaseRequest
    {
        public Guid? PerfilId { get; set; }

        public TipoContato TipoContato { get; set; }
        public string? Texto { get; set; }
    }
}
