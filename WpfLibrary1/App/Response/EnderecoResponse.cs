using System;

namespace CVIServiceLibShared.App.Response
{
    public class EnderecoResponse : BaseResponse
    {
        public Guid? PerfilId { get; set; }
        public Guid? CidadeId { get; set; }
        public Guid? EstadoId { get; set; }

        public string? Logradouro { get; set; }

        public string? Bairro { get; set; }

        public Int64? Numero { get; set; }

        public Int64? CEP { get; set; }

        public string? Complemento { get; set; }



        //relacionamento
        public CidadeResponse? Cidade { get; set; }
        public EstadoResponse? Estado { get; set; }

    }
}
