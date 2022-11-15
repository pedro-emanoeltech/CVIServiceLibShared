namespace CVIServiceLibShared.App.Request
{
    public class AuthenticateRequest : BaseRequest
    {
        public string? Email { get; set; }

        public string? Senha { get; set; }
    }
}
