using CVIServiceLibShared.Constants.Enums;


namespace CVIServiceLibShared.App.Response
{
    public class ContaResponse : BaseResponse
    {
        public string? Email { get; set; }
        public Status Status { get; set; } = Status.Ativo;
    }
}
