using CVIServiceLibShared.App.Request;

namespace CVIServiceLibShared.App.Request
{
    public class PaisRequest : BaseRequest
    {
       
        public string? Nome { get; set; }

        public string? Sigla { get; set; }

    }
}
