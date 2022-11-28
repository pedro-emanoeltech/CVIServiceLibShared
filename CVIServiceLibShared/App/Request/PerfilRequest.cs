using CVIServiceLibShared.Constants.Enums;
using System;

namespace CVIServiceLibShared.App.Request
{
    public class PerfilRequest : BaseRequest
    {
        public Guid? ContaId { get; set; }
        public string? Nome { get; set; }
        public string? Bio { get; set; }
        public string? Apelido { get; set; }
        public Int64? CPF { get; set; }
        public Int64? CNPJ { get; set; }
        public int? Idade { get; set; }
        public EstadoCivil EstadoCivil { get; set; }
        public Genero Genero { get; set; }
        public Guid? NacionalidadeId { get; set; }
        public Guid? SegmentoId { get; set; }

    }
}
