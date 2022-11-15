using System;

namespace CVIServiceLibShared.App.Response
{
    public class AuthenticateResponse : BaseResponse
    {
        public Guid? ContaId { get; set; }
        public string? Email { get; set; }
        public string? Token { get; set; }

    }
}
