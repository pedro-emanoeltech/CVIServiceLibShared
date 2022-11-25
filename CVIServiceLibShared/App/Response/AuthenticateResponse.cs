using CVIServiceLibShared.Constants.Enums;
using System;

namespace CVIServiceLibShared.App.Response
{
    public class AuthenticateResponse : BaseResponse
    {
        public Guid? ContaId { get; set; }
        public string? Email { get; set; }
        public TipoConta? Role { get; set; }
        public string? Token { get; set; }
        public DateTime? DataExpiracao { get; set; }
        public int? ExpiryTimeStamp { get; set; }
    }
}
