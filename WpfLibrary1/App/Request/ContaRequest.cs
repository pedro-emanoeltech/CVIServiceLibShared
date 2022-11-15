using CVIServiceLibShared.Constants.Enums;

namespace CVIServiceLibShared.App.Request
{
    public class ContaRequest : BaseRequest
    {
        public string? Email { get; set; }

        public string? Senha { get; set; }

        public Status Status { get; set; }
    }
}
